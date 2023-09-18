Public Class Form1
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        AboutUs.Show()
    End Sub

    Private Sub EngineSpartPartsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EngineSpartPartsToolStripMenuItem.Click
        Form2.Hide()
        Form2.Show()
    End Sub

    Private Sub TyreSparePartsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TyreSparePartsToolStripMenuItem.Click
        Form3.Hide()
        Form3.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
