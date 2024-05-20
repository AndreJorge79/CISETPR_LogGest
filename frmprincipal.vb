Public Class frmprincipal
    Dim TVscreenAvailable As Boolean = False
    Dim screen As Screen


    Private Sub tsbtnsair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnsair.Click
        Dim mensagem, titulo, botões, icone
        Dim resposta As DialogResult

        mensagem = "Deseja sair da aplicação"
        titulo = Me.Text
        botões = MessageBoxButtons.YesNo
        icone = MessageBoxIcon.Question
        resposta = MessageBox.Show(mensagem, titulo, botões, icone)

        If resposta = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub tscmbportaCOM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tscmbportaCOM.Click
        tscmbportaCOM.Items.Clear()
        For Each sp As String In My.Computer.Ports.SerialPortNames
            tscmbportaCOM.Items.Add(sp)
        Next

    End Sub

    Private Sub tsbtniniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtniniciar.Click

        Dim janela As New frmporteiro
        janela.MdiParent = Me
        janela.Show()
        tsbtnecravisintantes.Enabled = True
        tscmbportaCOM.Enabled = False

    End Sub


    Private Sub tscmbportaCOM_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tscmbportaCOM.TextChanged
        tsbtniniciar.Enabled = True

    End Sub

    Private Sub tsbtnalunosconsultas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnalunosconsultas.Click
        frmconsultas.ShowDialog()
    End Sub

    Private Sub btnecravisintantes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnecravisintantes.Click
        If Application.OpenForms.OfType(Of CISETPR_LogGest.frmvisitantes)().Count() > 0 Then
            frmvisitantes.Close()
        Else
            For Each s In screen.AllScreens
                If Not s.Primary Then
                    TVscreenAvailable = True
                End If
            Next
            If TVscreenAvailable Then
                screen = screen.AllScreens(1)
                frmvisitantes.Location = screen.AllScreens(UBound(screen.AllScreens)).Bounds.Location + New Point((screen.PrimaryScreen.WorkingArea.Width - frmvisitantes.Width) / 2, 0)
                frmvisitantes.Show()
            Else
                MsgBox("Não existe um sengundo monitor!", MsgBoxStyle.Information)
            End If
        End If

    End Sub

    Private Sub frmprincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Label1.Text = SystemInformation.PrimaryMonitorSize.Width
        Label2.Text = SystemInformation.PrimaryMonitorSize.Height

        If Label1.Text < 1024 And Label2.Text < 768 Then
            MsgBox("A sua resolução não permite que esta aplicação execute!", MsgBoxStyle.Critical, "Atenção")
            Stop
        End If

        Dim result As String
        Dim ler As String() = IO.File.ReadAllLines("C:\CISETPR LogGest\ValorCheckBox.txt")

        result = ler(0)

        If result = "0" Then
            frmresolução.ShowDialog()

        End If

    End Sub

    Private Sub tsbtnregistovisitantes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnregistovisitantes.Click
        frmregistarvisitante.ShowDialog()
    End Sub

    Private Sub tsbtndefiniçoes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtndefiniçoes.Click
        frmdefinicoes.ShowDialog()
    End Sub

    Private Sub tsbtnajuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnajuda.Click
        frmajuda.ShowDialog()
    End Sub
End Class
