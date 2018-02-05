Imports WholeSales.functions
Imports WholeSales.Methodes
Public Class additem
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If txt_barcode.Text = "" Then
            MsgBox("Invalid Barcode!")
            Return
        End If
        Methodes.additem(txt_barcode.Text, txt_itemname.Text, txt_qty.Text, txt_origprice.Text, txt_sellprice.Text)
        txt_barcode.Text = ""
        txt_qty.Text = ""
        txt_origprice.Text = ""
        txt_sellprice.Text = ""
        txt_itemname.Text = ""
    End Sub

End Class