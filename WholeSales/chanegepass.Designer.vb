<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class chanegepass
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
        Me.txt_oldpass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_newpass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_repnewpass = New System.Windows.Forms.TextBox()
        Me.btn_passexec = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_oldpass
        '
        Me.txt_oldpass.Location = New System.Drawing.Point(93, 6)
        Me.txt_oldpass.Name = "txt_oldpass"
        Me.txt_oldpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.txt_oldpass.Size = New System.Drawing.Size(117, 20)
        Me.txt_oldpass.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Old Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "New Password:"
        '
        'txt_newpass
        '
        Me.txt_newpass.Location = New System.Drawing.Point(93, 32)
        Me.txt_newpass.Name = "txt_newpass"
        Me.txt_newpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.txt_newpass.Size = New System.Drawing.Size(117, 20)
        Me.txt_newpass.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Repeat New:"
        '
        'txt_repnewpass
        '
        Me.txt_repnewpass.Location = New System.Drawing.Point(93, 58)
        Me.txt_repnewpass.Name = "txt_repnewpass"
        Me.txt_repnewpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.txt_repnewpass.Size = New System.Drawing.Size(117, 20)
        Me.txt_repnewpass.TabIndex = 4
        '
        'btn_passexec
        '
        Me.btn_passexec.Location = New System.Drawing.Point(93, 84)
        Me.btn_passexec.Name = "btn_passexec"
        Me.btn_passexec.Size = New System.Drawing.Size(117, 23)
        Me.btn_passexec.TabIndex = 6
        Me.btn_passexec.Text = "Change Pass"
        Me.btn_passexec.UseVisualStyleBackColor = True
        '
        'chanegepass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(231, 113)
        Me.Controls.Add(Me.btn_passexec)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_repnewpass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_newpass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_oldpass)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "chanegepass"
        Me.Text = "chanegepass"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_oldpass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_newpass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_repnewpass As TextBox
    Friend WithEvents btn_passexec As Button
End Class
