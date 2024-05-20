Imports System.Data.OleDb
Public Class frmrelatorioalunos
    Dim connection As New OleDbConnection
    Dim Da As New OleDbDataAdapter
    Dim Dt As DataTable
    Private Sub ApagarTudo()
        Dim i As Integer

        Dim n_processo As Integer
        Dim nome_aluno As String
        Dim data As String
        Dim hora_saida As String
        Dim hora_entrada As String
        For i = 0 To frmconsultas.listalunos.Items.Count - 1
            n_processo = frmconsultas.listalunos.Items(i).SubItems(0).Text
            nome_aluno = frmconsultas.listalunos.Items(i).SubItems(1).Text
            data = frmconsultas.listalunos.Items(i).SubItems(2).Text
            hora_saida = frmconsultas.listalunos.Items(i).SubItems(3).Text
            hora_entrada = frmconsultas.listalunos.Items(i).SubItems(4).Text
            Dim ds As New DataSet
            Dim dt As New DataTable
            ds.Tables.Add(dt)
            Dim da As New OleDbDataAdapter("DELETE * FROM RELATORIO_ALUNOS WHERE NOME_ALUNO <> ('" & 0 & "')", connection)
            da.Fill(dt)
            Try
                'MsgBox("Removido com sucesso!")
            Catch ex As Exception
                ' MsgBox(ex.Message, MsgBoxStyle.Critical, "Oledb Error")
            End Try
            connection.Close()
        Next
    End Sub
    Private Sub frmrelatorioalunos_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmconsultas.Cursor = Cursors.Default
        ApagarTudo()
    End Sub

    Private Sub frmrelatorioalunos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            connection.ConnectionString = "provider = microsoft.jet.oledb.4.0;data source= ..\BDALUNOS.mdb"
            connection.Open()
            connection.Close()

        Catch ex As Exception
        End Try
    End Sub

End Class