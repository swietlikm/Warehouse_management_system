<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Logowanie
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Logowanie))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BT_podglad = New System.Windows.Forms.Button()
        Me.TB_haslo = New System.Windows.Forms.TextBox()
        Me.BT_edycja = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 29)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Magazyn Zannini Poland "
        '
        'BT_podglad
        '
        Me.BT_podglad.Location = New System.Drawing.Point(82, 127)
        Me.BT_podglad.Name = "BT_podglad"
        Me.BT_podglad.Size = New System.Drawing.Size(86, 22)
        Me.BT_podglad.TabIndex = 6
        Me.BT_podglad.Text = "Podgląd"
        Me.BT_podglad.UseVisualStyleBackColor = True
        '
        'TB_haslo
        '
        Me.TB_haslo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_haslo.Location = New System.Drawing.Point(82, 101)
        Me.TB_haslo.Name = "TB_haslo"
        Me.TB_haslo.Size = New System.Drawing.Size(176, 20)
        Me.TB_haslo.TabIndex = 5
        Me.TB_haslo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TB_haslo.UseSystemPasswordChar = True
        '
        'BT_edycja
        '
        Me.BT_edycja.Enabled = False
        Me.BT_edycja.Location = New System.Drawing.Point(174, 127)
        Me.BT_edycja.Name = "BT_edycja"
        Me.BT_edycja.Size = New System.Drawing.Size(84, 22)
        Me.BT_edycja.TabIndex = 4
        Me.BT_edycja.Text = "Edycja"
        Me.BT_edycja.UseVisualStyleBackColor = True
        '
        'Logowanie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 189)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BT_podglad)
        Me.Controls.Add(Me.TB_haslo)
        Me.Controls.Add(Me.BT_edycja)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(356, 275)
        Me.Name = "Logowanie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Magazyn - logowanie"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BT_podglad As Button
    Friend WithEvents TB_haslo As TextBox
    Friend WithEvents BT_edycja As Button
End Class
