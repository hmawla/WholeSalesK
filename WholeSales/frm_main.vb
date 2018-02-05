Imports System.ComponentModel
Imports WholeSales.functions
Imports WholeSales.Methodes
Public Class frm_main
    Dim totprice, sellprice, quantity As Integer
    Dim itemname, barcode As String
    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EMPTableAdapter.Fill(Me.SalesDataSet.EMP)
        Me.CLIENTTableAdapter.Fill(Me.SalesDataSet.CLIENT)
        Me.EMPTableAdapter.Fill(Me.SalesDataSet.EMP)
        Me.ITEMSTableAdapter.Fill(Me.SalesDataSet.ITEMS)
        checkstock()

    End Sub

    Private Sub btn_additem_Click(sender As Object, e As EventArgs) Handles btn_additem.Click
        additem.Show()
    End Sub

    Private Sub btn_editem_Click(sender As Object, e As EventArgs) Handles btn_editem.Click
        edititem.Show()
    End Sub

    Private Sub btn_addemp_Click(sender As Object, e As EventArgs) Handles btn_addemp.Click
        addemp.Show()
    End Sub

    Private Sub btn_sellexec_Click(sender As Object, e As EventArgs) Handles btn_sellexec.Click
        itemname = SalesDataSet.ITEMS.FindByBARCODE(barcode).ITEMNAME
        Dim result As Integer = MessageBox.Show("Are you sure you want to sell " & quantity & " " + itemname, "Sell", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            sellitem(barcode, quantity)
        End If
    End Sub

    Private Sub btn_addcl_Click(sender As Object, e As EventArgs) Handles btn_addcl.Click
        addclient.Show()
    End Sub

    Private Sub btn_editcl_Click(sender As Object, e As EventArgs) Handles btn_editcl.Click
        editclient.Show()
    End Sub

    Private Sub btn_editemp_Click(sender As Object, e As EventArgs) Handles btn_editemp.Click
        editemp.Show()
    End Sub

    Private Sub ChangepassToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangepassToolStripMenuItem.Click
        chanegepass.Show()
    End Sub

    Private Sub txt_sellbarcode_TextChanged(sender As Object, e As EventArgs) Handles txt_sellbarcode.TextChanged
        If txt_sellqty.Text <> "" And checkbarcode(txt_sellbarcode.Text) = 1 Then
            Try
                barcode = SalesDataSet.ITEMS.FindByBARCODE(txt_sellbarcode.Text).BARCODE
                sellprice = SalesDataSet.ITEMS.FindByBARCODE(barcode).ITEMSELLPRICE
                itemname = SalesDataSet.ITEMS.FindByBARCODE(barcode).ITEMNAME
                quantity = txt_sellqty.Text
                totprice = quantity * sellprice
                txt_sellprice.Text = totprice
                lbl_sellname.Text = itemname
                btn_sellexec.Enabled = True
            Catch ex As Exception

            End Try

        Else
            txt_sellprice.Text = "NOT AVAILABLE!"
            btn_sellexec.Enabled = False
        End If
    End Sub

    Private Sub txt_sellqty_TextChanged(sender As Object, e As EventArgs) Handles txt_sellqty.TextChanged
        If txt_sellbarcode.Text <> "" And checkbarcode(txt_sellbarcode.Text) = 1 Then
            Try
                barcode = SalesDataSet.ITEMS.FindByBARCODE(txt_sellbarcode.Text).BARCODE
                sellprice = SalesDataSet.ITEMS.FindByBARCODE(barcode).ITEMSELLPRICE
                itemname = SalesDataSet.ITEMS.FindByBARCODE(barcode).ITEMNAME
                quantity = txt_sellqty.Text
                totprice = quantity * sellprice
                txt_sellprice.Text = totprice
                lbl_sellname.Text = itemname
                btn_sellexec.Enabled = True
            Catch ex As Exception

            End Try

        Else
            txt_sellprice.Text = "NOT AVAILABLE!"
            btn_sellexec.Enabled = False
        End If
    End Sub

    Private Sub frm_main_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        login.Close()
    End Sub
End Class
