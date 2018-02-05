Public Class Methodes
    Public Shared Sub sellitem(rbarcode As String, rqty As Integer)
        Dim qty As Integer = frm_main.SalesDataSet.ITEMS.FindByBARCODE(rbarcode).ITEMQTY
        Dim therow As salesDataSet.ITEMSRow
        therow = frm_main.SalesDataSet.ITEMS.FindByBARCODE(rbarcode)
        If qty >= rqty Then
            therow.ITEMQTY = qty - rqty
            frm_main.dgv_att.Rows.Add(New String() {therow.ITEMNAME, frm_main.txt_sellqty.Text, frm_main.txt_sellprice.Text, TimeOfDay})
        Else
            MessageBox.Show("You only have " & qty & " in stock.")
        End If

        updateitems()
    End Sub
    Public Shared Sub checkstock()
        Dim c As Integer = 0
        Dim theitems As String = ""
        Dim therow As salesDataSet.ITEMSRow
        While c < frm_main.SalesDataSet.ITEMS.Count
            therow = frm_main.SalesDataSet.ITEMS.Rows(c)
            If therow.ITEMQTY <= 5 Then
                theitems = theitems & vbNewLine & therow.ITEMNAME & " = " & therow.ITEMQTY
            End If
            c += 1
        End While

        frm_main.notify_stock.BalloonTipTitle = "Items Stock Warning!"
        frm_main.notify_stock.BalloonTipText = "These items are nearly or out of stock" & theitems
        frm_main.notify_stock.ShowBalloonTip(20)
    End Sub
    Public Shared Sub additem(rbarcode As String, ritem As String, rqty As Integer, rbuyprice As String, rsellprice As String)

        frm_main.ITEMSTableAdapter.Fill(frm_main.SalesDataSet.ITEMS)
        Dim therow As salesDataSet.ITEMSRow
        therow = frm_main.SalesDataSet.ITEMS.NewITEMSRow()
        therow.BARCODE = rbarcode
        therow.ITEMNAME = ritem
        therow.ITEMQTY = rqty
        therow.ITEMORIGPRICE = rbuyprice
        therow.ITEMSELLPRICE = rsellprice
        therow.ITEMADDEDDATE = Now
        Try
            frm_main.SalesDataSet.ITEMS.Rows.Add(therow)
        Catch
            MsgBox("BARCODE ALREADY EXIST!")
        End Try
        updateitems()
    End Sub
    Public Shared Sub edititem(rbarcode As String, ritem As String, rqty As Integer, rbuyprice As String, rsellprice As String, newbarcode As String)
        Dim therow As salesDataSet.ITEMSRow
        therow = frm_main.SalesDataSet.ITEMS.FindByBARCODE(rbarcode)
        therow.BARCODE = newbarcode
        therow.ITEMNAME = ritem
        therow.ITEMQTY = rqty
        therow.ITEMORIGPRICE = rbuyprice
        therow.ITEMSELLPRICE = rsellprice

        updateitems()
    End Sub
    Public Shared Sub editemp(rempid As String, rempname As String, rempphone As String, rarrtime As String, rworkdur As Integer, rdebt As Integer, rsal As Integer, rnote As String)
        Dim therow As salesDataSet.EMPRow
        therow = frm_main.SalesDataSet.EMP.FindByEMPID(rempid)
        therow.EMPNAME = rempname
        therow.EMPPHONE = rempphone
        therow.ARRIVETIME = rarrtime
        therow.WORKDUR = rworkdur
        therow.EMPDEPT = rdebt
        therow.SALARY = rsal
        therow.EMPNOTE = rnote

        updateemp()
    End Sub
    Public Shared Sub editclient(rclid As String, rclname As String, rclphone As String, rdebt As Integer, rdebtdate As Date, raddress As String, rnote As String)
        Dim therow As salesDataSet.CLIENTRow
        therow = frm_main.SalesDataSet.CLIENT.FindByCLID(rclid)
        therow.CLNAME = rclname
        therow.CLPHONE = rclphone
        therow.DEPTVAL = rdebt
        therow.DEPTDATE = rdebtdate
        therow.CLADDRESS = raddress
        therow.CLNOTE = rnote

        updateclient()
    End Sub
    Public Shared Sub updateitems()
        Dim Itemsadapter As New salesDataSetTableAdapters.ITEMSTableAdapter
        Itemsadapter.Update(frm_main.SalesDataSet.ITEMS)
        frm_main.ITEMSTableAdapter.Fill(frm_main.SalesDataSet.ITEMS)
    End Sub
    Public Shared Sub updatepass()
        Dim credentialsadapter As New credintialsDataSetTableAdapters.credentialsTableAdapter
        credentialsadapter.Update(login.CredintialsDataSet.credentials)
        login.CredentialsTableAdapter.Fill(login.CredintialsDataSet.credentials)
    End Sub

    Public Shared Sub updateemp()
        Dim Empadapter As New salesDataSetTableAdapters.EMPTableAdapter
        Empadapter.Update(frm_main.SalesDataSet.EMP)
        frm_main.EMPTableAdapter.Fill(frm_main.SalesDataSet.EMP)
    End Sub

    Public Shared Sub updateclient()
        Dim cladapter As New salesDataSetTableAdapters.CLIENTTableAdapter
        cladapter.Update(frm_main.SalesDataSet.CLIENT)
        frm_main.CLIENTTableAdapter.Fill(frm_main.SalesDataSet.CLIENT)
    End Sub

    Public Shared Sub addemp(rempid As String, rempname As String, rempphone As String, rarrtime As String, rworkdu As Integer, rempdept As Integer, rsal As Integer, rempnote As String)

        frm_main.EMPTableAdapter.Fill(frm_main.SalesDataSet.EMP)
        Dim therow As salesDataSet.EMPRow
        therow = frm_main.SalesDataSet.EMP.NewEMPRow()
        therow.EMPID = rempid
        therow.EMPNAME = rempname
        therow.EMPPHONE = rempphone
        therow.ARRIVETIME = rarrtime
        therow.WORKDUR = rworkdu
        therow.EMPDEPT = rempdept
        therow.SALARY = rsal
        therow.EMPNOTE = rempnote
        Try
            frm_main.SalesDataSet.EMP.Rows.Add(therow)
        Catch
            MsgBox("EMPLOYEE ALREADY EXIST!")
        End Try
        updateemp()
    End Sub
    Public Shared Sub addclient(rclid As String, rclname As String, rclphone As String, rcldebt As Integer, rdebtdate As Date, rcladdress As String, rclnote As String)

        frm_main.CLIENTTableAdapter.Fill(frm_main.SalesDataSet.CLIENT)
        Dim therow As salesDataSet.CLIENTRow
        therow = frm_main.SalesDataSet.CLIENT.NewCLIENTRow()
        therow.CLID = rclid
        therow.CLNAME = rclname
        therow.CLPHONE = rclphone
        therow.DEPTVAL = rcldebt
        therow.DEPTDATE = rdebtdate
        therow.CLADDRESS = rcladdress
        therow.CLNOTE = rclnote
        Try
            frm_main.SalesDataSet.CLIENT.Rows.Add(therow)
        Catch
            MsgBox("CLIENT ALREADY EXIST!")
        End Try
        updateclient()
    End Sub

End Class
