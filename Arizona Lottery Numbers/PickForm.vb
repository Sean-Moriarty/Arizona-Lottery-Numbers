Public Class PickForm

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Const intMAX_SUBSCRIPT As Integer = 5
        Dim intNumbers(intMAX_SUBSCRIPT) As Integer
        Dim intCount As Integer

        Dim rand As New Random


        For intCount = 0 To intMAX_SUBSCRIPT
            intNumbers(intCount) = rand.Next(41)
        Next

        Label1.Text = intNumbers(0).ToString()
        Label2.Text = intNumbers(1).ToString()
        Label3.Text = intNumbers(2).ToString()
        Label4.Text = intNumbers(3).ToString()
        Label5.Text = intNumbers(4).ToString()
        Label6.Text = intNumbers(5).ToString()

    End Sub
End Class