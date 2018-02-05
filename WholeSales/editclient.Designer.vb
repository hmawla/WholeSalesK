<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editclient
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_check = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_clid = New System.Windows.Forms.TextBox()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.dp_debt = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_note = New System.Windows.Forms.TextBox()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_debt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_clphone = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_clname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_oldclid = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_check)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_clid)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(265, 39)
        Me.GroupBox1.TabIndex = 70
        Me.GroupBox1.TabStop = False
        '
        'btn_check
        '
        Me.btn_check.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_check.Location = New System.Drawing.Point(177, 10)
        Me.btn_check.Name = "btn_check"
        Me.btn_check.Size = New System.Drawing.Size(74, 23)
        Me.btn_check.TabIndex = 2
        Me.btn_check.Text = "CHECK"
        Me.btn_check.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "ClientID:"
        '
        'txt_clid
        '
        Me.txt_clid.Location = New System.Drawing.Point(80, 11)
        Me.txt_clid.Name = "txt_clid"
        Me.txt_clid.Size = New System.Drawing.Size(91, 20)
        Me.txt_clid.TabIndex = 1
        '
        'btn_delete
        '
        Me.btn_delete.Enabled = False
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(15, 272)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete.TabIndex = 61
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Enabled = False
        Me.btn_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.Location = New System.Drawing.Point(178, 272)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(75, 23)
        Me.btn_edit.TabIndex = 60
        Me.btn_edit.Text = "EDIT"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'dp_debt
        '
        Me.dp_debt.CustomFormat = "dd/MM/yyyy hh:mm tt"
        Me.dp_debt.Enabled = False
        Me.dp_debt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dp_debt.Location = New System.Drawing.Point(82, 149)
        Me.dp_debt.MaxDate = New Date(2040, 12, 31, 0, 0, 0, 0)
        Me.dp_debt.MinDate = New Date(2001, 1, 1, 0, 0, 0, 0)
        Me.dp_debt.Name = "dp_debt"
        Me.dp_debt.Size = New System.Drawing.Size(171, 20)
        Me.dp_debt.TabIndex = 75
        Me.dp_debt.Value = New Date(2017, 4, 16, 0, 0, 0, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 178)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 84
        Me.Label8.Text = "Address:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 204)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 83
        Me.Label7.Text = "NOTE:"
        '
        'txt_note
        '
        Me.txt_note.Enabled = False
        Me.txt_note.Location = New System.Drawing.Point(82, 201)
        Me.txt_note.Multiline = True
        Me.txt_note.Name = "txt_note"
        Me.txt_note.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_note.Size = New System.Drawing.Size(171, 65)
        Me.txt_note.TabIndex = 77
        '
        'txt_address
        '
        Me.txt_address.Enabled = False
        Me.txt_address.Location = New System.Drawing.Point(82, 175)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(171, 20)
        Me.txt_address.TabIndex = 76
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "DebtDate:"
        '
        'txt_debt
        '
        Me.txt_debt.Enabled = False
        Me.txt_debt.Location = New System.Drawing.Point(82, 123)
        Me.txt_debt.Name = "txt_debt"
        Me.txt_debt.Size = New System.Drawing.Size(171, 20)
        Me.txt_debt.TabIndex = 74
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Debt:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "ClientPhone:"
        '
        'txt_clphone
        '
        Me.txt_clphone.Enabled = False
        Me.txt_clphone.Location = New System.Drawing.Point(82, 97)
        Me.txt_clphone.Name = "txt_clphone"
        Me.txt_clphone.Size = New System.Drawing.Size(171, 20)
        Me.txt_clphone.TabIndex = 73
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "ClientName:"
        '
        'txt_clname
        '
        Me.txt_clname.Enabled = False
        Me.txt_clname.Location = New System.Drawing.Point(82, 71)
        Me.txt_clname.Name = "txt_clname"
        Me.txt_clname.Size = New System.Drawing.Size(171, 20)
        Me.txt_clname.TabIndex = 72
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "ClientID:"
        '
        'txt_oldclid
        '
        Me.txt_oldclid.Enabled = False
        Me.txt_oldclid.Location = New System.Drawing.Point(82, 45)
        Me.txt_oldclid.Name = "txt_oldclid"
        Me.txt_oldclid.Size = New System.Drawing.Size(171, 20)
        Me.txt_oldclid.TabIndex = 71
        '
        'editclient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(265, 305)
        Me.Controls.Add(Me.dp_debt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_note)
        Me.Controls.Add(Me.txt_address)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_debt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_clphone)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_clname)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_oldclid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_edit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "editclient"
        Me.Text = "editclient"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_check As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_clid As TextBox
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents dp_debt As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_note As TextBox
    Friend WithEvents txt_address As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_debt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_clphone As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_clname As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_oldclid As TextBox
End Class
