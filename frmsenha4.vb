Imports System.Data.OleDb
Imports System.IO

Public Class frmsenha4
    Dim connection As New OleDbConnection
    Dim Da As New OleDbDataAdapter
    Dim Dt As DataTable

    Private Sub frmsenha4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            connection.ConnectionString = "provider = microsoft.jet.oledb.4.0;data source= ..\BDALUNOS.mdb"
            connection.Open()
            connection.Close()

        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        If txtpass.Text = "" Then
            MsgBox("Introduza a senha!")
        Else
            VerificaPass()
        End If
    End Sub

    Private Sub VerificaPass()
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)

        Dim da As New OleDbDataAdapter("SELECT * FROM ADMIN_SENHA", connection)
        da.Fill(dt)

        Label3.Text = dt.Rows(0).Item(1)

        If txtpass.Text = Label3.Text Then
            Dim mensagem, titulo, botões, icone
            Dim resposta As DialogResult

            mensagem = "Tem a certeza que deseja continuar?"
            titulo = Me.Text
            botões = MessageBoxButtons.YesNo
            icone = MessageBoxIcon.Question
            resposta = MessageBox.Show(mensagem, titulo, botões, icone)

            If resposta = Windows.Forms.DialogResult.Yes Then
                ApagarRegistosAlunos()
                ApagarRegistosVisitantes()
                ReporPassAdmin()
                ReporPassPorteiro()
                ReporValorCheckBox()
                connection.Close()

            End If

        Else
            MsgBox("Senha Errada", MsgBoxStyle.Exclamation)
            txtpass.Text = ""
            txtpass.Focus()
        End If

    End Sub

    Private Sub ApagarRegistosAlunos()
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter("DELETE * FROM ENTRADAS_SAIDAS", connection)
        da.Fill(dt)
        Try

        Catch ex As Exception

        End Try
        connection.Close()
    End Sub

    Private Sub ApagarRegistosVisitantes()
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter("DELETE * FROM VISITANTES", connection)
        da.Fill(dt)
        Try

        Catch ex As Exception

        End Try
        connection.Close()
    End Sub

    Private Sub ReporPassAdmin()

        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)

        Dim da As New OleDbDataAdapter("UPDATE ADMIN_SENHA SET PASS = '" & txtpass.Text & "' WHERE USER = '" & Label2.Text & "'", connection)
        da.Fill(dt)

        Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Oledb Error")
        End Try

    End Sub

    Private Sub ReporPassPorteiro()
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)

        Dim da As New OleDbDataAdapter("UPDATE ADMIN_SENHA SET PASS = '" & txtpass.Text & "' WHERE USER = '" & Label2.Text & "'", connection)
        da.Fill(dt)

        Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Oledb Error")
        End Try

    End Sub

    Private Sub ReporValorCheckBox()
        Dim strPath = "C:\CISETPR LogGest\ValorCheckBox.txt"
        Dim fs As New FileStream(strPath, FileMode.Open)
        Dim sr As New StreamReader(fs)
        Dim strFile As String

        strFile = sr.ReadToEnd()
        sr.Close()

        Dim fstwo As New FileStream(strPath, FileMode.Create)

        strFile = strFile.Replace("1", "0")

        Dim sw As New StreamWriter(fstwo)

        sw.Write(strFile)

        sw.Flush()
        sw.Close()

        MsgBox("Definições Repostas com sucesso!", MsgBoxStyle.Information)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If My.Computer.Keyboard.CapsLock Then
        Else
        End If
    End Sub

    Private Sub btnsair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsair.Click
        Me.Close()
    End Sub

    Private Sub txtpass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpass.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtpass.Text = Nothing Then
                MsgBox("Insira a senha", MsgBoxStyle.Exclamation)
            Else
                VerificaPass()
            End If
        End If
    End Sub

    
End Class