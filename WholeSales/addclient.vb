Imports WholeSales.functions
Imports WholeSales.Methodes
Public Class addclient
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If txt_clid.Text = "" Then
            MsgBox("Invalid ClientID!")
            Return
        End If
        Methodes.addclient(txt_clid.Text, txt_clname.Text, txt_clphone.Text, txt_debt.Text, dp_debt.Value, txt_address.Text, txt_note.Text)
        txt_clid.Text = ""
        txt_clname.Text = ""
        txt_clphone.Text = ""
        txt_debt.Text = ""
        txt_address.Text = ""
        txt_note.Text = ""

    End Sub
End Class