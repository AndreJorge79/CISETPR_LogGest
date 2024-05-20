Imports System.Data.OleDb
Public Class frmnovapassporteiro
    Dim connection As New OleDbConnection
    Dim Da As New OleDbDataAdapter
    Dim Dt As DataTable

    Private Sub frmnovapassporteiro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection.ConnectionString = "provider = microsoft.jet.oledb.4.0;data source= ..\BDALUNOS.mdb"
        connection.Open()
    End Sub

    Private Sub btnsair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsair.Click
        Me.Close()
    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        If txtpass.Text = Nothing Then
            MsgBox("Por favor digite a nova palavra-chave!", MsgBoxStyle.Exclamation)
        Else
            AtualizarPass()
        End If
    End Sub

    Private Sub AtualizarPass()
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)

        Dim da As New OleDbDataAdapter("UPDATE ADMIN_SENHA SET PASS = '" & txtpass.Text & "' WHERE USER = '" & Label2.Text & "'", connection)
        da.Fill(dt)

        Try
            MsgBox("Palavra-chave alterada com sucesso!", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Oledb Error")
        End Try

        Me.Close()
        frmprincipaladmin.Close()
        frmprincipal.Show()


    End Sub

    Private Sub txtpass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpass.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtpass.Text = Nothing Then
                MsgBox("Por favor digite a nova palavra-chave!", MsgBoxStyle.Exclamation)
            Else
                AtualizarPass()
            End If
        End If
    End Sub

    Private Sub txtpass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpass.TextChanged
        btnok.Enabled = True
    End Sub
End Class