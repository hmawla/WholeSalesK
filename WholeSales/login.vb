Public Class login
    Private Sub btn_loginexec_Click(sender As Object, e As EventArgs) Handles btn_loginexec.Click
        If txt_pass.Text = CredintialsDataSet.credentials.FindByusername("admin").pass Then
            frm_main.Show()
            Me.Hide()
        Else
            MsgBox("Wrong Password")
        End If
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CredentialsTableAdapter.Fill(Me.CredintialsDataSet.credentials)
    End Sub

    Private Sub txt_pass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_pass.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            btn_loginexec.PerformClick()
            e.Handled = True
        End If
    End Sub
End Class