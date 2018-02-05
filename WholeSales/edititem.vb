Imports WholeSales.functions
Imports WholeSales.Methodes
Public Class edititem
    Dim barcode, oldbarcode, iname, iqty, buyprice, sellprice As String

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to delete: " + iname, "Delete", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            frm_main.SalesDataSet.ITEMS.FindByBARCODE(txt_barcode.Text).Delete()
            updateitems()
            txt_origprice.Enabled = False
            txt_qty.Enabled = False
            txt_itemname.Enabled = False
            txt_sellprice.Enabled = False
            btn_update.Enabled = False
            btn_delete.Enabled = False
            txt_origprice.Text = ""
            txt_qty.Text = ""
            txt_itemname.Text = ""
            txt_sellprice.Text = ""
        End If

    End Sub

    Private Sub btn_check_Click(sender As Object, e As EventArgs) Handles btn_check.Click
        Try
            barcode = frm_main.SalesDataSet.ITEMS.FindByBARCODE(txt_barcode.Text).BARCODE
        Catch
        End Try

        If checkbarcode(txt_barcode.Text) = 1 Then
            oldbarcode = frm_main.SalesDataSet.ITEMS.FindByBARCODE(txt_barcode.Text).BARCODE
            iname = frm_main.SalesDataSet.ITEMS.FindByBARCODE(txt_barcode.Text).ITEMNAME
            iqty = frm_main.SalesDataSet.ITEMS.FindByBARCODE(txt_barcode.Text).ITEMQTY
            buyprice = frm_main.SalesDataSet.ITEMS.FindByBARCODE(txt_barcode.Text).ITEMORIGPRICE
            sellprice = frm_main.SalesDataSet.ITEMS.FindByBARCODE(txt_barcode.Text).ITEMSELLPRICE

            txt_barcode.Enabled = True
            txt_barcode.Text = barcode

            txt_origprice.Enabled = True
            txt_origprice.Text = buyprice

            txt_qty.Enabled = True
            txt_qty.Text = iqty

            txt_itemname.Enabled = True
            txt_itemname.Text = iname

            txt_sellprice.Enabled = True
            txt_sellprice.Text = sellprice

            btn_update.Enabled = True
            btn_delete.Enabled = True

        Else

            txt_origprice.Enabled = False
            txt_qty.Enabled = False
            txt_itemname.Enabled = False
            txt_sellprice.Enabled = False
            btn_update.Enabled = False
            btn_delete.Enabled = False

            MsgBox("WRONG BARCODE!")
        End If
    End Sub
    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to update item number: " + barcode, "Delete", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Methodes.edititem(barcode, txt_itemname.Text, txt_qty.Text, txt_origprice.Text, txt_sellprice.Text, txt_barcode.Text)
            barcode = txt_barcode.Text

            txt_origprice.Enabled = False
            txt_qty.Enabled = False
            txt_itemname.Enabled = False
            txt_sellprice.Enabled = False
            btn_update.Enabled = False
            btn_delete.Enabled = False
            txt_origprice.Text = ""
            txt_qty.Text = ""
            txt_itemname.Text = ""
            txt_sellprice.Text = ""
        End If

    End Sub
End Class