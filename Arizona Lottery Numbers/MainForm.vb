Public Class MainForm

    Private Sub btnPower_Click(sender As Object, e As EventArgs) Handles btnPower.Click
        Dim frmPower As New PowerForm
        frmPower.ShowDialog()
    End Sub

    Private Sub btnMega_Click(sender As Object, e As EventArgs) Handles btnMega.Click
        Dim frmMega As New MegaForm
        frmMega.ShowDialog()
    End Sub

    Private Sub btnPick_Click(sender As Object, e As EventArgs) Handles btnPick.Click
        Dim frmPick As New PickForm
        frmPick.ShowDialog()
    End Sub
End Class
