Imports WholeSales.functions
Imports WholeSales.Methodes
Public Class addemp
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If txt_empid.Text = "" Then
            MsgBox("Invalid EmployeeID!")
            Return
        End If
        Methodes.addemp(txt_empid.Text, txt_empname.Text, txt_empphone.Text, DateTimePicker1.Text, txt_workdur.Text, txt_debt.Text, txt_sal.Text, txt_note.Text)
        txt_empid.Text = ""
        txt_empname.Text = ""
        txt_empphone.Text = ""
        DateTimePicker1.Text = ""
        txt_workdur.Text = ""
        txt_debt.Text = ""
        txt_sal.Text = ""
        txt_note.Text = ""

    End Sub
End Class