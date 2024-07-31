<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Registration_by_User
    Inherits DevComponents.DotNetBar.Metro.MetroForm

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Registration_by_User))
        Me.circ_Usr_Reg_prog = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.lst_User_Reg_List = New DevComponents.DotNetBar.Controls.ListViewEx()
        Me.pan_usr_reg_control = New DevComponents.DotNetBar.PanelEx()
        Me.chk_Mark_Sanitation_Only = New System.Windows.Forms.CheckBox()
        Me.rdo_Usr_Reg_search_by_Account_Number = New System.Windows.Forms.RadioButton()
        Me.rdo_Usr_Reg_search_by_Address = New System.Windows.Forms.RadioButton()
        Me.rdo_Usr_Reg_search_by_Name = New System.Windows.Forms.RadioButton()
        Me.btn_Usr_Reg_refresh_list = New DevComponents.DotNetBar.ButtonX()
        Me.btn_Usr_Reg_Search = New DevComponents.DotNetBar.ButtonX()
        Me.txt_Usr_Reg_Search_Term = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.BW_Usr_Reg_Load = New System.ComponentModel.BackgroundWorker()
        Me.tmr_usr_reg_anim = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuBar1 = New DevComponents.DotNetBar.ContextMenuBar()
        Me.User_Reg = New DevComponents.DotNetBar.ButtonItem()
        Me.btn_usr_reg_View_Details = New DevComponents.DotNetBar.ButtonItem()
        Me.btn_Delete = New DevComponents.DotNetBar.ButtonItem()
        Me.btn_usr_reg_Export_to_PDF = New DevComponents.DotNetBar.ButtonItem()
        Me.btn_usr_reg_Export_to_Excel = New DevComponents.DotNetBar.ButtonItem()
        Me.BW_Usr_Load_Reg_Details = New System.ComponentModel.BackgroundWorker()
        Me.BW_Export_Regs_PDF = New System.ComponentModel.BackgroundWorker()
        Me.BW_Export_Regs_Excel = New System.ComponentModel.BackgroundWorker()
        Me.BW_Usr_Dialog_Search = New System.ComponentModel.BackgroundWorker()
        Me.BW_Delete_Entry_Reg_View = New System.ComponentModel.BackgroundWorker()
        Me.pan_usr_reg_control.SuspendLayout()
        CType(Me.ContextMenuBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'circ_Usr_Reg_prog
        '
        Me.circ_Usr_Reg_prog.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.circ_Usr_Reg_prog.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.circ_Usr_Reg_prog.Location = New System.Drawing.Point(364, 236)
        Me.circ_Usr_Reg_prog.Name = "circ_Usr_Reg_prog"
        Me.circ_Usr_Reg_prog.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot
        Me.circ_Usr_Reg_prog.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.circ_Usr_Reg_prog.ProgressTextVisible = True
        Me.circ_Usr_Reg_prog.Size = New System.Drawing.Size(100, 100)
        Me.circ_Usr_Reg_prog.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.circ_Usr_Reg_prog.TabIndex = 42
        Me.circ_Usr_Reg_prog.Visible = False
        '
        'lst_User_Reg_List
        '
        Me.lst_User_Reg_List.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.lst_User_Reg_List.Border.Class = "ListViewBorder"
        Me.lst_User_Reg_List.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ContextMenuBar1.SetContextMenuEx(Me.lst_User_Reg_List, Me.User_Reg)
        Me.lst_User_Reg_List.DisabledBackColor = System.Drawing.Color.Empty
        Me.lst_User_Reg_List.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lst_User_Reg_List.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lst_User_Reg_List.ForeColor = System.Drawing.Color.Black
        Me.lst_User_Reg_List.FullRowSelect = True
        Me.lst_User_Reg_List.GridLines = True
        Me.lst_User_Reg_List.HideSelection = False
        Me.lst_User_Reg_List.Location = New System.Drawing.Point(0, 129)
        Me.lst_User_Reg_List.MultiSelect = False
        Me.lst_User_Reg_List.Name = "lst_User_Reg_List"
        Me.lst_User_Reg_List.Size = New System.Drawing.Size(829, 456)
        Me.lst_User_Reg_List.TabIndex = 40
        Me.lst_User_Reg_List.UseCompatibleStateImageBehavior = False
        Me.lst_User_Reg_List.View = System.Windows.Forms.View.Details
        '
        'pan_usr_reg_control
        '
        Me.pan_usr_reg_control.CanvasColor = System.Drawing.SystemColors.Control
        Me.pan_usr_reg_control.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pan_usr_reg_control.Controls.Add(Me.chk_Mark_Sanitation_Only)
        Me.pan_usr_reg_control.Controls.Add(Me.rdo_Usr_Reg_search_by_Account_Number)
        Me.pan_usr_reg_control.Controls.Add(Me.rdo_Usr_Reg_search_by_Address)
        Me.pan_usr_reg_control.Controls.Add(Me.rdo_Usr_Reg_search_by_Name)
        Me.pan_usr_reg_control.Controls.Add(Me.btn_Usr_Reg_refresh_list)
        Me.pan_usr_reg_control.Controls.Add(Me.btn_Usr_Reg_Search)
        Me.pan_usr_reg_control.Controls.Add(Me.txt_Usr_Reg_Search_Term)
        Me.pan_usr_reg_control.Controls.Add(Me.LabelX3)
        Me.pan_usr_reg_control.DisabledBackColor = System.Drawing.Color.Empty
        Me.pan_usr_reg_control.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_usr_reg_control.Location = New System.Drawing.Point(0, 0)
        Me.pan_usr_reg_control.Name = "pan_usr_reg_control"
        Me.pan_usr_reg_control.Size = New System.Drawing.Size(829, 129)
        Me.pan_usr_reg_control.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pan_usr_reg_control.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pan_usr_reg_control.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pan_usr_reg_control.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pan_usr_reg_control.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pan_usr_reg_control.Style.GradientAngle = 90
        Me.pan_usr_reg_control.TabIndex = 41
        '
        'chk_Mark_Sanitation_Only
        '
        Me.chk_Mark_Sanitation_Only.AutoSize = True
        Me.chk_Mark_Sanitation_Only.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chk_Mark_Sanitation_Only.Checked = True
        Me.chk_Mark_Sanitation_Only.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Mark_Sanitation_Only.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.chk_Mark_Sanitation_Only.ForeColor = System.Drawing.Color.Black
        Me.chk_Mark_Sanitation_Only.Location = New System.Drawing.Point(84, 102)
        Me.chk_Mark_Sanitation_Only.Name = "chk_Mark_Sanitation_Only"
        Me.chk_Mark_Sanitation_Only.Size = New System.Drawing.Size(214, 23)
        Me.chk_Mark_Sanitation_Only.TabIndex = 10
        Me.chk_Mark_Sanitation_Only.Text = "Pending Sanitation Data Only"
        Me.chk_Mark_Sanitation_Only.UseVisualStyleBackColor = False
        '
        'rdo_Usr_Reg_search_by_Account_Number
        '
        Me.rdo_Usr_Reg_search_by_Account_Number.AutoSize = True
        Me.rdo_Usr_Reg_search_by_Account_Number.ForeColor = System.Drawing.Color.Black
        Me.rdo_Usr_Reg_search_by_Account_Number.Location = New System.Drawing.Point(84, 79)
        Me.rdo_Usr_Reg_search_by_Account_Number.Name = "rdo_Usr_Reg_search_by_Account_Number"
        Me.rdo_Usr_Reg_search_by_Account_Number.Size = New System.Drawing.Size(163, 17)
        Me.rdo_Usr_Reg_search_by_Account_Number.TabIndex = 4
        Me.rdo_Usr_Reg_search_by_Account_Number.Text = "Search by Account Number"
        Me.rdo_Usr_Reg_search_by_Account_Number.UseVisualStyleBackColor = True
        '
        'rdo_Usr_Reg_search_by_Address
        '
        Me.rdo_Usr_Reg_search_by_Address.AutoSize = True
        Me.rdo_Usr_Reg_search_by_Address.ForeColor = System.Drawing.Color.Black
        Me.rdo_Usr_Reg_search_by_Address.Location = New System.Drawing.Point(258, 56)
        Me.rdo_Usr_Reg_search_by_Address.Name = "rdo_Usr_Reg_search_by_Address"
        Me.rdo_Usr_Reg_search_by_Address.Size = New System.Drawing.Size(118, 17)
        Me.rdo_Usr_Reg_search_by_Address.TabIndex = 6
        Me.rdo_Usr_Reg_search_by_Address.Text = "Search by Address"
        Me.rdo_Usr_Reg_search_by_Address.UseVisualStyleBackColor = True
        '
        'rdo_Usr_Reg_search_by_Name
        '
        Me.rdo_Usr_Reg_search_by_Name.AutoSize = True
        Me.rdo_Usr_Reg_search_by_Name.Checked = True
        Me.rdo_Usr_Reg_search_by_Name.ForeColor = System.Drawing.Color.Black
        Me.rdo_Usr_Reg_search_by_Name.Location = New System.Drawing.Point(84, 56)
        Me.rdo_Usr_Reg_search_by_Name.Name = "rdo_Usr_Reg_search_by_Name"
        Me.rdo_Usr_Reg_search_by_Name.Size = New System.Drawing.Size(151, 17)
        Me.rdo_Usr_Reg_search_by_Name.TabIndex = 3
        Me.rdo_Usr_Reg_search_by_Name.TabStop = True
        Me.rdo_Usr_Reg_search_by_Name.Text = "Search by Account Name"
        Me.rdo_Usr_Reg_search_by_Name.UseVisualStyleBackColor = True
        '
        'btn_Usr_Reg_refresh_list
        '
        Me.btn_Usr_Reg_refresh_list.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Usr_Reg_refresh_list.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.btn_Usr_Reg_refresh_list.Location = New System.Drawing.Point(524, 56)
        Me.btn_Usr_Reg_refresh_list.Name = "btn_Usr_Reg_refresh_list"
        Me.btn_Usr_Reg_refresh_list.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btn_Usr_Reg_refresh_list.Size = New System.Drawing.Size(134, 35)
        Me.btn_Usr_Reg_refresh_list.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Usr_Reg_refresh_list.TabIndex = 2
        Me.btn_Usr_Reg_refresh_list.Text = "Refresh List"
        '
        'btn_Usr_Reg_Search
        '
        Me.btn_Usr_Reg_Search.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Usr_Reg_Search.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.btn_Usr_Reg_Search.Location = New System.Drawing.Point(524, 15)
        Me.btn_Usr_Reg_Search.Name = "btn_Usr_Reg_Search"
        Me.btn_Usr_Reg_Search.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btn_Usr_Reg_Search.Size = New System.Drawing.Size(134, 35)
        Me.btn_Usr_Reg_Search.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Usr_Reg_Search.TabIndex = 1
        Me.btn_Usr_Reg_Search.Text = "Search"
        '
        'txt_Usr_Reg_Search_Term
        '
        Me.txt_Usr_Reg_Search_Term.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_Usr_Reg_Search_Term.Border.Class = "TextBoxBorder"
        Me.txt_Usr_Reg_Search_Term.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.txt_Usr_Reg_Search_Term.DisabledBackColor = System.Drawing.Color.White
        Me.txt_Usr_Reg_Search_Term.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txt_Usr_Reg_Search_Term.ForeColor = System.Drawing.Color.Black
        Me.txt_Usr_Reg_Search_Term.Location = New System.Drawing.Point(84, 17)
        Me.txt_Usr_Reg_Search_Term.Name = "txt_Usr_Reg_Search_Term"
        Me.txt_Usr_Reg_Search_Term.PreventEnterBeep = True
        Me.txt_Usr_Reg_Search_Term.Size = New System.Drawing.Size(434, 33)
        Me.txt_Usr_Reg_Search_Term.TabIndex = 0
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(3, 15)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(75, 23)
        Me.LabelX3.TabIndex = 0
        Me.LabelX3.Text = "Search Term:"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'BW_Usr_Reg_Load
        '
        Me.BW_Usr_Reg_Load.WorkerReportsProgress = True
        Me.BW_Usr_Reg_Load.WorkerSupportsCancellation = True
        '
        'ContextMenuBar1
        '
        Me.ContextMenuBar1.AntiAlias = True
        Me.ContextMenuBar1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ContextMenuBar1.IsMaximized = False
        Me.ContextMenuBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.User_Reg})
        Me.ContextMenuBar1.Location = New System.Drawing.Point(598, 283)
        Me.ContextMenuBar1.Name = "ContextMenuBar1"
        Me.ContextMenuBar1.Size = New System.Drawing.Size(75, 27)
        Me.ContextMenuBar1.Stretch = True
        Me.ContextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ContextMenuBar1.TabIndex = 46
        Me.ContextMenuBar1.TabStop = False
        Me.ContextMenuBar1.Text = "ContextMenuBar1"
        '
        'User_Reg
        '
        Me.User_Reg.AutoExpandOnClick = True
        Me.User_Reg.Name = "User_Reg"
        Me.User_Reg.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btn_usr_reg_View_Details, Me.btn_Delete, Me.btn_usr_reg_Export_to_PDF, Me.btn_usr_reg_Export_to_Excel})
        Me.User_Reg.Text = "User_Reg"
        '
        'btn_usr_reg_View_Details
        '
        Me.btn_usr_reg_View_Details.Name = "btn_usr_reg_View_Details"
        Me.btn_usr_reg_View_Details.Text = "View Details"
        '
        'btn_Delete
        '
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Text = "Delete Selected Item"
        '
        'btn_usr_reg_Export_to_PDF
        '
        Me.btn_usr_reg_Export_to_PDF.Name = "btn_usr_reg_Export_to_PDF"
        Me.btn_usr_reg_Export_to_PDF.Text = "Export List to PDF"
        '
        'btn_usr_reg_Export_to_Excel
        '
        Me.btn_usr_reg_Export_to_Excel.Name = "btn_usr_reg_Export_to_Excel"
        Me.btn_usr_reg_Export_to_Excel.Text = "Export List to Excel"
        '
        'BW_Usr_Load_Reg_Details
        '
        Me.BW_Usr_Load_Reg_Details.WorkerReportsProgress = True
        Me.BW_Usr_Load_Reg_Details.WorkerSupportsCancellation = True
        '
        'BW_Export_Regs_PDF
        '
        Me.BW_Export_Regs_PDF.WorkerReportsProgress = True
        Me.BW_Export_Regs_PDF.WorkerSupportsCancellation = True
        '
        'BW_Export_Regs_Excel
        '
        Me.BW_Export_Regs_Excel.WorkerReportsProgress = True
        Me.BW_Export_Regs_Excel.WorkerSupportsCancellation = True
        '
        'BW_Usr_Dialog_Search
        '
        Me.BW_Usr_Dialog_Search.WorkerReportsProgress = True
        Me.BW_Usr_Dialog_Search.WorkerSupportsCancellation = True
        '
        'BW_Delete_Entry_Reg_View
        '
        Me.BW_Delete_Entry_Reg_View.WorkerReportsProgress = True
        Me.BW_Delete_Entry_Reg_View.WorkerSupportsCancellation = True
        '
        'frm_Registration_by_User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 585)
        Me.Controls.Add(Me.ContextMenuBar1)
        Me.Controls.Add(Me.circ_Usr_Reg_prog)
        Me.Controls.Add(Me.lst_User_Reg_List)
        Me.Controls.Add(Me.pan_usr_reg_control)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Registration_by_User"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "MCO registered by:"
        Me.pan_usr_reg_control.ResumeLayout(False)
        Me.pan_usr_reg_control.PerformLayout()
        CType(Me.ContextMenuBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents circ_Usr_Reg_prog As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents lst_User_Reg_List As DevComponents.DotNetBar.Controls.ListViewEx
    Friend WithEvents pan_usr_reg_control As DevComponents.DotNetBar.PanelEx
    Friend WithEvents rdo_Usr_Reg_search_by_Account_Number As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_Usr_Reg_search_by_Address As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_Usr_Reg_search_by_Name As System.Windows.Forms.RadioButton
    Friend WithEvents btn_Usr_Reg_refresh_list As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_Usr_Reg_Search As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txt_Usr_Reg_Search_Term As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents BW_Usr_Reg_Load As System.ComponentModel.BackgroundWorker
    Friend WithEvents tmr_usr_reg_anim As System.Windows.Forms.Timer
    Friend WithEvents ContextMenuBar1 As DevComponents.DotNetBar.ContextMenuBar
    Friend WithEvents User_Reg As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btn_usr_reg_View_Details As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btn_usr_reg_Export_to_PDF As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btn_usr_reg_Export_to_Excel As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BW_Usr_Load_Reg_Details As System.ComponentModel.BackgroundWorker
    Friend WithEvents BW_Export_Regs_PDF As System.ComponentModel.BackgroundWorker
    Friend WithEvents BW_Export_Regs_Excel As System.ComponentModel.BackgroundWorker
    Friend WithEvents BW_Usr_Dialog_Search As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_Delete As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BW_Delete_Entry_Reg_View As System.ComponentModel.BackgroundWorker
    Friend WithEvents chk_Mark_Sanitation_Only As CheckBox
End Class
