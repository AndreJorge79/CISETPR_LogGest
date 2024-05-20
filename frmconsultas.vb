Imports System.Data.OleDb
Public Class frmconsultas
    Dim connection As New OleDbConnection
    Dim Da As New OleDbDataAdapter
    Dim Dt As DataTable

    Private Sub apagartudo()
        Dim i As Integer

        Dim n_processo As Integer
        Dim nome_aluno As String
        Dim data As String
        Dim hora_saida As String
        Dim hora_entrada As String
        For i = 0 To listalunos.Items.Count - 1
            n_processo = listalunos.Items(i).SubItems(0).Text
            nome_aluno = listalunos.Items(i).SubItems(1).Text
            data = listalunos.Items(i).SubItems(2).Text
            hora_saida = listalunos.Items(i).SubItems(3).Text
            hora_entrada = listalunos.Items(i).SubItems(4).Text
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
    Private Sub frmconsultas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dtdataalunos.Format = DateTimePickerFormat.Custom
        dtdataalunos.CustomFormat = "dd/MM/yyyy"

        dtdataambos.Format = DateTimePickerFormat.Custom
        dtdataambos.CustomFormat = "dd/MM/yyyy"

        dtdatavisitantes.Format = DateTimePickerFormat.Custom
        dtdatavisitantes.CustomFormat = "dd/MM/yyyy"

        dtdataetipo.Format = DateTimePickerFormat.Custom
        dtdatavisitantes.CustomFormat = "dd/MM/yyyy"

        Try
            connection.ConnectionString = "provider = microsoft.jet.oledb.4.0;data source= ..\BDALUNOS.mdb"
            connection.Open()
            ListaAlunos()
            ListaVisitantes()
            connection.Close()

        Catch ex As Exception
        End Try
    End Sub

    Private Sub ListaAlunos()
        listalunos.Items.Clear()

        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)

        Dim da As New OleDbDataAdapter("SELECT * FROM ENTRADAS_SAIDAS", connection)
        da.Fill(dt)

        Dim coluna As DataRow

        For Each coluna In dt.Rows

            listalunos.Items.Add(coluna.Item(1))
            listalunos.Items(listalunos.Items.Count - 1).SubItems.Add(coluna.Item(2))
            listalunos.Items(listalunos.Items.Count - 1).SubItems.Add(coluna.Item(3))
            listalunos.Items(listalunos.Items.Count - 1).SubItems.Add(coluna.Item(4))
            listalunos.Items(listalunos.Items.Count - 1).SubItems.Add(coluna.Item(5))
            listalunos.Items(listalunos.Items.Count - 1).SubItems.Add(coluna.Item(6))
            listalunos.Items(listalunos.Items.Count - 1).SubItems.Add(coluna.Item(7))
        Next

    End Sub

    Private Sub ListaVisitantes()
        listvisitantes.Items.Clear()

        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)

        Dim da As New OleDbDataAdapter("SELECT * FROM VISITANTES", connection)
        da.Fill(dt)

        Dim coluna As DataRow

        For Each coluna In dt.Rows

            listvisitantes.Items.Add(coluna.Item(0))
            listvisitantes.Items(listvisitantes.Items.Count - 1).SubItems.Add(coluna.Item(1))
            listvisitantes.Items(listvisitantes.Items.Count - 1).SubItems.Add(coluna.Item(2))
            listvisitantes.Items(listvisitantes.Items.Count - 1).SubItems.Add(coluna.Item(3))
            listvisitantes.Items(listvisitantes.Items.Count - 1).SubItems.Add(coluna.Item(4))
            listvisitantes.Items(listvisitantes.Items.Count - 1).SubItems.Add(coluna.Item(5))
            listvisitantes.Items(listvisitantes.Items.Count - 1).SubItems.Add(coluna.Item(6))
        Next
    End Sub

    Private Sub PreencherListaNomeAluno()
        listalunos.Items.Clear()
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter("SELECT * FROM ENTRADAS_SAIDAS WHERE NOME_ALUNO LIKE '%" & txtnomealunos.Text & "%'", connection)
        da.Fill(dt)
        Dim coluna As DataRow
        For Each coluna In dt.Rows
            listalunos.Items.Add(coluna.Item(1))
            listalunos.Items(listalunos.Items.Count - 1).SubItems.Add(coluna.Item(2))
            listalunos.Items(listalunos.Items.Count - 1).SubItems.Add(coluna.Item(3))
            listalunos.Items(listalunos.Items.Count - 1).SubItems.Add(coluna.Item(4))
            listalunos.Items(listalunos.Items.Count - 1).SubItems.Add(coluna.Item(5))
            listalunos.Items(listalunos.Items.Count - 1).SubItems.Add(coluna.Item(6))

        Next
    End Sub

    Private Sub btnnome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnomealuno.Click
        If txtnomealunos.Text = String.Empty Then
            MsgBox("Digite o nome do aluno!!!", MsgBoxStyle.Information, "Informação")
        Else
            ApagarRelatorioAlunos()

            PreencherListaNomeAluno()
        End If
    End Sub

    Private Sub txtnome_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnomealunos.GotFocus
        txtnomealunos.Text = ""
    End Sub

    Private Sub txtnome_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnomealunos.KeyDown
        If e.KeyCode = Keys.Enter Then                  'Verifica quando é que a tecla enter é precionada
            If txtnomealunos.Text = String.Empty Then
                MsgBox("Digite o nome do aluno!!!", MsgBoxStyle.Information, "Informação")   'se nao tiver nenhum numero de aluno, surge a mensagem a avisar
            Else
                ApagarRelatorioAlunos()
                PreencherListaNomeAluno()
            End If

        End If
    End Sub

    Private Sub txtnome_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnomealunos.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Then

            e.Handled = True

            e = Nothing

        End If
    End Sub

    Private Sub txtnome_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnomealunos.TextChanged
        If txtnomealunos.Text = Nothing Then
            listalunos.Items.Clear()
        End If
    End Sub

    Private Sub PreencherListaDataAlunos()
        listalunos.Items.Clear()
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter("SELECT * FROM ENTRADAS_SAIDAS WHERE DATA = '" & dtdataalunos.Text & "'", connection)
        da.Fill(dt)
        Dim coluna As DataRow
        For Each coluna In dt.Rows
            listalunos.Items.Add(coluna.Item(1))
            listalunos.Items(listalunos.Items.Count - 1).SubItems.Add(coluna.Item(2))
            listalunos.Items(listalunos.Items.Count - 1).SubItems.Add(coluna.Item(4))
            listalunos.Items(listalunos.Items.Count - 1).SubItems.Add(coluna.Item(3))
            listalunos.Items(listalunos.Items.Count - 1).SubItems.Add(coluna.Item(5))

        Next

    End Sub

    Private Sub dtdataalunos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtdataalunos.KeyDown
        If e.KeyCode = Keys.Enter Then                  'Verifica quando é que a tecla enter é precionada
            ApagarRelatorioAlunos()
            PreencherListaDataAlunos()
        End If
    End Sub

    Private Sub btndata_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndataaluno.Click
        ApagarRelatorioAlunos()
        PreencherListaDataAlunos()
    End Sub

    Private Sub PreencherAmbos()
        listalunos.Items.Clear()
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter("SELECT * FROM ENTRADAS_SAIDAS WHERE NOME_ALUNO LIKE '%" & txtnomeambosaluno.Text & "%' AND DATA = '" & dtdataambos.Text & "'", connection)
        da.Fill(dt)
        Dim coluna As DataRow
        For Each coluna In dt.Rows
            listalunos.Items.Add(coluna.Item(1))
            listalunos.Items(listalunos.Items.Count - 1).SubItems.Add(coluna.Item(2))
            listalunos.Items(listalunos.Items.Count - 1).SubItems.Add(coluna.Item(3))
            listalunos.Items(listalunos.Items.Count - 1).SubItems.Add(coluna.Item(4))
            listalunos.Items(listalunos.Items.Count - 1).SubItems.Add(coluna.Item(5))
        Next

    End Sub

    Private Sub btnambos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnambosaluno.Click
        ApagarRelatorioAlunos()
        PreencherAmbos()
    End Sub

    Private Sub btnambosaluno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnambosaluno.KeyDown
        If e.KeyCode = Keys.Enter Then                  'Verifica quando é que a tecla enter é precionada
            If txtnomevisitante.Text = String.Empty Then
                MsgBox("Digite o nome do aluno!!!", MsgBoxStyle.Information, "Informação")
            Else
                ApagarRelatorioAlunos()
                PreencherAmbos()
            End If
        End If
    End Sub

    Private Sub dtdataambos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtdataambos.KeyDown
        If e.KeyCode = Keys.Enter Then                  'Verifica quando é que a tecla enter é precionada
            If txtnomeambosaluno.Text = String.Empty Then
                MsgBox("Digite o nome do aluno!!!", MsgBoxStyle.Information, "Informação")
            Else
                ApagarRelatorioAlunos()
                PreencherAmbos()
            End If
        End If
    End Sub

    Private Sub txtnomeambosaluno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnomeambosaluno.KeyDown
        If e.KeyCode = Keys.Enter Then                  'Verifica quando é que a tecla enter é precionada
            If txtnomeambosaluno.Text = String.Empty Then
                MsgBox("Digite o nome do aluno!!!", MsgBoxStyle.Information, "Informação")
            Else
                ApagarRelatorioAlunos()
                PreencherAmbos()
            End If
        End If
    End Sub










    Private Sub PreencherListaNomeVisitante()
        listvisitantes.Items.Clear()
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter("SELECT * FROM VISITANTES WHERE NOME LIKE '%" & txtnomevisitante.Text & "%'", connection)
        da.Fill(dt)
        Dim coluna As DataRow
        For Each coluna In dt.Rows
            listvisitantes.Items.Add(coluna.Item(0))
            listvisitantes.Items(listvisitantes.Items.Count - 1).SubItems.Add(coluna.Item(1))
            listvisitantes.Items(listvisitantes.Items.Count - 1).SubItems.Add(coluna.Item(2))
            listvisitantes.Items(listvisitantes.Items.Count - 1).SubItems.Add(coluna.Item(3))
            listvisitantes.Items(listvisitantes.Items.Count - 1).SubItems.Add(coluna.Item(4))
            listvisitantes.Items(listvisitantes.Items.Count - 1).SubItems.Add(coluna.Item(5))
            listvisitantes.Items(listvisitantes.Items.Count - 1).SubItems.Add(coluna.Item(6))
        Next
    End Sub

    Private Sub btnnomevisitante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnomevisitante.Click
        If txtnomevisitante.Text = String.Empty Then
            MsgBox("Digite o nome do visitante!!!", MsgBoxStyle.Information, "Informação")
        Else
            ApagarRelatorioVisitantes()
            PreencherListaNomeVisitante()
        End If
    End Sub

    Private Sub txtnomevisitante_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnomevisitante.GotFocus
        txtnomevisitante.Text = ""
    End Sub

    Private Sub txtnomevisitante_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnomevisitante.KeyDown
        If e.KeyCode = Keys.Enter Then                  'Verifica quando é que a tecla enter é precionada
            If txtnomevisitante.Text = String.Empty Then
                MsgBox("Digite o nome do visitante!!!", MsgBoxStyle.Information, "Informação")
            Else
                ApagarRelatorioVisitantes()
                PreencherListaNomeVisitante()
            End If
        End If
    End Sub

    Private Sub PreencherListaVisitanteTipoPessoa()
        listvisitantes.Items.Clear()
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter("SELECT * FROM VISITANTES WHERE TIPO_PESSOA LIKE '%" & cmbtipopessoa.Text & "%'", connection)
        da.Fill(dt)
        Dim coluna As DataRow
        For Each coluna In dt.Rows
            listvisitantes.Items.Add(coluna.Item(0))
            listvisitantes.Items(listvisitantes.Items.Count - 1).SubItems.Add(coluna.Item(1))
            listvisitantes.Items(listvisitantes.Items.Count - 1).SubItems.Add(coluna.Item(2))
            listvisitantes.Items(listvisitantes.Items.Count - 1).SubItems.Add(coluna.Item(3))
            listvisitantes.Items(listvisitantes.Items.Count - 1).SubItems.Add(coluna.Item(4))
            listvisitantes.Items(listvisitantes.Items.Count - 1).SubItems.Add(coluna.Item(5))
            listvisitantes.Items(listvisitantes.Items.Count - 1).SubItems.Add(coluna.Item(6))
        Next
    End Sub

    Private Sub btntipopessoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntipopessoa.Click
        ApagarRelatorioVisitantes()
        PreencherListaVisitanteTipoPessoa()
    End Sub

    Private Sub cmbtipopessoa_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbtipopessoa.KeyDown
        If e.KeyCode = Keys.Enter Then                  'Verifica quando é que a tecla enter é precionada
            If cmbtipopessoa.Text = String.Empty Then
                MsgBox("Selecione uma das opções!!!", MsgBoxStyle.Information, "Informação")
            Else
                ApagarRelatorioVisitantes()
                PreencherListaVisitanteTipoPessoa()
            End If
        End If
    End Sub

    Private Sub cmbtipopessoa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbtipopessoa.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then

            e.Handled = True

            e = Nothing

        End If

    End Sub

    Private Sub PreencherListaVistantesData()
        listvisitantes.Items.Clear()
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter("SELECT * FROM VISITANTES WHERE DATA LIKE '%" & dtdatavisitantes.Text & "%'", connection)
        da.Fill(dt)
        Dim coluna As DataRow
        For Each coluna In dt.Rows
            listvisitantes.Items.Add(coluna.Item(0))
            listvisitantes.Items(listvisitantes.Items.Count - 1).SubItems.Add(coluna.Item(1))
            listvisitantes.Items(listvisitantes.Items.Count - 1).SubItems.Add(coluna.Item(2))
            listvisitantes.Items(listvisitantes.Items.Count - 1).SubItems.Add(coluna.Item(3))
            listvisitantes.Items(listvisitantes.Items.Count - 1).SubItems.Add(coluna.Item(4))
            listvisitantes.Items(listvisitantes.Items.Count - 1).SubItems.Add(coluna.Item(5))
            listvisitantes.Items(listvisitantes.Items.Count - 1).SubItems.Add(coluna.Item(6))
        Next
    End Sub

    Private Sub btnpesquisardata_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpesquisardata.Click
        ApagarRelatorioVisitantes()
        PreencherListaVistantesData()
    End Sub

    Private Sub dtdatavisitantes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtdatavisitantes.KeyDown
        If e.KeyCode = Keys.Enter Then                  'Verifica quando é que a tecla enter é precionada
            If dtdatavisitantes.Text = String.Empty Then
                MsgBox("Informe a data!!!", MsgBoxStyle.Information, "Informação")
            Else
                ApagarRelatorioVisitantes()
                PreencherListaVistantesData()
            End If
        End If
    End Sub

    Private Sub PreencherListaVisitantesDataTipoPessoa()
        listvisitantes.Items.Clear()
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter("SELECT * FROM VISITANTES WHERE TIPO_PESSOA LIKE '%" & cmbdataetipo.Text & "%' AND DATA = '" & dtdataetipo.Text & "'", connection)
        da.Fill(dt)
        Dim coluna As DataRow
        For Each coluna In dt.Rows
            listvisitantes.Items.Add(coluna.Item(0))
            listvisitantes.Items(listvisitantes.Items.Count - 1).SubItems.Add(coluna.Item(1))
            listvisitantes.Items(listvisitantes.Items.Count - 1).SubItems.Add(coluna.Item(2))
            listvisitantes.Items(listvisitantes.Items.Count - 1).SubItems.Add(coluna.Item(3))
            listvisitantes.Items(listvisitantes.Items.Count - 1).SubItems.Add(coluna.Item(4))
            listvisitantes.Items(listvisitantes.Items.Count - 1).SubItems.Add(coluna.Item(5))
            listvisitantes.Items(listvisitantes.Items.Count - 1).SubItems.Add(coluna.Item(6))
        Next

    End Sub


    Private Sub cmbdataetipo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbdataetipo.KeyDown
        If e.KeyCode = Keys.Enter Then                  'Verifica quando é que a tecla enter é precionada
            If cmbdataetipo.Text = String.Empty Then
                MsgBox("Selecione uma das opções!!!", MsgBoxStyle.Information, "Informação")
            Else
                ApagarRelatorioVisitantes()
                PreencherListaVisitanteTipoPessoa()
            End If
        End If
    End Sub

    Private Sub cmbdataetipo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbdataetipo.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then

            e.Handled = True

            e = Nothing

        End If
    End Sub

    Private Sub btnpesquisardataetipo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpesquisardataetipo.Click
        ApagarRelatorioVisitantes()
        PreencherListaVisitantesDataTipoPessoa()
    End Sub

    Private Sub ApagarRelatorioAlunos()
        Dim i As Integer

        Dim n_processo As Integer
        Dim nome_aluno As String
        Dim data As String
        Dim hora_saida As String
        Dim hora_entrada As String
        For i = 0 To listalunos.Items.Count - 1
            n_processo = listalunos.Items(i).SubItems(0).Text
            nome_aluno = listalunos.Items(i).SubItems(1).Text
            data = listalunos.Items(i).SubItems(2).Text
            hora_saida = listalunos.Items(i).SubItems(3).Text
            hora_entrada = listalunos.Items(i).SubItems(4).Text
            Dim ds As New DataSet
            Dim dt As New DataTable
            ds.Tables.Add(dt)
            Dim da As New OleDbDataAdapter("DELETE * FROM RELATORIO_ALUNOS WHERE N_PROCESSO <> ('" & 0 & "')", connection)
            da.Fill(dt)
            Try
                'MsgBox("Removido com sucesso!")
            Catch ex As Exception
                ' MsgBox(ex.Message, MsgBoxStyle.Critical, "Oledb Error")
            End Try
            connection.Close()
        Next
    End Sub

    Private Sub RelatorioAlunos()
        ApagarRelatorioAlunos()

        Dim i As Integer

        Dim n_processo As Integer
        Dim nome_aluno As String
        Dim turma As String
        Dim data As String
        Dim hora_saida As String
        Dim hora_entrada As String
        Dim motivo_saida As String
        For i = 0 To listalunos.Items.Count - 1
            n_processo = listalunos.Items(i).SubItems(0).Text
            nome_aluno = listalunos.Items(i).SubItems(1).Text
            turma = listalunos.Items(i).SubItems(2).Text
            data = listalunos.Items(i).SubItems(3).Text
            hora_saida = listalunos.Items(i).SubItems(4).Text
            hora_entrada = listalunos.Items(i).SubItems(5).Text
            motivo_saida = listalunos.Items(i).SubItems(6).Text

            Dim connection As OleDb.OleDbConnection
            Dim mydb, mystr As String
            mystr = "provider = microsoft.jet.oledb.4.0;data source = ..\BDALUNOS.mdb"
            connection = New OleDb.OleDbConnection(mystr)
            connection.Open()
            mydb = "INSERT INTO RELATORIO_ALUNOS (N_PROCESSO, NOME_ALUNO, TURMA,DATA,HORA_SAIDA, HORA_ENTRADA, MOTIVO_SAIDA ) values ('" & n_processo & "','" & nome_aluno & "','" & turma & "','" & data & "','" & hora_saida & "' ,'" & hora_entrada & "','" & motivo_saida & "')"
            Dim run = New OleDb.OleDbCommand
            Try
                run = New OleDbCommand(mydb, connection)
                run.ExecuteNonQuery()

            Catch ex As Exception
                ' MsgBox(ex.Message, MsgBoxStyle.Information, "Adicionado!")
            End Try
            connection.Close()
        Next
        frmrelatorioalunos.Show()
        MsgBox("Relatório gerado com sucesso!" & vbNewLine & "Por favor actualize sempre o seu relatório!", MsgBoxStyle.Information, "Informação")

    End Sub

    Private Sub btnrelatorioalunos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrelatorioalunos.Click
        Cursor = Cursors.WaitCursor
        RelatorioAlunos()

    End Sub

    Private Sub ApagarRelatorioVisitantes()
        Dim i As Integer


        Dim nome As String
        Dim tipo_pessoa As String
        Dim data As String
        Dim observacoes As String
        Dim hora_saida As String
        Dim hora_entrada As String
        For i = 0 To listvisitantes.Items.Count - 1
            nome = listvisitantes.Items(i).SubItems(1).Text
            tipo_pessoa = listvisitantes.Items(i).SubItems(2).Text
            data = listvisitantes.Items(i).SubItems(3).Text
            observacoes = listvisitantes.Items(i).SubItems(4).Text
            hora_saida = listvisitantes.Items(i).SubItems(5).Text
            hora_entrada = listvisitantes.Items(i).SubItems(6).Text
            Dim ds As New DataSet
            Dim dt As New DataTable
            ds.Tables.Add(dt)
            Dim da As New OleDbDataAdapter("DELETE * FROM RELATORIO_VISITANTES WHERE NOME <> ('" & 0 & "')", connection)
            da.Fill(dt)
            Try
                'MsgBox("Removido com sucesso!")
            Catch ex As Exception
                ' MsgBox(ex.Message, MsgBoxStyle.Critical, "Oledb Error")
            End Try
            connection.Close()
        Next
    End Sub

    Private Sub RelatorioVisitantes()
        ApagarRelatorioVisitantes()

        Dim i As Integer

        Dim nome As String
        Dim tipo_pessoa As String
        Dim data As String
        Dim observacoes As String
        Dim hora_saida As String
        Dim hora_entrada As String
        For i = 0 To listvisitantes.Items.Count - 1
            nome = listvisitantes.Items(i).SubItems(1).Text
            tipo_pessoa = listvisitantes.Items(i).SubItems(2).Text
            data = listvisitantes.Items(i).SubItems(3).Text
            observacoes = listvisitantes.Items(i).SubItems(4).Text
            hora_saida = listvisitantes.Items(i).SubItems(5).Text
            hora_entrada = listvisitantes.Items(i).SubItems(6).Text

            Dim connection As OleDb.OleDbConnection
            Dim mydb, mystr As String
            mystr = "provider = microsoft.jet.oledb.4.0;data source = ..\BDALUNOS.mdb"
            connection = New OleDb.OleDbConnection(mystr)
            connection.Open()
            mydb = "INSERT INTO RELATORIO_VISITANTES (NOME, TIPO_PESSOA, DATA, OBSERVACOES, HORA_SAIDA, HORA_ENTRADA ) values ('" & nome & "','" & tipo_pessoa & "','" & data & "','" & observacoes & "','" & hora_saida & "' ,'" & hora_entrada & "')"
            Dim run = New OleDb.OleDbCommand
            Try
                run = New OleDbCommand(mydb, connection)
                run.ExecuteNonQuery()

            Catch ex As Exception
                ' MsgBox(ex.Message, MsgBoxStyle.Information, "Adicionado!")
            End Try
            connection.Close()
        Next
        frmrelatoriovisitante.Show()
        MsgBox("Relatório gerado com sucesso!" & vbNewLine & "Por favor actualize sempre o seu relatório!", MsgBoxStyle.Information, "Informação")

    End Sub

    Private Sub btnrelatoriovisitantes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrelatoriovisitantes.Click
        Cursor = Cursors.WaitCursor
        RelatorioVisitantes()
    End Sub

    Private Sub btnsair1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsair1.Click
        Me.Close()
    End Sub

    Private Sub btnsair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsair.Click
        Me.Close()
    End Sub

End Class