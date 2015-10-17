<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Matriks_Calculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TextBoxMatriks1 = New System.Windows.Forms.TextBox()
        Me.TextBoxMatriks2 = New System.Windows.Forms.TextBox()
        Me.TextBoxHasil = New System.Windows.Forms.TextBox()
        Me.ComboBoxOperasi = New System.Windows.Forms.ComboBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Matriks1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonProses = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxMatriks1
        '
        Me.TextBoxMatriks1.Location = New System.Drawing.Point(92, 12)
        Me.TextBoxMatriks1.Multiline = True
        Me.TextBoxMatriks1.Name = "TextBoxMatriks1"
        Me.TextBoxMatriks1.Size = New System.Drawing.Size(337, 62)
        Me.TextBoxMatriks1.TabIndex = 0
        '
        'TextBoxMatriks2
        '
        Me.TextBoxMatriks2.Location = New System.Drawing.Point(92, 136)
        Me.TextBoxMatriks2.Multiline = True
        Me.TextBoxMatriks2.Name = "TextBoxMatriks2"
        Me.TextBoxMatriks2.Size = New System.Drawing.Size(337, 61)
        Me.TextBoxMatriks2.TabIndex = 1
        '
        'TextBoxHasil
        '
        Me.TextBoxHasil.Location = New System.Drawing.Point(92, 212)
        Me.TextBoxHasil.Multiline = True
        Me.TextBoxHasil.Name = "TextBoxHasil"
        Me.TextBoxHasil.Size = New System.Drawing.Size(337, 76)
        Me.TextBoxHasil.TabIndex = 2
        '
        'ComboBoxOperasi
        '
        Me.ComboBoxOperasi.FormattingEnabled = True
        Me.ComboBoxOperasi.Items.AddRange(New Object() {"Penambahan", "Pengurangan"})
        Me.ComboBoxOperasi.Location = New System.Drawing.Point(92, 96)
        Me.ComboBoxOperasi.Name = "ComboBoxOperasi"
        Me.ComboBoxOperasi.Size = New System.Drawing.Size(337, 21)
        Me.ComboBoxOperasi.TabIndex = 3
        '
        'Matriks1
        '
        Me.Matriks1.AutoSize = True
        Me.Matriks1.Location = New System.Drawing.Point(24, 40)
        Me.Matriks1.Name = "Matriks1"
        Me.Matriks1.Size = New System.Drawing.Size(50, 13)
        Me.Matriks1.TabIndex = 4
        Me.Matriks1.Text = "Matriks 1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Operasi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Matriks 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 249)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Hasil"
        '
        'ButtonProses
        '
        Me.ButtonProses.Location = New System.Drawing.Point(354, 313)
        Me.ButtonProses.Name = "ButtonProses"
        Me.ButtonProses.Size = New System.Drawing.Size(75, 23)
        Me.ButtonProses.TabIndex = 8
        Me.ButtonProses.Text = "Proses"
        Me.ButtonProses.UseVisualStyleBackColor = True
        '
        'Matriks_Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 402)
        Me.Controls.Add(Me.ButtonProses)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Matriks1)
        Me.Controls.Add(Me.ComboBoxOperasi)
        Me.Controls.Add(Me.TextBoxHasil)
        Me.Controls.Add(Me.TextBoxMatriks2)
        Me.Controls.Add(Me.TextBoxMatriks1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Matriks_Calculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matriks Kalkulator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxMatriks1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxMatriks2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxHasil As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxOperasi As System.Windows.Forms.ComboBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Matriks1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ButtonProses As System.Windows.Forms.Button
End Class
