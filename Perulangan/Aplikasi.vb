Public Class Aplikasi

    Private Sub ProblemBintangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProblemBintangToolStripMenuItem.Click
        Problem_Bintang.MdiParent = Me
        Problem_Bintang.Show()
    End Sub

    Private Sub MatriksKalkulatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MatriksKalkulatorToolStripMenuItem.Click
        Matriks_Calculator.MdiParent = Me
        Matriks_Calculator.Show()
    End Sub


    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim klik = MessageBox.Show("Apakah anda yakin ingin keluar ?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If klik = Windows.Forms.DialogResult.OK Then
            Environment.Exit(0)
        Else

        End If
    End Sub
End Class
