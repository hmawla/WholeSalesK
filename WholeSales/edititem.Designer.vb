<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class edititem
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_sellprice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_origprice = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_qty = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_itemname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_barcode = New System.Windows.Forms.TextBox()
        Me.btn_check = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_update
        '
        Me.btn_update.Enabled = False
        Me.btn_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(176, 136)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 23)
        Me.btn_update.TabIndex = 7
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Sell Price:"
        '
        'txt_sellprice
        '
        Me.txt_sellprice.Enabled = False
        Me.txt_sellprice.Location = New System.Drawing.Point(73, 110)
        Me.txt_sellprice.Name = "txt_sellprice"
        Me.txt_sellprice.Size = New System.Drawing.Size(178, 20)
        Me.txt_sellprice.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Orig Price:"
        '
        'txt_origprice
        '
        Me.txt_origprice.Enabled = False
        Me.txt_origprice.Location = New System.Drawing.Point(73, 84)
        Me.txt_origprice.Name = "txt_origprice"
        Me.txt_origprice.Size = New System.Drawing.Size(178, 20)
        Me.txt_origprice.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Qty:"
        '
        'txt_qty
        '
        Me.txt_qty.Enabled = False
        Me.txt_qty.Location = New System.Drawing.Point(73, 58)
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Size = New System.Drawing.Size(178, 20)
        Me.txt_qty.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Item Name:"
        '
        'txt_itemname
        '
        Me.txt_itemname.Enabled = False
        Me.txt_itemname.Location = New System.Drawing.Point(73, 32)
        Me.txt_itemname.Name = "txt_itemname"
        Me.txt_itemname.Size = New System.Drawing.Size(178, 20)
        Me.txt_itemname.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Barcode:"
        '
        'txt_barcode
        '
        Me.txt_barcode.Location = New System.Drawing.Point(73, 6)
        Me.txt_barcode.Name = "txt_barcode"
        Me.txt_barcode.Size = New System.Drawing.Size(97, 20)
        Me.txt_barcode.TabIndex = 1
        '
        'btn_check
        '
        Me.btn_check.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_check.Location = New System.Drawing.Point(178, 4)
        Me.btn_check.Name = "btn_check"
        Me.btn_check.Size = New System.Drawing.Size(75, 23)
        Me.btn_check.TabIndex = 2
        Me.btn_check.Text = "Check"
        Me.btn_check.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Enabled = False
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(15, 136)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete.TabIndex = 8
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'edititem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(265, 177)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_check)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_sellprice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_origprice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_qty)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_itemname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_barcode)
        Me.Name = "edititem"
        Me.Text = "edititem"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_update As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_sellprice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_origprice As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_qty As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_itemname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_barcode As TextBox
    Friend WithEvents btn_check As Button
    Friend WithEvents btn_delete As Button
End Class
