Imports WholeSales.functions
Imports WholeSales.Methodes
Public Class editclient
    Dim clid, clname, clphone, claddress, note As String

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to update: " + clname, "Update", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Methodes.editclient(clid, txt_clname.Text, txt_clphone.Text, txt_debt.Text, dp_debt.Value, txt_address.Text, txt_note.Text)

            txt_clname.Enabled = False
            txt_clphone.Enabled = False
            txt_debt.Enabled = False
            txt_address.Enabled = False
            txt_note.Enabled = False
            btn_edit.Enabled = False
            btn_delete.Enabled = False
            txt_oldclid.Text = ""
            txt_clname.Text = ""
            txt_clphone.Text = ""
            txt_debt.Text = ""
            txt_address.Text = ""
            txt_note.Text = ""
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to delete: " + clname, "Delete", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            frm_main.SalesDataSet.CLIENT.FindByCLID(txt_clid.Text).Delete()
            updateclient()
            txt_clname.Enabled = False
            txt_clphone.Enabled = False
            txt_debt.Enabled = False
            txt_address.Enabled = False
            txt_note.Enabled = False
            btn_edit.Enabled = False
            btn_delete.Enabled = False
            txt_oldclid.Text = ""
            txt_clname.Text = ""
            txt_clphone.Text = ""
            txt_debt.Text = ""
            txt_address.Text = ""
            txt_note.Text = ""

        End If
    End Sub

    Dim debt As Integer
    Dim debtdate As Date
    Private Sub btn_check_Click(sender As Object, e As EventArgs) Handles btn_check.Click
        Try
            clid = frm_main.SalesDataSet.CLIENT.FindByCLID(txt_clid.Text).CLID
        Catch
        End Try

        If checkclientid(txt_clid.Text) = 1 Then
            clid = frm_main.SalesDataSet.CLIENT.FindByCLID(txt_clid.Text).CLID
            clname = frm_main.SalesDataSet.CLIENT.FindByCLID(txt_clid.Text).CLNAME
            clphone = frm_main.SalesDataSet.CLIENT.FindByCLID(txt_clid.Text).CLPHONE
            debt = frm_main.SalesDataSet.CLIENT.FindByCLID(txt_clid.Text).DEPTVAL
            debtdate = frm_main.SalesDataSet.CLIENT.FindByCLID(txt_clid.Text).DEPTDATE
            claddress = frm_main.SalesDataSet.CLIENT.FindByCLID(txt_clid.Text).CLADDRESS
            note = frm_main.SalesDataSet.CLIENT.FindByCLID(txt_clid.Text).CLNOTE


            txt_oldclid.Text = clid

            txt_clname.Enabled = True
            txt_clname.Text = clname

            txt_clphone.Enabled = True
            txt_clphone.Text = clphone

            txt_debt.Enabled = True
            txt_debt.Text = debt

            dp_debt.Enabled = True
            dp_debt.Value = debtdate


            txt_address.Enabled = True
            txt_address.Text = claddress

            txt_note.Enabled = True
            txt_note.Text = note

            btn_edit.Enabled = True
            btn_delete.Enabled = True

        Else

            txt_clname.Enabled = False
            txt_clphone.Enabled = False
            dp_debt.Enabled = False
            txt_address.Enabled = False
            txt_debt.Enabled = False
            txt_note.Enabled = False
            btn_edit.Enabled = False
            btn_delete.Enabled = False

            MsgBox("WRONG ID!")
        End If
    End Sub
End Class