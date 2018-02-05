<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Searcher
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
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Barcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMQTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMORIGPRICE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMSELLPRICE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMADDEDDATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaterialTabControl1
        '
        Me.MaterialTabControl1.Controls.Add(Me.TabPage1)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage2)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(622, 462)
        Me.MaterialTabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(614, 436)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(545, 470)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Barcode, Me.ITEMNAME, Me.ITEMQTY, Me.ITEMORIGPRICE, Me.ITEMSELLPRICE, Me.ITEMADDEDDATE})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(608, 430)
        Me.DataGridView1.TabIndex = 2
        '
        'Barcode
        '
        Me.Barcode.HeaderText = "Barcode"
        Me.Barcode.Name = "Barcode"
        Me.Barcode.ReadOnly = True
        '
        'ITEMNAME
        '
        Me.ITEMNAME.HeaderText = "Item Name"
        Me.ITEMNAME.Name = "ITEMNAME"
        Me.ITEMNAME.ReadOnly = True
        '
        'ITEMQTY
        '
        Me.ITEMQTY.HeaderText = "Qty"
        Me.ITEMQTY.Name = "ITEMQTY"
        Me.ITEMQTY.ReadOnly = True
        '
        'ITEMORIGPRICE
        '
        Me.ITEMORIGPRICE.HeaderText = "Original Price"
        Me.ITEMORIGPRICE.Name = "ITEMORIGPRICE"
        Me.ITEMORIGPRICE.ReadOnly = True
        '
        'ITEMSELLPRICE
        '
        Me.ITEMSELLPRICE.HeaderText = "Sell Price"
        Me.ITEMSELLPRICE.Name = "ITEMSELLPRICE"
        Me.ITEMSELLPRICE.ReadOnly = True
        '
        'ITEMADDEDDATE
        '
        Me.ITEMADDEDDATE.HeaderText = "Added Date"
        Me.ITEMADDEDDATE.Name = "ITEMADDEDDATE"
        Me.ITEMADDEDDATE.ReadOnly = True
        '
        'Searcher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 462)
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.Name = "Searcher"
        Me.Text = "Searcher"
        Me.MaterialTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Barcode As DataGridViewTextBoxColumn
    Friend WithEvents ITEMNAME As DataGridViewTextBoxColumn
    Friend WithEvents ITEMQTY As DataGridViewTextBoxColumn
    Friend WithEvents ITEMORIGPRICE As DataGridViewTextBoxColumn
    Friend WithEvents ITEMSELLPRICE As DataGridViewTextBoxColumn
    Friend WithEvents ITEMADDEDDATE As DataGridViewTextBoxColumn
End Class
