Imports System.Data.OleDb
Imports System.Data
Imports System.IO
Public Class frmregistarvisitante
    Dim connection As New OleDbConnection
    Dim Da As New OleDbDataAdapter
    Dim Dt As DataTable

    Private Sub frmregistarvisitante_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtdata.Format = DateTimePickerFormat.Custom
        dtdata.CustomFormat = "dd/MM/yyyy"

        connection.ConnectionString = "provider = microsoft.jet.oledb.4.0;data source= ..\BDALUNOS.mdb"
        connection.Open()

        PreencherLista()

    End Sub

    Private Sub btnadicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadicionar.Click
        If cmbtipopessoa.Text = Nothing Then
            MsgBox("O campo tipo de pessoa é obrigatório")
        Else
            RegistarVisitante()
        End If
    End Sub


    Private Sub RegistarVisitante()
        Dim mydb As String

        mydb = "INSERT INTO VISITANTES (NOME,TIPO_PESSOA,DATA,OBSERVACOES,HORA_ENTRADA,HORA_SAIDA) values ('" & txtnome.Text & "','" & cmbtipopessoa.Text & "','" & dtdata.Text & "','" & txtobservacoes.Text & "','" & lblhora.Text & "','" & "" & "')"

        Dim run = New OleDb.OleDbCommand

        Try

            run = New OleDbCommand(mydb, connection)

            run.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Oledb Error")

        End Try

        PreencherLista()
        LimparCampos()

    End Sub

    Private Sub TimerHora_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerHora.Tick
        lblhora.Text = TimeOfDay.ToLongTimeString()
    End Sub

    Private Sub PreencherLista()
        listvisitantes.Items.Clear()

        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)

        Dim da As New OleDbDataAdapter("SELECT * FROM VISITANTES", connection)
        da.Fill(dt)

        Dim i As Integer = 0
        Dim coluna As DataRow

      For Each coluna In dt.Rows
            If dt.Rows(i).Item(6) <> "" Then
            Else
                listvisitantes.Items.Add(coluna.Item(0))
                listvisitantes.Items(listvisitantes.Items.Count - 1).SubItems.Add(coluna.Item(1))
                listvisitantes.Items(listvisitantes.Items.Count - 1).SubItems.Add(coluna.Item(2))
                listvisitantes.Items(listvisitantes.Items.Count - 1).SubItems.Add(coluna.Item(3))
                listvisitantes.Items(listvisitantes.Items.Count - 1).SubItems.Add(coluna.Item(4))
                listvisitantes.Items(listvisitantes.Items.Count - 1).SubItems.Add(coluna.Item(5))
                listvisitantes.Items(listvisitantes.Items.Count - 1).SubItems.Add(coluna.Item(6))
            End If
            i = i + 1
        Next
    End Sub

    Private Sub txtnome_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnome.GotFocus
        LimparCampos()
    End Sub

    Private Sub txtnome_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnome.TextChanged
        If txtnome.Text = Nothing Then
            btnadicionar.Enabled = False
            btnsair.Enabled = False
        Else
            btnadicionar.Enabled = True
            btnsair.Enabled = True
        End If
    End Sub

    Private Sub listvisitantes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles listvisitantes.Click
        txtnome.Text = listvisitantes.SelectedItems.Item(0).SubItems(1).Text
        cmbtipopessoa.Text = listvisitantes.SelectedItems.Item(0).SubItems(2).Text
        txtobservacoes.Text = listvisitantes.SelectedItems.Item(0).SubItems(4).Text
        lblid.Text = listvisitantes.SelectedItems.Item(0).SubItems(0).Text

    End Sub

    Private Sub btnsair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsair.Click
        
        Dim id_visitante As Integer = 0
        id_visitante = lblid.Text
        If id_visitante = 0 Then
            MsgBox("A pessoa que referiu ainda não entrou no campus escolar")
        Else
            'SairVisitante()
        End If

    End Sub

    Private Sub SairVisitante()
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim id_visitante As Integer = 0
        id_visitante = lblid.Text
        Dim da As New OleDbDataAdapter("UPDATE VISITANTES SET HORA_SAIDA = '" & lblhora.Text & "' WHERE ID = " & id_visitante, connection)
        da.Fill(dt)
        
        Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Oledb Error")
        End Try

        PreencherLista()
        LimparCampos()

    End Sub

    Private Sub LimparCampos()
        txtnome.Text = Nothing
        cmbtipopessoa.Text = Nothing
        txtobservacoes.Text = Nothing
        lblid.Text = "0"
    End Sub

    Private Sub listvisitantes_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles listvisitantes.DoubleClick
        SairVisitante()
    End Sub

    Private Sub btnfechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfechar.Click
        Me.Close()
    End Sub
End Class