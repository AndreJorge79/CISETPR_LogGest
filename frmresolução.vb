Imports System.IO
Public Class frmresolução

    Private Sub cbvoltaramostrar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbvoltaramostrar.CheckedChanged
        Dim strPath = "C:\CISETPR LogGest\ValorCheckBox.txt"
        Dim fs As New FileStream(strPath, FileMode.Open)
        Dim sr As New StreamReader(fs)
        Dim strFile As String

        strFile = sr.ReadToEnd()
        sr.Close()

        Dim fstwo As New FileStream(strPath, FileMode.Create)

        If cbvoltaramostrar.Checked = True Then
            strFile = strFile.Replace("0", "1")
        Else
            strFile = strFile.Replace("1", "0")
        End If

        Dim sw As New StreamWriter(fstwo)

        sw.Write(strFile)

        sw.Flush()
        sw.Close()

    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnok_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        Me.Close()
    End Sub


    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmajudaresolução.ShowDialog()
    End Sub
End Class