Imports WholeSales.functions
Imports WholeSales.Methodes
Public Class editemp
    Dim workdur, debt, sal As Integer
    Dim empname, empphone, arrtime, note As String
    Dim empid As String

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to update: " + empname, "Update", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Methodes.editemp(empid, txt_empname.Text, txt_empphone.Text, DateTimePicker1.Text, txt_workdur.Text, txt_debt.Text, txt_sal.Text, txt_note.Text)

            txt_empname.Enabled = False
            txt_empphone.Enabled = False
            DateTimePicker1.Enabled = False
            txt_workdur.Enabled = False
            txt_debt.Enabled = False
            txt_sal.Enabled = False
            txt_note.Enabled = False
            btn_edit.Enabled = False
            btn_delete.Enabled = False
            txt_empid.Text = ""
            txt_empname.Text = ""
            txt_empphone.Text = ""
            DateTimePicker1.Text = ""
            txt_workdur.Text = ""
            txt_debt.Text = ""
            txt_sal.Text = ""
            txt_note.Text = ""

        End If
    End Sub


    Private Sub btn_check_Click(sender As Object, e As EventArgs) Handles btn_check.Click
        Try
            empid = frm_main.SalesDataSet.EMP.FindByEMPID(txt_empid.Text).EMPID
        Catch
        End Try

        If checkempid(txt_empid.Text) = 1 Then
            empid = frm_main.SalesDataSet.EMP.FindByEMPID(txt_empid.Text).EMPID
            empname = frm_main.SalesDataSet.EMP.FindByEMPID(txt_empid.Text).EMPNAME
            empphone = frm_main.SalesDataSet.EMP.FindByEMPID(txt_empid.Text).EMPPHONE
            arrtime = frm_main.SalesDataSet.EMP.FindByEMPID(txt_empid.Text).ARRIVETIME
            workdur = frm_main.SalesDataSet.EMP.FindByEMPID(txt_empid.Text).WORKDUR
            debt = frm_main.SalesDataSet.EMP.FindByEMPID(txt_empid.Text).EMPDEPT
            sal = frm_main.SalesDataSet.EMP.FindByEMPID(txt_empid.Text).SALARY
            note = frm_main.SalesDataSet.EMP.FindByEMPID(txt_empid.Text).EMPNOTE

            txt_oldempid.Text = empid

            txt_empname.Enabled = True
            txt_empname.Text = empname

            txt_empphone.Enabled = True
            txt_empphone.Text = empphone

            DateTimePicker1.Enabled = True
            DateTimePicker1.Text = arrtime

            txt_workdur.Enabled = True
            txt_workdur.Text = workdur

            txt_debt.Enabled = True
            txt_debt.Text = debt

            txt_sal.Enabled = True
            txt_sal.Text = sal

            txt_note.Enabled = True
            txt_note.Text = note

            btn_edit.Enabled = True
            btn_delete.Enabled = True

        Else

            txt_empname.Enabled = False
            txt_empphone.Enabled = False
            DateTimePicker1.Enabled = False
            txt_workdur.Enabled = False
            txt_debt.Enabled = False
            txt_sal.Enabled = False
            txt_note.Enabled = False
            btn_edit.Enabled = False
            btn_delete.Enabled = False

            MsgBox("WRONG ID!")
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to delete: " + empname, "Delete", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            frm_main.SalesDataSet.EMP.FindByEMPID(txt_empid.Text).Delete()
            updateemp()

            txt_empname.Enabled = False
            txt_empphone.Enabled = False
            DateTimePicker1.Enabled = False
            txt_workdur.Enabled = False
            txt_debt.Enabled = False
            txt_sal.Enabled = False
            txt_note.Enabled = False
            btn_edit.Enabled = False
            btn_delete.Enabled = False
            txt_empid.Text = ""
            txt_empname.Text = ""
            txt_empphone.Text = ""
            DateTimePicker1.Text = ""
            txt_workdur.Text = ""
            txt_debt.Text = ""
            txt_sal.Text = ""
            txt_note.Text = ""
        End If
    End Sub
End Class