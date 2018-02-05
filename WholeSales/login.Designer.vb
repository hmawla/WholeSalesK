<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.CredintialsDataSet = New WholeSales.credintialsDataSet()
        Me.CredentialsTableAdapter = New WholeSales.credintialsDataSetTableAdapters.credentialsTableAdapter()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.btn_loginexec = New System.Windows.Forms.Button()
        CType(Me.CredintialsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CredintialsDataSet
        '
        Me.CredintialsDataSet.DataSetName = "credintialsDataSet"
        Me.CredintialsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CredentialsTableAdapter
        '
        Me.CredentialsTableAdapter.ClearBeforeFill = True
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(12, 12)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.txt_pass.Size = New System.Drawing.Size(100, 20)
        Me.txt_pass.TabIndex = 0
        '
        'btn_loginexec
        '
        Me.btn_loginexec.Location = New System.Drawing.Point(12, 38)
        Me.btn_loginexec.Name = "btn_loginexec"
        Me.btn_loginexec.Size = New System.Drawing.Size(100, 23)
        Me.btn_loginexec.TabIndex = 1
        Me.btn_loginexec.Text = "Login"
        Me.btn_loginexec.UseVisualStyleBackColor = True
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(130, 70)
        Me.Controls.Add(Me.btn_loginexec)
        Me.Controls.Add(Me.txt_pass)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "login"
        Me.Text = "Login"
        CType(Me.CredintialsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CredintialsDataSet As credintialsDataSet
    Friend WithEvents CredentialsTableAdapter As credintialsDataSetTableAdapters.credentialsTableAdapter
    Friend WithEvents txt_pass As TextBox
    Friend WithEvents btn_loginexec As Button
End Class
