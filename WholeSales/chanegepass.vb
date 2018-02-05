Public Class chanegepass
    Private Sub btn_passexec_Click(sender As Object, e As EventArgs) Handles btn_passexec.Click
        If txt_newpass.Text <> txt_repnewpass.Text Then
            MsgBox("New pass is wrong!")
        ElseIf txt_oldpass.Text <> login.CredintialsDataSet.credentials.FindByusername("admin").pass
            MsgBox("Old pass is worng!")
        Else
            Dim therow As credintialsDataSet.credentialsRow = login.CredintialsDataSet.credentials.FindByusername("admin")
            therow.pass = txt_newpass.Text
            Methodes.updatepass()
            MsgBox("Password Changed")
            Me.Close()
        End If
    End Sub
End Class