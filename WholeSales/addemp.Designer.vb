<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addemp
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
        Me.btn_add = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_workdur = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_empphone = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_empname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_empid = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_sal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_note = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_debt = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'btn_add
        '
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(176, 259)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 23)
        Me.btn_add.TabIndex = 9
        Me.btn_add.Text = "ADD"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "WorkDur:"
        '
        'txt_workdur
        '
        Me.txt_workdur.Location = New System.Drawing.Point(80, 110)
        Me.txt_workdur.Name = "txt_workdur"
        Me.txt_workdur.Size = New System.Drawing.Size(171, 20)
        Me.txt_workdur.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "ArrTime:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "EmpPhone:"
        '
        'txt_empphone
        '
        Me.txt_empphone.Location = New System.Drawing.Point(80, 58)
        Me.txt_empphone.Name = "txt_empphone"
        Me.txt_empphone.Size = New System.Drawing.Size(171, 20)
        Me.txt_empphone.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "EmpName:"
        '
        'txt_empname
        '
        Me.txt_empname.Location = New System.Drawing.Point(80, 32)
        Me.txt_empname.Name = "txt_empname"
        Me.txt_empname.Size = New System.Drawing.Size(171, 20)
        Me.txt_empname.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "EmpID:"
        '
        'txt_empid
        '
        Me.txt_empid.Location = New System.Drawing.Point(80, 6)
        Me.txt_empid.Name = "txt_empid"
        Me.txt_empid.Size = New System.Drawing.Size(171, 20)
        Me.txt_empid.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Salary:"
        '
        'txt_sal
        '
        Me.txt_sal.Location = New System.Drawing.Point(80, 162)
        Me.txt_sal.Name = "txt_sal"
        Me.txt_sal.Size = New System.Drawing.Size(171, 20)
        Me.txt_sal.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 191)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "NOTE:"
        '
        'txt_note
        '
        Me.txt_note.Location = New System.Drawing.Point(80, 188)
        Me.txt_note.Multiline = True
        Me.txt_note.Name = "txt_note"
        Me.txt_note.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_note.Size = New System.Drawing.Size(171, 65)
        Me.txt_note.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 139)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Debt:"
        '
        'txt_debt
        '
        Me.txt_debt.Location = New System.Drawing.Point(80, 136)
        Me.txt_debt.Name = "txt_debt"
        Me.txt_debt.Size = New System.Drawing.Size(171, 20)
        Me.txt_debt.TabIndex = 6
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker1.Location = New System.Drawing.Point(80, 84)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShowUpDown = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(171, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'addemp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(264, 296)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_debt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_note)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_sal)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_workdur)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_empphone)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_empname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_empid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "addemp"
        Me.Text = "addemp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_add As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_workdur As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_empphone As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_empname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_empid As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_sal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_note As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_debt As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
