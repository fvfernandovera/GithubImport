
Public Class Form1

    Private _Controller As Controller_GithubImport
    Private lista As Collection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lista = _Controller.GetSources()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub


End Class
