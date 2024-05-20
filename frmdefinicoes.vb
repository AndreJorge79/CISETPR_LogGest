Imports System.Data.OleDb
Public Class frmdefinicoes
    Dim connection As New OleDbConnection
    Dim Da As New OleDbDataAdapter
    Dim Dt As DataTable

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        frmprincipal.Hide()
        frmlogin.ShowDialog()

    End Sub

    Private Sub frmdefinicoes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            connection.ConnectionString = "provider = microsoft.jet.oledb.4.0;data source= ..\BDALUNOS.mdb"
            connection.Open()
            connection.Close()

        Catch ex As Exception
        End Try

    End Sub

    Private Sub btnreporregistosalunos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreporregistosalunos.Click
        frmsenha1.Show()
    End Sub

    Private Sub btnreporregistosvisitantes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreporregistosvisitantes.Click
        frmsenha2.Show()
    End Sub

    Private Sub btnsair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsair.Click
        Me.Close()
    End Sub

    Private Sub btnreportodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreportodos.Click
        frmsenha3.Show()
    End Sub

    Private Sub brnrepordeorigem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brnrepordeorigem.Click
        frmsenha4.Show()
    End Sub
End Class