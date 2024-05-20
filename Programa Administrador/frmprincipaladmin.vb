Imports System.Data.OleDb
Public Class frmprincipaladmin
    Dim connection As New OleDbConnection
    Private Sub frmprincipaladmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        connection.ConnectionString = "provider = microsoft.jet.oledb.4.0;data source= ..\BDALUNOS.mdb"
        connection.Open()

        MostrarTodasTurmas()
    End Sub

    Private Sub MostrarTodasTurmas()
        If cmbturma.Text = "Todas" Then
            listalunos.Items.Clear()
            connection.Close()
            connection.ConnectionString = "provider = microsoft.jet.oledb.4.0;data source= ..\BDALUNOS.mdb"

            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim da As New OleDbDataAdapter("SELECT * FROM ALUNOS", connection)
            da.Fill(dt)
            Dim coluna As DataRow
            For Each coluna In dt.Rows
                listalunos.Items.Add(coluna.Item(0))
                listalunos.Items(listalunos.Items.Count - 1).SubItems.Add(coluna.Item(1))
                listalunos.Items(listalunos.Items.Count - 1).SubItems.Add(coluna.Item(2))
                listalunos.Items(listalunos.Items.Count - 1).SubItems.Add(coluna.Item(3))
                listalunos.Items(listalunos.Items.Count - 1).SubItems.Add(coluna.Item(4))
                listalunos.Items(listalunos.Items.Count - 1).SubItems.Add(coluna.Item(5))
            Next
        Else
            MostrarTurmaEspecifica()
        End If
    End Sub

    Private Sub MostrarTurmaEspecifica()
        listalunos.Items.Clear()

        Dim i As Integer = 0
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter("SELECT * FROM ALUNOS WHERE TURMA = '" & cmbturma.Text & "'", connection)
        da.Fill(dt)
        Dim coluna As DataRow

        For Each coluna In dt.Rows
            listalunos.Items.Add(coluna.Item(0))
            listalunos.Items(listalunos.Items.Count - 1).SubItems.Add(coluna.Item(1))
            listalunos.Items(listalunos.Items.Count - 1).SubItems.Add(coluna.Item(2))
            listalunos.Items(listalunos.Items.Count - 1).SubItems.Add(coluna.Item(3))
            listalunos.Items(listalunos.Items.Count - 1).SubItems.Add(coluna.Item(4))
            listalunos.Items(listalunos.Items.Count - 1).SubItems.Add(coluna.Item(5))
        Next
    End Sub

    Private Sub cmbturma_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbturma.TextChanged
        If cmbturma.Text = "Todas" Then
            MostrarTodasTurmas()
        Else
            MostrarTurmaEspecifica()
        End If
       
    End Sub

    Private Sub listalunos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles listalunos.Click
        txtnprocesso.Text = listalunos.SelectedItems.Item(0).SubItems(0).Text
        txtnome.Text = listalunos.SelectedItems.Item(0).SubItems(1).Text
        txtnturma.Text = listalunos.SelectedItems.Item(0).SubItems(2).Text
        txtturma.Text = listalunos.SelectedItems.Item(0).SubItems(3).Text
        cmbescola.Text = listalunos.SelectedItems.Item(0).SubItems(4).Text
        cbautorização.Checked = listalunos.SelectedItems.Item(0).SubItems(5).Text
        txtnprocesso.Enabled = False
        btneditar.Enabled = True
        btnremover.Enabled = True
    End Sub

    Private Sub LimparCampos()
        txtnprocesso.Text = ""
        txtnome.Text = ""
        txtnturma.Text = ""
        txtturma.Text = ""
        cmbescola.Text = ""
        cbautorização.Checked = False
        btneditar.Enabled = False
        btnremover.Enabled = False

    End Sub

    Private Sub AdicionarAluno()

        Dim valorchkbox As String
        If cbautorização.Checked = True Then
            valorchkbox = "1"
        Else
            valorchkbox = "0"
        End If

        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter("INSERT INTO ALUNOS (N_PROCESSO,NOME,NUMERO,TURMA,ESCOLA,AUTORIZAÇÃO)" & "values ('" & txtnprocesso.Text & "','" & txtnome.Text & "','" & txtnturma.Text & "','" & txtturma.Text & "','" & cmbescola.Text & "','" & valorchkbox & "')", connection)
        da.Fill(dt)
        Try
            MsgBox("Aluno adicionado com sucesso!")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Oledb Error")
        End Try

        MostrarTodasTurmas()
        LimparCampos()

    End Sub

    Private Sub btnadicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadicionar.Click
        AdicionarAluno()
    End Sub

    Private Sub ApagarAluno()
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter("DELETE * FROM ALUNOS WHERE N_PROCESSO LIKE ('" & txtnprocesso.Text & "')", connection)
        da.Fill(dt)
        Try
            MsgBox("Aluno apagado com sucesso!")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Oledb Error")
        End Try
        MostrarTodasTurmas()
        LimparCampos()
    End Sub

    Private Sub btnremover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnremover.Click
        ApagarAluno()
    End Sub

    Private Sub EditarAluno()
       
        Dim valorchkbox As String
        If cbautorização.Checked = True Then
            valorchkbox = "1"
        Else
            valorchkbox = "0"
        End If
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter("UPDATE ALUNOS SET NOME = '" & txtnome.Text & "'," & "NUMERO = '" & txtnturma.Text & "'," & "TURMA = '" & txtturma.Text & "'," & "ESCOLA = '" & cmbescola.Text & "'," & "AUTORIZAÇÃO = '" & valorchkbox & "' WHERE N_PROCESSO = " & txtnprocesso.Text, connection)
        da.Fill(dt)
        Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Oledb Error")
        End Try

        MostrarTodasTurmas()
        LimparCampos()
    End Sub

    Private Sub btneditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneditar.Click
        EditarAluno()

    End Sub

    Private Sub btnnovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnovo.Click
        txtnprocesso.Text = ""
        txtnome.Text = ""
        txtnturma.Text = ""
        txtturma.Text = ""
        cmbescola.Text = ""
        cbautorização.Checked = False
        btnnovo.Hide()

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmnovapassadmin.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        frmnovapassporteiro.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsair.Click
        frmprincipal.Show()
        Me.Close()
    End Sub

End Class