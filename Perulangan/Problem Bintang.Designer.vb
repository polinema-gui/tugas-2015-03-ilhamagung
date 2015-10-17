<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Problem_Bintang
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
        Me.TexBoxHasilBintang = New System.Windows.Forms.TextBox()
        Me.LabelHasilBintang = New System.Windows.Forms.Label()
        Me.TexBoxInputBaris = New System.Windows.Forms.TextBox()
        Me.LabelInputBaris = New System.Windows.Forms.Label()
        Me.ComboBoxPola = New System.Windows.Forms.ComboBox()
        Me.LabelPola = New System.Windows.Forms.Label()
        Me.Tombol_Proses = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TexBoxHasilBintang
        '
        Me.TexBoxHasilBintang.Location = New System.Drawing.Point(12, 161)
        Me.TexBoxHasilBintang.Multiline = True
        Me.TexBoxHasilBintang.Name = "TexBoxHasilBintang"
        Me.TexBoxHasilBintang.Size = New System.Drawing.Size(441, 222)
        Me.TexBoxHasilBintang.TabIndex = 0
        '
        'LabelHasilBintang
        '
        Me.LabelHasilBintang.AutoSize = True
        Me.LabelHasilBintang.Location = New System.Drawing.Point(12, 135)
        Me.LabelHasilBintang.Name = "LabelHasilBintang"
        Me.LabelHasilBintang.Size = New System.Drawing.Size(75, 13)
        Me.LabelHasilBintang.TabIndex = 1
        Me.LabelHasilBintang.Text = "Hasil Bintang :"
        '
        'TexBoxInputBaris
        '
        Me.TexBoxInputBaris.Location = New System.Drawing.Point(105, 47)
        Me.TexBoxInputBaris.Name = "TexBoxInputBaris"
        Me.TexBoxInputBaris.Size = New System.Drawing.Size(357, 20)
        Me.TexBoxInputBaris.TabIndex = 2
        '
        'LabelInputBaris
        '
        Me.LabelInputBaris.AutoSize = True
        Me.LabelInputBaris.Location = New System.Drawing.Point(16, 50)
        Me.LabelInputBaris.Name = "LabelInputBaris"
        Me.LabelInputBaris.Size = New System.Drawing.Size(63, 13)
        Me.LabelInputBaris.TabIndex = 3
        Me.LabelInputBaris.Text = "Input Baris :"
        '
        'ComboBoxPola
        '
        Me.ComboBoxPola.FormattingEnabled = True
        Me.ComboBoxPola.Items.AddRange(New Object() {"Pyramid", "Hollow Pyramid", "Inverted Pyramid", "Hollow Inverted Pyramid"})
        Me.ComboBoxPola.Location = New System.Drawing.Point(105, 9)
        Me.ComboBoxPola.Name = "ComboBoxPola"
        Me.ComboBoxPola.Size = New System.Drawing.Size(208, 21)
        Me.ComboBoxPola.TabIndex = 4
        '
        'LabelPola
        '
        Me.LabelPola.AutoSize = True
        Me.LabelPola.Location = New System.Drawing.Point(16, 17)
        Me.LabelPola.Name = "LabelPola"
        Me.LabelPola.Size = New System.Drawing.Size(34, 13)
        Me.LabelPola.TabIndex = 5
        Me.LabelPola.Text = "Pola :"
        '
        'Tombol_Proses
        '
        Me.Tombol_Proses.Location = New System.Drawing.Point(378, 84)
        Me.Tombol_Proses.Name = "Tombol_Proses"
        Me.Tombol_Proses.Size = New System.Drawing.Size(75, 23)
        Me.Tombol_Proses.TabIndex = 6
        Me.Tombol_Proses.Text = "Proses"
        Me.Tombol_Proses.UseVisualStyleBackColor = True
        '
        'Problem_Bintang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 425)
        Me.Controls.Add(Me.Tombol_Proses)
        Me.Controls.Add(Me.LabelPola)
        Me.Controls.Add(Me.ComboBoxPola)
        Me.Controls.Add(Me.LabelInputBaris)
        Me.Controls.Add(Me.TexBoxInputBaris)
        Me.Controls.Add(Me.LabelHasilBintang)
        Me.Controls.Add(Me.TexBoxHasilBintang)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Problem_Bintang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Problem Bintang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TexBoxHasilBintang As System.Windows.Forms.TextBox
    Friend WithEvents LabelHasilBintang As System.Windows.Forms.Label
    Friend WithEvents TexBoxInputBaris As System.Windows.Forms.TextBox
    Friend WithEvents LabelInputBaris As System.Windows.Forms.Label
    Friend WithEvents ComboBoxPola As System.Windows.Forms.ComboBox
    Friend WithEvents LabelPola As System.Windows.Forms.Label
    Friend WithEvents Tombol_Proses As System.Windows.Forms.Button
End Class
