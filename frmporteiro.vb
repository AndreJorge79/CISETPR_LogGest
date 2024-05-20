Imports System.Data.OleDb
Imports System.Data
Imports System.IO
Public Class frmporteiro
    Dim connection As New OleDbConnection
    Dim Da As New OleDbDataAdapter
    Dim Dt As DataTable
    Dim ncarateres As Integer

    Private Sub frmporteiro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SerialPort1.BaudRate = 9600 'Defenir a taxa de transferencia entre o pc e arduino'
        SerialPort1.Parity = System.IO.Ports.Parity.None 'paridade=none'
        SerialPort1.DataBits = 8 'bits de dados=8'
        SerialPort1.StopBits = System.IO.Ports.StopBits.One 'stop bits=1'
        SerialPort1.PortName = frmprincipal.tscmbportaCOM.Text 'nome da porta'"
        SerialPort1.Open() 'Abre a porta serial'
        frmprincipal.tsbtniniciar.Enabled = False

        connection.ConnectionString = "provider = microsoft.jet.oledb.4.0;data source= ..\BDALUNOS.mdb"
        connection.Open()

        PreencherListaES()

        txtrfid.Focus()

    End Sub

    Private Sub PreencherListaES()
        listesalunos.Items.Clear()

        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)

        Dim da As New OleDbDataAdapter("SELECT * FROM ENTRADAS_SAIDAS", connection)
        da.Fill(dt)

        Dim i As Integer = 0
        Dim coluna As DataRow

        For Each coluna In dt.Rows
            If dt.Rows(i).Item(6) <> "" Then
            Else
                listesalunos.Items.Add(coluna.Item(0))
                listesalunos.Items(listesalunos.Items.Count - 1).SubItems.Add(coluna.Item(1))
                listesalunos.Items(listesalunos.Items.Count - 1).SubItems.Add(coluna.Item(2))
                listesalunos.Items(listesalunos.Items.Count - 1).SubItems.Add(coluna.Item(3))
                listesalunos.Items(listesalunos.Items.Count - 1).SubItems.Add(coluna.Item(5))

            End If
            i = i + 1
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'If txtnprocesso.Text = String.Empty Then
        'MsgBox("Insira o número do aluno!!!", MsgBoxStyle.Information, "Informação")
        ' Else
        ' PreencherCampos(Me.txtnprocesso.Text)
        'End If
    End Sub

    Private Sub PreencherCampos(ByVal codigo As Integer)

        If lbles.Text = "SAIU" Then
            piccor4.BackColor = piccor3.BackColor
            picfoto5.Image = picfoto4.Image

            piccor3.BackColor = piccor2.BackColor
            picfoto4.Image = picfoto3.Image

            piccor2.BackColor = piccor1.BackColor
            picfoto3.Image = picfoto2.Image

            piccor1.BackColor = txtautorizacao.BackColor
            picfoto2.Image = picfoto.Image


            Dim ms As New IO.MemoryStream
            Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM ALUNOS " & _
                                                 " WHERE CARTAO_RFID ='" & txtrfid.Text & "'", connection)
            txtrfid.Text = Nothing


            Dim dt As New DataTable
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                Me.txtnprocesso.Text = dt.Rows(0).Item("N_PROCESSO")
                Me.txtturma.Text = dt.Rows(0).Item("TURMA") & ""
                Me.txtnome.Text = dt.Rows(0).Item("NOME") & ""

                If dt.Rows(0).Item("AUTORIZAÇÃO") = True Then
                    txtautorizacao.Text = "Autorizado"
                    txtautorizacao.BackColor = Color.Green
                Else
                    txtautorizacao.Text = "Não Autorizado"
                    txtautorizacao.BackColor = Color.Red
                End If

                If txtnprocesso.Text <> "" Then
                    Me.picfoto.Image = System.Drawing.Image.FromFile("C:\CISETPR LogGest\Fotos\" & txtnprocesso.Text & ".jpg")
                End If


                If txtautorizacao.Text = "Autorizado" Then
                    Dim mydb As String

                    mydb = "INSERT INTO ENTRADAS_SAIDAS (N_PROCESSO,NOME_ALUNO,TURMA,HORA_SAIDA,HORA_ENTRADA,DATA,MOTIVO_SAIDA) values ('" & txtnprocesso.Text & "','" & txtnome.Text & "','" & txtturma.Text & "','" & lblhora.Text & "','" & "" & "','" & lbldata.Text & "','" & "Sem info." & "')"

                    Dim run = New OleDb.OleDbCommand

                    Try

                        run = New OleDbCommand(mydb, connection)

                        run.ExecuteNonQuery()

                    Catch ex As Exception

                        MsgBox(ex.Message, MsgBoxStyle.Critical, "Oledb Error")

                    End Try

                Else
                    My.Forms.frmregistoalunonaoautorizado.lblnprocesso.Text = txtnprocesso.Text
                    My.Forms.frmregistoalunonaoautorizado.lblnome.Text = txtnome.Text
                    My.Forms.frmregistoalunonaoautorizado.lblturma.Text = txtturma.Text
                    My.Forms.frmregistoalunonaoautorizado.lblhora.Text = lblhora.Text
                    My.Forms.frmregistoalunonaoautorizado.lbldata.Text = lbldata.Text

                    frmmsgdeautorizacao.ShowDialog()

                End If



            Else
                MsgBox("Aluno inexistente!", MsgBoxStyle.Information, "Informação")
            End If
        Else
            If lbles.Text = "ENTROU" Then
                Dim aux As New ListViewItem

                For Each aux In listesalunos.Items
                    aux.Selected = False
                Next

                aux = listesalunos.FindItemWithText(txtnprocesso.Text)

                If aux Is Nothing Then
                    MsgBox("Nenhum Aluno Fora da Escola")
                Else
                    aux.Selected = True

                End If

                Dim dt As New DataTable
                Dim ds As New DataSet
                ds.Tables.Add(dt)
                Dim id As Integer = 0
                id = aux.Text
                Dim da As New OleDbDataAdapter("UPDATE ENTRADAS_SAIDAS SET HORA_ENTRADA = '" & lblhora.Text & "' WHERE ID = " & id, connection)
                da.Fill(dt)

                txtrfid.Text = Nothing

                Try

                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Oledb Error")
                End Try

            End If
        End If
        PreencherListaES()

        txtrfid.Focus()

    End Sub

    Private Sub txtnprocesso_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnprocesso.Click
        'LimparCampos() 'quando clicarmos sobre a textbox do numero de processo chama a função LimpaCampos

    End Sub

    Private Sub LimparCampos() 'Mete todas as textbox em branco
        txtnprocesso.Text = ""
        txtnome.Text = ""
        txtturma.Text = ""
        txtautorizacao.Text = ""
        picfoto.Image = Nothing
        txtautorizacao.BackColor = Color.White
    End Sub

    Private Sub txtnprocesso_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnprocesso.KeyDown
        If e.KeyCode = Keys.Enter Then                  'Verifica quando é que a tecla enter é precionada
            If txtnprocesso.Text = String.Empty Then
                MsgBox("Digite o número do aluno!!!", MsgBoxStyle.Information, "Informação")   'se nao tiver nenhum numero de aluno, surge a mensagem a avisar
            Else
                PreencherCampos(Me.txtnprocesso.Text)   'se tiver o numero de aluno chama a funçao PreencherCampos
            End If

        End If
    End Sub

    Private Sub txtnprocesso_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnprocesso.KeyPress

        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then

            e.Handled = True

        End If

    End Sub

    Private Sub TimerHoraData_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerHoraData.Tick
        lblhora.Text = TimeOfDay.ToLongTimeString()
        lbldata.Text = Date.Now.ToString("dd/MM/yyyy")
    End Sub

    Private Sub TimerCOM_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerCOM.Tick

        txtrfid.Focus()


        ncarateres = Len(txtrfid.Text)

        If ncarateres = "10" Then
            PreencherCampos(Me.txtrfid.Text)

        End If

        Dim primeiraletra As String 'Define a variavel primeiraletra como string'
        Dim segundaletra As String 'Define a variavel segundaletra como string'
        Dim valorporta As String 'Define a variavel valorporta como string'
        lblportaserial.Text = SerialPort1.ReadExisting 'escreve na label o valor da porta serial'
        valorporta = lblportaserial.Text 'escreve na variavel valorporta o que esta na label'
        'lbles.Text = ""
        If lblportaserial.Text <> "" Then

            If valorporta = "0" Or valorporta = Nothing Then

            Else
                If valorporta(0) = Nothing Then
                Else
                    primeiraletra = valorporta(0)
                    txtletra1.Text = primeiraletra
                End If


                If valorporta(1) = Nothing Then

                Else
                    segundaletra = valorporta(1)
                    txtletra2.Text = segundaletra
                End If

            End If



            If primeiraletra = "E" Then
                lbles.Text = "ENTROU"
            End If
            If primeiraletra = "S" Then
                lbles.Text = "SAIU"
            End If

            If primeiraletra = "0" Then
                If segundaletra = "L" Then
                    txtlugar0.Text = "Livre"
                    lugar0.Image = My.Resources.verde
                    frmvisitantes.picvisitante0.Image = My.Resources.verde
                    txtlugar0.BackColor = Color.Green
                    txtlugar0.ForeColor = Color.White
                End If

                If segundaletra = "O" Then
                    txtlugar0.Text = "Ocupado"
                    lugar0.Image = My.Resources.vermelho
                    frmvisitantes.picvisitante0.Image = My.Resources.vermelho
                    txtlugar0.BackColor = Color.Red
                    txtlugar0.ForeColor = Color.White
                End If
            End If

            If primeiraletra = "1" Then
                If segundaletra = "L" Then
                    txtlugar1.Text = "Livre"
                    lugar1.Image = My.Resources.verde
                    frmvisitantes.picvisitante1.Image = My.Resources.verde
                    txtlugar1.BackColor = Color.Green
                End If

                If segundaletra = "O" Then
                    txtlugar1.Text = "Ocupado"
                    lugar1.Image = My.Resources.vermelho
                    frmvisitantes.picvisitante1.Image = My.Resources.vermelho
                    txtlugar1.BackColor = Color.Red
                    txtlugar1.ForeColor = Color.White
                End If
            End If

            If primeiraletra = "2" Then
                If segundaletra = "L" Then
                    txtlugar2.Text = "Livre"
                    lugar2.Image = My.Resources.verde
                    frmvisitantes.picvisitante2.Image = My.Resources.verde
                    txtlugar2.BackColor = Color.Green
                End If

                If segundaletra = "O" Then
                    txtlugar2.Text = "Ocupado"
                    lugar2.Image = My.Resources.vermelho
                    frmvisitantes.picvisitante2.Image = My.Resources.vermelho
                    txtlugar2.BackColor = Color.Red
                    txtlugar2.ForeColor = Color.White
                End If
            End If

            If primeiraletra = "3" Then
                If segundaletra = "L" Then
                    txtlugar3.Text = "Livre"
                    lugar3.Image = My.Resources.verde
                    frmvisitantes.picvisitante3.Image = My.Resources.verde
                    txtlugar3.BackColor = Color.Green
                End If

                If segundaletra = "O" Then
                    txtlugar3.Text = "Ocupado"
                    lugar3.Image = My.Resources.vermelho
                    frmvisitantes.picvisitante3.Image = My.Resources.vermelho
                    txtlugar3.BackColor = Color.Red
                    txtlugar3.ForeColor = Color.White
                End If
            End If

            If primeiraletra = "4" Then
                If segundaletra = "L" Then
                    txtlugar4.Text = "Livre"
                    lugar4.Image = My.Resources.verde
                    frmvisitantes.picvisitante4.Image = My.Resources.verde
                    txtlugar4.BackColor = Color.Green

                End If

                If segundaletra = "O" Then
                    txtlugar4.Text = "Ocupado"
                    lugar4.Image = My.Resources.vermelho
                    frmvisitantes.picvisitante4.Image = My.Resources.vermelho
                    txtlugar4.BackColor = Color.Red
                    txtlugar4.ForeColor = Color.White
                End If
            End If

            If primeiraletra = "5" Then
                If segundaletra = "L" Then
                    txtlugar5.Text = "Livre"
                    lugar5.Image = My.Resources.verde
                    frmvisitantes.picvisitante5.Image = My.Resources.verde
                    txtlugar5.BackColor = Color.Green
                End If

                If segundaletra = "O" Then
                    txtlugar5.Text = "Ocupado"
                    lugar5.Image = My.Resources.vermelho
                    frmvisitantes.picvisitante5.Image = My.Resources.vermelho
                    txtlugar5.BackColor = Color.Red
                    txtlugar5.ForeColor = Color.White
                End If
            End If
        End If


    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        lbles.Text = "ENTROU"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        lbles.Text = "SAIU"
    End Sub
End Class





