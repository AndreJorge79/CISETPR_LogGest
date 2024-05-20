Imports System.Data.OleDb
Public Class frmlogin
    Dim connection As New OleDbConnection
    Dim Da As New OleDbDataAdapter
    Dim Dt As DataTable

    Private Sub frmlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            connection.ConnectionString = "provider = microsoft.jet.oledb.4.0;data source= ..\BDALUNOS.mdb"
            connection.Open()
            connection.Close()

        Catch ex As Exception
        End Try

        txtpass.Text = Nothing

    End Sub
    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        If txtpass.Text = "" Then
            MsgBox("Introduza a palavra-chave!", MsgBoxStyle.Information)
        Else
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)

            Dim da As New OleDbDataAdapter("SELECT * FROM ADMIN_SENHA", connection)
            da.Fill(dt)

            Label2.Text = dt.Rows(0).Item(1)

            If txtpass.Text = Label2.Text Then
                Me.Hide()
                frmprincipaladmin.Show()

            Else
                MsgBox("Palavra-chave incorreta!", MsgBoxStyle.Exclamation)
                txtpass.Text = ""
                txtpass.Focus()
            End If

        End If

    End Sub

    Private Sub btnsair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsair.Click
        Me.Close()
        frmprincipal.Show()
        frmdefinicoes.Show()
    End Sub

    Private Sub txtpass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpass.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtpass.Text = Nothing Then
                MsgBox("Introduza a palavra-chave!", MsgBoxStyle.Information)
            Else
                Dim dt As New DataTable
                Dim ds As New DataSet
                ds.Tables.Add(dt)

                Dim da As New OleDbDataAdapter("SELECT * FROM ADMIN_SENHA", connection)
                da.Fill(dt)

                Label2.Text = dt.Rows(0).Item(1)

                If txtpass.Text = Label2.Text Then
                    frmprincipaladmin.Show()
                    Me.Hide()
                Else
                    MsgBox("Palavra-chave incorreta!", MsgBoxStyle.Exclamation)
                    txtpass.Text = ""
                    txtpass.Focus()
                End If
            End If
        End If
    End Sub

End Class