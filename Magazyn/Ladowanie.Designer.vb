<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ladowanie
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
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.lblGen = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(34, 35)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(206, 34)
        Me.ProgressBar.TabIndex = 0
        '
        'lblGen
        '
        Me.lblGen.AutoSize = True
        Me.lblGen.Location = New System.Drawing.Point(79, 16)
        Me.lblGen.Name = "lblGen"
        Me.lblGen.Size = New System.Drawing.Size(95, 13)
        Me.lblGen.TabIndex = 1
        Me.lblGen.Text = "Generowanie pliku"
        '
        'Ladowanie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(276, 101)
        Me.Controls.Add(Me.lblGen)
        Me.Controls.Add(Me.ProgressBar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ladowanie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ładowanie"
        Me.TopMost = True
        Me.UseWaitCursor = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents lblGen As Label
End Class
