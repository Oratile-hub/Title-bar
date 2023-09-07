Public Class Form1
    Private Sub btnChangeTitleBar_Click(sender As Object, e As EventArgs) Handles btnChangeTitleBar.Click


        Dim stTitleBar As String

        stTitleBar = txtTitleBar.Text

        Me.Text = stTitleBar

    End Sub
End Class
