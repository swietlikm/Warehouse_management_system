<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Magazyn
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Magazyn))
        Me.PasekZadan = New System.Windows.Forms.MenuStrip()
        Me.OdświeżToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GalileoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PobierzStanyMagazynoweToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KodyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LottoProdukcyjneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LottoNatychmiastoweToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PobraniaMateriałówToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ZCPQV = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportujDoExcelaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OProgramieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UżytkownicyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DbClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.LblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.label_user = New System.Windows.Forms.Label()
        Me.Wyloguj = New System.Windows.Forms.Button()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabMG = New System.Windows.Forms.TabPage()
        Me.BT_przenies_regal = New System.Windows.Forms.Button()
        Me.BT_doloz = New System.Windows.Forms.Button()
        Me.F_formula = New System.Windows.Forms.TextBox()
        Me.lblwidok = New System.Windows.Forms.Label()
        Me.BT_x = New System.Windows.Forms.Button()
        Me.F_data_dodania = New System.Windows.Forms.TextBox()
        Me.F_uwagi = New System.Windows.Forms.TextBox()
        Me.F_lotto_nat = New System.Windows.Forms.TextBox()
        Me.F_lotto_prod = New System.Windows.Forms.TextBox()
        Me.F_galileo = New System.Windows.Forms.TextBox()
        Me.F_ilosc = New System.Windows.Forms.TextBox()
        Me.F_regal = New System.Windows.Forms.TextBox()
        Me.F_opis = New System.Windows.Forms.TextBox()
        Me.F_Kod = New System.Windows.Forms.TextBox()
        Me.BT_pobierz_pal = New System.Windows.Forms.Button()
        Me.BT_inwentaryzacja = New System.Windows.Forms.Button()
        Me.BT_pobierz = New System.Windows.Forms.Button()
        Me.BT_przenies = New System.Windows.Forms.Button()
        Me.BT_dodaj = New System.Windows.Forms.Button()
        Me.MGdgv = New System.Windows.Forms.DataGridView()
        Me.MgIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodZPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IloscDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LottoprodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LottonatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UwagiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatadodaniaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatamodyfikacjiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LmodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MGBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MagDbDataSet = New MagDbDataSet()
        Me.TabMP = New System.Windows.Forms.TabPage()
        Me.BT_MP_doloz = New System.Windows.Forms.Button()
        Me.FMP_data_dodania = New System.Windows.Forms.TextBox()
        Me.FMP_wymiar = New System.Windows.Forms.TextBox()
        Me.FMP_przekroj = New System.Windows.Forms.TextBox()
        Me.FMP_material = New System.Windows.Forms.TextBox()
        Me.FMP_uwagi = New System.Windows.Forms.TextBox()
        Me.FMP_lotto = New System.Windows.Forms.TextBox()
        Me.FMP_galileo = New System.Windows.Forms.TextBox()
        Me.FMP_ilosc = New System.Windows.Forms.TextBox()
        Me.FMP_regal = New System.Windows.Forms.TextBox()
        Me.FMP_opis = New System.Windows.Forms.TextBox()
        Me.BT_MP_przenies = New System.Windows.Forms.Button()
        Me.BT_MP_inwentaryzacja = New System.Windows.Forms.Button()
        Me.BT_MP_pobierz = New System.Windows.Forms.Button()
        Me.BT_x3 = New System.Windows.Forms.Button()
        Me.lblWidok_MP = New System.Windows.Forms.Label()
        Me.FMP_kod = New System.Windows.Forms.TextBox()
        Me.BT_MP_dodaj = New System.Windows.Forms.Button()
        Me.MPdgv = New System.Windows.Forms.DataGridView()
        Me.MpID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodMP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lotto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Material = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Przekroj = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Wymiar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabMGR = New System.Windows.Forms.TabPage()
        Me.MGstan = New System.Windows.Forms.Button()
        Me.BT_x2 = New System.Windows.Forms.Button()
        Me.lblWidokRuchy = New System.Windows.Forms.Label()
        Me.FR_uwagi = New System.Windows.Forms.TextBox()
        Me.FR_lotto_nat = New System.Windows.Forms.TextBox()
        Me.FR_lotto_prod = New System.Windows.Forms.TextBox()
        Me.FR_ilosc = New System.Windows.Forms.TextBox()
        Me.FR_regal = New System.Windows.Forms.TextBox()
        Me.FR_opis = New System.Windows.Forms.TextBox()
        Me.FR_kod = New System.Windows.Forms.TextBox()
        Me.FR_akcja = New System.Windows.Forms.TextBox()
        Me.FR_data = New System.Windows.Forms.TextBox()
        Me.MGRdgv = New System.Windows.Forms.DataGridView()
        Me.MgruchyIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.akcja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodZPDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpisgalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegalDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ilosc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LottoprodDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LottonatDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UwagiDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stanMG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uwagi_mod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NrmodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MgIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uzytkownik = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MGruchyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabMPR = New System.Windows.Forms.TabPage()
        Me.MPstan = New System.Windows.Forms.Button()
        Me.FMPR_uwagi = New System.Windows.Forms.TextBox()
        Me.FMPR_lotto_prod = New System.Windows.Forms.TextBox()
        Me.FMPR_lotto = New System.Windows.Forms.TextBox()
        Me.FMPR_ilosc = New System.Windows.Forms.TextBox()
        Me.FMPR_regal = New System.Windows.Forms.TextBox()
        Me.FMPR_opis = New System.Windows.Forms.TextBox()
        Me.FMPR_kod = New System.Windows.Forms.TextBox()
        Me.FMPR_akcja = New System.Windows.Forms.TextBox()
        Me.BT_x4 = New System.Windows.Forms.Button()
        Me.lblWidok_MPR = New System.Windows.Forms.Label()
        Me.FMPR_data = New System.Windows.Forms.TextBox()
        Me.MPRdgv = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MP_lotto_prod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MPruchyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.FD_wymiar = New System.Windows.Forms.TextBox()
        Me.FD_data = New System.Windows.Forms.TextBox()
        Me.FD_uwagi = New System.Windows.Forms.TextBox()
        Me.FD_lotto_nat = New System.Windows.Forms.TextBox()
        Me.FD_lotto_prod = New System.Windows.Forms.TextBox()
        Me.FD_ilosc_pak = New System.Windows.Forms.TextBox()
        Me.FD_ilosc = New System.Windows.Forms.TextBox()
        Me.lblDostawy = New System.Windows.Forms.Label()
        Me.BT_x5 = New System.Windows.Forms.Button()
        Me.FD_regal = New System.Windows.Forms.TextBox()
        Me.BT_DOS_dodaj = New System.Windows.Forms.Button()
        Me.FD_opis = New System.Windows.Forms.TextBox()
        Me.FD_kod = New System.Windows.Forms.TextBox()
        Me.DOSdgv = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ilosc_pak = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOSTAWYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Menu_rozwijane = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ZmieńToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.PobierzToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PobierzPaletęToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DołóżToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrzenieśToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrzenieśRegałToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.InwentaryzacjaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.FiltrujToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PoKodzieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PoRegaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PoLottoProdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PoLottoNatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZobaczRuchyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.MP_menu_rozwijane = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TSM_MP_edytuj = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSM_MP_pobierz = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_MP_doloz = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSM_MP_przenies = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSM_MP_inwentaryzacja = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_PoKodzie = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_PoRegale = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_PoLotto = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_MP_zobacz_ruchy = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.DOSTAWY_menu_rozwijane = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TSM_DOS_edytuj = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSM_DOS_przenies = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_DOS_przenies_MG = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_DOS_przenies_MP = New System.Windows.Forms.ToolStripMenuItem()
        Me.WyślijToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_DOS_usun = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.FiltrujToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_DOS_filtruj_po_kodzie = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_DOS_filtruj_po_regale = New System.Windows.Forms.ToolStripMenuItem()
        Me.Process1 = New System.Diagnostics.Process()
        Me.MGR_MenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FiltrujToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PoKodzieToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PoRegaleToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PoLottoProdToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PoLottoNatToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.PokażRuchyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PokażWMagazynieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MPR_MenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PoKodzieToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PoRegaleToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PoLottoProdToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PoLottoNatToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.PokażRuchyToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PokażWMagazynieToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MGTableAdapter = New MagDbDataSetTableAdapters.MGTableAdapter()
        Me.MG_ruchyTableAdapter = New MagDbDataSetTableAdapters.MG_ruchyTableAdapter()
        Me.MPTableAdapter = New MagDbDataSetTableAdapters.MPTableAdapter()
        Me.MP_ruchyTableAdapter = New MagDbDataSetTableAdapters.MP_ruchyTableAdapter()
        Me.DOSTAWYTableAdapter = New MagDbDataSetTableAdapters.DOSTAWYTableAdapter()
        Me.PasekZadan.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.TabMG.SuspendLayout()
        CType(Me.MGdgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MGBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MagDbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabMP.SuspendLayout()
        CType(Me.MPdgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabMGR.SuspendLayout()
        CType(Me.MGRdgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MGruchyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabMPR.SuspendLayout()
        CType(Me.MPRdgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MPruchyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.DOSdgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DOSTAWYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Menu_rozwijane.SuspendLayout()
        Me.MP_menu_rozwijane.SuspendLayout()
        Me.DOSTAWY_menu_rozwijane.SuspendLayout()
        Me.MGR_MenuStrip.SuspendLayout()
        Me.MPR_MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'PasekZadan
        '
        Me.PasekZadan.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PasekZadan.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.PasekZadan.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OdświeżToolStripMenuItem, Me.GalileoToolStripMenuItem, Me.MaterialyToolStripMenuItem, Me.ExportujDoExcelaToolStripMenuItem, Me.OProgramieToolStripMenuItem, Me.BackupToolStripMenuItem, Me.UżytkownicyToolStripMenuItem, Me.DbClearToolStripMenuItem})
        Me.PasekZadan.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.PasekZadan.Location = New System.Drawing.Point(0, 0)
        Me.PasekZadan.Name = "PasekZadan"
        Me.PasekZadan.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.PasekZadan.Size = New System.Drawing.Size(1376, 28)
        Me.PasekZadan.TabIndex = 1
        Me.PasekZadan.Text = "MenuStrip1"
        '
        'OdświeżToolStripMenuItem
        '
        Me.OdświeżToolStripMenuItem.Image = Global.Magazyn.My.Resources.Resources.refresh
        Me.OdświeżToolStripMenuItem.Name = "OdświeżToolStripMenuItem"
        Me.OdświeżToolStripMenuItem.Size = New System.Drawing.Size(83, 24)
        Me.OdświeżToolStripMenuItem.Text = "Odśwież"
        '
        'GalileoToolStripMenuItem
        '
        Me.GalileoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PobierzStanyMagazynoweToolStripMenuItem, Me.KodyToolStripMenuItem, Me.LottoProdukcyjneToolStripMenuItem, Me.LottoNatychmiastoweToolStripMenuItem, Me.PobraniaMateriałówToolStripMenuItem, Me.ToolStripSeparator9, Me.ZCPQV})
        Me.GalileoToolStripMenuItem.Image = Global.Magazyn.My.Resources.Resources.LOGOG_1
        Me.GalileoToolStripMenuItem.Name = "GalileoToolStripMenuItem"
        Me.GalileoToolStripMenuItem.Size = New System.Drawing.Size(75, 24)
        Me.GalileoToolStripMenuItem.Text = "Galileo"
        '
        'PobierzStanyMagazynoweToolStripMenuItem
        '
        Me.PobierzStanyMagazynoweToolStripMenuItem.Image = Global.Magazyn.My.Resources.Resources.cloud
        Me.PobierzStanyMagazynoweToolStripMenuItem.Name = "PobierzStanyMagazynoweToolStripMenuItem"
        Me.PobierzStanyMagazynoweToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.PobierzStanyMagazynoweToolStripMenuItem.Text = "Pobierz stany magazynowe"
        '
        'KodyToolStripMenuItem
        '
        Me.KodyToolStripMenuItem.Image = Global.Magazyn.My.Resources.Resources.search
        Me.KodyToolStripMenuItem.Name = "KodyToolStripMenuItem"
        Me.KodyToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.KodyToolStripMenuItem.Text = "Wyszukiwarka kodów"
        '
        'LottoProdukcyjneToolStripMenuItem
        '
        Me.LottoProdukcyjneToolStripMenuItem.Name = "LottoProdukcyjneToolStripMenuItem"
        Me.LottoProdukcyjneToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.LottoProdukcyjneToolStripMenuItem.Text = "Lotto produkcyjne"
        '
        'LottoNatychmiastoweToolStripMenuItem
        '
        Me.LottoNatychmiastoweToolStripMenuItem.Name = "LottoNatychmiastoweToolStripMenuItem"
        Me.LottoNatychmiastoweToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.LottoNatychmiastoweToolStripMenuItem.Text = "Lotto natychmiastowe"
        '
        'PobraniaMateriałówToolStripMenuItem
        '
        Me.PobraniaMateriałówToolStripMenuItem.Name = "PobraniaMateriałówToolStripMenuItem"
        Me.PobraniaMateriałówToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.PobraniaMateriałówToolStripMenuItem.Text = "Pobrania materiałów"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(214, 6)
        '
        'ZCPQV
        '
        Me.ZCPQV.Image = Global.Magazyn.My.Resources.Resources.favicon_ZCP_QV
        Me.ZCPQV.Name = "ZCPQV"
        Me.ZCPQV.Size = New System.Drawing.Size(217, 22)
        Me.ZCPQV.Text = "ZCP Quick View"
        '
        'MaterialyToolStripMenuItem
        '
        Me.MaterialyToolStripMenuItem.Image = Global.Magazyn.My.Resources.Resources.iron_bar
        Me.MaterialyToolStripMenuItem.Name = "MaterialyToolStripMenuItem"
        Me.MaterialyToolStripMenuItem.Size = New System.Drawing.Size(88, 24)
        Me.MaterialyToolStripMenuItem.Text = "Materiały"
        '
        'ExportujDoExcelaToolStripMenuItem
        '
        Me.ExportujDoExcelaToolStripMenuItem.Image = Global.Magazyn.My.Resources.Resources.excel
        Me.ExportujDoExcelaToolStripMenuItem.Name = "ExportujDoExcelaToolStripMenuItem"
        Me.ExportujDoExcelaToolStripMenuItem.Size = New System.Drawing.Size(83, 24)
        Me.ExportujDoExcelaToolStripMenuItem.Text = "Exportuj"
        '
        'OProgramieToolStripMenuItem
        '
        Me.OProgramieToolStripMenuItem.Image = Global.Magazyn.My.Resources.Resources.information
        Me.OProgramieToolStripMenuItem.Name = "OProgramieToolStripMenuItem"
        Me.OProgramieToolStripMenuItem.Size = New System.Drawing.Size(106, 24)
        Me.OProgramieToolStripMenuItem.Text = "O programie"
        '
        'BackupToolStripMenuItem
        '
        Me.BackupToolStripMenuItem.Name = "BackupToolStripMenuItem"
        Me.BackupToolStripMenuItem.Size = New System.Drawing.Size(58, 24)
        Me.BackupToolStripMenuItem.Text = "Backup"
        Me.BackupToolStripMenuItem.Visible = False
        '
        'UżytkownicyToolStripMenuItem
        '
        Me.UżytkownicyToolStripMenuItem.Name = "UżytkownicyToolStripMenuItem"
        Me.UżytkownicyToolStripMenuItem.Size = New System.Drawing.Size(86, 24)
        Me.UżytkownicyToolStripMenuItem.Text = "Użytkownicy"
        Me.UżytkownicyToolStripMenuItem.Visible = False
        '
        'DbClearToolStripMenuItem
        '
        Me.DbClearToolStripMenuItem.Name = "DbClearToolStripMenuItem"
        Me.DbClearToolStripMenuItem.Size = New System.Drawing.Size(177, 24)
        Me.DbClearToolStripMenuItem.Text = "Czyszczenie całej bazy danych"
        Me.DbClearToolStripMenuItem.Visible = False
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LblStatus})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 665)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1376, 22)
        Me.StatusStrip.TabIndex = 2
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'LblStatus
        '
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(39, 17)
        Me.LblStatus.Text = "Status"
        '
        'label_user
        '
        Me.label_user.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label_user.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.label_user.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.label_user.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_user.Location = New System.Drawing.Point(1209, 4)
        Me.label_user.Name = "label_user"
        Me.label_user.Size = New System.Drawing.Size(74, 18)
        Me.label_user.TabIndex = 6
        Me.label_user.Text = "login"
        Me.label_user.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Wyloguj
        '
        Me.Wyloguj.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Wyloguj.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Wyloguj.Location = New System.Drawing.Point(1289, 2)
        Me.Wyloguj.Name = "Wyloguj"
        Me.Wyloguj.Size = New System.Drawing.Size(75, 22)
        Me.Wyloguj.TabIndex = 5
        Me.Wyloguj.Text = "Wyloguj"
        Me.Wyloguj.UseVisualStyleBackColor = True
        '
        'TabControl
        '
        Me.TabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl.Controls.Add(Me.TabMG)
        Me.TabControl.Controls.Add(Me.TabMP)
        Me.TabControl.Controls.Add(Me.TabMGR)
        Me.TabControl.Controls.Add(Me.TabMPR)
        Me.TabControl.Controls.Add(Me.TabPage1)
        Me.TabControl.Location = New System.Drawing.Point(12, 27)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1352, 635)
        Me.TabControl.TabIndex = 7
        '
        'TabMG
        '
        Me.TabMG.Controls.Add(Me.BT_przenies_regal)
        Me.TabMG.Controls.Add(Me.BT_doloz)
        Me.TabMG.Controls.Add(Me.F_formula)
        Me.TabMG.Controls.Add(Me.lblwidok)
        Me.TabMG.Controls.Add(Me.BT_x)
        Me.TabMG.Controls.Add(Me.F_data_dodania)
        Me.TabMG.Controls.Add(Me.F_uwagi)
        Me.TabMG.Controls.Add(Me.F_lotto_nat)
        Me.TabMG.Controls.Add(Me.F_lotto_prod)
        Me.TabMG.Controls.Add(Me.F_galileo)
        Me.TabMG.Controls.Add(Me.F_ilosc)
        Me.TabMG.Controls.Add(Me.F_regal)
        Me.TabMG.Controls.Add(Me.F_opis)
        Me.TabMG.Controls.Add(Me.F_Kod)
        Me.TabMG.Controls.Add(Me.BT_pobierz_pal)
        Me.TabMG.Controls.Add(Me.BT_inwentaryzacja)
        Me.TabMG.Controls.Add(Me.BT_pobierz)
        Me.TabMG.Controls.Add(Me.BT_przenies)
        Me.TabMG.Controls.Add(Me.BT_dodaj)
        Me.TabMG.Controls.Add(Me.MGdgv)
        Me.TabMG.Location = New System.Drawing.Point(4, 22)
        Me.TabMG.Name = "TabMG"
        Me.TabMG.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabMG.Size = New System.Drawing.Size(1344, 609)
        Me.TabMG.TabIndex = 0
        Me.TabMG.Text = "Magazyn główny"
        Me.TabMG.UseVisualStyleBackColor = True
        '
        'BT_przenies_regal
        '
        Me.BT_przenies_regal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BT_przenies_regal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BT_przenies_regal.Location = New System.Drawing.Point(856, 555)
        Me.BT_przenies_regal.Name = "BT_przenies_regal"
        Me.BT_przenies_regal.Size = New System.Drawing.Size(164, 48)
        Me.BT_przenies_regal.TabIndex = 307
        Me.BT_przenies_regal.Text = "Przenieś regał"
        Me.BT_przenies_regal.UseVisualStyleBackColor = True
        '
        'BT_doloz
        '
        Me.BT_doloz.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BT_doloz.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BT_doloz.Location = New System.Drawing.Point(516, 555)
        Me.BT_doloz.Name = "BT_doloz"
        Me.BT_doloz.Size = New System.Drawing.Size(164, 48)
        Me.BT_doloz.TabIndex = 303
        Me.BT_doloz.Text = "Dołóż"
        Me.BT_doloz.UseVisualStyleBackColor = True
        '
        'F_formula
        '
        Me.F_formula.Location = New System.Drawing.Point(420, 6)
        Me.F_formula.MaxLength = 7
        Me.F_formula.Name = "F_formula"
        Me.F_formula.Size = New System.Drawing.Size(93, 20)
        Me.F_formula.TabIndex = 15
        Me.F_formula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.F_formula.Visible = False
        '
        'lblwidok
        '
        Me.lblwidok.AutoSize = True
        Me.lblwidok.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblwidok.ForeColor = System.Drawing.Color.Red
        Me.lblwidok.Location = New System.Drawing.Point(1197, 9)
        Me.lblwidok.Name = "lblwidok"
        Me.lblwidok.Size = New System.Drawing.Size(68, 13)
        Me.lblwidok.TabIndex = 8
        Me.lblwidok.Text = "Filtrowanie"
        Me.lblwidok.Visible = False
        '
        'BT_x
        '
        Me.BT_x.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BT_x.Location = New System.Drawing.Point(1164, 4)
        Me.BT_x.Name = "BT_x"
        Me.BT_x.Size = New System.Drawing.Size(28, 23)
        Me.BT_x.TabIndex = 9
        Me.BT_x.Text = "X"
        Me.BT_x.UseVisualStyleBackColor = True
        '
        'F_data_dodania
        '
        Me.F_data_dodania.Location = New System.Drawing.Point(1064, 6)
        Me.F_data_dodania.Name = "F_data_dodania"
        Me.F_data_dodania.Size = New System.Drawing.Size(94, 20)
        Me.F_data_dodania.TabIndex = 8
        Me.F_data_dodania.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F_uwagi
        '
        Me.F_uwagi.Location = New System.Drawing.Point(779, 6)
        Me.F_uwagi.Name = "F_uwagi"
        Me.F_uwagi.Size = New System.Drawing.Size(279, 20)
        Me.F_uwagi.TabIndex = 7
        Me.F_uwagi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F_lotto_nat
        '
        Me.F_lotto_nat.Location = New System.Drawing.Point(709, 6)
        Me.F_lotto_nat.MaxLength = 9
        Me.F_lotto_nat.Name = "F_lotto_nat"
        Me.F_lotto_nat.Size = New System.Drawing.Size(64, 20)
        Me.F_lotto_nat.TabIndex = 6
        Me.F_lotto_nat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F_lotto_prod
        '
        Me.F_lotto_prod.Location = New System.Drawing.Point(639, 6)
        Me.F_lotto_prod.MaxLength = 8
        Me.F_lotto_prod.Name = "F_lotto_prod"
        Me.F_lotto_prod.Size = New System.Drawing.Size(64, 20)
        Me.F_lotto_prod.TabIndex = 5
        Me.F_lotto_prod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F_galileo
        '
        Me.F_galileo.Location = New System.Drawing.Point(579, 6)
        Me.F_galileo.MaxLength = 8
        Me.F_galileo.Name = "F_galileo"
        Me.F_galileo.Size = New System.Drawing.Size(54, 20)
        Me.F_galileo.TabIndex = 4
        Me.F_galileo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F_ilosc
        '
        Me.F_ilosc.Location = New System.Drawing.Point(519, 6)
        Me.F_ilosc.MaxLength = 7
        Me.F_ilosc.Name = "F_ilosc"
        Me.F_ilosc.Size = New System.Drawing.Size(54, 20)
        Me.F_ilosc.TabIndex = 3
        Me.F_ilosc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.F_ilosc.Visible = False
        '
        'F_regal
        '
        Me.F_regal.Location = New System.Drawing.Point(370, 6)
        Me.F_regal.MaxLength = 5
        Me.F_regal.Name = "F_regal"
        Me.F_regal.Size = New System.Drawing.Size(44, 20)
        Me.F_regal.TabIndex = 2
        Me.F_regal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F_opis
        '
        Me.F_opis.Location = New System.Drawing.Point(100, 6)
        Me.F_opis.Name = "F_opis"
        Me.F_opis.Size = New System.Drawing.Size(264, 20)
        Me.F_opis.TabIndex = 1
        Me.F_opis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F_Kod
        '
        Me.F_Kod.Location = New System.Drawing.Point(6, 6)
        Me.F_Kod.Name = "F_Kod"
        Me.F_Kod.Size = New System.Drawing.Size(88, 20)
        Me.F_Kod.TabIndex = 0
        Me.F_Kod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BT_pobierz_pal
        '
        Me.BT_pobierz_pal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BT_pobierz_pal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BT_pobierz_pal.Location = New System.Drawing.Point(346, 555)
        Me.BT_pobierz_pal.Name = "BT_pobierz_pal"
        Me.BT_pobierz_pal.Size = New System.Drawing.Size(164, 48)
        Me.BT_pobierz_pal.TabIndex = 302
        Me.BT_pobierz_pal.Text = "Pobierz paletę"
        Me.BT_pobierz_pal.UseVisualStyleBackColor = True
        '
        'BT_inwentaryzacja
        '
        Me.BT_inwentaryzacja.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BT_inwentaryzacja.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BT_inwentaryzacja.Location = New System.Drawing.Point(1026, 555)
        Me.BT_inwentaryzacja.Name = "BT_inwentaryzacja"
        Me.BT_inwentaryzacja.Size = New System.Drawing.Size(164, 48)
        Me.BT_inwentaryzacja.TabIndex = 305
        Me.BT_inwentaryzacja.Text = "Inwentaryzacja"
        Me.BT_inwentaryzacja.UseVisualStyleBackColor = True
        '
        'BT_pobierz
        '
        Me.BT_pobierz.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BT_pobierz.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BT_pobierz.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BT_pobierz.Location = New System.Drawing.Point(176, 555)
        Me.BT_pobierz.Name = "BT_pobierz"
        Me.BT_pobierz.Size = New System.Drawing.Size(164, 48)
        Me.BT_pobierz.TabIndex = 301
        Me.BT_pobierz.Text = "Pobierz"
        Me.BT_pobierz.UseVisualStyleBackColor = True
        '
        'BT_przenies
        '
        Me.BT_przenies.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BT_przenies.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BT_przenies.Location = New System.Drawing.Point(686, 555)
        Me.BT_przenies.Name = "BT_przenies"
        Me.BT_przenies.Size = New System.Drawing.Size(164, 48)
        Me.BT_przenies.TabIndex = 304
        Me.BT_przenies.Text = "Przenieś"
        Me.BT_przenies.UseVisualStyleBackColor = True
        '
        'BT_dodaj
        '
        Me.BT_dodaj.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BT_dodaj.BackColor = System.Drawing.Color.Transparent
        Me.BT_dodaj.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BT_dodaj.ForeColor = System.Drawing.Color.DarkGreen
        Me.BT_dodaj.Location = New System.Drawing.Point(6, 555)
        Me.BT_dodaj.Name = "BT_dodaj"
        Me.BT_dodaj.Size = New System.Drawing.Size(164, 48)
        Me.BT_dodaj.TabIndex = 300
        Me.BT_dodaj.Text = "Dodaj na magazyn"
        Me.BT_dodaj.UseVisualStyleBackColor = False
        '
        'MGdgv
        '
        Me.MGdgv.AllowUserToAddRows = False
        Me.MGdgv.AllowUserToDeleteRows = False
        Me.MGdgv.AllowUserToResizeColumns = False
        Me.MGdgv.AllowUserToResizeRows = False
        Me.MGdgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MGdgv.AutoGenerateColumns = False
        Me.MGdgv.BackgroundColor = System.Drawing.SystemColors.Window
        Me.MGdgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MGdgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MGdgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MGdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MGdgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MgIDDataGridViewTextBoxColumn, Me.KodZPDataGridViewTextBoxColumn, Me.OpisDataGridViewTextBoxColumn, Me.RegalDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn2, Me.IloscDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn24, Me.LottoprodDataGridViewTextBoxColumn, Me.LottonatDataGridViewTextBoxColumn, Me.UwagiDataGridViewTextBoxColumn, Me.DatadodaniaDataGridViewTextBoxColumn, Me.DatamodyfikacjiDataGridViewTextBoxColumn, Me.LmodDataGridViewTextBoxColumn})
        Me.MGdgv.DataSource = Me.MGBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.MenuText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MGdgv.DefaultCellStyle = DataGridViewCellStyle2
        Me.MGdgv.Location = New System.Drawing.Point(6, 31)
        Me.MGdgv.Name = "MGdgv"
        Me.MGdgv.ReadOnly = True
        Me.MGdgv.RowHeadersVisible = False
        Me.MGdgv.RowHeadersWidth = 51
        Me.MGdgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MGdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MGdgv.Size = New System.Drawing.Size(1332, 518)
        Me.MGdgv.TabIndex = 8
        '
        'MgIDDataGridViewTextBoxColumn
        '
        Me.MgIDDataGridViewTextBoxColumn.DataPropertyName = "MgID"
        Me.MgIDDataGridViewTextBoxColumn.HeaderText = "MgID"
        Me.MgIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MgIDDataGridViewTextBoxColumn.Name = "MgIDDataGridViewTextBoxColumn"
        Me.MgIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.MgIDDataGridViewTextBoxColumn.Width = 125
        '
        'KodZPDataGridViewTextBoxColumn
        '
        Me.KodZPDataGridViewTextBoxColumn.DataPropertyName = "KodZP"
        Me.KodZPDataGridViewTextBoxColumn.HeaderText = "KodZP"
        Me.KodZPDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.KodZPDataGridViewTextBoxColumn.Name = "KodZPDataGridViewTextBoxColumn"
        Me.KodZPDataGridViewTextBoxColumn.ReadOnly = True
        Me.KodZPDataGridViewTextBoxColumn.Width = 125
        '
        'OpisDataGridViewTextBoxColumn
        '
        Me.OpisDataGridViewTextBoxColumn.DataPropertyName = "opis"
        Me.OpisDataGridViewTextBoxColumn.HeaderText = "opis"
        Me.OpisDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OpisDataGridViewTextBoxColumn.Name = "OpisDataGridViewTextBoxColumn"
        Me.OpisDataGridViewTextBoxColumn.ReadOnly = True
        Me.OpisDataGridViewTextBoxColumn.Width = 125
        '
        'RegalDataGridViewTextBoxColumn
        '
        Me.RegalDataGridViewTextBoxColumn.DataPropertyName = "regal"
        Me.RegalDataGridViewTextBoxColumn.HeaderText = "regal"
        Me.RegalDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RegalDataGridViewTextBoxColumn.Name = "RegalDataGridViewTextBoxColumn"
        Me.RegalDataGridViewTextBoxColumn.ReadOnly = True
        Me.RegalDataGridViewTextBoxColumn.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ilosc_pak"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ilosc_pak"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'IloscDataGridViewTextBoxColumn
        '
        Me.IloscDataGridViewTextBoxColumn.DataPropertyName = "ilosc"
        Me.IloscDataGridViewTextBoxColumn.HeaderText = "ilosc"
        Me.IloscDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IloscDataGridViewTextBoxColumn.Name = "IloscDataGridViewTextBoxColumn"
        Me.IloscDataGridViewTextBoxColumn.ReadOnly = True
        Me.IloscDataGridViewTextBoxColumn.Width = 125
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "ilosc_galileo"
        Me.DataGridViewTextBoxColumn24.HeaderText = "ilosc_galileo"
        Me.DataGridViewTextBoxColumn24.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        Me.DataGridViewTextBoxColumn24.Width = 125
        '
        'LottoprodDataGridViewTextBoxColumn
        '
        Me.LottoprodDataGridViewTextBoxColumn.DataPropertyName = "lotto_prod"
        Me.LottoprodDataGridViewTextBoxColumn.HeaderText = "lotto_prod"
        Me.LottoprodDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LottoprodDataGridViewTextBoxColumn.Name = "LottoprodDataGridViewTextBoxColumn"
        Me.LottoprodDataGridViewTextBoxColumn.ReadOnly = True
        Me.LottoprodDataGridViewTextBoxColumn.Width = 125
        '
        'LottonatDataGridViewTextBoxColumn
        '
        Me.LottonatDataGridViewTextBoxColumn.DataPropertyName = "lotto_nat"
        Me.LottonatDataGridViewTextBoxColumn.HeaderText = "lotto_nat"
        Me.LottonatDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LottonatDataGridViewTextBoxColumn.Name = "LottonatDataGridViewTextBoxColumn"
        Me.LottonatDataGridViewTextBoxColumn.ReadOnly = True
        Me.LottonatDataGridViewTextBoxColumn.Width = 125
        '
        'UwagiDataGridViewTextBoxColumn
        '
        Me.UwagiDataGridViewTextBoxColumn.DataPropertyName = "uwagi"
        Me.UwagiDataGridViewTextBoxColumn.HeaderText = "uwagi"
        Me.UwagiDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UwagiDataGridViewTextBoxColumn.Name = "UwagiDataGridViewTextBoxColumn"
        Me.UwagiDataGridViewTextBoxColumn.ReadOnly = True
        Me.UwagiDataGridViewTextBoxColumn.Width = 125
        '
        'DatadodaniaDataGridViewTextBoxColumn
        '
        Me.DatadodaniaDataGridViewTextBoxColumn.DataPropertyName = "data_dodania"
        Me.DatadodaniaDataGridViewTextBoxColumn.HeaderText = "data_dodania"
        Me.DatadodaniaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DatadodaniaDataGridViewTextBoxColumn.Name = "DatadodaniaDataGridViewTextBoxColumn"
        Me.DatadodaniaDataGridViewTextBoxColumn.ReadOnly = True
        Me.DatadodaniaDataGridViewTextBoxColumn.Width = 125
        '
        'DatamodyfikacjiDataGridViewTextBoxColumn
        '
        Me.DatamodyfikacjiDataGridViewTextBoxColumn.DataPropertyName = "data_modyfikacji"
        Me.DatamodyfikacjiDataGridViewTextBoxColumn.HeaderText = "data_modyfikacji"
        Me.DatamodyfikacjiDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DatamodyfikacjiDataGridViewTextBoxColumn.Name = "DatamodyfikacjiDataGridViewTextBoxColumn"
        Me.DatamodyfikacjiDataGridViewTextBoxColumn.ReadOnly = True
        Me.DatamodyfikacjiDataGridViewTextBoxColumn.Width = 125
        '
        'LmodDataGridViewTextBoxColumn
        '
        Me.LmodDataGridViewTextBoxColumn.DataPropertyName = "l_mod"
        Me.LmodDataGridViewTextBoxColumn.HeaderText = "l_mod"
        Me.LmodDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LmodDataGridViewTextBoxColumn.Name = "LmodDataGridViewTextBoxColumn"
        Me.LmodDataGridViewTextBoxColumn.ReadOnly = True
        Me.LmodDataGridViewTextBoxColumn.Width = 125
        '
        'MGBindingSource
        '
        Me.MGBindingSource.DataMember = "MG"
        Me.MGBindingSource.DataSource = Me.MagDbDataSet
        '
        'MagDbDataSet
        '
        Me.MagDbDataSet.DataSetName = "MagDbDataSet"
        Me.MagDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabMP
        '
        Me.TabMP.Controls.Add(Me.BT_MP_doloz)
        Me.TabMP.Controls.Add(Me.FMP_data_dodania)
        Me.TabMP.Controls.Add(Me.FMP_wymiar)
        Me.TabMP.Controls.Add(Me.FMP_przekroj)
        Me.TabMP.Controls.Add(Me.FMP_material)
        Me.TabMP.Controls.Add(Me.FMP_uwagi)
        Me.TabMP.Controls.Add(Me.FMP_lotto)
        Me.TabMP.Controls.Add(Me.FMP_galileo)
        Me.TabMP.Controls.Add(Me.FMP_ilosc)
        Me.TabMP.Controls.Add(Me.FMP_regal)
        Me.TabMP.Controls.Add(Me.FMP_opis)
        Me.TabMP.Controls.Add(Me.BT_MP_przenies)
        Me.TabMP.Controls.Add(Me.BT_MP_inwentaryzacja)
        Me.TabMP.Controls.Add(Me.BT_MP_pobierz)
        Me.TabMP.Controls.Add(Me.BT_x3)
        Me.TabMP.Controls.Add(Me.lblWidok_MP)
        Me.TabMP.Controls.Add(Me.FMP_kod)
        Me.TabMP.Controls.Add(Me.BT_MP_dodaj)
        Me.TabMP.Controls.Add(Me.MPdgv)
        Me.TabMP.Location = New System.Drawing.Point(4, 22)
        Me.TabMP.Name = "TabMP"
        Me.TabMP.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabMP.Size = New System.Drawing.Size(1344, 609)
        Me.TabMP.TabIndex = 1
        Me.TabMP.Text = "Magazyn prętów"
        Me.TabMP.UseVisualStyleBackColor = True
        '
        'BT_MP_doloz
        '
        Me.BT_MP_doloz.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BT_MP_doloz.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BT_MP_doloz.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BT_MP_doloz.Location = New System.Drawing.Point(346, 555)
        Me.BT_MP_doloz.Name = "BT_MP_doloz"
        Me.BT_MP_doloz.Size = New System.Drawing.Size(164, 48)
        Me.BT_MP_doloz.TabIndex = 403
        Me.BT_MP_doloz.Text = "Dołóż"
        Me.BT_MP_doloz.UseVisualStyleBackColor = True
        '
        'FMP_data_dodania
        '
        Me.FMP_data_dodania.Location = New System.Drawing.Point(991, 6)
        Me.FMP_data_dodania.Name = "FMP_data_dodania"
        Me.FMP_data_dodania.Size = New System.Drawing.Size(94, 20)
        Me.FMP_data_dodania.TabIndex = 25
        Me.FMP_data_dodania.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FMP_wymiar
        '
        Me.FMP_wymiar.Location = New System.Drawing.Point(942, 6)
        Me.FMP_wymiar.MaxLength = 5
        Me.FMP_wymiar.Name = "FMP_wymiar"
        Me.FMP_wymiar.Size = New System.Drawing.Size(44, 20)
        Me.FMP_wymiar.TabIndex = 24
        Me.FMP_wymiar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FMP_przekroj
        '
        Me.FMP_przekroj.Location = New System.Drawing.Point(892, 6)
        Me.FMP_przekroj.MaxLength = 5
        Me.FMP_przekroj.Name = "FMP_przekroj"
        Me.FMP_przekroj.Size = New System.Drawing.Size(44, 20)
        Me.FMP_przekroj.TabIndex = 23
        Me.FMP_przekroj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FMP_material
        '
        Me.FMP_material.Location = New System.Drawing.Point(812, 6)
        Me.FMP_material.Name = "FMP_material"
        Me.FMP_material.Size = New System.Drawing.Size(74, 20)
        Me.FMP_material.TabIndex = 22
        Me.FMP_material.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FMP_uwagi
        '
        Me.FMP_uwagi.Location = New System.Drawing.Point(610, 6)
        Me.FMP_uwagi.Name = "FMP_uwagi"
        Me.FMP_uwagi.Size = New System.Drawing.Size(196, 20)
        Me.FMP_uwagi.TabIndex = 21
        Me.FMP_uwagi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FMP_lotto
        '
        Me.FMP_lotto.Location = New System.Drawing.Point(540, 6)
        Me.FMP_lotto.MaxLength = 9
        Me.FMP_lotto.Name = "FMP_lotto"
        Me.FMP_lotto.Size = New System.Drawing.Size(64, 20)
        Me.FMP_lotto.TabIndex = 20
        Me.FMP_lotto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FMP_galileo
        '
        Me.FMP_galileo.Location = New System.Drawing.Point(480, 6)
        Me.FMP_galileo.Name = "FMP_galileo"
        Me.FMP_galileo.Size = New System.Drawing.Size(54, 20)
        Me.FMP_galileo.TabIndex = 19
        Me.FMP_galileo.Visible = False
        '
        'FMP_ilosc
        '
        Me.FMP_ilosc.Location = New System.Drawing.Point(420, 6)
        Me.FMP_ilosc.MaxLength = 7
        Me.FMP_ilosc.Name = "FMP_ilosc"
        Me.FMP_ilosc.Size = New System.Drawing.Size(54, 20)
        Me.FMP_ilosc.TabIndex = 18
        Me.FMP_ilosc.Visible = False
        '
        'FMP_regal
        '
        Me.FMP_regal.Location = New System.Drawing.Point(370, 6)
        Me.FMP_regal.MaxLength = 5
        Me.FMP_regal.Name = "FMP_regal"
        Me.FMP_regal.Size = New System.Drawing.Size(44, 20)
        Me.FMP_regal.TabIndex = 17
        Me.FMP_regal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FMP_opis
        '
        Me.FMP_opis.Location = New System.Drawing.Point(100, 6)
        Me.FMP_opis.Name = "FMP_opis"
        Me.FMP_opis.Size = New System.Drawing.Size(264, 20)
        Me.FMP_opis.TabIndex = 16
        Me.FMP_opis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BT_MP_przenies
        '
        Me.BT_MP_przenies.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BT_MP_przenies.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BT_MP_przenies.Location = New System.Drawing.Point(516, 555)
        Me.BT_MP_przenies.Name = "BT_MP_przenies"
        Me.BT_MP_przenies.Size = New System.Drawing.Size(164, 48)
        Me.BT_MP_przenies.TabIndex = 404
        Me.BT_MP_przenies.Text = "Przenieś"
        Me.BT_MP_przenies.UseVisualStyleBackColor = True
        '
        'BT_MP_inwentaryzacja
        '
        Me.BT_MP_inwentaryzacja.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BT_MP_inwentaryzacja.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BT_MP_inwentaryzacja.Location = New System.Drawing.Point(686, 555)
        Me.BT_MP_inwentaryzacja.Name = "BT_MP_inwentaryzacja"
        Me.BT_MP_inwentaryzacja.Size = New System.Drawing.Size(164, 48)
        Me.BT_MP_inwentaryzacja.TabIndex = 405
        Me.BT_MP_inwentaryzacja.Text = "Inwentaryzacja"
        Me.BT_MP_inwentaryzacja.UseVisualStyleBackColor = True
        '
        'BT_MP_pobierz
        '
        Me.BT_MP_pobierz.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BT_MP_pobierz.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BT_MP_pobierz.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BT_MP_pobierz.Location = New System.Drawing.Point(176, 555)
        Me.BT_MP_pobierz.Name = "BT_MP_pobierz"
        Me.BT_MP_pobierz.Size = New System.Drawing.Size(164, 48)
        Me.BT_MP_pobierz.TabIndex = 402
        Me.BT_MP_pobierz.Text = "Pobierz"
        Me.BT_MP_pobierz.UseVisualStyleBackColor = True
        '
        'BT_x3
        '
        Me.BT_x3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BT_x3.Location = New System.Drawing.Point(1090, 4)
        Me.BT_x3.Name = "BT_x3"
        Me.BT_x3.Size = New System.Drawing.Size(28, 23)
        Me.BT_x3.TabIndex = 26
        Me.BT_x3.Text = "X"
        Me.BT_x3.UseVisualStyleBackColor = True
        '
        'lblWidok_MP
        '
        Me.lblWidok_MP.AutoSize = True
        Me.lblWidok_MP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblWidok_MP.ForeColor = System.Drawing.Color.Red
        Me.lblWidok_MP.Location = New System.Drawing.Point(1120, 9)
        Me.lblWidok_MP.Name = "lblWidok_MP"
        Me.lblWidok_MP.Size = New System.Drawing.Size(68, 13)
        Me.lblWidok_MP.TabIndex = 23
        Me.lblWidok_MP.Text = "Filtrowanie"
        Me.lblWidok_MP.Visible = False
        '
        'FMP_kod
        '
        Me.FMP_kod.Location = New System.Drawing.Point(6, 6)
        Me.FMP_kod.Name = "FMP_kod"
        Me.FMP_kod.Size = New System.Drawing.Size(88, 20)
        Me.FMP_kod.TabIndex = 15
        Me.FMP_kod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BT_MP_dodaj
        '
        Me.BT_MP_dodaj.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BT_MP_dodaj.BackColor = System.Drawing.Color.Transparent
        Me.BT_MP_dodaj.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BT_MP_dodaj.ForeColor = System.Drawing.Color.Chocolate
        Me.BT_MP_dodaj.Location = New System.Drawing.Point(6, 555)
        Me.BT_MP_dodaj.Name = "BT_MP_dodaj"
        Me.BT_MP_dodaj.Size = New System.Drawing.Size(164, 48)
        Me.BT_MP_dodaj.TabIndex = 401
        Me.BT_MP_dodaj.Text = "Dodaj na magazyn"
        Me.BT_MP_dodaj.UseVisualStyleBackColor = False
        '
        'MPdgv
        '
        Me.MPdgv.AllowUserToAddRows = False
        Me.MPdgv.AllowUserToDeleteRows = False
        Me.MPdgv.AllowUserToResizeColumns = False
        Me.MPdgv.AllowUserToResizeRows = False
        Me.MPdgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MPdgv.AutoGenerateColumns = False
        Me.MPdgv.BackgroundColor = System.Drawing.SystemColors.Window
        Me.MPdgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MPdgv.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.MPdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MPdgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MpID, Me.KodMP, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.lotto, Me.DataGridViewTextBoxColumn11, Me.Material, Me.Przekroj, Me.Wymiar, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn36})
        Me.MPdgv.DataSource = Me.MPBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MPdgv.DefaultCellStyle = DataGridViewCellStyle3
        Me.MPdgv.Location = New System.Drawing.Point(6, 31)
        Me.MPdgv.Name = "MPdgv"
        Me.MPdgv.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LemonChiffon
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MPdgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.MPdgv.RowHeadersVisible = False
        Me.MPdgv.RowHeadersWidth = 51
        Me.MPdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MPdgv.Size = New System.Drawing.Size(1332, 518)
        Me.MPdgv.TabIndex = 9
        '
        'MpID
        '
        Me.MpID.DataPropertyName = "MpID"
        Me.MpID.HeaderText = "MpID"
        Me.MpID.MinimumWidth = 6
        Me.MpID.Name = "MpID"
        Me.MpID.ReadOnly = True
        Me.MpID.Width = 125
        '
        'KodMP
        '
        Me.KodMP.DataPropertyName = "KodMP"
        Me.KodMP.HeaderText = "KodMP"
        Me.KodMP.MinimumWidth = 6
        Me.KodMP.Name = "KodMP"
        Me.KodMP.ReadOnly = True
        Me.KodMP.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "opis"
        Me.DataGridViewTextBoxColumn5.HeaderText = "opis"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "regal"
        Me.DataGridViewTextBoxColumn6.HeaderText = "regal"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ilosc"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ilosc"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ilosc_galileo"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ilosc_galileo"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'lotto
        '
        Me.lotto.DataPropertyName = "lotto"
        Me.lotto.HeaderText = "lotto"
        Me.lotto.MinimumWidth = 6
        Me.lotto.Name = "lotto"
        Me.lotto.ReadOnly = True
        Me.lotto.Width = 125
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "uwagi"
        Me.DataGridViewTextBoxColumn11.HeaderText = "uwagi"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 125
        '
        'Material
        '
        Me.Material.DataPropertyName = "Material"
        Me.Material.HeaderText = "Material"
        Me.Material.MinimumWidth = 6
        Me.Material.Name = "Material"
        Me.Material.ReadOnly = True
        Me.Material.Width = 125
        '
        'Przekroj
        '
        Me.Przekroj.DataPropertyName = "Przekroj"
        Me.Przekroj.HeaderText = "Przekroj"
        Me.Przekroj.MinimumWidth = 6
        Me.Przekroj.Name = "Przekroj"
        Me.Przekroj.ReadOnly = True
        Me.Przekroj.Width = 125
        '
        'Wymiar
        '
        Me.Wymiar.DataPropertyName = "Wymiar"
        Me.Wymiar.HeaderText = "Wymiar"
        Me.Wymiar.MinimumWidth = 6
        Me.Wymiar.Name = "Wymiar"
        Me.Wymiar.ReadOnly = True
        Me.Wymiar.Width = 125
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "data_dodania"
        Me.DataGridViewTextBoxColumn13.HeaderText = "data_dodania"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 125
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "data_modyfikacji"
        Me.DataGridViewTextBoxColumn14.HeaderText = "data_modyfikacji"
        Me.DataGridViewTextBoxColumn14.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 125
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "l_mod"
        Me.DataGridViewTextBoxColumn36.HeaderText = "l_mod"
        Me.DataGridViewTextBoxColumn36.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.ReadOnly = True
        Me.DataGridViewTextBoxColumn36.Width = 125
        '
        'MPBindingSource
        '
        Me.MPBindingSource.DataMember = "MP"
        Me.MPBindingSource.DataSource = Me.MagDbDataSet
        '
        'TabMGR
        '
        Me.TabMGR.Controls.Add(Me.MGstan)
        Me.TabMGR.Controls.Add(Me.BT_x2)
        Me.TabMGR.Controls.Add(Me.lblWidokRuchy)
        Me.TabMGR.Controls.Add(Me.FR_uwagi)
        Me.TabMGR.Controls.Add(Me.FR_lotto_nat)
        Me.TabMGR.Controls.Add(Me.FR_lotto_prod)
        Me.TabMGR.Controls.Add(Me.FR_ilosc)
        Me.TabMGR.Controls.Add(Me.FR_regal)
        Me.TabMGR.Controls.Add(Me.FR_opis)
        Me.TabMGR.Controls.Add(Me.FR_kod)
        Me.TabMGR.Controls.Add(Me.FR_akcja)
        Me.TabMGR.Controls.Add(Me.FR_data)
        Me.TabMGR.Controls.Add(Me.MGRdgv)
        Me.TabMGR.Location = New System.Drawing.Point(4, 22)
        Me.TabMGR.Name = "TabMGR"
        Me.TabMGR.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabMGR.Size = New System.Drawing.Size(1344, 609)
        Me.TabMGR.TabIndex = 2
        Me.TabMGR.Text = "Ruchy - Magazyn główny"
        Me.TabMGR.UseVisualStyleBackColor = True
        '
        'MGstan
        '
        Me.MGstan.Location = New System.Drawing.Point(1040, 5)
        Me.MGstan.Name = "MGstan"
        Me.MGstan.Size = New System.Drawing.Size(64, 23)
        Me.MGstan.TabIndex = 40
        Me.MGstan.Text = "Edytuj"
        Me.MGstan.UseVisualStyleBackColor = True
        '
        'BT_x2
        '
        Me.BT_x2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BT_x2.Location = New System.Drawing.Point(1110, 5)
        Me.BT_x2.Name = "BT_x2"
        Me.BT_x2.Size = New System.Drawing.Size(28, 23)
        Me.BT_x2.TabIndex = 41
        Me.BT_x2.Text = "X"
        Me.BT_x2.UseVisualStyleBackColor = True
        '
        'lblWidokRuchy
        '
        Me.lblWidokRuchy.AutoSize = True
        Me.lblWidokRuchy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblWidokRuchy.ForeColor = System.Drawing.Color.Red
        Me.lblWidokRuchy.Location = New System.Drawing.Point(1144, 10)
        Me.lblWidokRuchy.Name = "lblWidokRuchy"
        Me.lblWidokRuchy.Size = New System.Drawing.Size(68, 13)
        Me.lblWidokRuchy.TabIndex = 22
        Me.lblWidokRuchy.Text = "Filtrowanie"
        Me.lblWidokRuchy.Visible = False
        '
        'FR_uwagi
        '
        Me.FR_uwagi.Location = New System.Drawing.Point(840, 6)
        Me.FR_uwagi.Name = "FR_uwagi"
        Me.FR_uwagi.Size = New System.Drawing.Size(194, 20)
        Me.FR_uwagi.TabIndex = 39
        Me.FR_uwagi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FR_lotto_nat
        '
        Me.FR_lotto_nat.Location = New System.Drawing.Point(770, 6)
        Me.FR_lotto_nat.MaxLength = 9
        Me.FR_lotto_nat.Name = "FR_lotto_nat"
        Me.FR_lotto_nat.Size = New System.Drawing.Size(64, 20)
        Me.FR_lotto_nat.TabIndex = 38
        Me.FR_lotto_nat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FR_lotto_prod
        '
        Me.FR_lotto_prod.Location = New System.Drawing.Point(700, 6)
        Me.FR_lotto_prod.MaxLength = 8
        Me.FR_lotto_prod.Name = "FR_lotto_prod"
        Me.FR_lotto_prod.Size = New System.Drawing.Size(64, 20)
        Me.FR_lotto_prod.TabIndex = 37
        Me.FR_lotto_prod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FR_ilosc
        '
        Me.FR_ilosc.Location = New System.Drawing.Point(630, 6)
        Me.FR_ilosc.Name = "FR_ilosc"
        Me.FR_ilosc.Size = New System.Drawing.Size(64, 20)
        Me.FR_ilosc.TabIndex = 36
        Me.FR_ilosc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.FR_ilosc.Visible = False
        '
        'FR_regal
        '
        Me.FR_regal.Location = New System.Drawing.Point(580, 6)
        Me.FR_regal.MaxLength = 5
        Me.FR_regal.Name = "FR_regal"
        Me.FR_regal.Size = New System.Drawing.Size(44, 20)
        Me.FR_regal.TabIndex = 35
        Me.FR_regal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FR_opis
        '
        Me.FR_opis.Location = New System.Drawing.Point(310, 6)
        Me.FR_opis.Name = "FR_opis"
        Me.FR_opis.Size = New System.Drawing.Size(264, 20)
        Me.FR_opis.TabIndex = 34
        Me.FR_opis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FR_kod
        '
        Me.FR_kod.Location = New System.Drawing.Point(210, 6)
        Me.FR_kod.Name = "FR_kod"
        Me.FR_kod.Size = New System.Drawing.Size(94, 20)
        Me.FR_kod.TabIndex = 33
        Me.FR_kod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FR_akcja
        '
        Me.FR_akcja.Location = New System.Drawing.Point(110, 6)
        Me.FR_akcja.Name = "FR_akcja"
        Me.FR_akcja.Size = New System.Drawing.Size(94, 20)
        Me.FR_akcja.TabIndex = 32
        Me.FR_akcja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FR_data
        '
        Me.FR_data.Location = New System.Drawing.Point(6, 6)
        Me.FR_data.Name = "FR_data"
        Me.FR_data.Size = New System.Drawing.Size(98, 20)
        Me.FR_data.TabIndex = 31
        Me.FR_data.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MGRdgv
        '
        Me.MGRdgv.AllowUserToAddRows = False
        Me.MGRdgv.AllowUserToDeleteRows = False
        Me.MGRdgv.AllowUserToResizeColumns = False
        Me.MGRdgv.AllowUserToResizeRows = False
        Me.MGRdgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MGRdgv.AutoGenerateColumns = False
        Me.MGRdgv.BackgroundColor = System.Drawing.SystemColors.Window
        Me.MGRdgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MGRdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MGRdgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MgruchyIDDataGridViewTextBoxColumn, Me.DataDataGridViewTextBoxColumn, Me.akcja, Me.KodZPDataGridViewTextBoxColumn1, Me.OpisgalDataGridViewTextBoxColumn, Me.RegalDataGridViewTextBoxColumn1, Me.ilosc, Me.LottoprodDataGridViewTextBoxColumn1, Me.LottonatDataGridViewTextBoxColumn1, Me.UwagiDataGridViewTextBoxColumn1, Me.stanMG, Me.uwagi_mod, Me.NrmodDataGridViewTextBoxColumn, Me.MgIDDataGridViewTextBoxColumn1, Me.uzytkownik})
        Me.MGRdgv.DataSource = Me.MGruchyBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(155, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MGRdgv.DefaultCellStyle = DataGridViewCellStyle5
        Me.MGRdgv.Location = New System.Drawing.Point(6, 31)
        Me.MGRdgv.Name = "MGRdgv"
        Me.MGRdgv.ReadOnly = True
        Me.MGRdgv.RowHeadersVisible = False
        Me.MGRdgv.RowHeadersWidth = 51
        Me.MGRdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MGRdgv.Size = New System.Drawing.Size(1332, 572)
        Me.MGRdgv.TabIndex = 0
        '
        'MgruchyIDDataGridViewTextBoxColumn
        '
        Me.MgruchyIDDataGridViewTextBoxColumn.DataPropertyName = "Mg_ruchyID"
        Me.MgruchyIDDataGridViewTextBoxColumn.HeaderText = "Mg_ruchyID"
        Me.MgruchyIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MgruchyIDDataGridViewTextBoxColumn.Name = "MgruchyIDDataGridViewTextBoxColumn"
        Me.MgruchyIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.MgruchyIDDataGridViewTextBoxColumn.Width = 125
        '
        'DataDataGridViewTextBoxColumn
        '
        Me.DataDataGridViewTextBoxColumn.DataPropertyName = "data"
        Me.DataDataGridViewTextBoxColumn.HeaderText = "data"
        Me.DataDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DataDataGridViewTextBoxColumn.Name = "DataDataGridViewTextBoxColumn"
        Me.DataDataGridViewTextBoxColumn.ReadOnly = True
        Me.DataDataGridViewTextBoxColumn.Width = 125
        '
        'akcja
        '
        Me.akcja.DataPropertyName = "akcja"
        Me.akcja.HeaderText = "akcja"
        Me.akcja.MinimumWidth = 6
        Me.akcja.Name = "akcja"
        Me.akcja.ReadOnly = True
        Me.akcja.Width = 125
        '
        'KodZPDataGridViewTextBoxColumn1
        '
        Me.KodZPDataGridViewTextBoxColumn1.DataPropertyName = "KodZP"
        Me.KodZPDataGridViewTextBoxColumn1.HeaderText = "KodZP"
        Me.KodZPDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.KodZPDataGridViewTextBoxColumn1.Name = "KodZPDataGridViewTextBoxColumn1"
        Me.KodZPDataGridViewTextBoxColumn1.ReadOnly = True
        Me.KodZPDataGridViewTextBoxColumn1.Width = 125
        '
        'OpisgalDataGridViewTextBoxColumn
        '
        Me.OpisgalDataGridViewTextBoxColumn.DataPropertyName = "opis_gal"
        Me.OpisgalDataGridViewTextBoxColumn.HeaderText = "opis_gal"
        Me.OpisgalDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OpisgalDataGridViewTextBoxColumn.Name = "OpisgalDataGridViewTextBoxColumn"
        Me.OpisgalDataGridViewTextBoxColumn.ReadOnly = True
        Me.OpisgalDataGridViewTextBoxColumn.Width = 125
        '
        'RegalDataGridViewTextBoxColumn1
        '
        Me.RegalDataGridViewTextBoxColumn1.DataPropertyName = "regal"
        Me.RegalDataGridViewTextBoxColumn1.HeaderText = "regal"
        Me.RegalDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.RegalDataGridViewTextBoxColumn1.Name = "RegalDataGridViewTextBoxColumn1"
        Me.RegalDataGridViewTextBoxColumn1.ReadOnly = True
        Me.RegalDataGridViewTextBoxColumn1.Width = 125
        '
        'ilosc
        '
        Me.ilosc.DataPropertyName = "ilosc"
        Me.ilosc.HeaderText = "ilosc"
        Me.ilosc.MinimumWidth = 6
        Me.ilosc.Name = "ilosc"
        Me.ilosc.ReadOnly = True
        Me.ilosc.Width = 125
        '
        'LottoprodDataGridViewTextBoxColumn1
        '
        Me.LottoprodDataGridViewTextBoxColumn1.DataPropertyName = "lotto_prod"
        Me.LottoprodDataGridViewTextBoxColumn1.HeaderText = "lotto_prod"
        Me.LottoprodDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.LottoprodDataGridViewTextBoxColumn1.Name = "LottoprodDataGridViewTextBoxColumn1"
        Me.LottoprodDataGridViewTextBoxColumn1.ReadOnly = True
        Me.LottoprodDataGridViewTextBoxColumn1.Width = 125
        '
        'LottonatDataGridViewTextBoxColumn1
        '
        Me.LottonatDataGridViewTextBoxColumn1.DataPropertyName = "lotto_nat"
        Me.LottonatDataGridViewTextBoxColumn1.HeaderText = "lotto_nat"
        Me.LottonatDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.LottonatDataGridViewTextBoxColumn1.Name = "LottonatDataGridViewTextBoxColumn1"
        Me.LottonatDataGridViewTextBoxColumn1.ReadOnly = True
        Me.LottonatDataGridViewTextBoxColumn1.Width = 125
        '
        'UwagiDataGridViewTextBoxColumn1
        '
        Me.UwagiDataGridViewTextBoxColumn1.DataPropertyName = "uwagi"
        Me.UwagiDataGridViewTextBoxColumn1.HeaderText = "uwagi"
        Me.UwagiDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.UwagiDataGridViewTextBoxColumn1.Name = "UwagiDataGridViewTextBoxColumn1"
        Me.UwagiDataGridViewTextBoxColumn1.ReadOnly = True
        Me.UwagiDataGridViewTextBoxColumn1.Width = 125
        '
        'stanMG
        '
        Me.stanMG.DataPropertyName = "stan"
        Me.stanMG.HeaderText = "stan"
        Me.stanMG.MinimumWidth = 6
        Me.stanMG.Name = "stanMG"
        Me.stanMG.ReadOnly = True
        Me.stanMG.Width = 125
        '
        'uwagi_mod
        '
        Me.uwagi_mod.DataPropertyName = "uwagi_mod"
        Me.uwagi_mod.HeaderText = "uwagi_mod"
        Me.uwagi_mod.MinimumWidth = 6
        Me.uwagi_mod.Name = "uwagi_mod"
        Me.uwagi_mod.ReadOnly = True
        Me.uwagi_mod.Width = 125
        '
        'NrmodDataGridViewTextBoxColumn
        '
        Me.NrmodDataGridViewTextBoxColumn.DataPropertyName = "nr_mod"
        Me.NrmodDataGridViewTextBoxColumn.HeaderText = "nr_mod"
        Me.NrmodDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NrmodDataGridViewTextBoxColumn.Name = "NrmodDataGridViewTextBoxColumn"
        Me.NrmodDataGridViewTextBoxColumn.ReadOnly = True
        Me.NrmodDataGridViewTextBoxColumn.Width = 125
        '
        'MgIDDataGridViewTextBoxColumn1
        '
        Me.MgIDDataGridViewTextBoxColumn1.DataPropertyName = "MgID"
        Me.MgIDDataGridViewTextBoxColumn1.HeaderText = "MgID"
        Me.MgIDDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.MgIDDataGridViewTextBoxColumn1.Name = "MgIDDataGridViewTextBoxColumn1"
        Me.MgIDDataGridViewTextBoxColumn1.ReadOnly = True
        Me.MgIDDataGridViewTextBoxColumn1.Width = 125
        '
        'uzytkownik
        '
        Me.uzytkownik.DataPropertyName = "uzytkownik"
        Me.uzytkownik.HeaderText = "uzytkownik"
        Me.uzytkownik.MinimumWidth = 6
        Me.uzytkownik.Name = "uzytkownik"
        Me.uzytkownik.ReadOnly = True
        Me.uzytkownik.Width = 125
        '
        'MGruchyBindingSource
        '
        Me.MGruchyBindingSource.DataMember = "MG_ruchy"
        Me.MGruchyBindingSource.DataSource = Me.MagDbDataSet
        '
        'TabMPR
        '
        Me.TabMPR.Controls.Add(Me.MPstan)
        Me.TabMPR.Controls.Add(Me.FMPR_uwagi)
        Me.TabMPR.Controls.Add(Me.FMPR_lotto_prod)
        Me.TabMPR.Controls.Add(Me.FMPR_lotto)
        Me.TabMPR.Controls.Add(Me.FMPR_ilosc)
        Me.TabMPR.Controls.Add(Me.FMPR_regal)
        Me.TabMPR.Controls.Add(Me.FMPR_opis)
        Me.TabMPR.Controls.Add(Me.FMPR_kod)
        Me.TabMPR.Controls.Add(Me.FMPR_akcja)
        Me.TabMPR.Controls.Add(Me.BT_x4)
        Me.TabMPR.Controls.Add(Me.lblWidok_MPR)
        Me.TabMPR.Controls.Add(Me.FMPR_data)
        Me.TabMPR.Controls.Add(Me.MPRdgv)
        Me.TabMPR.Location = New System.Drawing.Point(4, 22)
        Me.TabMPR.Name = "TabMPR"
        Me.TabMPR.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabMPR.Size = New System.Drawing.Size(1344, 609)
        Me.TabMPR.TabIndex = 3
        Me.TabMPR.Text = "Ruchy - Magazyn prętów"
        Me.TabMPR.UseVisualStyleBackColor = True
        '
        'MPstan
        '
        Me.MPstan.Location = New System.Drawing.Point(1040, 5)
        Me.MPstan.Name = "MPstan"
        Me.MPstan.Size = New System.Drawing.Size(64, 23)
        Me.MPstan.TabIndex = 51
        Me.MPstan.Text = "Edytuj"
        Me.MPstan.UseVisualStyleBackColor = True
        '
        'FMPR_uwagi
        '
        Me.FMPR_uwagi.Location = New System.Drawing.Point(840, 6)
        Me.FMPR_uwagi.Name = "FMPR_uwagi"
        Me.FMPR_uwagi.Size = New System.Drawing.Size(194, 20)
        Me.FMPR_uwagi.TabIndex = 50
        Me.FMPR_uwagi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FMPR_lotto_prod
        '
        Me.FMPR_lotto_prod.Location = New System.Drawing.Point(700, 6)
        Me.FMPR_lotto_prod.MaxLength = 8
        Me.FMPR_lotto_prod.Name = "FMPR_lotto_prod"
        Me.FMPR_lotto_prod.Size = New System.Drawing.Size(64, 20)
        Me.FMPR_lotto_prod.TabIndex = 48
        Me.FMPR_lotto_prod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FMPR_lotto
        '
        Me.FMPR_lotto.Location = New System.Drawing.Point(770, 6)
        Me.FMPR_lotto.MaxLength = 9
        Me.FMPR_lotto.Name = "FMPR_lotto"
        Me.FMPR_lotto.Size = New System.Drawing.Size(64, 20)
        Me.FMPR_lotto.TabIndex = 49
        Me.FMPR_lotto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FMPR_ilosc
        '
        Me.FMPR_ilosc.Location = New System.Drawing.Point(630, 6)
        Me.FMPR_ilosc.Name = "FMPR_ilosc"
        Me.FMPR_ilosc.Size = New System.Drawing.Size(64, 20)
        Me.FMPR_ilosc.TabIndex = 47
        Me.FMPR_ilosc.Visible = False
        '
        'FMPR_regal
        '
        Me.FMPR_regal.Location = New System.Drawing.Point(580, 6)
        Me.FMPR_regal.MaxLength = 5
        Me.FMPR_regal.Name = "FMPR_regal"
        Me.FMPR_regal.Size = New System.Drawing.Size(44, 20)
        Me.FMPR_regal.TabIndex = 46
        Me.FMPR_regal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FMPR_opis
        '
        Me.FMPR_opis.Location = New System.Drawing.Point(310, 6)
        Me.FMPR_opis.Name = "FMPR_opis"
        Me.FMPR_opis.Size = New System.Drawing.Size(264, 20)
        Me.FMPR_opis.TabIndex = 45
        Me.FMPR_opis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FMPR_kod
        '
        Me.FMPR_kod.Location = New System.Drawing.Point(210, 6)
        Me.FMPR_kod.Name = "FMPR_kod"
        Me.FMPR_kod.Size = New System.Drawing.Size(94, 20)
        Me.FMPR_kod.TabIndex = 44
        Me.FMPR_kod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FMPR_akcja
        '
        Me.FMPR_akcja.Location = New System.Drawing.Point(110, 6)
        Me.FMPR_akcja.Name = "FMPR_akcja"
        Me.FMPR_akcja.Size = New System.Drawing.Size(94, 20)
        Me.FMPR_akcja.TabIndex = 43
        Me.FMPR_akcja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BT_x4
        '
        Me.BT_x4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BT_x4.Location = New System.Drawing.Point(1110, 5)
        Me.BT_x4.Name = "BT_x4"
        Me.BT_x4.Size = New System.Drawing.Size(28, 23)
        Me.BT_x4.TabIndex = 52
        Me.BT_x4.Text = "X"
        Me.BT_x4.UseVisualStyleBackColor = True
        '
        'lblWidok_MPR
        '
        Me.lblWidok_MPR.AutoSize = True
        Me.lblWidok_MPR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblWidok_MPR.ForeColor = System.Drawing.Color.Red
        Me.lblWidok_MPR.Location = New System.Drawing.Point(1144, 10)
        Me.lblWidok_MPR.Name = "lblWidok_MPR"
        Me.lblWidok_MPR.Size = New System.Drawing.Size(68, 13)
        Me.lblWidok_MPR.TabIndex = 26
        Me.lblWidok_MPR.Text = "Filtrowanie"
        Me.lblWidok_MPR.Visible = False
        '
        'FMPR_data
        '
        Me.FMPR_data.Location = New System.Drawing.Point(6, 6)
        Me.FMPR_data.Name = "FMPR_data"
        Me.FMPR_data.Size = New System.Drawing.Size(98, 20)
        Me.FMPR_data.TabIndex = 42
        Me.FMPR_data.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MPRdgv
        '
        Me.MPRdgv.AllowUserToAddRows = False
        Me.MPRdgv.AllowUserToDeleteRows = False
        Me.MPRdgv.AllowUserToResizeColumns = False
        Me.MPRdgv.AllowUserToResizeRows = False
        Me.MPRdgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MPRdgv.AutoGenerateColumns = False
        Me.MPRdgv.BackgroundColor = System.Drawing.SystemColors.Window
        Me.MPRdgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MPRdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MPRdgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.MP_lotto_prod, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn21, Me.stan, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn37})
        Me.MPRdgv.DataSource = Me.MPruchyBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Khaki
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MPRdgv.DefaultCellStyle = DataGridViewCellStyle6
        Me.MPRdgv.Location = New System.Drawing.Point(6, 31)
        Me.MPRdgv.Name = "MPRdgv"
        Me.MPRdgv.ReadOnly = True
        Me.MPRdgv.RowHeadersVisible = False
        Me.MPRdgv.RowHeadersWidth = 51
        Me.MPRdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MPRdgv.Size = New System.Drawing.Size(1332, 572)
        Me.MPRdgv.TabIndex = 1
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Mg_ruchyID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Mg_ruchyID"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "data"
        Me.DataGridViewTextBoxColumn4.HeaderText = "data"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "akcja"
        Me.DataGridViewTextBoxColumn9.HeaderText = "akcja"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 125
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "KodMP"
        Me.DataGridViewTextBoxColumn10.HeaderText = "KodMP"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 125
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "opis_gal"
        Me.DataGridViewTextBoxColumn16.HeaderText = "opis_gal"
        Me.DataGridViewTextBoxColumn16.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Width = 125
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "regal"
        Me.DataGridViewTextBoxColumn17.HeaderText = "regal"
        Me.DataGridViewTextBoxColumn17.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Width = 125
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "ilosc"
        Me.DataGridViewTextBoxColumn18.HeaderText = "ilosc"
        Me.DataGridViewTextBoxColumn18.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Width = 125
        '
        'MP_lotto_prod
        '
        Me.MP_lotto_prod.DataPropertyName = "lotto_prod"
        Me.MP_lotto_prod.HeaderText = "lotto_prod"
        Me.MP_lotto_prod.MinimumWidth = 6
        Me.MP_lotto_prod.Name = "MP_lotto_prod"
        Me.MP_lotto_prod.ReadOnly = True
        Me.MP_lotto_prod.Width = 125
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "lotto"
        Me.DataGridViewTextBoxColumn19.HeaderText = "lotto"
        Me.DataGridViewTextBoxColumn19.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Width = 125
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "uwagi"
        Me.DataGridViewTextBoxColumn21.HeaderText = "uwagi"
        Me.DataGridViewTextBoxColumn21.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Width = 125
        '
        'stan
        '
        Me.stan.DataPropertyName = "stan"
        Me.stan.HeaderText = "stan"
        Me.stan.MinimumWidth = 6
        Me.stan.Name = "stan"
        Me.stan.ReadOnly = True
        Me.stan.Width = 125
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "uwagi_mod"
        Me.DataGridViewTextBoxColumn22.HeaderText = "uwagi_mod"
        Me.DataGridViewTextBoxColumn22.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Width = 125
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "nr_mod"
        Me.DataGridViewTextBoxColumn23.HeaderText = "nr_mod"
        Me.DataGridViewTextBoxColumn23.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Width = 125
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "MpID"
        Me.DataGridViewTextBoxColumn25.HeaderText = "MpID"
        Me.DataGridViewTextBoxColumn25.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        Me.DataGridViewTextBoxColumn25.Width = 125
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "uzytkownik"
        Me.DataGridViewTextBoxColumn37.HeaderText = "uzytkownik"
        Me.DataGridViewTextBoxColumn37.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        Me.DataGridViewTextBoxColumn37.ReadOnly = True
        Me.DataGridViewTextBoxColumn37.Width = 125
        '
        'MPruchyBindingSource
        '
        Me.MPruchyBindingSource.DataMember = "MP_ruchy"
        Me.MPruchyBindingSource.DataSource = Me.MagDbDataSet
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.FD_wymiar)
        Me.TabPage1.Controls.Add(Me.FD_data)
        Me.TabPage1.Controls.Add(Me.FD_uwagi)
        Me.TabPage1.Controls.Add(Me.FD_lotto_nat)
        Me.TabPage1.Controls.Add(Me.FD_lotto_prod)
        Me.TabPage1.Controls.Add(Me.FD_ilosc_pak)
        Me.TabPage1.Controls.Add(Me.FD_ilosc)
        Me.TabPage1.Controls.Add(Me.lblDostawy)
        Me.TabPage1.Controls.Add(Me.BT_x5)
        Me.TabPage1.Controls.Add(Me.FD_regal)
        Me.TabPage1.Controls.Add(Me.BT_DOS_dodaj)
        Me.TabPage1.Controls.Add(Me.FD_opis)
        Me.TabPage1.Controls.Add(Me.FD_kod)
        Me.TabPage1.Controls.Add(Me.DOSdgv)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabPage1.Size = New System.Drawing.Size(1344, 609)
        Me.TabPage1.TabIndex = 4
        Me.TabPage1.Text = "Dostawy"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'FD_wymiar
        '
        Me.FD_wymiar.Location = New System.Drawing.Point(580, 6)
        Me.FD_wymiar.MaxLength = 7
        Me.FD_wymiar.Name = "FD_wymiar"
        Me.FD_wymiar.Size = New System.Drawing.Size(69, 20)
        Me.FD_wymiar.TabIndex = 20
        Me.FD_wymiar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.FD_wymiar.Visible = False
        '
        'FD_data
        '
        Me.FD_data.Location = New System.Drawing.Point(1077, 6)
        Me.FD_data.Name = "FD_data"
        Me.FD_data.Size = New System.Drawing.Size(94, 20)
        Me.FD_data.TabIndex = 8
        Me.FD_data.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FD_uwagi
        '
        Me.FD_uwagi.Location = New System.Drawing.Point(795, 6)
        Me.FD_uwagi.Name = "FD_uwagi"
        Me.FD_uwagi.Size = New System.Drawing.Size(276, 20)
        Me.FD_uwagi.TabIndex = 7
        Me.FD_uwagi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FD_lotto_nat
        '
        Me.FD_lotto_nat.Location = New System.Drawing.Point(725, 6)
        Me.FD_lotto_nat.MaxLength = 9
        Me.FD_lotto_nat.Name = "FD_lotto_nat"
        Me.FD_lotto_nat.Size = New System.Drawing.Size(64, 20)
        Me.FD_lotto_nat.TabIndex = 6
        Me.FD_lotto_nat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FD_lotto_prod
        '
        Me.FD_lotto_prod.Location = New System.Drawing.Point(655, 6)
        Me.FD_lotto_prod.MaxLength = 8
        Me.FD_lotto_prod.Name = "FD_lotto_prod"
        Me.FD_lotto_prod.Size = New System.Drawing.Size(64, 20)
        Me.FD_lotto_prod.TabIndex = 5
        Me.FD_lotto_prod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FD_ilosc_pak
        '
        Me.FD_ilosc_pak.Location = New System.Drawing.Point(480, 6)
        Me.FD_ilosc_pak.MaxLength = 15
        Me.FD_ilosc_pak.Name = "FD_ilosc_pak"
        Me.FD_ilosc_pak.Size = New System.Drawing.Size(94, 20)
        Me.FD_ilosc_pak.TabIndex = 4
        Me.FD_ilosc_pak.Visible = False
        '
        'FD_ilosc
        '
        Me.FD_ilosc.Location = New System.Drawing.Point(420, 6)
        Me.FD_ilosc.MaxLength = 7
        Me.FD_ilosc.Name = "FD_ilosc"
        Me.FD_ilosc.Size = New System.Drawing.Size(54, 20)
        Me.FD_ilosc.TabIndex = 3
        Me.FD_ilosc.Visible = False
        '
        'lblDostawy
        '
        Me.lblDostawy.AutoSize = True
        Me.lblDostawy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblDostawy.ForeColor = System.Drawing.Color.Red
        Me.lblDostawy.Location = New System.Drawing.Point(1211, 9)
        Me.lblDostawy.Name = "lblDostawy"
        Me.lblDostawy.Size = New System.Drawing.Size(68, 13)
        Me.lblDostawy.TabIndex = 19
        Me.lblDostawy.Text = "Filtrowanie"
        Me.lblDostawy.Visible = False
        '
        'BT_x5
        '
        Me.BT_x5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BT_x5.Location = New System.Drawing.Point(1177, 4)
        Me.BT_x5.Name = "BT_x5"
        Me.BT_x5.Size = New System.Drawing.Size(28, 23)
        Me.BT_x5.TabIndex = 19
        Me.BT_x5.Text = "X"
        Me.BT_x5.UseVisualStyleBackColor = True
        '
        'FD_regal
        '
        Me.FD_regal.Location = New System.Drawing.Point(370, 6)
        Me.FD_regal.MaxLength = 5
        Me.FD_regal.Name = "FD_regal"
        Me.FD_regal.Size = New System.Drawing.Size(44, 20)
        Me.FD_regal.TabIndex = 2
        Me.FD_regal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BT_DOS_dodaj
        '
        Me.BT_DOS_dodaj.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BT_DOS_dodaj.BackColor = System.Drawing.Color.Transparent
        Me.BT_DOS_dodaj.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BT_DOS_dodaj.ForeColor = System.Drawing.Color.DimGray
        Me.BT_DOS_dodaj.Location = New System.Drawing.Point(6, 555)
        Me.BT_DOS_dodaj.Name = "BT_DOS_dodaj"
        Me.BT_DOS_dodaj.Size = New System.Drawing.Size(164, 48)
        Me.BT_DOS_dodaj.TabIndex = 12
        Me.BT_DOS_dodaj.Text = "Dodaj"
        Me.BT_DOS_dodaj.UseVisualStyleBackColor = False
        '
        'FD_opis
        '
        Me.FD_opis.Location = New System.Drawing.Point(100, 6)
        Me.FD_opis.Name = "FD_opis"
        Me.FD_opis.Size = New System.Drawing.Size(264, 20)
        Me.FD_opis.TabIndex = 1
        Me.FD_opis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FD_kod
        '
        Me.FD_kod.Location = New System.Drawing.Point(6, 6)
        Me.FD_kod.Name = "FD_kod"
        Me.FD_kod.Size = New System.Drawing.Size(88, 20)
        Me.FD_kod.TabIndex = 0
        Me.FD_kod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DOSdgv
        '
        Me.DOSdgv.AllowUserToAddRows = False
        Me.DOSdgv.AllowUserToDeleteRows = False
        Me.DOSdgv.AllowUserToResizeColumns = False
        Me.DOSdgv.AllowUserToResizeRows = False
        Me.DOSdgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DOSdgv.AutoGenerateColumns = False
        Me.DOSdgv.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DOSdgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DOSdgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DOSdgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DOSdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DOSdgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.ilosc_pak, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35})
        Me.DOSdgv.DataSource = Me.DOSTAWYBindingSource
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.MenuText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DOSdgv.DefaultCellStyle = DataGridViewCellStyle8
        Me.DOSdgv.Location = New System.Drawing.Point(6, 31)
        Me.DOSdgv.Name = "DOSdgv"
        Me.DOSdgv.ReadOnly = True
        Me.DOSdgv.RowHeadersVisible = False
        Me.DOSdgv.RowHeadersWidth = 51
        Me.DOSdgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DOSdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DOSdgv.Size = New System.Drawing.Size(1332, 518)
        Me.DOSdgv.TabIndex = 9
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 6
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 125
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "KodZP"
        Me.DataGridViewTextBoxColumn26.HeaderText = "KodZP"
        Me.DataGridViewTextBoxColumn26.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        Me.DataGridViewTextBoxColumn26.Width = 125
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "opis"
        Me.DataGridViewTextBoxColumn27.HeaderText = "opis"
        Me.DataGridViewTextBoxColumn27.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        Me.DataGridViewTextBoxColumn27.Width = 125
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "regal"
        Me.DataGridViewTextBoxColumn28.HeaderText = "regal"
        Me.DataGridViewTextBoxColumn28.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        Me.DataGridViewTextBoxColumn28.Width = 125
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "ilosc"
        Me.DataGridViewTextBoxColumn29.HeaderText = "ilosc"
        Me.DataGridViewTextBoxColumn29.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        Me.DataGridViewTextBoxColumn29.Width = 125
        '
        'ilosc_pak
        '
        Me.ilosc_pak.DataPropertyName = "ilosc_pak"
        Me.ilosc_pak.HeaderText = "ilosc_pak"
        Me.ilosc_pak.MinimumWidth = 6
        Me.ilosc_pak.Name = "ilosc_pak"
        Me.ilosc_pak.ReadOnly = True
        Me.ilosc_pak.Width = 125
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "wymiar"
        Me.DataGridViewTextBoxColumn31.HeaderText = "wymiar"
        Me.DataGridViewTextBoxColumn31.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.ReadOnly = True
        Me.DataGridViewTextBoxColumn31.Width = 125
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "lotto_prod"
        Me.DataGridViewTextBoxColumn32.HeaderText = "lotto_prod"
        Me.DataGridViewTextBoxColumn32.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.ReadOnly = True
        Me.DataGridViewTextBoxColumn32.Width = 125
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "lotto_nat"
        Me.DataGridViewTextBoxColumn33.HeaderText = "lotto_nat"
        Me.DataGridViewTextBoxColumn33.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.ReadOnly = True
        Me.DataGridViewTextBoxColumn33.Width = 125
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "uwagi"
        Me.DataGridViewTextBoxColumn34.HeaderText = "uwagi"
        Me.DataGridViewTextBoxColumn34.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.ReadOnly = True
        Me.DataGridViewTextBoxColumn34.Width = 125
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "data_dodania"
        Me.DataGridViewTextBoxColumn35.HeaderText = "data_dodania"
        Me.DataGridViewTextBoxColumn35.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        Me.DataGridViewTextBoxColumn35.ReadOnly = True
        Me.DataGridViewTextBoxColumn35.Width = 125
        '
        'DOSTAWYBindingSource
        '
        Me.DOSTAWYBindingSource.DataMember = "DOSTAWY"
        Me.DOSTAWYBindingSource.DataSource = Me.MagDbDataSet
        '
        'Menu_rozwijane
        '
        Me.Menu_rozwijane.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Menu_rozwijane.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZmieńToolStripMenuItem, Me.ToolStripSeparator4, Me.PobierzToolStripMenuItem, Me.PobierzPaletęToolStripMenuItem, Me.DołóżToolStripMenuItem, Me.ToolStripSeparator1, Me.PrzenieśToolStripMenuItem, Me.PrzenieśRegałToolStripMenuItem, Me.ToolStripSeparator2, Me.InwentaryzacjaToolStripMenuItem, Me.ToolStripSeparator3, Me.FiltrujToolStripMenuItem, Me.ZobaczRuchyToolStripMenuItem})
        Me.Menu_rozwijane.Name = "Menu_rozwijane"
        Me.Menu_rozwijane.Size = New System.Drawing.Size(153, 226)
        '
        'ZmieńToolStripMenuItem
        '
        Me.ZmieńToolStripMenuItem.Name = "ZmieńToolStripMenuItem"
        Me.ZmieńToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ZmieńToolStripMenuItem.Text = "Edytuj"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(149, 6)
        '
        'PobierzToolStripMenuItem
        '
        Me.PobierzToolStripMenuItem.Name = "PobierzToolStripMenuItem"
        Me.PobierzToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PobierzToolStripMenuItem.Text = "Pobierz"
        '
        'PobierzPaletęToolStripMenuItem
        '
        Me.PobierzPaletęToolStripMenuItem.Name = "PobierzPaletęToolStripMenuItem"
        Me.PobierzPaletęToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PobierzPaletęToolStripMenuItem.Text = "Pobierz paletę"
        '
        'DołóżToolStripMenuItem
        '
        Me.DołóżToolStripMenuItem.Name = "DołóżToolStripMenuItem"
        Me.DołóżToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DołóżToolStripMenuItem.Text = "Dołóż"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'PrzenieśToolStripMenuItem
        '
        Me.PrzenieśToolStripMenuItem.Name = "PrzenieśToolStripMenuItem"
        Me.PrzenieśToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PrzenieśToolStripMenuItem.Text = "Przenieś"
        '
        'PrzenieśRegałToolStripMenuItem
        '
        Me.PrzenieśRegałToolStripMenuItem.Name = "PrzenieśRegałToolStripMenuItem"
        Me.PrzenieśRegałToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PrzenieśRegałToolStripMenuItem.Text = "Przenieś regał"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'InwentaryzacjaToolStripMenuItem
        '
        Me.InwentaryzacjaToolStripMenuItem.Name = "InwentaryzacjaToolStripMenuItem"
        Me.InwentaryzacjaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.InwentaryzacjaToolStripMenuItem.Text = "Inwentaryzacja"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(149, 6)
        '
        'FiltrujToolStripMenuItem
        '
        Me.FiltrujToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PoKodzieToolStripMenuItem, Me.PoRegaleToolStripMenuItem, Me.PoLottoProdToolStripMenuItem, Me.PoLottoNatToolStripMenuItem})
        Me.FiltrujToolStripMenuItem.Name = "FiltrujToolStripMenuItem"
        Me.FiltrujToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FiltrujToolStripMenuItem.Text = "Filtruj"
        '
        'PoKodzieToolStripMenuItem
        '
        Me.PoKodzieToolStripMenuItem.Name = "PoKodzieToolStripMenuItem"
        Me.PoKodzieToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.PoKodzieToolStripMenuItem.Text = "Po kodzie"
        '
        'PoRegaleToolStripMenuItem
        '
        Me.PoRegaleToolStripMenuItem.Name = "PoRegaleToolStripMenuItem"
        Me.PoRegaleToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.PoRegaleToolStripMenuItem.Text = "Po regale"
        '
        'PoLottoProdToolStripMenuItem
        '
        Me.PoLottoProdToolStripMenuItem.Name = "PoLottoProdToolStripMenuItem"
        Me.PoLottoProdToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.PoLottoProdToolStripMenuItem.Text = "Po lotto prod"
        Me.PoLottoProdToolStripMenuItem.Visible = False
        '
        'PoLottoNatToolStripMenuItem
        '
        Me.PoLottoNatToolStripMenuItem.Name = "PoLottoNatToolStripMenuItem"
        Me.PoLottoNatToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.PoLottoNatToolStripMenuItem.Text = "Po lotto nat"
        Me.PoLottoNatToolStripMenuItem.Visible = False
        '
        'ZobaczRuchyToolStripMenuItem
        '
        Me.ZobaczRuchyToolStripMenuItem.Name = "ZobaczRuchyToolStripMenuItem"
        Me.ZobaczRuchyToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ZobaczRuchyToolStripMenuItem.Text = "Pokaż ruchy"
        '
        'MP_menu_rozwijane
        '
        Me.MP_menu_rozwijane.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MP_menu_rozwijane.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSM_MP_edytuj, Me.ToolStripSeparator5, Me.TSM_MP_pobierz, Me.TSM_MP_doloz, Me.ToolStripSeparator6, Me.TSM_MP_przenies, Me.ToolStripSeparator7, Me.TSM_MP_inwentaryzacja, Me.ToolStripSeparator8, Me.ToolStripMenuItem6, Me.TSM_MP_zobacz_ruchy})
        Me.MP_menu_rozwijane.Name = "Menu_rozwijane"
        Me.MP_menu_rozwijane.Size = New System.Drawing.Size(153, 182)
        '
        'TSM_MP_edytuj
        '
        Me.TSM_MP_edytuj.Name = "TSM_MP_edytuj"
        Me.TSM_MP_edytuj.Size = New System.Drawing.Size(152, 22)
        Me.TSM_MP_edytuj.Text = "Edytuj"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(149, 6)
        '
        'TSM_MP_pobierz
        '
        Me.TSM_MP_pobierz.Name = "TSM_MP_pobierz"
        Me.TSM_MP_pobierz.Size = New System.Drawing.Size(152, 22)
        Me.TSM_MP_pobierz.Text = "Pobierz"
        '
        'TSM_MP_doloz
        '
        Me.TSM_MP_doloz.Name = "TSM_MP_doloz"
        Me.TSM_MP_doloz.Size = New System.Drawing.Size(152, 22)
        Me.TSM_MP_doloz.Text = "Dołóż"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(149, 6)
        '
        'TSM_MP_przenies
        '
        Me.TSM_MP_przenies.Name = "TSM_MP_przenies"
        Me.TSM_MP_przenies.Size = New System.Drawing.Size(152, 22)
        Me.TSM_MP_przenies.Text = "Przenieś"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(149, 6)
        '
        'TSM_MP_inwentaryzacja
        '
        Me.TSM_MP_inwentaryzacja.Name = "TSM_MP_inwentaryzacja"
        Me.TSM_MP_inwentaryzacja.Size = New System.Drawing.Size(152, 22)
        Me.TSM_MP_inwentaryzacja.Text = "Inwentaryzacja"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(149, 6)
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MP_PoKodzie, Me.MP_PoRegale, Me.MP_PoLotto})
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem6.Text = "Filtruj"
        '
        'MP_PoKodzie
        '
        Me.MP_PoKodzie.Name = "MP_PoKodzie"
        Me.MP_PoKodzie.Size = New System.Drawing.Size(125, 22)
        Me.MP_PoKodzie.Text = "Po kodzie"
        '
        'MP_PoRegale
        '
        Me.MP_PoRegale.Name = "MP_PoRegale"
        Me.MP_PoRegale.Size = New System.Drawing.Size(125, 22)
        Me.MP_PoRegale.Text = "Po regale"
        '
        'MP_PoLotto
        '
        Me.MP_PoLotto.Name = "MP_PoLotto"
        Me.MP_PoLotto.Size = New System.Drawing.Size(125, 22)
        Me.MP_PoLotto.Text = "Po lotto"
        Me.MP_PoLotto.Visible = False
        '
        'TSM_MP_zobacz_ruchy
        '
        Me.TSM_MP_zobacz_ruchy.Name = "TSM_MP_zobacz_ruchy"
        Me.TSM_MP_zobacz_ruchy.Size = New System.Drawing.Size(152, 22)
        Me.TSM_MP_zobacz_ruchy.Text = "Pokaż ruchy"
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'DOSTAWY_menu_rozwijane
        '
        Me.DOSTAWY_menu_rozwijane.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.DOSTAWY_menu_rozwijane.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSM_DOS_edytuj, Me.ToolStripSeparator11, Me.TSM_DOS_przenies, Me.WyślijToolStripMenuItem, Me.TSM_DOS_usun, Me.ToolStripSeparator10, Me.FiltrujToolStripMenuItem1})
        Me.DOSTAWY_menu_rozwijane.Name = "Menu_rozwijane"
        Me.DOSTAWY_menu_rozwijane.Size = New System.Drawing.Size(118, 126)
        '
        'TSM_DOS_edytuj
        '
        Me.TSM_DOS_edytuj.Name = "TSM_DOS_edytuj"
        Me.TSM_DOS_edytuj.Size = New System.Drawing.Size(117, 22)
        Me.TSM_DOS_edytuj.Text = "Edytuj"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(114, 6)
        '
        'TSM_DOS_przenies
        '
        Me.TSM_DOS_przenies.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSM_DOS_przenies_MG, Me.TSM_DOS_przenies_MP})
        Me.TSM_DOS_przenies.Name = "TSM_DOS_przenies"
        Me.TSM_DOS_przenies.Size = New System.Drawing.Size(117, 22)
        Me.TSM_DOS_przenies.Text = "Przenieś"
        '
        'TSM_DOS_przenies_MG
        '
        Me.TSM_DOS_przenies_MG.Name = "TSM_DOS_przenies_MG"
        Me.TSM_DOS_przenies_MG.Size = New System.Drawing.Size(164, 22)
        Me.TSM_DOS_przenies_MG.Text = "Magazyn główny"
        '
        'TSM_DOS_przenies_MP
        '
        Me.TSM_DOS_przenies_MP.Name = "TSM_DOS_przenies_MP"
        Me.TSM_DOS_przenies_MP.Size = New System.Drawing.Size(164, 22)
        Me.TSM_DOS_przenies_MP.Text = "Magazyn prętów"
        '
        'WyślijToolStripMenuItem
        '
        Me.WyślijToolStripMenuItem.Name = "WyślijToolStripMenuItem"
        Me.WyślijToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.WyślijToolStripMenuItem.Text = "Wyślij"
        '
        'TSM_DOS_usun
        '
        Me.TSM_DOS_usun.Name = "TSM_DOS_usun"
        Me.TSM_DOS_usun.Size = New System.Drawing.Size(117, 22)
        Me.TSM_DOS_usun.Text = "Usuń"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(114, 6)
        '
        'FiltrujToolStripMenuItem1
        '
        Me.FiltrujToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSM_DOS_filtruj_po_kodzie, Me.TSM_DOS_filtruj_po_regale})
        Me.FiltrujToolStripMenuItem1.Name = "FiltrujToolStripMenuItem1"
        Me.FiltrujToolStripMenuItem1.Size = New System.Drawing.Size(117, 22)
        Me.FiltrujToolStripMenuItem1.Text = "Filtruj"
        '
        'TSM_DOS_filtruj_po_kodzie
        '
        Me.TSM_DOS_filtruj_po_kodzie.Name = "TSM_DOS_filtruj_po_kodzie"
        Me.TSM_DOS_filtruj_po_kodzie.Size = New System.Drawing.Size(125, 22)
        Me.TSM_DOS_filtruj_po_kodzie.Text = "Po kodzie"
        '
        'TSM_DOS_filtruj_po_regale
        '
        Me.TSM_DOS_filtruj_po_regale.Name = "TSM_DOS_filtruj_po_regale"
        Me.TSM_DOS_filtruj_po_regale.Size = New System.Drawing.Size(125, 22)
        Me.TSM_DOS_filtruj_po_regale.Text = "Po regale"
        '
        'Process1
        '
        Me.Process1.StartInfo.Domain = ""
        Me.Process1.StartInfo.LoadUserProfile = False
        Me.Process1.StartInfo.Password = Nothing
        Me.Process1.StartInfo.StandardErrorEncoding = Nothing
        Me.Process1.StartInfo.StandardOutputEncoding = Nothing
        Me.Process1.StartInfo.UserName = ""
        Me.Process1.SynchronizingObject = Me
        '
        'MGR_MenuStrip
        '
        Me.MGR_MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MGR_MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FiltrujToolStripMenuItem2, Me.ToolStripSeparator12, Me.PokażRuchyToolStripMenuItem, Me.PokażWMagazynieToolStripMenuItem})
        Me.MGR_MenuStrip.Name = "MGR_MenuStrip"
        Me.MGR_MenuStrip.Size = New System.Drawing.Size(178, 76)
        '
        'FiltrujToolStripMenuItem2
        '
        Me.FiltrujToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PoKodzieToolStripMenuItem1, Me.PoRegaleToolStripMenuItem1, Me.PoLottoProdToolStripMenuItem1, Me.PoLottoNatToolStripMenuItem1})
        Me.FiltrujToolStripMenuItem2.Name = "FiltrujToolStripMenuItem2"
        Me.FiltrujToolStripMenuItem2.Size = New System.Drawing.Size(177, 22)
        Me.FiltrujToolStripMenuItem2.Text = "Filtruj"
        '
        'PoKodzieToolStripMenuItem1
        '
        Me.PoKodzieToolStripMenuItem1.Name = "PoKodzieToolStripMenuItem1"
        Me.PoKodzieToolStripMenuItem1.Size = New System.Drawing.Size(144, 22)
        Me.PoKodzieToolStripMenuItem1.Text = "Po kodzie"
        '
        'PoRegaleToolStripMenuItem1
        '
        Me.PoRegaleToolStripMenuItem1.Name = "PoRegaleToolStripMenuItem1"
        Me.PoRegaleToolStripMenuItem1.Size = New System.Drawing.Size(144, 22)
        Me.PoRegaleToolStripMenuItem1.Text = "Po regale"
        '
        'PoLottoProdToolStripMenuItem1
        '
        Me.PoLottoProdToolStripMenuItem1.Name = "PoLottoProdToolStripMenuItem1"
        Me.PoLottoProdToolStripMenuItem1.Size = New System.Drawing.Size(144, 22)
        Me.PoLottoProdToolStripMenuItem1.Text = "Po lotto prod"
        '
        'PoLottoNatToolStripMenuItem1
        '
        Me.PoLottoNatToolStripMenuItem1.Name = "PoLottoNatToolStripMenuItem1"
        Me.PoLottoNatToolStripMenuItem1.Size = New System.Drawing.Size(144, 22)
        Me.PoLottoNatToolStripMenuItem1.Text = "Po lotto nat"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(174, 6)
        '
        'PokażRuchyToolStripMenuItem
        '
        Me.PokażRuchyToolStripMenuItem.Name = "PokażRuchyToolStripMenuItem"
        Me.PokażRuchyToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.PokażRuchyToolStripMenuItem.Text = "Pokaż ruchy"
        '
        'PokażWMagazynieToolStripMenuItem
        '
        Me.PokażWMagazynieToolStripMenuItem.Name = "PokażWMagazynieToolStripMenuItem"
        Me.PokażWMagazynieToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.PokażWMagazynieToolStripMenuItem.Text = "Pokaż w magazynie"
        '
        'MPR_MenuStrip
        '
        Me.MPR_MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MPR_MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripSeparator13, Me.PokażRuchyToolStripMenuItem1, Me.PokażWMagazynieToolStripMenuItem1})
        Me.MPR_MenuStrip.Name = "MGR_MenuStrip"
        Me.MPR_MenuStrip.Size = New System.Drawing.Size(178, 76)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PoKodzieToolStripMenuItem2, Me.PoRegaleToolStripMenuItem2, Me.PoLottoProdToolStripMenuItem2, Me.PoLottoNatToolStripMenuItem2})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(177, 22)
        Me.ToolStripMenuItem1.Text = "Filtruj"
        '
        'PoKodzieToolStripMenuItem2
        '
        Me.PoKodzieToolStripMenuItem2.Name = "PoKodzieToolStripMenuItem2"
        Me.PoKodzieToolStripMenuItem2.Size = New System.Drawing.Size(144, 22)
        Me.PoKodzieToolStripMenuItem2.Text = "Po kodzie"
        '
        'PoRegaleToolStripMenuItem2
        '
        Me.PoRegaleToolStripMenuItem2.Name = "PoRegaleToolStripMenuItem2"
        Me.PoRegaleToolStripMenuItem2.Size = New System.Drawing.Size(144, 22)
        Me.PoRegaleToolStripMenuItem2.Text = "Po regale"
        '
        'PoLottoProdToolStripMenuItem2
        '
        Me.PoLottoProdToolStripMenuItem2.Name = "PoLottoProdToolStripMenuItem2"
        Me.PoLottoProdToolStripMenuItem2.Size = New System.Drawing.Size(144, 22)
        Me.PoLottoProdToolStripMenuItem2.Text = "Po lotto prod"
        Me.PoLottoProdToolStripMenuItem2.Visible = False
        '
        'PoLottoNatToolStripMenuItem2
        '
        Me.PoLottoNatToolStripMenuItem2.Name = "PoLottoNatToolStripMenuItem2"
        Me.PoLottoNatToolStripMenuItem2.Size = New System.Drawing.Size(144, 22)
        Me.PoLottoNatToolStripMenuItem2.Text = "Po lotto nat"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(174, 6)
        '
        'PokażRuchyToolStripMenuItem1
        '
        Me.PokażRuchyToolStripMenuItem1.Name = "PokażRuchyToolStripMenuItem1"
        Me.PokażRuchyToolStripMenuItem1.Size = New System.Drawing.Size(177, 22)
        Me.PokażRuchyToolStripMenuItem1.Text = "Pokaż ruchy"
        '
        'PokażWMagazynieToolStripMenuItem1
        '
        Me.PokażWMagazynieToolStripMenuItem1.Name = "PokażWMagazynieToolStripMenuItem1"
        Me.PokażWMagazynieToolStripMenuItem1.Size = New System.Drawing.Size(177, 22)
        Me.PokażWMagazynieToolStripMenuItem1.Text = "Pokaż w magazynie"
        '
        'MGTableAdapter
        '
        Me.MGTableAdapter.ClearBeforeFill = True
        '
        'MG_ruchyTableAdapter
        '
        Me.MG_ruchyTableAdapter.ClearBeforeFill = True
        '
        'MPTableAdapter
        '
        Me.MPTableAdapter.ClearBeforeFill = True
        '
        'MP_ruchyTableAdapter
        '
        Me.MP_ruchyTableAdapter.ClearBeforeFill = True
        '
        'DOSTAWYTableAdapter
        '
        Me.DOSTAWYTableAdapter.ClearBeforeFill = True
        '
        'Magazyn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1376, 687)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.label_user)
        Me.Controls.Add(Me.Wyloguj)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.PasekZadan)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Magazyn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Magazyn Zannini Poland"
        Me.PasekZadan.ResumeLayout(False)
        Me.PasekZadan.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.TabControl.ResumeLayout(False)
        Me.TabMG.ResumeLayout(False)
        Me.TabMG.PerformLayout()
        CType(Me.MGdgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MGBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MagDbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabMP.ResumeLayout(False)
        Me.TabMP.PerformLayout()
        CType(Me.MPdgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabMGR.ResumeLayout(False)
        Me.TabMGR.PerformLayout()
        CType(Me.MGRdgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MGruchyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabMPR.ResumeLayout(False)
        Me.TabMPR.PerformLayout()
        CType(Me.MPRdgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MPruchyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DOSdgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DOSTAWYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Menu_rozwijane.ResumeLayout(False)
        Me.MP_menu_rozwijane.ResumeLayout(False)
        Me.DOSTAWY_menu_rozwijane.ResumeLayout(False)
        Me.MGR_MenuStrip.ResumeLayout(False)
        Me.MPR_MenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PasekZadan As MenuStrip
    Friend WithEvents ExportujDoExcelaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OProgramieToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UżytkownicyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DbClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents LblStatus As ToolStripStatusLabel
    Friend WithEvents label_user As Label
    Friend WithEvents Wyloguj As Button
    Friend WithEvents TabControl As TabControl
    Friend WithEvents TabMG As TabPage
    Friend WithEvents TabMP As TabPage
    Friend WithEvents TabMGR As TabPage
    Friend WithEvents TabMPR As TabPage
    Friend WithEvents MGdgv As DataGridView
    Friend WithEvents BT_dodaj As Button
    Friend WithEvents BT_pobierz_pal As Button
    Friend WithEvents BT_inwentaryzacja As Button
    Friend WithEvents BT_pobierz As Button
    Friend WithEvents BT_przenies As Button
    Friend WithEvents MagDbDataSet As MagDbDataSet
    Friend WithEvents MGTableAdapter As MagDbDataSetTableAdapters.MGTableAdapter
    Friend WithEvents IloscgalileoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MGRdgv As DataGridView
    Friend WithEvents MGruchyBindingSource As BindingSource
    Friend WithEvents MG_ruchyTableAdapter As MagDbDataSetTableAdapters.MG_ruchyTableAdapter
    Friend WithEvents RuchDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents MGBindingSource As BindingSource
    Friend WithEvents Menu_rozwijane As ContextMenuStrip
    Friend WithEvents PrzenieśToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents PobierzToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents InwentaryzacjaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents FiltrujToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PoKodzieToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PoRegaleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents F_regal As TextBox
    Friend WithEvents F_opis As TextBox
    Friend WithEvents F_Kod As TextBox
    Friend WithEvents F_ilosc As TextBox
    Friend WithEvents F_galileo As TextBox
    Friend WithEvents F_lotto_nat As TextBox
    Friend WithEvents F_lotto_prod As TextBox
    Friend WithEvents F_uwagi As TextBox
    Friend WithEvents F_data_dodania As TextBox
    Friend WithEvents UzytkownikDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BT_x As Button
    Friend WithEvents PobierzPaletęToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblwidok As Label
    Friend WithEvents ZmieńToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents PoLottoProdToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PoLottoNatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZobaczRuchyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents FR_data As TextBox
    Friend WithEvents FR_kod As TextBox
    Friend WithEvents FR_akcja As TextBox
    Friend WithEvents FR_opis As TextBox
    Friend WithEvents FR_regal As TextBox
    Friend WithEvents FR_uwagi As TextBox
    Friend WithEvents FR_lotto_nat As TextBox
    Friend WithEvents FR_lotto_prod As TextBox
    Friend WithEvents FR_ilosc As TextBox
    Friend WithEvents lblWidokRuchy As Label
    Friend WithEvents BT_x2 As Button
    Friend WithEvents MPdgv As DataGridView
    Friend WithEvents MPBindingSource As BindingSource
    Friend WithEvents MPTableAdapter As MagDbDataSetTableAdapters.MPTableAdapter
    Friend WithEvents BT_MP_dodaj As Button
    Friend WithEvents FMP_kod As TextBox
    Friend WithEvents MPRdgv As DataGridView
    Friend WithEvents MPruchyBindingSource As BindingSource
    Friend WithEvents MP_ruchyTableAdapter As MagDbDataSetTableAdapters.MP_ruchyTableAdapter
    Friend WithEvents FMPR_data As TextBox
    Friend WithEvents MP_menu_rozwijane As ContextMenuStrip
    Friend WithEvents TSM_MP_edytuj As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents TSM_MP_pobierz As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents TSM_MP_przenies As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents TSM_MP_inwentaryzacja As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents MP_PoKodzie As ToolStripMenuItem
    Friend WithEvents MP_PoRegale As ToolStripMenuItem
    Friend WithEvents MP_PoLotto As ToolStripMenuItem
    Friend WithEvents TSM_MP_zobacz_ruchy As ToolStripMenuItem
    Friend WithEvents BT_x3 As Button
    Friend WithEvents lblWidok_MP As Label
    Friend WithEvents BT_x4 As Button
    Friend WithEvents lblWidok_MPR As Label
    Friend WithEvents FMPR_kod As TextBox
    Friend WithEvents FMPR_akcja As TextBox
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents BT_MP_przenies As Button
    Friend WithEvents BT_MP_inwentaryzacja As Button
    Friend WithEvents BT_MP_pobierz As Button
    Friend WithEvents FMP_uwagi As TextBox
    Friend WithEvents FMP_lotto As TextBox
    Friend WithEvents FMP_galileo As TextBox
    Friend WithEvents FMP_ilosc As TextBox
    Friend WithEvents FMP_regal As TextBox
    Friend WithEvents FMP_opis As TextBox
    Friend WithEvents FMP_wymiar As TextBox
    Friend WithEvents FMP_przekroj As TextBox
    Friend WithEvents FMP_material As TextBox
    Friend WithEvents FMP_data_dodania As TextBox
    Friend WithEvents MaterialyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer As Timer
    Friend WithEvents FMPR_uwagi As TextBox
    Friend WithEvents FMPR_lotto As TextBox
    Friend WithEvents FMPR_ilosc As TextBox
    Friend WithEvents FMPR_regal As TextBox
    Friend WithEvents FMPR_opis As TextBox
    Friend WithEvents OdświeżToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GalileoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZCPQV As ToolStripMenuItem
    Friend WithEvents KodyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LottoProdukcyjneToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LottoNatychmiastoweToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PobierzStanyMagazynoweToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents BT_DOS_dodaj As Button
    Friend WithEvents FD_opis As TextBox
    Friend WithEvents FD_kod As TextBox
    Friend WithEvents DOSdgv As DataGridView
    Friend WithEvents DOSTAWYBindingSource As BindingSource
    Friend WithEvents DOSTAWYTableAdapter As MagDbDataSetTableAdapters.DOSTAWYTableAdapter
    Friend WithEvents DOSTAWY_menu_rozwijane As ContextMenuStrip
    Friend WithEvents TSM_DOS_edytuj As ToolStripMenuItem
    Friend WithEvents TSM_DOS_usun As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents TSM_DOS_przenies As ToolStripMenuItem
    Friend WithEvents TSM_DOS_przenies_MG As ToolStripMenuItem
    Friend WithEvents TSM_DOS_przenies_MP As ToolStripMenuItem
    Friend WithEvents FiltrujToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TSM_DOS_filtruj_po_kodzie As ToolStripMenuItem
    Friend WithEvents TSM_DOS_filtruj_po_regale As ToolStripMenuItem
    Friend WithEvents FD_regal As TextBox
    Friend WithEvents lblDostawy As Label
    Friend WithEvents BT_x5 As Button
    Friend WithEvents FD_ilosc_pak As TextBox
    Friend WithEvents FD_ilosc As TextBox
    Friend WithEvents FD_data As TextBox
    Friend WithEvents FD_uwagi As TextBox
    Friend WithEvents FD_lotto_nat As TextBox
    Friend WithEvents FD_lotto_prod As TextBox
    Friend WithEvents F_formula As TextBox
    Friend WithEvents DołóżToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BT_doloz As Button
    Friend WithEvents BT_MP_doloz As Button
    Friend WithEvents TSM_MP_doloz As ToolStripMenuItem
    Friend WithEvents WyślijToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents Process1 As Process
    Friend WithEvents BackupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrzenieśRegałToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BT_przenies_regal As Button
    Friend WithEvents FMPR_lotto_prod As TextBox
    Friend WithEvents MGR_MenuStrip As ContextMenuStrip
    Friend WithEvents FiltrujToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents PoKodzieToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PoRegaleToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PoLottoProdToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PoLottoNatToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PokażWMagazynieToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Friend WithEvents PokażRuchyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MPR_MenuStrip As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator13 As ToolStripSeparator
    Friend WithEvents PoKodzieToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents PoRegaleToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents PoLottoProdToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents PoLottoNatToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents PokażRuchyToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PokażWMagazynieToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PobraniaMateriałówToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FD_wymiar As TextBox
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents ilosc_pak As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As DataGridViewTextBoxColumn
    Friend WithEvents MpID As DataGridViewTextBoxColumn
    Friend WithEvents KodMP As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents lotto As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents Material As DataGridViewTextBoxColumn
    Friend WithEvents Przekroj As DataGridViewTextBoxColumn
    Friend WithEvents Wymiar As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As DataGridViewTextBoxColumn
    Friend WithEvents MgIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KodZPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OpisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RegalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents IloscDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents LottoprodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LottonatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UwagiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatadodaniaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatamodyfikacjiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LmodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MPstan As Button
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents MP_lotto_prod As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents stan As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As DataGridViewTextBoxColumn
    Friend WithEvents MGstan As Button
    Friend WithEvents MgruchyIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents akcja As DataGridViewTextBoxColumn
    Friend WithEvents KodZPDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents OpisgalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RegalDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ilosc As DataGridViewTextBoxColumn
    Friend WithEvents LottoprodDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents LottonatDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents UwagiDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents stanMG As DataGridViewTextBoxColumn
    Friend WithEvents uwagi_mod As DataGridViewTextBoxColumn
    Friend WithEvents NrmodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MgIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents uzytkownik As DataGridViewTextBoxColumn
End Class
