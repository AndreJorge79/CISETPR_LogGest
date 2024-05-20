Imports System.Data.OleDb
Public Class frmregistoalunonaoautorizado
    Dim connection As New OleDbConnection
    Dim Da As New OleDbDataAdapter
    Dim Dt As DataTable

    Private Sub frmregistoalunonaoautorizado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection.ConnectionString = "provider = microsoft.jet.oledb.4.0;data source= ..\BDALUNOS.mdb"
        connection.Open()

    End Sub

    Private Sub btnsair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsair.Click
        connection.Close()
        Me.Close()
    End Sub

    Private Sub btnautorizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnautorizar.Click
        If txtpass.Text = Nothing Then
            MsgBox("Por favor insira a palavra-chave", MsgBoxStyle.Exclamation)
        Else
            If txtmotivo.Text = Nothing Then
                MsgBox("Para proceder ao registo da saída terá de preencher o campo 'Motivo de Saída'", MsgBoxStyle.Information)
            Else
                RegistarSaida()
            End If
        End If
    End Sub

    Private Sub txtmotivo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtmotivo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtpass.Text = Nothing Then
                MsgBox("Por favor insira a palavra-chave", MsgBoxStyle.Exclamation)
            Else
                If txtmotivo.Text = Nothing Then
                    MsgBox("Para proceder ao registo da saída terá de preencher o campo 'Motivo de Saída'", MsgBoxStyle.Information)
                Else
                    RegistarSaida()
                End If
            End If
        End If
    End Sub

    Private Sub txtpass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpass.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtpass.Text = Nothing Then
                MsgBox("Por favor insira a palavra-chave", MsgBoxStyle.Exclamation)
            Else
                If txtmotivo.Text = Nothing Then
                    MsgBox("Para proceder ao registo da saída terá de preencher o campo 'Motivo de Saída'", MsgBoxStyle.Information)
                Else
                    RegistarSaida()
                End If
            End If
        End If
    End Sub

    Private Sub RegistarSaida()

        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)

        Dim da As New OleDbDataAdapter("SELECT * FROM ADMIN_SENHA", connection)
        da.Fill(dt)

        Label3.Text = dt.Rows(1).Item(1)

        If txtpass.Text = Label3.Text Then
            Dim mydb As String

            mydb = "INSERT INTO ENTRADAS_SAIDAS (N_PROCESSO,NOME_ALUNO,TURMA,HORA_SAIDA,HORA_ENTRADA,DATA,MOTIVO_SAIDA) values ('" & lblnprocesso.Text & "','" & lblnome.Text & "','" & lblturma.Text & "','" & lblhora.Text & "','" & " Sem Info. " & "','" & lbldata.Text & "','" & txtmotivo.Text & "')"

            Dim run = New OleDb.OleDbCommand

            Try

                run = New OleDbCommand(mydb, connection)

                run.ExecuteNonQuery()

                Me.Close()

            Catch ex As Exception

                MsgBox(ex.Message, MsgBoxStyle.Critical, "Oledb Error")

            End Try

            connection.Close()

        Else
            MsgBox("Senha Errada!", MsgBoxStyle.Exclamation)
            txtpass.Text = ""
            txtpass.Focus()
        End If

        txtpass.Text = Nothing
        txtmotivo.Text = Nothing

    End Sub

End Class