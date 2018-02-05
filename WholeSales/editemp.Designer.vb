<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editemp
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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_debt = New System.Windows.Forms.TextBox()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_note = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_sal = New System.Windows.Forms.TextBox()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_workdur = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_empphone = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_empname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_empid = New System.Windows.Forms.TextBox()
        Me.btn_check = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_oldempid = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker1.Location = New System.Drawing.Point(80, 123)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShowUpDown = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(171, 20)
        Me.DateTimePicker1.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 178)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Debt:"
        '
        'txt_debt
        '
        Me.txt_debt.Enabled = False
        Me.txt_debt.Location = New System.Drawing.Point(80, 175)
        Me.txt_debt.Name = "txt_debt"
        Me.txt_debt.Size = New System.Drawing.Size(171, 20)
        Me.txt_debt.TabIndex = 8
        '
        'btn_delete
        '
        Me.btn_delete.Enabled = False
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(12, 298)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete.TabIndex = 12
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 230)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "NOTE:"
        '
        'txt_note
        '
        Me.txt_note.Enabled = False
        Me.txt_note.Location = New System.Drawing.Point(80, 227)
        Me.txt_note.Multiline = True
        Me.txt_note.Name = "txt_note"
        Me.txt_note.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_note.Size = New System.Drawing.Size(171, 65)
        Me.txt_note.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Salary:"
        '
        'txt_sal
        '
        Me.txt_sal.Enabled = False
        Me.txt_sal.Location = New System.Drawing.Point(80, 201)
        Me.txt_sal.Name = "txt_sal"
        Me.txt_sal.Size = New System.Drawing.Size(171, 20)
        Me.txt_sal.TabIndex = 9
        '
        'btn_edit
        '
        Me.btn_edit.Enabled = False
        Me.btn_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.Location = New System.Drawing.Point(176, 298)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(75, 23)
        Me.btn_edit.TabIndex = 11
        Me.btn_edit.Text = "EDIT"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "WorkDur:"
        '
        'txt_workdur
        '
        Me.txt_workdur.Enabled = False
        Me.txt_workdur.Location = New System.Drawing.Point(80, 149)
        Me.txt_workdur.Name = "txt_workdur"
        Me.txt_workdur.Size = New System.Drawing.Size(171, 20)
        Me.txt_workdur.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "ArrTime:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "EmpPhone:"
        '
        'txt_empphone
        '
        Me.txt_empphone.Enabled = False
        Me.txt_empphone.Location = New System.Drawing.Point(80, 97)
        Me.txt_empphone.Name = "txt_empphone"
        Me.txt_empphone.Size = New System.Drawing.Size(171, 20)
        Me.txt_empphone.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "EmpName:"
        '
        'txt_empname
        '
        Me.txt_empname.Enabled = False
        Me.txt_empname.Location = New System.Drawing.Point(80, 71)
        Me.txt_empname.Name = "txt_empname"
        Me.txt_empname.Size = New System.Drawing.Size(171, 20)
        Me.txt_empname.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "EmpID:"
        '
        'txt_empid
        '
        Me.txt_empid.Location = New System.Drawing.Point(80, 11)
        Me.txt_empid.Name = "txt_empid"
        Me.txt_empid.Size = New System.Drawing.Size(91, 20)
        Me.txt_empid.TabIndex = 1
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "EmpID:"
        '
        'txt_oldempid
        '
        Me.txt_oldempid.Enabled = False
        Me.txt_oldempid.Location = New System.Drawing.Point(80, 45)
        Me.txt_oldempid.Name = "txt_oldempid"
        Me.txt_oldempid.Size = New System.Drawing.Size(171, 20)
        Me.txt_oldempid.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_check)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_empid)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(263, 39)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        '
        'editemp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(263, 331)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_oldempid)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_debt)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_note)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_sal)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_workdur)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_empphone)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_empname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "editemp"
        Me.Text = "0"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_debt As TextBox
    Friend WithEvents btn_delete As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_note As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_sal As TextBox
    Friend WithEvents btn_edit As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_workdur As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_empphone As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_empname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_empid As TextBox
    Friend WithEvents btn_check As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_oldempid As TextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
