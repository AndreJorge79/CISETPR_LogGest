Public Class frmmsgdeautorizacao

    Private Sub btnnaoautorizo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnaoautorizo.Click
        Me.Close()
    End Sub

    Private Sub btnautorizo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnautorizo.Click
        Me.Hide()
        frmregistoalunonaoautorizado.ShowDialog()
    End Sub

End Class