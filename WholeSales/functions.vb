Public Class functions
    Public Shared Function checkbarcode(barcode As String)
        Try
            barcode = frm_main.SalesDataSet.ITEMS.FindByBARCODE(barcode).BARCODE
            Return 1
        Catch
            Return 0
        End Try
    End Function

    Public Shared Function checkempid(empid As String)
        Try
            empid = frm_main.SalesDataSet.EMP.FindByEMPID(empid).EMPID
            Return 1
        Catch
            Return 0
        End Try
    End Function

    Public Shared Function checkclientid(clientid As String)
        Try
            clientid = frm_main.SalesDataSet.CLIENT.FindByCLID(clientid).CLID
            Return 1
        Catch
            Return 0
        End Try
    End Function
End Class
