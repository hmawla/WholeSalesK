<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addclient
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_note = New System.Windows.Forms.TextBox()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_debt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_clphone = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_clname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_clid = New System.Windows.Forms.TextBox()
        Me.dp_debt = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 139)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Address:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "NOTE:"
        '
        'txt_note
        '
        Me.txt_note.Location = New System.Drawing.Point(80, 162)
        Me.txt_note.Multiline = True
        Me.txt_note.Name = "txt_note"
        Me.txt_note.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_note.Size = New System.Drawing.Size(171, 65)
        Me.txt_note.TabIndex = 7
        '
        'txt_address
        '
        Me.txt_address.Location = New System.Drawing.Point(80, 136)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(171, 20)
        Me.txt_address.TabIndex = 6
        '
        'btn_add
        '
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(176, 233)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 23)
        Me.btn_add.TabIndex = 8
        Me.btn_add.Text = "ADD"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "DebtDate:"
        '
        'txt_debt
        '
        Me.txt_debt.Location = New System.Drawing.Point(80, 84)
        Me.txt_debt.Name = "txt_debt"
        Me.txt_debt.Size = New System.Drawing.Size(171, 20)
        Me.txt_debt.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Debt:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "ClientPhone:"
        '
        'txt_clphone
        '
        Me.txt_clphone.Location = New System.Drawing.Point(80, 58)
        Me.txt_clphone.Name = "txt_clphone"
        Me.txt_clphone.Size = New System.Drawing.Size(171, 20)
        Me.txt_clphone.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "ClientName:"
        '
        'txt_clname
        '
        Me.txt_clname.Location = New System.Drawing.Point(80, 32)
        Me.txt_clname.Name = "txt_clname"
        Me.txt_clname.Size = New System.Drawing.Size(171, 20)
        Me.txt_clname.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "ClientID:"
        '
        'txt_clid
        '
        Me.txt_clid.Location = New System.Drawing.Point(80, 6)
        Me.txt_clid.Name = "txt_clid"
        Me.txt_clid.Size = New System.Drawing.Size(171, 20)
        Me.txt_clid.TabIndex = 1
        '
        'dp_debt
        '
        Me.dp_debt.CustomFormat = "dd/MM/yyyy hh:mm tt"
        Me.dp_debt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dp_debt.Location = New System.Drawing.Point(80, 110)
        Me.dp_debt.MaxDate = New Date(2040, 12, 31, 0, 0, 0, 0)
        Me.dp_debt.MinDate = New Date(2001, 1, 1, 0, 0, 0, 0)
        Me.dp_debt.Name = "dp_debt"
        Me.dp_debt.Size = New System.Drawing.Size(171, 20)
        Me.dp_debt.TabIndex = 5
        Me.dp_debt.Value = New Date(2017, 4, 16, 0, 0, 0, 0)
        '
        'addclient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(260, 263)
        Me.Controls.Add(Me.dp_debt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_note)
        Me.Controls.Add(Me.txt_address)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_debt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_clphone)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_clname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_clid)
        Me.Name = "addclient"
        Me.Text = "addclient"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_note As TextBox
    Friend WithEvents txt_address As TextBox
    Friend WithEvents btn_add As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_debt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_clphone As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_clname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_clid As TextBox
    Friend WithEvents dp_debt As DateTimePicker
End Class
