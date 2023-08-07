Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.IO
Module Funkcje
    Public PCuser As String = Environment.UserName
    Public strFile As String = "V:\ZPMAGlog.txt"

    Public SqlString As String
    Public SqlStringRuchy As String

    Public user As String
    Public index As Integer
    Public idDostawy As Integer
    Public data As String
    Public kod As String
    Public opis As String
    Public regal As String
    Public ile As Single
    Public ile_pak As String
    Public D_wymiar As String
    Public uwagi As String
    Public dostawa As Boolean

    Public lotto_prod As String
    Public lotto_nat As String
    Public lotto_mp As String

    '--------ACCESS DATABASE ----------
    'Provider=Microsoft.Jet.OLEDB.4.0;Data Source=V:\ZP MAG\MagDb.mdb;Persist Security Info=True;Jet OLEDB:Database Password=
    'Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\MagDb.mdb;Persist Security Info=True;Jet OLEDB:Database Password=
    Private ReadOnly dbProvider As String = "Provider=Microsoft.JET.OLEDB.4.0;"
    'Public MyDocFolder As String = Directory.GetCurrentDirectory
    Public MyDocFolder As String = "D:\ZP MAG"
    Private ReadOnly TheDatabase As String = "\MagDb.mdb"
    Public FullDatabasePath As String = MyDocFolder & TheDatabase
    Private ReadOnly dbSource As String = "Data Source = " & FullDatabasePath
    Private ReadOnly dbSecurity As String = ";Jet OLEDB:Database Password='';" 'ADD PASSWORD
    Private ReadOnly LocMagDb = dbProvider & dbSource & dbSecurity

    Public MagDbCon As New OleDbConnection(LocMagDb)

    '--------ODBC CONS ------------
    Private ReadOnly ZCP As String = "DSN=;UID=;PWD=;DBALIAS=;" 'CHANGE CREDENTIALS
    Public ZCPCon As New OdbcConnection(ZCP)

    Private ReadOnly Galileo As String = "DSN=;Uid=;Pwd=;" 'CHANGE CREDENTIALS
    Public GalileoCon As New OdbcConnection(Galileo)
    '------------------------------

    '------OleDb objects-----------'
    Public da As OleDbDataAdapter
    Public daR As OleDbDataAdapter

    Public cb As OleDbCommandBuilder
    Public cbR As OleDbCommandBuilder

    Public ds As DataSet
    Public dt As DataTable
    Public dr As DataRow
    Public dNewRow As DataRow

    'formatowanie daty
    Public FormatDaty As String = "yyyy-MM-dd HH:mm:ss"
    Public Sub TbEnabled(x As Form, y As Boolean)
        For Each TB As Control In x.Controls
            If TB.GetType Is GetType(TextBox) Then
                TB.Enabled = y
            End If
        Next
    End Sub
    Public Sub BtEnabled(x As Form, y As Boolean)
        For Each BT As Control In x.Controls
            If BT.GetType Is GetType(Button) Then
                BT.Enabled = y
            End If
        Next
    End Sub
    Public Sub CBEnabled(x As Form, y As Boolean)
        For Each CB As Control In x.Controls
            If CB.GetType Is GetType(ComboBox) Then
                CB.Enabled = y
            End If
        Next
    End Sub
    Public Sub TB_clear(x As Form)
        For Each TB As Control In x.Controls
            If TB.GetType Is GetType(TextBox) Then
                TB.Text = Nothing
            End If
        Next
    End Sub
    Public Sub TB_clear_EX(x As Form, Optional BoxName As String = "")
        For Each TB As Control In x.Controls
            If TB.GetType Is GetType(TextBox) Then
                If TB.Name <> BoxName Then
                    TB.Text = Nothing
                End If
            End If
        Next
    End Sub
    Public Sub CB_clear(x As Form)
        For Each CB As Control In x.Controls
            If TypeOf CB Is CheckBox Then
                DirectCast(CB, CheckBox).Checked = False
            End If
        Next
    End Sub
    Sub PokazBlad()
        Dim Msg As String
        Msg = "Błąd #" & Str(Err.Number) & " został wygenerowany przez " &
        Err.Source & ControlChars.CrLf & Err.Description
        MsgBox(Msg, MsgBoxStyle.Critical, "Błąd")
    End Sub
    Sub AktualizujMGDGV()
        Magazyn.MGTableAdapter.Fill(Magazyn.MagDbDataSet.MG)
        Magazyn.MG_ruchyTableAdapter.Fill(Magazyn.MagDbDataSet.MG_ruchy)
        OdswiezStatus()
    End Sub
    Sub AktualizujMGR()
        Magazyn.MG_ruchyTableAdapter.Fill(Magazyn.MagDbDataSet.MG_ruchy)
        OdswiezStatus()
    End Sub
    Sub AktualizujMPDGV()
        Magazyn.MPTableAdapter.Fill(Magazyn.MagDbDataSet.MP)
        Magazyn.MP_ruchyTableAdapter.Fill(Magazyn.MagDbDataSet.MP_ruchy)
        OdswiezStatus()
    End Sub
    Sub AktualizujMPR()
        Magazyn.MP_ruchyTableAdapter.Fill(Magazyn.MagDbDataSet.MP_ruchy)
        OdswiezStatus()
    End Sub
    Sub AktualizujDOSDGV()
        Magazyn.DOSTAWYTableAdapter.Fill(Magazyn.MagDbDataSet.DOSTAWY)
        OdswiezStatus()
    End Sub
    Sub AktualizujWszystkieDGV()
        AktualizujMGDGV()
        AktualizujMPDGV()
        AktualizujDOSDGV()
        OdswiezStatus()
    End Sub
    Sub OpenMagConnection()
        If MagDbCon.State = ConnectionState.Closed Then
            MagDbCon.Open()
        End If
    End Sub
    Sub OpenGalileoConnection()
        Try
            If GalileoCon.State = ConnectionState.Closed Then
                GalileoCon.Open()
            End If
        Catch ex As Exception
            If Err.Number = 5 Then
                MsgBox("Brak połączenia z bazą danych Galileo", vbCritical)
            Else
                PokazBlad()
            End If
            Exit Sub
        End Try
    End Sub
    Sub OdswiezStatus()
        Dim suma As Single
        Dim sumaF As Single
        Select Case Magazyn.TabControl.SelectedIndex
            Case 0
                For Each r As DataGridViewRow In Magazyn.MGdgv.Rows
                    suma += r.Cells(5).Value
                    If r.Selected = True Then
                        sumaF += r.Cells(5).Value
                    End If
                Next
                Magazyn.LblStatus.Text = "Magazyn główny. Ilość pozycji: " & Magazyn.MGdgv.Rows.Count & "    Suma częściowa: " & String.Format("{0:# ### ###}", suma) & "    Suma zaznaczenia: " & String.Format("{0:# ### ###}", sumaF)
            Case 1
                For Each r As DataGridViewRow In Magazyn.MPdgv.Rows
                    suma += r.Cells(4).Value
                    If r.Selected = True Then
                        sumaF += r.Cells(4).Value
                    End If
                Next
                Magazyn.LblStatus.Text = "Magazyn prętów. Ilość pozycji: " & Magazyn.MPdgv.Rows.Count & "    Suma częściowa: " & String.Format("{0:# ### ###}", suma) & "    Suma zaznaczenia: " & String.Format("{0:# ### ###}", sumaF)
            Case 2
                Magazyn.LblStatus.Text = "Ruchy - Magazyn główny. Ilość pozycji: " & Magazyn.MGRdgv.Rows.Count
            Case 3
                Magazyn.LblStatus.Text = "Ruchy - Magazyn prętów. Ilość pozycji: " & Magazyn.MPRdgv.Rows.Count
            Case 4
                For Each r As DataGridViewRow In Magazyn.DOSdgv.Rows
                    suma += r.Cells(4).Value
                    If r.Selected = True Then
                        sumaF += r.Cells(4).Value
                    End If
                Next
                Magazyn.LblStatus.Text = "Dostawy. Ilość pozycji: " & Magazyn.DOSdgv.Rows.Count & "    Suma częściowa: " & String.Format("{0:# ### ###}", suma) & "    Suma zaznaczenia: " & String.Format("{0:# ### ###}", sumaF)
        End Select
    End Sub
    Public Class FasterDataGridView
        Inherits DataGridView
        Public Sub New()
            Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        End Sub
    End Class
    Sub StartAPPlog()
        Try
            Using sw As New StreamWriter(File.Open(strFile, FileMode.OpenOrCreate))
            End Using
            Using sw As New StreamWriter(strFile, True)
                sw.WriteLine("Otwarto MAG: " & PCuser & " @ " & DateTime.Now)
            End Using
        Catch
        End Try
    End Sub
    Sub StopAPPlog()
        Try
            Using sw As New StreamWriter(File.Open(strFile, FileMode.OpenOrCreate))
            End Using
            Using sw As New StreamWriter(strFile, True)
                sw.WriteLine("Zamknięto MAG: " & PCuser & " @ " & DateTime.Now)
            End Using
        Catch
        End Try
    End Sub
End Module
