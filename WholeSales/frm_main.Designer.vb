<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DEVEOPERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangepassToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tab_attendance = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbl_sellname = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_sellexec = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_sellprice = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_sellqty = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_sellbarcode = New System.Windows.Forms.TextBox()
        Me.dgv_att = New System.Windows.Forms.DataGridView()
        Me.INAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.selltime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tab_items = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_editem = New System.Windows.Forms.Button()
        Me.btn_additem = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BARCODEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMQTYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMORIGPRICEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMSELLPRICEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMADDEDDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesDataSet = New WholeSales.salesDataSet()
        Me.tab_clients = New System.Windows.Forms.TabPage()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.RadioButton13 = New System.Windows.Forms.RadioButton()
        Me.RadioButton14 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.RadioButton15 = New System.Windows.Forms.RadioButton()
        Me.RadioButton16 = New System.Windows.Forms.RadioButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.btn_editcl = New System.Windows.Forms.Button()
        Me.btn_addcl = New System.Windows.Forms.Button()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.CLIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLPHONEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEPTVALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEPTDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLADDRESSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLNOTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tab_emp = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btn_editemp = New System.Windows.Forms.Button()
        Me.btn_addemp = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.EMPIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPPHONEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARRIVETIMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WORKDURDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPDEPTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SALARYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPNOTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ITEMSTableAdapter = New WholeSales.salesDataSetTableAdapters.ITEMSTableAdapter()
        Me.CLIENTTableAdapter = New WholeSales.salesDataSetTableAdapters.CLIENTTableAdapter()
        Me.EMPTableAdapter = New WholeSales.salesDataSetTableAdapters.EMPTableAdapter()
        Me.notify_stock = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tab_attendance.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv_att, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_items.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ITEMSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_clients.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_emp.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.LoginToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DEVEOPERToolStripMenuItem, Me.ChangepassToolStripMenuItem})
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'DEVEOPERToolStripMenuItem
        '
        Me.DEVEOPERToolStripMenuItem.Name = "DEVEOPERToolStripMenuItem"
        Me.DEVEOPERToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.DEVEOPERToolStripMenuItem.Text = "DEVEOPER"
        '
        'ChangepassToolStripMenuItem
        '
        Me.ChangepassToolStripMenuItem.Name = "ChangepassToolStripMenuItem"
        Me.ChangepassToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ChangepassToolStripMenuItem.Text = "Change Password"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tab_attendance)
        Me.TabControl1.Controls.Add(Me.tab_items)
        Me.TabControl1.Controls.Add(Me.tab_clients)
        Me.TabControl1.Controls.Add(Me.tab_emp)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(784, 537)
        Me.TabControl1.TabIndex = 1
        '
        'tab_attendance
        '
        Me.tab_attendance.Controls.Add(Me.GroupBox3)
        Me.tab_attendance.Controls.Add(Me.dgv_att)
        Me.tab_attendance.Location = New System.Drawing.Point(4, 22)
        Me.tab_attendance.Name = "tab_attendance"
        Me.tab_attendance.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_attendance.Size = New System.Drawing.Size(776, 511)
        Me.tab_attendance.TabIndex = 0
        Me.tab_attendance.Text = "Sell"
        Me.tab_attendance.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lbl_sellname)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.btn_sellexec)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txt_sellprice)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txt_sellqty)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txt_sellbarcode)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(770, 95)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SELL"
        '
        'lbl_sellname
        '
        Me.lbl_sellname.AutoSize = True
        Me.lbl_sellname.Location = New System.Drawing.Point(73, 63)
        Me.lbl_sellname.Name = "lbl_sellname"
        Me.lbl_sellname.Size = New System.Drawing.Size(27, 13)
        Me.lbl_sellname.TabIndex = 10
        Me.lbl_sellname.Text = "N/A"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 63)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Item Name:"
        '
        'btn_sellexec
        '
        Me.btn_sellexec.Enabled = False
        Me.btn_sellexec.Location = New System.Drawing.Point(271, 38)
        Me.btn_sellexec.Name = "btn_sellexec"
        Me.btn_sellexec.Size = New System.Drawing.Size(75, 23)
        Me.btn_sellexec.TabIndex = 3
        Me.btn_sellexec.Text = "SELL"
        Me.btn_sellexec.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(157, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Price"
        '
        'txt_sellprice
        '
        Me.txt_sellprice.Location = New System.Drawing.Point(157, 40)
        Me.txt_sellprice.Name = "txt_sellprice"
        Me.txt_sellprice.ReadOnly = True
        Me.txt_sellprice.Size = New System.Drawing.Size(108, 20)
        Me.txt_sellprice.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(120, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "QTY"
        '
        'txt_sellqty
        '
        Me.txt_sellqty.Location = New System.Drawing.Point(120, 40)
        Me.txt_sellqty.Name = "txt_sellqty"
        Me.txt_sellqty.Size = New System.Drawing.Size(31, 20)
        Me.txt_sellqty.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Barcode"
        '
        'txt_sellbarcode
        '
        Me.txt_sellbarcode.Location = New System.Drawing.Point(6, 40)
        Me.txt_sellbarcode.Name = "txt_sellbarcode"
        Me.txt_sellbarcode.Size = New System.Drawing.Size(108, 20)
        Me.txt_sellbarcode.TabIndex = 1
        '
        'dgv_att
        '
        Me.dgv_att.AllowUserToAddRows = False
        Me.dgv_att.AllowUserToDeleteRows = False
        Me.dgv_att.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_att.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_att.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_att.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.INAME, Me.QTY, Me.price, Me.selltime})
        Me.dgv_att.Location = New System.Drawing.Point(3, 104)
        Me.dgv_att.Name = "dgv_att"
        Me.dgv_att.ReadOnly = True
        Me.dgv_att.RowHeadersVisible = False
        Me.dgv_att.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgv_att.Size = New System.Drawing.Size(770, 404)
        Me.dgv_att.TabIndex = 0
        '
        'INAME
        '
        Me.INAME.FillWeight = 120.0!
        Me.INAME.HeaderText = "Item Name"
        Me.INAME.Name = "INAME"
        Me.INAME.ReadOnly = True
        '
        'QTY
        '
        Me.QTY.FillWeight = 20.0!
        Me.QTY.HeaderText = "Qty"
        Me.QTY.Name = "QTY"
        Me.QTY.ReadOnly = True
        '
        'price
        '
        Me.price.FillWeight = 80.0!
        Me.price.HeaderText = "Sell Price"
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        '
        'selltime
        '
        Me.selltime.FillWeight = 51.21859!
        Me.selltime.HeaderText = "Time"
        Me.selltime.Name = "selltime"
        Me.selltime.ReadOnly = True
        '
        'tab_items
        '
        Me.tab_items.Controls.Add(Me.GroupBox2)
        Me.tab_items.Controls.Add(Me.GroupBox1)
        Me.tab_items.Controls.Add(Me.DataGridView1)
        Me.tab_items.Location = New System.Drawing.Point(4, 22)
        Me.tab_items.Name = "tab_items"
        Me.tab_items.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_items.Size = New System.Drawing.Size(776, 511)
        Me.tab_items.TabIndex = 1
        Me.tab_items.Text = "Items"
        Me.tab_items.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.RadioButton3)
        Me.GroupBox2.Controls.Add(Me.RadioButton4)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Location = New System.Drawing.Point(214, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(556, 117)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Enabled = False
        Me.RadioButton3.Location = New System.Drawing.Point(220, 35)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton3.TabIndex = 15
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Enabled = False
        Me.RadioButton4.Location = New System.Drawing.Point(220, 73)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton4.TabIndex = 14
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(237, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Added Date"
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(240, 70)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(188, 20)
        Me.TextBox4.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(237, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Sell Price"
        '
        'TextBox5
        '
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(240, 32)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(188, 20)
        Me.TextBox5.TabIndex = 10
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 35)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton1.TabIndex = 9
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Enabled = False
        Me.RadioButton2.Location = New System.Drawing.Point(6, 73)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton2.TabIndex = 8
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Item Name"
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(26, 70)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(188, 20)
        Me.TextBox3.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "BARCODE"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(26, 32)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(188, 20)
        Me.TextBox2.TabIndex = 3
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(434, 30)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 60)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "SEARCH"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_editem)
        Me.GroupBox1.Controls.Add(Me.btn_additem)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 117)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Manage"
        '
        'btn_editem
        '
        Me.btn_editem.Location = New System.Drawing.Point(6, 48)
        Me.btn_editem.Name = "btn_editem"
        Me.btn_editem.Size = New System.Drawing.Size(75, 23)
        Me.btn_editem.TabIndex = 2
        Me.btn_editem.Text = "Edit Item"
        Me.btn_editem.UseVisualStyleBackColor = True
        '
        'btn_additem
        '
        Me.btn_additem.Location = New System.Drawing.Point(6, 19)
        Me.btn_additem.Name = "btn_additem"
        Me.btn_additem.Size = New System.Drawing.Size(75, 23)
        Me.btn_additem.TabIndex = 2
        Me.btn_additem.Text = "Add Item"
        Me.btn_additem.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BARCODEDataGridViewTextBoxColumn, Me.ITEMNAMEDataGridViewTextBoxColumn, Me.ITEMQTYDataGridViewTextBoxColumn, Me.ITEMORIGPRICEDataGridViewTextBoxColumn, Me.ITEMSELLPRICEDataGridViewTextBoxColumn, Me.ITEMADDEDDATEDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ITEMSBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(3, 129)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(770, 379)
        Me.DataGridView1.TabIndex = 1
        '
        'BARCODEDataGridViewTextBoxColumn
        '
        Me.BARCODEDataGridViewTextBoxColumn.DataPropertyName = "BARCODE"
        Me.BARCODEDataGridViewTextBoxColumn.FillWeight = 114.5178!
        Me.BARCODEDataGridViewTextBoxColumn.HeaderText = "Barcode"
        Me.BARCODEDataGridViewTextBoxColumn.Name = "BARCODEDataGridViewTextBoxColumn"
        Me.BARCODEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ITEMNAMEDataGridViewTextBoxColumn
        '
        Me.ITEMNAMEDataGridViewTextBoxColumn.DataPropertyName = "ITEMNAME"
        Me.ITEMNAMEDataGridViewTextBoxColumn.FillWeight = 114.5178!
        Me.ITEMNAMEDataGridViewTextBoxColumn.HeaderText = "Item Name"
        Me.ITEMNAMEDataGridViewTextBoxColumn.Name = "ITEMNAMEDataGridViewTextBoxColumn"
        Me.ITEMNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ITEMQTYDataGridViewTextBoxColumn
        '
        Me.ITEMQTYDataGridViewTextBoxColumn.DataPropertyName = "ITEMQTY"
        Me.ITEMQTYDataGridViewTextBoxColumn.FillWeight = 27.41117!
        Me.ITEMQTYDataGridViewTextBoxColumn.HeaderText = "Qty"
        Me.ITEMQTYDataGridViewTextBoxColumn.Name = "ITEMQTYDataGridViewTextBoxColumn"
        Me.ITEMQTYDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ITEMORIGPRICEDataGridViewTextBoxColumn
        '
        Me.ITEMORIGPRICEDataGridViewTextBoxColumn.DataPropertyName = "ITEMORIGPRICE"
        Me.ITEMORIGPRICEDataGridViewTextBoxColumn.FillWeight = 114.5178!
        Me.ITEMORIGPRICEDataGridViewTextBoxColumn.HeaderText = "Original Price"
        Me.ITEMORIGPRICEDataGridViewTextBoxColumn.Name = "ITEMORIGPRICEDataGridViewTextBoxColumn"
        Me.ITEMORIGPRICEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ITEMSELLPRICEDataGridViewTextBoxColumn
        '
        Me.ITEMSELLPRICEDataGridViewTextBoxColumn.DataPropertyName = "ITEMSELLPRICE"
        Me.ITEMSELLPRICEDataGridViewTextBoxColumn.FillWeight = 114.5178!
        Me.ITEMSELLPRICEDataGridViewTextBoxColumn.HeaderText = "Sell Price"
        Me.ITEMSELLPRICEDataGridViewTextBoxColumn.Name = "ITEMSELLPRICEDataGridViewTextBoxColumn"
        Me.ITEMSELLPRICEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ITEMADDEDDATEDataGridViewTextBoxColumn
        '
        Me.ITEMADDEDDATEDataGridViewTextBoxColumn.DataPropertyName = "ITEMADDEDDATE"
        Me.ITEMADDEDDATEDataGridViewTextBoxColumn.FillWeight = 114.5178!
        Me.ITEMADDEDDATEDataGridViewTextBoxColumn.HeaderText = "Added Date"
        Me.ITEMADDEDDATEDataGridViewTextBoxColumn.Name = "ITEMADDEDDATEDataGridViewTextBoxColumn"
        Me.ITEMADDEDDATEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ITEMSBindingSource
        '
        Me.ITEMSBindingSource.DataMember = "ITEMS"
        Me.ITEMSBindingSource.DataSource = Me.SalesDataSet
        '
        'SalesDataSet
        '
        Me.SalesDataSet.DataSetName = "salesDataSet"
        Me.SalesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tab_clients
        '
        Me.tab_clients.Controls.Add(Me.GroupBox10)
        Me.tab_clients.Controls.Add(Me.GroupBox11)
        Me.tab_clients.Controls.Add(Me.DataGridView4)
        Me.tab_clients.Location = New System.Drawing.Point(4, 22)
        Me.tab_clients.Name = "tab_clients"
        Me.tab_clients.Size = New System.Drawing.Size(776, 511)
        Me.tab_clients.TabIndex = 2
        Me.tab_clients.Text = "Clients"
        Me.tab_clients.UseVisualStyleBackColor = True
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.RadioButton13)
        Me.GroupBox10.Controls.Add(Me.RadioButton14)
        Me.GroupBox10.Controls.Add(Me.Label1)
        Me.GroupBox10.Controls.Add(Me.TextBox1)
        Me.GroupBox10.Controls.Add(Me.Label14)
        Me.GroupBox10.Controls.Add(Me.TextBox10)
        Me.GroupBox10.Controls.Add(Me.RadioButton15)
        Me.GroupBox10.Controls.Add(Me.RadioButton16)
        Me.GroupBox10.Controls.Add(Me.Label15)
        Me.GroupBox10.Controls.Add(Me.TextBox11)
        Me.GroupBox10.Controls.Add(Me.Label16)
        Me.GroupBox10.Controls.Add(Me.TextBox12)
        Me.GroupBox10.Controls.Add(Me.Button2)
        Me.GroupBox10.Location = New System.Drawing.Point(212, 1)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(556, 117)
        Me.GroupBox10.TabIndex = 10
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Search"
        '
        'RadioButton13
        '
        Me.RadioButton13.AutoSize = True
        Me.RadioButton13.Enabled = False
        Me.RadioButton13.Location = New System.Drawing.Point(220, 35)
        Me.RadioButton13.Name = "RadioButton13"
        Me.RadioButton13.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton13.TabIndex = 15
        Me.RadioButton13.UseVisualStyleBackColor = True
        '
        'RadioButton14
        '
        Me.RadioButton14.AutoSize = True
        Me.RadioButton14.Enabled = False
        Me.RadioButton14.Location = New System.Drawing.Point(220, 73)
        Me.RadioButton14.Name = "RadioButton14"
        Me.RadioButton14.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton14.TabIndex = 14
        Me.RadioButton14.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(237, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Client Phone"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(240, 70)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(188, 20)
        Me.TextBox1.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(237, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 13)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Client Debt"
        '
        'TextBox10
        '
        Me.TextBox10.Enabled = False
        Me.TextBox10.Location = New System.Drawing.Point(240, 32)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(188, 20)
        Me.TextBox10.TabIndex = 10
        '
        'RadioButton15
        '
        Me.RadioButton15.AutoSize = True
        Me.RadioButton15.Checked = True
        Me.RadioButton15.Location = New System.Drawing.Point(6, 35)
        Me.RadioButton15.Name = "RadioButton15"
        Me.RadioButton15.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton15.TabIndex = 9
        Me.RadioButton15.TabStop = True
        Me.RadioButton15.UseVisualStyleBackColor = True
        '
        'RadioButton16
        '
        Me.RadioButton16.AutoSize = True
        Me.RadioButton16.Enabled = False
        Me.RadioButton16.Location = New System.Drawing.Point(6, 73)
        Me.RadioButton16.Name = "RadioButton16"
        Me.RadioButton16.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton16.TabIndex = 8
        Me.RadioButton16.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(23, 55)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 13)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Client Name"
        '
        'TextBox11
        '
        Me.TextBox11.Enabled = False
        Me.TextBox11.Location = New System.Drawing.Point(26, 70)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(188, 20)
        Me.TextBox11.TabIndex = 5
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(23, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 13)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Client ID"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(26, 32)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(188, 20)
        Me.TextBox12.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(434, 30)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 60)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "SEARCH"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.btn_editcl)
        Me.GroupBox11.Controls.Add(Me.btn_addcl)
        Me.GroupBox11.Location = New System.Drawing.Point(6, 1)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(200, 117)
        Me.GroupBox11.TabIndex = 9
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Manage"
        '
        'btn_editcl
        '
        Me.btn_editcl.Location = New System.Drawing.Point(6, 48)
        Me.btn_editcl.Name = "btn_editcl"
        Me.btn_editcl.Size = New System.Drawing.Size(75, 23)
        Me.btn_editcl.TabIndex = 2
        Me.btn_editcl.Text = "Edit Client"
        Me.btn_editcl.UseVisualStyleBackColor = True
        '
        'btn_addcl
        '
        Me.btn_addcl.Location = New System.Drawing.Point(6, 19)
        Me.btn_addcl.Name = "btn_addcl"
        Me.btn_addcl.Size = New System.Drawing.Size(75, 23)
        Me.btn_addcl.TabIndex = 2
        Me.btn_addcl.Text = "Add Client"
        Me.btn_addcl.UseVisualStyleBackColor = True
        '
        'DataGridView4
        '
        Me.DataGridView4.AllowUserToAddRows = False
        Me.DataGridView4.AllowUserToDeleteRows = False
        Me.DataGridView4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView4.AutoGenerateColumns = False
        Me.DataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CLIDDataGridViewTextBoxColumn, Me.CLNAMEDataGridViewTextBoxColumn, Me.CLPHONEDataGridViewTextBoxColumn, Me.DEPTVALDataGridViewTextBoxColumn, Me.DEPTDATEDataGridViewTextBoxColumn, Me.CLADDRESSDataGridViewTextBoxColumn, Me.CLNOTEDataGridViewTextBoxColumn})
        Me.DataGridView4.DataSource = Me.CLIENTBindingSource
        Me.DataGridView4.Location = New System.Drawing.Point(0, 124)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.ReadOnly = True
        Me.DataGridView4.RowHeadersVisible = False
        Me.DataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView4.Size = New System.Drawing.Size(776, 385)
        Me.DataGridView4.TabIndex = 8
        '
        'CLIDDataGridViewTextBoxColumn
        '
        Me.CLIDDataGridViewTextBoxColumn.DataPropertyName = "CLID"
        Me.CLIDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.CLIDDataGridViewTextBoxColumn.Name = "CLIDDataGridViewTextBoxColumn"
        Me.CLIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CLNAMEDataGridViewTextBoxColumn
        '
        Me.CLNAMEDataGridViewTextBoxColumn.DataPropertyName = "CLNAME"
        Me.CLNAMEDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.CLNAMEDataGridViewTextBoxColumn.Name = "CLNAMEDataGridViewTextBoxColumn"
        Me.CLNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CLPHONEDataGridViewTextBoxColumn
        '
        Me.CLPHONEDataGridViewTextBoxColumn.DataPropertyName = "CLPHONE"
        Me.CLPHONEDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.CLPHONEDataGridViewTextBoxColumn.Name = "CLPHONEDataGridViewTextBoxColumn"
        Me.CLPHONEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DEPTVALDataGridViewTextBoxColumn
        '
        Me.DEPTVALDataGridViewTextBoxColumn.DataPropertyName = "DEPTVAL"
        Me.DEPTVALDataGridViewTextBoxColumn.HeaderText = "Debt"
        Me.DEPTVALDataGridViewTextBoxColumn.Name = "DEPTVALDataGridViewTextBoxColumn"
        Me.DEPTVALDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DEPTDATEDataGridViewTextBoxColumn
        '
        Me.DEPTDATEDataGridViewTextBoxColumn.DataPropertyName = "DEPTDATE"
        Me.DEPTDATEDataGridViewTextBoxColumn.HeaderText = "Debt Date"
        Me.DEPTDATEDataGridViewTextBoxColumn.Name = "DEPTDATEDataGridViewTextBoxColumn"
        Me.DEPTDATEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CLADDRESSDataGridViewTextBoxColumn
        '
        Me.CLADDRESSDataGridViewTextBoxColumn.DataPropertyName = "CLADDRESS"
        Me.CLADDRESSDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.CLADDRESSDataGridViewTextBoxColumn.Name = "CLADDRESSDataGridViewTextBoxColumn"
        Me.CLADDRESSDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CLNOTEDataGridViewTextBoxColumn
        '
        Me.CLNOTEDataGridViewTextBoxColumn.DataPropertyName = "CLNOTE"
        Me.CLNOTEDataGridViewTextBoxColumn.HeaderText = "NOTE"
        Me.CLNOTEDataGridViewTextBoxColumn.Name = "CLNOTEDataGridViewTextBoxColumn"
        Me.CLNOTEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CLIENTBindingSource
        '
        Me.CLIENTBindingSource.DataMember = "CLIENT"
        Me.CLIENTBindingSource.DataSource = Me.SalesDataSet
        '
        'tab_emp
        '
        Me.tab_emp.Controls.Add(Me.GroupBox4)
        Me.tab_emp.Controls.Add(Me.GroupBox5)
        Me.tab_emp.Controls.Add(Me.DataGridView2)
        Me.tab_emp.Location = New System.Drawing.Point(4, 22)
        Me.tab_emp.Name = "tab_emp"
        Me.tab_emp.Size = New System.Drawing.Size(776, 511)
        Me.tab_emp.TabIndex = 4
        Me.tab_emp.Text = "Employees"
        Me.tab_emp.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RadioButton5)
        Me.GroupBox4.Controls.Add(Me.RadioButton6)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.TextBox6)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.TextBox7)
        Me.GroupBox4.Controls.Add(Me.RadioButton7)
        Me.GroupBox4.Controls.Add(Me.RadioButton8)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.TextBox8)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.TextBox9)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Location = New System.Drawing.Point(212, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(556, 117)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Search"
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Enabled = False
        Me.RadioButton5.Location = New System.Drawing.Point(220, 35)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton5.TabIndex = 15
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Enabled = False
        Me.RadioButton6.Location = New System.Drawing.Point(220, 73)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton6.TabIndex = 14
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(237, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Work Duration"
        '
        'TextBox6
        '
        Me.TextBox6.Enabled = False
        Me.TextBox6.Location = New System.Drawing.Point(240, 70)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(188, 20)
        Me.TextBox6.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(237, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Employee Debt"
        '
        'TextBox7
        '
        Me.TextBox7.Enabled = False
        Me.TextBox7.Location = New System.Drawing.Point(240, 32)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(188, 20)
        Me.TextBox7.TabIndex = 10
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Checked = True
        Me.RadioButton7.Location = New System.Drawing.Point(6, 35)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton7.TabIndex = 9
        Me.RadioButton7.TabStop = True
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.Enabled = False
        Me.RadioButton8.Location = New System.Drawing.Point(6, 73)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton8.TabIndex = 8
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(23, 55)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 13)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Employee Name"
        '
        'TextBox8
        '
        Me.TextBox8.Enabled = False
        Me.TextBox8.Location = New System.Drawing.Point(26, 70)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(188, 20)
        Me.TextBox8.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(23, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 13)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Employee ID"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(26, 32)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(188, 20)
        Me.TextBox9.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(434, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 60)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "SEARCH"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btn_editemp)
        Me.GroupBox5.Controls.Add(Me.btn_addemp)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(200, 117)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Manage"
        '
        'btn_editemp
        '
        Me.btn_editemp.Location = New System.Drawing.Point(6, 48)
        Me.btn_editemp.Name = "btn_editemp"
        Me.btn_editemp.Size = New System.Drawing.Size(75, 23)
        Me.btn_editemp.TabIndex = 2
        Me.btn_editemp.Text = "Edit Emp"
        Me.btn_editemp.UseVisualStyleBackColor = True
        '
        'btn_addemp
        '
        Me.btn_addemp.Location = New System.Drawing.Point(6, 19)
        Me.btn_addemp.Name = "btn_addemp"
        Me.btn_addemp.Size = New System.Drawing.Size(75, 23)
        Me.btn_addemp.TabIndex = 2
        Me.btn_addemp.Text = "Add Emp"
        Me.btn_addemp.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EMPIDDataGridViewTextBoxColumn, Me.EMPNAMEDataGridViewTextBoxColumn, Me.EMPPHONEDataGridViewTextBoxColumn, Me.ARRIVETIMEDataGridViewTextBoxColumn, Me.WORKDURDataGridViewTextBoxColumn, Me.EMPDEPTDataGridViewTextBoxColumn, Me.SALARYDataGridViewTextBoxColumn, Me.EMPNOTEDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.EMPBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(0, 126)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView2.Size = New System.Drawing.Size(776, 385)
        Me.DataGridView2.TabIndex = 2
        '
        'EMPIDDataGridViewTextBoxColumn
        '
        Me.EMPIDDataGridViewTextBoxColumn.DataPropertyName = "EMPID"
        Me.EMPIDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.EMPIDDataGridViewTextBoxColumn.Name = "EMPIDDataGridViewTextBoxColumn"
        Me.EMPIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EMPNAMEDataGridViewTextBoxColumn
        '
        Me.EMPNAMEDataGridViewTextBoxColumn.DataPropertyName = "EMPNAME"
        Me.EMPNAMEDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.EMPNAMEDataGridViewTextBoxColumn.Name = "EMPNAMEDataGridViewTextBoxColumn"
        Me.EMPNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EMPPHONEDataGridViewTextBoxColumn
        '
        Me.EMPPHONEDataGridViewTextBoxColumn.DataPropertyName = "EMPPHONE"
        Me.EMPPHONEDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.EMPPHONEDataGridViewTextBoxColumn.Name = "EMPPHONEDataGridViewTextBoxColumn"
        Me.EMPPHONEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ARRIVETIMEDataGridViewTextBoxColumn
        '
        Me.ARRIVETIMEDataGridViewTextBoxColumn.DataPropertyName = "ARRIVETIME"
        Me.ARRIVETIMEDataGridViewTextBoxColumn.HeaderText = "Arrive Time"
        Me.ARRIVETIMEDataGridViewTextBoxColumn.Name = "ARRIVETIMEDataGridViewTextBoxColumn"
        Me.ARRIVETIMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WORKDURDataGridViewTextBoxColumn
        '
        Me.WORKDURDataGridViewTextBoxColumn.DataPropertyName = "WORKDUR"
        Me.WORKDURDataGridViewTextBoxColumn.HeaderText = "Work Duration"
        Me.WORKDURDataGridViewTextBoxColumn.Name = "WORKDURDataGridViewTextBoxColumn"
        Me.WORKDURDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EMPDEPTDataGridViewTextBoxColumn
        '
        Me.EMPDEPTDataGridViewTextBoxColumn.DataPropertyName = "EMPDEPT"
        Me.EMPDEPTDataGridViewTextBoxColumn.HeaderText = "Debt"
        Me.EMPDEPTDataGridViewTextBoxColumn.Name = "EMPDEPTDataGridViewTextBoxColumn"
        Me.EMPDEPTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SALARYDataGridViewTextBoxColumn
        '
        Me.SALARYDataGridViewTextBoxColumn.DataPropertyName = "SALARY"
        Me.SALARYDataGridViewTextBoxColumn.HeaderText = "Salary"
        Me.SALARYDataGridViewTextBoxColumn.Name = "SALARYDataGridViewTextBoxColumn"
        Me.SALARYDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EMPNOTEDataGridViewTextBoxColumn
        '
        Me.EMPNOTEDataGridViewTextBoxColumn.DataPropertyName = "EMPNOTE"
        Me.EMPNOTEDataGridViewTextBoxColumn.HeaderText = "NOTE"
        Me.EMPNOTEDataGridViewTextBoxColumn.Name = "EMPNOTEDataGridViewTextBoxColumn"
        Me.EMPNOTEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EMPBindingSource
        '
        Me.EMPBindingSource.DataMember = "EMP"
        Me.EMPBindingSource.DataSource = Me.SalesDataSet
        '
        'ITEMSTableAdapter
        '
        Me.ITEMSTableAdapter.ClearBeforeFill = True
        '
        'CLIENTTableAdapter
        '
        Me.CLIENTTableAdapter.ClearBeforeFill = True
        '
        'EMPTableAdapter
        '
        Me.EMPTableAdapter.ClearBeforeFill = True
        '
        'notify_stock
        '
        Me.notify_stock.Icon = CType(resources.GetObject("notify_stock.Icon"), System.Drawing.Icon)
        Me.notify_stock.Text = "Notifyy"
        Me.notify_stock.Visible = True
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frm_main"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tab_attendance.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgv_att, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_items.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ITEMSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_clients.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_emp.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tab_attendance As TabPage
    Friend WithEvents tab_items As TabPage
    Friend WithEvents tab_clients As TabPage
    Friend WithEvents dgv_att As DataGridView
    Friend WithEvents tab_emp As TabPage
    Friend WithEvents SalesDataSet As salesDataSet
    Friend WithEvents ITEMSBindingSource As BindingSource
    Friend WithEvents ITEMSTableAdapter As salesDataSetTableAdapters.ITEMSTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_editem As Button
    Friend WithEvents btn_additem As Button
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents DEVEOPERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lbl_sellname As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_sellexec As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_sellprice As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_sellqty As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_sellbarcode As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btn_editemp As Button
    Friend WithEvents btn_addemp As Button
    Friend WithEvents EMPDEBTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents RadioButton13 As RadioButton
    Friend WithEvents RadioButton14 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents RadioButton15 As RadioButton
    Friend WithEvents RadioButton16 As RadioButton
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents btn_editcl As Button
    Friend WithEvents btn_addcl As Button
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents CLIENTBindingSource As BindingSource
    Friend WithEvents CLIENTTableAdapter As salesDataSetTableAdapters.CLIENTTableAdapter
    Friend WithEvents BARCODEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITEMNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITEMQTYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITEMORIGPRICEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITEMSELLPRICEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITEMADDEDDATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EMPBindingSource As BindingSource
    Friend WithEvents EMPTableAdapter As salesDataSetTableAdapters.EMPTableAdapter
    Friend WithEvents EMPIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EMPNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EMPPHONEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ARRIVETIMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WORKDURDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EMPDEPTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SALARYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EMPNOTEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CLIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CLNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CLPHONEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DEPTVALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DEPTDATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CLADDRESSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CLNOTEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents INAME As DataGridViewTextBoxColumn
    Friend WithEvents QTY As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents selltime As DataGridViewTextBoxColumn
    Friend WithEvents notify_stock As NotifyIcon
    Friend WithEvents ChangepassToolStripMenuItem As ToolStripMenuItem
End Class
