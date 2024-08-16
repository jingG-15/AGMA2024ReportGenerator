<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Main
    Inherits DevComponents.DotNetBar.Metro.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.SideNav1 = New DevComponents.DotNetBar.Controls.SideNav()
        Me.sidenavpan_LiveTotalReg = New DevComponents.DotNetBar.Controls.SideNavPanel()
        Me.lbl_Time_AMPM = New DevComponents.DotNetBar.LabelX()
        Me.lbl_Time_Minute = New DevComponents.DotNetBar.LabelX()
        Me.lbl_Time_Colon = New DevComponents.DotNetBar.LabelX()
        Me.lbl_Total_reg_Label = New DevComponents.DotNetBar.LabelX()
        Me.lbl_Total_Regs = New DevComponents.DotNetBar.LabelX()
        Me.lbl_Time_Hour = New DevComponents.DotNetBar.LabelX()
        Me.lbl_Time_Label = New DevComponents.DotNetBar.LabelX()
        Me.sidenavpan_masterlist = New DevComponents.DotNetBar.Controls.SideNavPanel()
        Me.ContextMenuBar1 = New DevComponents.DotNetBar.ContextMenuBar()
        Me.cntx_Masterlist = New DevComponents.DotNetBar.ButtonItem()
        Me.btn_Mstr_View_Details = New DevComponents.DotNetBar.ButtonItem()
        Me.btn_Mstr_Delete = New DevComponents.DotNetBar.ButtonItem()
        Me.btn_mstr_export_PDF = New DevComponents.DotNetBar.ButtonItem()
        Me.btn_mstr_export_Excel = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem9 = New DevComponents.DotNetBar.ButtonItem()
        Me.btn_mstr_export_district_PDF = New DevComponents.DotNetBar.ButtonItem()
        Me.btn_mstr_export_district_Excel = New DevComponents.DotNetBar.ButtonItem()
        Me.btnitm_Export_Audit_Report = New DevComponents.DotNetBar.ButtonItem()
        Me.cntx_Self_Reg = New DevComponents.DotNetBar.ButtonItem()
        Me.btn_Self_View_Details = New DevComponents.DotNetBar.ButtonItem()
        Me.btn_Self_Delete_Entry = New DevComponents.DotNetBar.ButtonItem()
        Me.btn_Self_Export_Reg_PDF = New DevComponents.DotNetBar.ButtonItem()
        Me.btn_Self_Export_Reg_Excel = New DevComponents.DotNetBar.ButtonItem()
        Me.cntx_MCO_Officers = New DevComponents.DotNetBar.ButtonItem()
        Me.btn_Prof_View_Details = New DevComponents.DotNetBar.ButtonItem()
        Me.btn_Prof_View_Reg_by_User = New DevComponents.DotNetBar.ButtonItem()
        Me.btn_Add_New_User = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem6 = New DevComponents.DotNetBar.ButtonItem()
        Me.btn_Prof_Export_Reg_by_User_PDF = New DevComponents.DotNetBar.ButtonItem()
        Me.btn_Prof_Export_Reg_by_User_Excel = New DevComponents.DotNetBar.ButtonItem()
        Me.QR_Attendance = New DevComponents.DotNetBar.ButtonItem()
        Me.btn_QR_View_Profile = New DevComponents.DotNetBar.ButtonItem()
        Me.btn_QR_Export_to_Excel = New DevComponents.DotNetBar.ButtonItem()
        Me.btn_QR_Export_to_PDF = New DevComponents.DotNetBar.ButtonItem()
        Me.Del_Logs = New DevComponents.DotNetBar.ButtonItem()
        Me.btn_View_Del_Prof = New DevComponents.DotNetBar.ButtonItem()
        Me.btn_Export_Del_Logs = New DevComponents.DotNetBar.ButtonItem()
        Me.btn_Send_Sanitation_SMS = New DevComponents.DotNetBar.ButtonItem()
        Me.lst_del_logs = New DevComponents.DotNetBar.Controls.ListViewEx()
        Me.lst_QR_Attendees = New DevComponents.DotNetBar.Controls.ListViewEx()
        Me.lst_users = New DevComponents.DotNetBar.Controls.ListViewEx()
        Me.lst_Self_Reg = New DevComponents.DotNetBar.Controls.ListViewEx()
        Me.lst_Masterlist = New DevComponents.DotNetBar.Controls.ListViewEx()
        Me.circ_prog_masterlist = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.pan_masterlist_controls = New DevComponents.DotNetBar.PanelEx()
        Me.chk_Mark_Sanitation_Only = New System.Windows.Forms.CheckBox()
        Me.rdo_Mstr_AccountNumberSearch = New System.Windows.Forms.RadioButton()
        Me.rdo_Mstr_Registrant_Search = New System.Windows.Forms.RadioButton()
        Me.rdo_Mstr_Address_Search = New System.Windows.Forms.RadioButton()
        Me.rdo_Mstr_NameSearch = New System.Windows.Forms.RadioButton()
        Me.btn_Refresh_Masterlist = New DevComponents.DotNetBar.ButtonX()
        Me.btn_Masterlist_Search = New DevComponents.DotNetBar.ButtonX()
        Me.txt_Mstr_Search_Term = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbl_Main = New DevComponents.DotNetBar.LabelX()
        Me.sidenavpan_livetotals_onsite = New DevComponents.DotNetBar.Controls.SideNavPanel()
        Me.lbl_Total_Regs_Onsite = New DevComponents.DotNetBar.LabelX()
        Me.lbl_Time_AMPM_Onsite = New DevComponents.DotNetBar.LabelX()
        Me.lbl_Time_Minute_Onsite = New DevComponents.DotNetBar.LabelX()
        Me.lbl_Time_Colon_Onsite = New DevComponents.DotNetBar.LabelX()
        Me.lbl_Time_Hour_Onsite = New DevComponents.DotNetBar.LabelX()
        Me.lbl_Time_Label_Onsite = New DevComponents.DotNetBar.LabelX()
        Me.sidenavpan_livetotals_per_district = New DevComponents.DotNetBar.Controls.SideNavPanel()
        Me.lbl_Time_AMPM_Area = New DevComponents.DotNetBar.LabelX()
        Me.lbl_Time_Minute_Area = New DevComponents.DotNetBar.LabelX()
        Me.lbl_Time_Colon_Area = New DevComponents.DotNetBar.LabelX()
        Me.lbl_Total_Regs_Area = New DevComponents.DotNetBar.LabelX()
        Me.lbl_Time_Hour_Area = New DevComponents.DotNetBar.LabelX()
        Me.lbl_Time_Label_Area = New DevComponents.DotNetBar.LabelX()
        Me.SideNavPanel1 = New DevComponents.DotNetBar.Controls.SideNavPanel()
        Me.circ_del_prog = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.pan_del_logs_control = New DevComponents.DotNetBar.PanelEx()
        Me.rdo_del_Search_by_Account_Name = New System.Windows.Forms.RadioButton()
        Me.rdo_del_Search_by_Del_Username = New System.Windows.Forms.RadioButton()
        Me.rdo_del_Search_by_Reg_Username = New System.Windows.Forms.RadioButton()
        Me.rdo_del_Search_by_Account_Num = New System.Windows.Forms.RadioButton()
        Me.btn_del_Refresh = New DevComponents.DotNetBar.ButtonX()
        Me.btn_del_Search = New DevComponents.DotNetBar.ButtonX()
        Me.txt_del_Search_Term = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.sidenavpan_QR_Attendance = New DevComponents.DotNetBar.Controls.SideNavPanel()
        Me.circ_prog_QR = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.pan_QR_control = New DevComponents.DotNetBar.PanelEx()
        Me.rdo_QR_Search_by_Account_Number = New System.Windows.Forms.RadioButton()
        Me.rdo_QR_Search_by_Account_Name = New System.Windows.Forms.RadioButton()
        Me.btn_QR_Refresh_List = New DevComponents.DotNetBar.ButtonX()
        Me.btn_QR_Search = New DevComponents.DotNetBar.ButtonX()
        Me.txt_QR_Search_Term = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.sidenavpan_Officer_List = New DevComponents.DotNetBar.Controls.SideNavPanel()
        Me.circ_users_prog = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.pan_users_control = New DevComponents.DotNetBar.PanelEx()
        Me.rdo_user_search_by_Username = New System.Windows.Forms.RadioButton()
        Me.rdo_user_search_by_Designation = New System.Windows.Forms.RadioButton()
        Me.rdo_user_search_by_Address = New System.Windows.Forms.RadioButton()
        Me.rdo_user_search_by_Real_Name = New System.Windows.Forms.RadioButton()
        Me.btn_user_refresh_list = New DevComponents.DotNetBar.ButtonX()
        Me.btn_user_Search = New DevComponents.DotNetBar.ButtonX()
        Me.txt_user_Search_Term = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.sidenavpan_self_reg = New DevComponents.DotNetBar.Controls.SideNavPanel()
        Me.circ_self_reg = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.pan_self_controls = New DevComponents.DotNetBar.PanelEx()
        Me.chk_Guest_Sanitation_Only = New System.Windows.Forms.CheckBox()
        Me.rdo_self_by_number = New System.Windows.Forms.RadioButton()
        Me.rdo_self_by_address = New System.Windows.Forms.RadioButton()
        Me.rdo_self_by_name = New System.Windows.Forms.RadioButton()
        Me.btn_self_refresh = New DevComponents.DotNetBar.ButtonX()
        Me.btn_self_search = New DevComponents.DotNetBar.ButtonX()
        Me.txt_Self_Search_Term = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.SideNavItem1 = New DevComponents.DotNetBar.Controls.SideNavItem()
        Me.SideNavItem5 = New DevComponents.DotNetBar.Controls.SideNavItem()
        Me.Separator1 = New DevComponents.DotNetBar.Separator()
        Me.SideNavItem7 = New DevComponents.DotNetBar.Controls.SideNavItem()
        Me.SideNavItem9 = New DevComponents.DotNetBar.Controls.SideNavItem()
        Me.SideNavItem2 = New DevComponents.DotNetBar.Controls.SideNavItem()
        Me.SideNavItem6 = New DevComponents.DotNetBar.Controls.SideNavItem()
        Me.SideNavItem4 = New DevComponents.DotNetBar.Controls.SideNavItem()
        Me.SideNavItem3 = New DevComponents.DotNetBar.Controls.SideNavItem()
        Me.SideNavItem8 = New DevComponents.DotNetBar.Controls.SideNavItem()
        Me.SideNavItem10 = New DevComponents.DotNetBar.Controls.SideNavItem()
        Me.BW_Load_Masterlist = New System.ComponentModel.BackgroundWorker()
        Me.BW_Config_Local_Settings = New System.ComponentModel.BackgroundWorker()
        Me.circ_prog_overall = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.tmr_Circ_overall_anim = New System.Windows.Forms.Timer(Me.components)
        Me.tmr_Circ_masterlist_anim = New System.Windows.Forms.Timer(Me.components)
        Me.tmr_Time_Updater = New System.Windows.Forms.Timer(Me.components)
        Me.tmr_Total_Reg_Updater = New System.Windows.Forms.Timer(Me.components)
        Me.BW_Get_Total_Reg = New System.ComponentModel.BackgroundWorker()
        Me.BW_Mstr_Search = New System.ComponentModel.BackgroundWorker()
        Me.BW_Mstr_Load_Reg_Details = New System.ComponentModel.BackgroundWorker()
        Me.BW_PDF_Exporter_Masterlist = New System.ComponentModel.BackgroundWorker()
        Me.BW_Export_Excel_Mstr = New System.ComponentModel.BackgroundWorker()
        Me.BW_PDF_Exporter_Mstr_Dist = New System.ComponentModel.BackgroundWorker()
        Me.BW_Export_Excel_Mstr_Dist = New System.ComponentModel.BackgroundWorker()
        Me.BW_Load_Self_Reg = New System.ComponentModel.BackgroundWorker()
        Me.tmr_Circ_self_anim = New System.Windows.Forms.Timer(Me.components)
        Me.BW_Self_Load_Reg_Details = New System.ComponentModel.BackgroundWorker()
        Me.BW_Self_Search = New System.ComponentModel.BackgroundWorker()
        Me.BW_Load_Users = New System.ComponentModel.BackgroundWorker()
        Me.tmr_Circ_user_anim = New System.Windows.Forms.Timer(Me.components)
        Me.BW_Prof_Details_Fetch = New System.ComponentModel.BackgroundWorker()
        Me.BW_User_Search = New System.ComponentModel.BackgroundWorker()
        Me.BW_PDF_Exporter_Usr = New System.ComponentModel.BackgroundWorker()
        Me.BW_Export_Excel_Usr = New System.ComponentModel.BackgroundWorker()
        Me.BW_Delete_Entry = New System.ComponentModel.BackgroundWorker()
        Me.BW_Fill_QR_Attendance = New System.ComponentModel.BackgroundWorker()
        Me.tmr_Circ_QR_anim = New System.Windows.Forms.Timer(Me.components)
        Me.BW_QR_Search = New System.ComponentModel.BackgroundWorker()
        Me.BW_Export_Excel_QR = New System.ComponentModel.BackgroundWorker()
        Me.BW_QR_Load_Reg_Details = New System.ComponentModel.BackgroundWorker()
        Me.tmr_Totals_Updater_Area = New System.Windows.Forms.Timer(Me.components)
        Me.BW_Get_Area_Reg = New System.ComponentModel.BackgroundWorker()
        Me.BW_PDF_Exporter_Self = New System.ComponentModel.BackgroundWorker()
        Me.BW_Export_Excel_Self = New System.ComponentModel.BackgroundWorker()
        Me.tmr_Circ_del_anim = New System.Windows.Forms.Timer(Me.components)
        Me.BW_Load_Del_Logs = New System.ComponentModel.BackgroundWorker()
        Me.BW_Del_Load_Reg_Details = New System.ComponentModel.BackgroundWorker()
        Me.BW_Export_Excel_Del_Logs = New System.ComponentModel.BackgroundWorker()
        Me.BW_Del_Logs_Search = New System.ComponentModel.BackgroundWorker()
        Me.BW_SMS_Marker_Updater = New System.ComponentModel.BackgroundWorker()
        Me.tmr_SMS_Done_Updater = New System.Windows.Forms.Timer(Me.components)
        Me.BW_del_logs_laoder = New System.ComponentModel.BackgroundWorker()
        Me.tmr_Entries_Loader = New System.Windows.Forms.Timer(Me.components)
        Me.BW_PDF_Export_Audit_Rpt = New System.ComponentModel.BackgroundWorker()
        Me.BW_Get_Onsite_Total_Count = New System.ComponentModel.BackgroundWorker()
        Me.tmr_Totals_Updater_Onsite = New System.Windows.Forms.Timer(Me.components)
        Me.BW_PDF_Exporter_Onsite_Dist = New System.ComponentModel.BackgroundWorker()
        Me.BW_Valid_Entries_Notifier = New System.ComponentModel.BackgroundWorker()
        Me.BW_SMS_Updater_Overall = New System.ComponentModel.BackgroundWorker()
        Me.SideNav1.SuspendLayout()
        Me.sidenavpan_LiveTotalReg.SuspendLayout()
        Me.sidenavpan_masterlist.SuspendLayout()
        CType(Me.ContextMenuBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan_masterlist_controls.SuspendLayout()
        Me.sidenavpan_livetotals_onsite.SuspendLayout()
        Me.sidenavpan_livetotals_per_district.SuspendLayout()
        Me.SideNavPanel1.SuspendLayout()
        Me.pan_del_logs_control.SuspendLayout()
        Me.sidenavpan_QR_Attendance.SuspendLayout()
        Me.pan_QR_control.SuspendLayout()
        Me.sidenavpan_Officer_List.SuspendLayout()
        Me.pan_users_control.SuspendLayout()
        Me.sidenavpan_self_reg.SuspendLayout()
        Me.pan_self_controls.SuspendLayout()
        Me.SuspendLayout()
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2016
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer)))
        '
        'SideNav1
        '
        Me.SideNav1.Controls.Add(Me.sidenavpan_livetotals_onsite)
        Me.SideNav1.Controls.Add(Me.sidenavpan_livetotals_per_district)
        Me.SideNav1.Controls.Add(Me.sidenavpan_LiveTotalReg)
        Me.SideNav1.Controls.Add(Me.sidenavpan_masterlist)
        Me.SideNav1.Controls.Add(Me.SideNavPanel1)
        Me.SideNav1.Controls.Add(Me.sidenavpan_QR_Attendance)
        Me.SideNav1.Controls.Add(Me.sidenavpan_Officer_List)
        Me.SideNav1.Controls.Add(Me.sidenavpan_self_reg)
        Me.SideNav1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SideNav1.EnableClose = False
        Me.SideNav1.EnableMaximize = False
        Me.SideNav1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SideNavItem1, Me.SideNavItem5, Me.Separator1, Me.SideNavItem7, Me.SideNavItem9, Me.SideNavItem2, Me.SideNavItem6, Me.SideNavItem4, Me.SideNavItem3, Me.SideNavItem8, Me.SideNavItem10})
        Me.SideNav1.Location = New System.Drawing.Point(0, 0)
        Me.SideNav1.Name = "SideNav1"
        Me.SideNav1.Padding = New System.Windows.Forms.Padding(1)
        Me.SideNav1.Size = New System.Drawing.Size(984, 561)
        Me.SideNav1.TabIndex = 1
        Me.SideNav1.Text = "SideNav1"
        '
        'sidenavpan_LiveTotalReg
        '
        Me.sidenavpan_LiveTotalReg.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.sidenavpan_LiveTotalReg.Controls.Add(Me.lbl_Time_AMPM)
        Me.sidenavpan_LiveTotalReg.Controls.Add(Me.lbl_Time_Minute)
        Me.sidenavpan_LiveTotalReg.Controls.Add(Me.lbl_Time_Colon)
        Me.sidenavpan_LiveTotalReg.Controls.Add(Me.lbl_Total_reg_Label)
        Me.sidenavpan_LiveTotalReg.Controls.Add(Me.lbl_Total_Regs)
        Me.sidenavpan_LiveTotalReg.Controls.Add(Me.lbl_Time_Hour)
        Me.sidenavpan_LiveTotalReg.Controls.Add(Me.lbl_Time_Label)
        Me.sidenavpan_LiveTotalReg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sidenavpan_LiveTotalReg.ForeColor = System.Drawing.Color.Black
        Me.sidenavpan_LiveTotalReg.Location = New System.Drawing.Point(212, 31)
        Me.sidenavpan_LiveTotalReg.Name = "sidenavpan_LiveTotalReg"
        Me.sidenavpan_LiveTotalReg.Size = New System.Drawing.Size(767, 529)
        Me.sidenavpan_LiveTotalReg.TabIndex = 14
        Me.sidenavpan_LiveTotalReg.Visible = False
        '
        'lbl_Time_AMPM
        '
        Me.lbl_Time_AMPM.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbl_Time_AMPM.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_Time_AMPM.Font = New System.Drawing.Font("Bahnschrift Condensed", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Time_AMPM.ForeColor = System.Drawing.Color.Black
        Me.lbl_Time_AMPM.Location = New System.Drawing.Point(340, 7)
        Me.lbl_Time_AMPM.Name = "lbl_Time_AMPM"
        Me.lbl_Time_AMPM.Size = New System.Drawing.Size(78, 57)
        Me.lbl_Time_AMPM.TabIndex = 5
        Me.lbl_Time_AMPM.Text = "PM"
        Me.lbl_Time_AMPM.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lbl_Time_Minute
        '
        Me.lbl_Time_Minute.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbl_Time_Minute.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_Time_Minute.Font = New System.Drawing.Font("Bahnschrift Condensed", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Time_Minute.ForeColor = System.Drawing.Color.Black
        Me.lbl_Time_Minute.Location = New System.Drawing.Point(274, 7)
        Me.lbl_Time_Minute.Name = "lbl_Time_Minute"
        Me.lbl_Time_Minute.Size = New System.Drawing.Size(60, 57)
        Me.lbl_Time_Minute.TabIndex = 4
        Me.lbl_Time_Minute.Text = "69"
        Me.lbl_Time_Minute.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lbl_Time_Colon
        '
        Me.lbl_Time_Colon.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbl_Time_Colon.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_Time_Colon.Font = New System.Drawing.Font("Bahnschrift Condensed", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Time_Colon.ForeColor = System.Drawing.Color.Black
        Me.lbl_Time_Colon.Location = New System.Drawing.Point(245, 7)
        Me.lbl_Time_Colon.Name = "lbl_Time_Colon"
        Me.lbl_Time_Colon.Size = New System.Drawing.Size(23, 57)
        Me.lbl_Time_Colon.TabIndex = 3
        Me.lbl_Time_Colon.Text = ":"
        Me.lbl_Time_Colon.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lbl_Total_reg_Label
        '
        Me.lbl_Total_reg_Label.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbl_Total_reg_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_Total_reg_Label.Font = New System.Drawing.Font("Bahnschrift Condensed", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Total_reg_Label.ForeColor = System.Drawing.Color.Black
        Me.lbl_Total_reg_Label.Location = New System.Drawing.Point(181, 346)
        Me.lbl_Total_reg_Label.Name = "lbl_Total_reg_Label"
        Me.lbl_Total_reg_Label.Size = New System.Drawing.Size(460, 113)
        Me.lbl_Total_reg_Label.TabIndex = 2
        Me.lbl_Total_reg_Label.Text = "Total Registered"
        Me.lbl_Total_reg_Label.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lbl_Total_Regs
        '
        Me.lbl_Total_Regs.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbl_Total_Regs.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_Total_Regs.Font = New System.Drawing.Font("Bahnschrift Condensed", 80.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_Total_Regs.ForeColor = System.Drawing.Color.Black
        Me.lbl_Total_Regs.Location = New System.Drawing.Point(0, 170)
        Me.lbl_Total_Regs.Name = "lbl_Total_Regs"
        Me.lbl_Total_Regs.Size = New System.Drawing.Size(768, 168)
        Me.lbl_Total_Regs.TabIndex = 1
        Me.lbl_Total_Regs.Text = "10,000"
        Me.lbl_Total_Regs.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lbl_Time_Hour
        '
        Me.lbl_Time_Hour.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbl_Time_Hour.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_Time_Hour.Font = New System.Drawing.Font("Bahnschrift Condensed", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Time_Hour.ForeColor = System.Drawing.Color.Black
        Me.lbl_Time_Hour.Location = New System.Drawing.Point(181, 7)
        Me.lbl_Time_Hour.Name = "lbl_Time_Hour"
        Me.lbl_Time_Hour.Size = New System.Drawing.Size(58, 57)
        Me.lbl_Time_Hour.TabIndex = 0
        Me.lbl_Time_Hour.Text = "12"
        Me.lbl_Time_Hour.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lbl_Time_Label
        '
        Me.lbl_Time_Label.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbl_Time_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_Time_Label.Font = New System.Drawing.Font("Bahnschrift Condensed", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Time_Label.ForeColor = System.Drawing.Color.Black
        Me.lbl_Time_Label.Location = New System.Drawing.Point(3, 4)
        Me.lbl_Time_Label.Name = "lbl_Time_Label"
        Me.lbl_Time_Label.Size = New System.Drawing.Size(145, 63)
        Me.lbl_Time_Label.TabIndex = 0
        Me.lbl_Time_Label.Text = "Time: "
        Me.lbl_Time_Label.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'sidenavpan_masterlist
        '
        Me.sidenavpan_masterlist.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.sidenavpan_masterlist.Controls.Add(Me.ContextMenuBar1)
        Me.sidenavpan_masterlist.Controls.Add(Me.circ_prog_masterlist)
        Me.sidenavpan_masterlist.Controls.Add(Me.lst_Masterlist)
        Me.sidenavpan_masterlist.Controls.Add(Me.pan_masterlist_controls)
        Me.sidenavpan_masterlist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sidenavpan_masterlist.ForeColor = System.Drawing.Color.Black
        Me.sidenavpan_masterlist.Location = New System.Drawing.Point(212, 31)
        Me.sidenavpan_masterlist.Name = "sidenavpan_masterlist"
        Me.sidenavpan_masterlist.Size = New System.Drawing.Size(767, 529)
        Me.sidenavpan_masterlist.TabIndex = 2
        Me.sidenavpan_masterlist.Visible = False
        '
        'ContextMenuBar1
        '
        Me.ContextMenuBar1.AntiAlias = True
        Me.ContextMenuBar1.DockSide = DevComponents.DotNetBar.eDockSide.Document
        Me.ContextMenuBar1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ContextMenuBar1.IsMaximized = False
        Me.ContextMenuBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.cntx_Masterlist, Me.cntx_Self_Reg, Me.cntx_MCO_Officers, Me.QR_Attendance, Me.Del_Logs})
        Me.ContextMenuBar1.Location = New System.Drawing.Point(73, 187)
        Me.ContextMenuBar1.Name = "ContextMenuBar1"
        Me.ContextMenuBar1.Size = New System.Drawing.Size(138, 123)
        Me.ContextMenuBar1.Stretch = True
        Me.ContextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ContextMenuBar1.TabIndex = 28
        Me.ContextMenuBar1.TabStop = False
        Me.ContextMenuBar1.Text = "ContextMenuBar1"
        '
        'cntx_Masterlist
        '
        Me.cntx_Masterlist.AutoExpandOnClick = True
        Me.cntx_Masterlist.Name = "cntx_Masterlist"
        Me.cntx_Masterlist.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btn_Mstr_View_Details, Me.btn_Mstr_Delete, Me.btn_mstr_export_PDF, Me.btn_mstr_export_Excel, Me.ButtonItem9, Me.btnitm_Export_Audit_Report})
        Me.cntx_Masterlist.Text = "Masterlist"
        '
        'btn_Mstr_View_Details
        '
        Me.btn_Mstr_View_Details.Name = "btn_Mstr_View_Details"
        Me.btn_Mstr_View_Details.Text = "View Details"
        '
        'btn_Mstr_Delete
        '
        Me.btn_Mstr_Delete.Name = "btn_Mstr_Delete"
        Me.btn_Mstr_Delete.Text = "Delete Selected Entry"
        '
        'btn_mstr_export_PDF
        '
        Me.btn_mstr_export_PDF.Name = "btn_mstr_export_PDF"
        Me.btn_mstr_export_PDF.Text = "Export Masterlist to PDF"
        '
        'btn_mstr_export_Excel
        '
        Me.btn_mstr_export_Excel.Name = "btn_mstr_export_Excel"
        Me.btn_mstr_export_Excel.Text = "Export Masterlist to Excel"
        '
        'ButtonItem9
        '
        Me.ButtonItem9.Name = "ButtonItem9"
        Me.ButtonItem9.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btn_mstr_export_district_PDF, Me.btn_mstr_export_district_Excel})
        Me.ButtonItem9.Text = "Export Masterlist Per District"
        '
        'btn_mstr_export_district_PDF
        '
        Me.btn_mstr_export_district_PDF.Name = "btn_mstr_export_district_PDF"
        Me.btn_mstr_export_district_PDF.Text = "PDF Format"
        '
        'btn_mstr_export_district_Excel
        '
        Me.btn_mstr_export_district_Excel.Name = "btn_mstr_export_district_Excel"
        Me.btn_mstr_export_district_Excel.Text = "Excel Format"
        '
        'btnitm_Export_Audit_Report
        '
        Me.btnitm_Export_Audit_Report.Name = "btnitm_Export_Audit_Report"
        Me.btnitm_Export_Audit_Report.Text = "Export Audit Report"
        '
        'cntx_Self_Reg
        '
        Me.cntx_Self_Reg.AutoExpandOnClick = True
        Me.cntx_Self_Reg.Name = "cntx_Self_Reg"
        Me.cntx_Self_Reg.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btn_Self_View_Details, Me.btn_Self_Delete_Entry, Me.btn_Self_Export_Reg_PDF, Me.btn_Self_Export_Reg_Excel})
        Me.cntx_Self_Reg.Text = "Self Registrants"
        '
        'btn_Self_View_Details
        '
        Me.btn_Self_View_Details.Name = "btn_Self_View_Details"
        Me.btn_Self_View_Details.Text = "View Details"
        '
        'btn_Self_Delete_Entry
        '
        Me.btn_Self_Delete_Entry.Name = "btn_Self_Delete_Entry"
        Me.btn_Self_Delete_Entry.Text = "Delete Selected Entry"
        '
        'btn_Self_Export_Reg_PDF
        '
        Me.btn_Self_Export_Reg_PDF.Name = "btn_Self_Export_Reg_PDF"
        Me.btn_Self_Export_Reg_PDF.Text = "Export to PDF"
        '
        'btn_Self_Export_Reg_Excel
        '
        Me.btn_Self_Export_Reg_Excel.Name = "btn_Self_Export_Reg_Excel"
        Me.btn_Self_Export_Reg_Excel.Text = "EXport to Excel"
        '
        'cntx_MCO_Officers
        '
        Me.cntx_MCO_Officers.AutoExpandOnClick = True
        Me.cntx_MCO_Officers.Name = "cntx_MCO_Officers"
        Me.cntx_MCO_Officers.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btn_Prof_View_Details, Me.btn_Prof_View_Reg_by_User, Me.btn_Add_New_User, Me.ButtonItem6})
        Me.cntx_MCO_Officers.Text = "MCO Officers"
        '
        'btn_Prof_View_Details
        '
        Me.btn_Prof_View_Details.Name = "btn_Prof_View_Details"
        Me.btn_Prof_View_Details.Text = "Profile Details"
        '
        'btn_Prof_View_Reg_by_User
        '
        Me.btn_Prof_View_Reg_by_User.Name = "btn_Prof_View_Reg_by_User"
        Me.btn_Prof_View_Reg_by_User.Text = "View MCOs Registered"
        '
        'btn_Add_New_User
        '
        Me.btn_Add_New_User.Name = "btn_Add_New_User"
        Me.btn_Add_New_User.Text = "Add New User Account"
        '
        'ButtonItem6
        '
        Me.ButtonItem6.Name = "ButtonItem6"
        Me.ButtonItem6.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btn_Prof_Export_Reg_by_User_PDF, Me.btn_Prof_Export_Reg_by_User_Excel})
        Me.ButtonItem6.Text = "Export Users' Registration"
        '
        'btn_Prof_Export_Reg_by_User_PDF
        '
        Me.btn_Prof_Export_Reg_by_User_PDF.Name = "btn_Prof_Export_Reg_by_User_PDF"
        Me.btn_Prof_Export_Reg_by_User_PDF.Text = "PDF"
        '
        'btn_Prof_Export_Reg_by_User_Excel
        '
        Me.btn_Prof_Export_Reg_by_User_Excel.Name = "btn_Prof_Export_Reg_by_User_Excel"
        Me.btn_Prof_Export_Reg_by_User_Excel.Text = "Excel"
        '
        'QR_Attendance
        '
        Me.QR_Attendance.AutoExpandOnClick = True
        Me.QR_Attendance.Name = "QR_Attendance"
        Me.QR_Attendance.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btn_QR_View_Profile, Me.btn_QR_Export_to_Excel, Me.btn_QR_Export_to_PDF})
        Me.QR_Attendance.Text = "QR_Attendance"
        '
        'btn_QR_View_Profile
        '
        Me.btn_QR_View_Profile.Name = "btn_QR_View_Profile"
        Me.btn_QR_View_Profile.Text = "View Profile"
        '
        'btn_QR_Export_to_Excel
        '
        Me.btn_QR_Export_to_Excel.Name = "btn_QR_Export_to_Excel"
        Me.btn_QR_Export_to_Excel.Text = "Export Attendance to Excel"
        '
        'btn_QR_Export_to_PDF
        '
        Me.btn_QR_Export_to_PDF.Name = "btn_QR_Export_to_PDF"
        Me.btn_QR_Export_to_PDF.Text = "Export Attendance to PDF Per District"
        '
        'Del_Logs
        '
        Me.Del_Logs.AutoExpandOnClick = True
        Me.Del_Logs.Name = "Del_Logs"
        Me.Del_Logs.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btn_View_Del_Prof, Me.btn_Export_Del_Logs, Me.btn_Send_Sanitation_SMS})
        Me.Del_Logs.Text = "Del_Logs"
        '
        'btn_View_Del_Prof
        '
        Me.btn_View_Del_Prof.Name = "btn_View_Del_Prof"
        Me.btn_View_Del_Prof.Text = "View Details"
        '
        'btn_Export_Del_Logs
        '
        Me.btn_Export_Del_Logs.Name = "btn_Export_Del_Logs"
        Me.btn_Export_Del_Logs.Text = "Export Logs to Excel"
        '
        'btn_Send_Sanitation_SMS
        '
        Me.btn_Send_Sanitation_SMS.Name = "btn_Send_Sanitation_SMS"
        Me.btn_Send_Sanitation_SMS.Text = "Send SMS to New Delete Logs"
        '
        'lst_del_logs
        '
        Me.lst_del_logs.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.lst_del_logs.Border.Class = "ListViewBorder"
        Me.lst_del_logs.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ContextMenuBar1.SetContextMenuEx(Me.lst_del_logs, Me.Del_Logs)
        Me.lst_del_logs.DisabledBackColor = System.Drawing.Color.Empty
        Me.lst_del_logs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lst_del_logs.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lst_del_logs.ForeColor = System.Drawing.Color.Black
        Me.lst_del_logs.FullRowSelect = True
        Me.lst_del_logs.GridLines = True
        Me.lst_del_logs.HideSelection = False
        Me.lst_del_logs.Location = New System.Drawing.Point(0, 109)
        Me.lst_del_logs.MultiSelect = False
        Me.lst_del_logs.Name = "lst_del_logs"
        Me.lst_del_logs.Size = New System.Drawing.Size(767, 420)
        Me.lst_del_logs.TabIndex = 39
        Me.lst_del_logs.UseCompatibleStateImageBehavior = False
        Me.lst_del_logs.View = System.Windows.Forms.View.Details
        '
        'lst_QR_Attendees
        '
        Me.lst_QR_Attendees.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.lst_QR_Attendees.Border.Class = "ListViewBorder"
        Me.lst_QR_Attendees.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ContextMenuBar1.SetContextMenuEx(Me.lst_QR_Attendees, Me.QR_Attendance)
        Me.lst_QR_Attendees.DisabledBackColor = System.Drawing.Color.Empty
        Me.lst_QR_Attendees.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lst_QR_Attendees.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lst_QR_Attendees.ForeColor = System.Drawing.Color.Black
        Me.lst_QR_Attendees.FullRowSelect = True
        Me.lst_QR_Attendees.GridLines = True
        Me.lst_QR_Attendees.HideSelection = False
        Me.lst_QR_Attendees.Location = New System.Drawing.Point(0, 109)
        Me.lst_QR_Attendees.MultiSelect = False
        Me.lst_QR_Attendees.Name = "lst_QR_Attendees"
        Me.lst_QR_Attendees.Size = New System.Drawing.Size(767, 420)
        Me.lst_QR_Attendees.TabIndex = 40
        Me.lst_QR_Attendees.UseCompatibleStateImageBehavior = False
        Me.lst_QR_Attendees.View = System.Windows.Forms.View.Details
        '
        'lst_users
        '
        Me.lst_users.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.lst_users.Border.Class = "ListViewBorder"
        Me.lst_users.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ContextMenuBar1.SetContextMenuEx(Me.lst_users, Me.cntx_MCO_Officers)
        Me.lst_users.DisabledBackColor = System.Drawing.Color.Empty
        Me.lst_users.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lst_users.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lst_users.ForeColor = System.Drawing.Color.Black
        Me.lst_users.FullRowSelect = True
        Me.lst_users.GridLines = True
        Me.lst_users.HideSelection = False
        Me.lst_users.Location = New System.Drawing.Point(0, 109)
        Me.lst_users.MultiSelect = False
        Me.lst_users.Name = "lst_users"
        Me.lst_users.Size = New System.Drawing.Size(767, 420)
        Me.lst_users.TabIndex = 34
        Me.lst_users.UseCompatibleStateImageBehavior = False
        Me.lst_users.View = System.Windows.Forms.View.Details
        '
        'lst_Self_Reg
        '
        Me.lst_Self_Reg.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.lst_Self_Reg.Border.Class = "ListViewBorder"
        Me.lst_Self_Reg.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ContextMenuBar1.SetContextMenuEx(Me.lst_Self_Reg, Me.cntx_Self_Reg)
        Me.lst_Self_Reg.DisabledBackColor = System.Drawing.Color.Empty
        Me.lst_Self_Reg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lst_Self_Reg.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lst_Self_Reg.ForeColor = System.Drawing.Color.Black
        Me.lst_Self_Reg.FullRowSelect = True
        Me.lst_Self_Reg.GridLines = True
        Me.lst_Self_Reg.HideSelection = False
        Me.lst_Self_Reg.Location = New System.Drawing.Point(0, 132)
        Me.lst_Self_Reg.MultiSelect = False
        Me.lst_Self_Reg.Name = "lst_Self_Reg"
        Me.lst_Self_Reg.Size = New System.Drawing.Size(767, 397)
        Me.lst_Self_Reg.TabIndex = 28
        Me.lst_Self_Reg.UseCompatibleStateImageBehavior = False
        Me.lst_Self_Reg.View = System.Windows.Forms.View.Details
        '
        'lst_Masterlist
        '
        Me.lst_Masterlist.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.lst_Masterlist.Border.Class = "ListViewBorder"
        Me.lst_Masterlist.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ContextMenuBar1.SetContextMenuEx(Me.lst_Masterlist, Me.cntx_Masterlist)
        Me.lst_Masterlist.DisabledBackColor = System.Drawing.Color.Empty
        Me.lst_Masterlist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lst_Masterlist.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lst_Masterlist.ForeColor = System.Drawing.Color.Black
        Me.lst_Masterlist.FullRowSelect = True
        Me.lst_Masterlist.GridLines = True
        Me.lst_Masterlist.HideSelection = False
        Me.lst_Masterlist.Location = New System.Drawing.Point(0, 132)
        Me.lst_Masterlist.MultiSelect = False
        Me.lst_Masterlist.Name = "lst_Masterlist"
        Me.lst_Masterlist.Size = New System.Drawing.Size(767, 397)
        Me.lst_Masterlist.TabIndex = 7
        Me.lst_Masterlist.UseCompatibleStateImageBehavior = False
        Me.lst_Masterlist.View = System.Windows.Forms.View.Details
        '
        'circ_prog_masterlist
        '
        Me.circ_prog_masterlist.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.circ_prog_masterlist.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.circ_prog_masterlist.Location = New System.Drawing.Point(326, 210)
        Me.circ_prog_masterlist.Name = "circ_prog_masterlist"
        Me.circ_prog_masterlist.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot
        Me.circ_prog_masterlist.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.circ_prog_masterlist.ProgressTextFormat = ""
        Me.circ_prog_masterlist.ProgressTextVisible = True
        Me.circ_prog_masterlist.Size = New System.Drawing.Size(100, 100)
        Me.circ_prog_masterlist.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.circ_prog_masterlist.TabIndex = 24
        Me.circ_prog_masterlist.Visible = False
        '
        'pan_masterlist_controls
        '
        Me.pan_masterlist_controls.CanvasColor = System.Drawing.SystemColors.Control
        Me.pan_masterlist_controls.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pan_masterlist_controls.Controls.Add(Me.chk_Mark_Sanitation_Only)
        Me.pan_masterlist_controls.Controls.Add(Me.rdo_Mstr_AccountNumberSearch)
        Me.pan_masterlist_controls.Controls.Add(Me.rdo_Mstr_Registrant_Search)
        Me.pan_masterlist_controls.Controls.Add(Me.rdo_Mstr_Address_Search)
        Me.pan_masterlist_controls.Controls.Add(Me.rdo_Mstr_NameSearch)
        Me.pan_masterlist_controls.Controls.Add(Me.btn_Refresh_Masterlist)
        Me.pan_masterlist_controls.Controls.Add(Me.btn_Masterlist_Search)
        Me.pan_masterlist_controls.Controls.Add(Me.txt_Mstr_Search_Term)
        Me.pan_masterlist_controls.Controls.Add(Me.lbl_Main)
        Me.pan_masterlist_controls.DisabledBackColor = System.Drawing.Color.Empty
        Me.pan_masterlist_controls.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_masterlist_controls.Location = New System.Drawing.Point(0, 0)
        Me.pan_masterlist_controls.Name = "pan_masterlist_controls"
        Me.pan_masterlist_controls.Size = New System.Drawing.Size(767, 132)
        Me.pan_masterlist_controls.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pan_masterlist_controls.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pan_masterlist_controls.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pan_masterlist_controls.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pan_masterlist_controls.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pan_masterlist_controls.Style.GradientAngle = 90
        Me.pan_masterlist_controls.TabIndex = 20
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
        Me.chk_Mark_Sanitation_Only.TabIndex = 9
        Me.chk_Mark_Sanitation_Only.Text = "Pending Sanitation Data Only"
        Me.chk_Mark_Sanitation_Only.UseVisualStyleBackColor = False
        '
        'rdo_Mstr_AccountNumberSearch
        '
        Me.rdo_Mstr_AccountNumberSearch.AutoSize = True
        Me.rdo_Mstr_AccountNumberSearch.ForeColor = System.Drawing.Color.Black
        Me.rdo_Mstr_AccountNumberSearch.Location = New System.Drawing.Point(84, 79)
        Me.rdo_Mstr_AccountNumberSearch.Name = "rdo_Mstr_AccountNumberSearch"
        Me.rdo_Mstr_AccountNumberSearch.Size = New System.Drawing.Size(163, 17)
        Me.rdo_Mstr_AccountNumberSearch.TabIndex = 4
        Me.rdo_Mstr_AccountNumberSearch.Text = "Search by Account Number"
        Me.rdo_Mstr_AccountNumberSearch.UseVisualStyleBackColor = True
        '
        'rdo_Mstr_Registrant_Search
        '
        Me.rdo_Mstr_Registrant_Search.AutoSize = True
        Me.rdo_Mstr_Registrant_Search.ForeColor = System.Drawing.Color.Black
        Me.rdo_Mstr_Registrant_Search.Location = New System.Drawing.Point(258, 56)
        Me.rdo_Mstr_Registrant_Search.Name = "rdo_Mstr_Registrant_Search"
        Me.rdo_Mstr_Registrant_Search.Size = New System.Drawing.Size(159, 17)
        Me.rdo_Mstr_Registrant_Search.TabIndex = 5
        Me.rdo_Mstr_Registrant_Search.Text = "Search by MCO Registrant"
        Me.rdo_Mstr_Registrant_Search.UseVisualStyleBackColor = True
        '
        'rdo_Mstr_Address_Search
        '
        Me.rdo_Mstr_Address_Search.AutoSize = True
        Me.rdo_Mstr_Address_Search.ForeColor = System.Drawing.Color.Black
        Me.rdo_Mstr_Address_Search.Location = New System.Drawing.Point(258, 79)
        Me.rdo_Mstr_Address_Search.Name = "rdo_Mstr_Address_Search"
        Me.rdo_Mstr_Address_Search.Size = New System.Drawing.Size(118, 17)
        Me.rdo_Mstr_Address_Search.TabIndex = 6
        Me.rdo_Mstr_Address_Search.Text = "Search by Address"
        Me.rdo_Mstr_Address_Search.UseVisualStyleBackColor = True
        '
        'rdo_Mstr_NameSearch
        '
        Me.rdo_Mstr_NameSearch.AutoSize = True
        Me.rdo_Mstr_NameSearch.Checked = True
        Me.rdo_Mstr_NameSearch.ForeColor = System.Drawing.Color.Black
        Me.rdo_Mstr_NameSearch.Location = New System.Drawing.Point(84, 56)
        Me.rdo_Mstr_NameSearch.Name = "rdo_Mstr_NameSearch"
        Me.rdo_Mstr_NameSearch.Size = New System.Drawing.Size(106, 17)
        Me.rdo_Mstr_NameSearch.TabIndex = 3
        Me.rdo_Mstr_NameSearch.TabStop = True
        Me.rdo_Mstr_NameSearch.Text = "Search by Name"
        Me.rdo_Mstr_NameSearch.UseVisualStyleBackColor = True
        '
        'btn_Refresh_Masterlist
        '
        Me.btn_Refresh_Masterlist.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Refresh_Masterlist.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.btn_Refresh_Masterlist.Location = New System.Drawing.Point(524, 56)
        Me.btn_Refresh_Masterlist.Name = "btn_Refresh_Masterlist"
        Me.btn_Refresh_Masterlist.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btn_Refresh_Masterlist.Size = New System.Drawing.Size(134, 35)
        Me.btn_Refresh_Masterlist.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Refresh_Masterlist.TabIndex = 2
        Me.btn_Refresh_Masterlist.Text = "Refresh List"
        '
        'btn_Masterlist_Search
        '
        Me.btn_Masterlist_Search.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Masterlist_Search.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.btn_Masterlist_Search.Location = New System.Drawing.Point(524, 15)
        Me.btn_Masterlist_Search.Name = "btn_Masterlist_Search"
        Me.btn_Masterlist_Search.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btn_Masterlist_Search.Size = New System.Drawing.Size(134, 35)
        Me.btn_Masterlist_Search.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Masterlist_Search.TabIndex = 1
        Me.btn_Masterlist_Search.Text = "Search"
        '
        'txt_Mstr_Search_Term
        '
        Me.txt_Mstr_Search_Term.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_Mstr_Search_Term.Border.Class = "TextBoxBorder"
        Me.txt_Mstr_Search_Term.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.txt_Mstr_Search_Term.DisabledBackColor = System.Drawing.Color.White
        Me.txt_Mstr_Search_Term.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txt_Mstr_Search_Term.ForeColor = System.Drawing.Color.Black
        Me.txt_Mstr_Search_Term.Location = New System.Drawing.Point(84, 17)
        Me.txt_Mstr_Search_Term.Name = "txt_Mstr_Search_Term"
        Me.txt_Mstr_Search_Term.PreventEnterBeep = True
        Me.txt_Mstr_Search_Term.Size = New System.Drawing.Size(434, 33)
        Me.txt_Mstr_Search_Term.TabIndex = 0
        '
        'lbl_Main
        '
        '
        '
        '
        Me.lbl_Main.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_Main.ForeColor = System.Drawing.Color.Black
        Me.lbl_Main.Location = New System.Drawing.Point(3, 15)
        Me.lbl_Main.Name = "lbl_Main"
        Me.lbl_Main.Size = New System.Drawing.Size(75, 23)
        Me.lbl_Main.TabIndex = 0
        Me.lbl_Main.Text = "Search Term:"
        Me.lbl_Main.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'sidenavpan_livetotals_onsite
        '
        Me.sidenavpan_livetotals_onsite.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.sidenavpan_livetotals_onsite.Controls.Add(Me.lbl_Total_Regs_Onsite)
        Me.sidenavpan_livetotals_onsite.Controls.Add(Me.lbl_Time_AMPM_Onsite)
        Me.sidenavpan_livetotals_onsite.Controls.Add(Me.lbl_Time_Minute_Onsite)
        Me.sidenavpan_livetotals_onsite.Controls.Add(Me.lbl_Time_Colon_Onsite)
        Me.sidenavpan_livetotals_onsite.Controls.Add(Me.lbl_Time_Hour_Onsite)
        Me.sidenavpan_livetotals_onsite.Controls.Add(Me.lbl_Time_Label_Onsite)
        Me.sidenavpan_livetotals_onsite.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sidenavpan_livetotals_onsite.ForeColor = System.Drawing.Color.Black
        Me.sidenavpan_livetotals_onsite.Location = New System.Drawing.Point(212, 31)
        Me.sidenavpan_livetotals_onsite.Name = "sidenavpan_livetotals_onsite"
        Me.sidenavpan_livetotals_onsite.Size = New System.Drawing.Size(767, 529)
        Me.sidenavpan_livetotals_onsite.TabIndex = 61
        '
        'lbl_Total_Regs_Onsite
        '
        Me.lbl_Total_Regs_Onsite.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbl_Total_Regs_Onsite.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_Total_Regs_Onsite.Font = New System.Drawing.Font("Bahnschrift Condensed", 80.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_Total_Regs_Onsite.ForeColor = System.Drawing.Color.Black
        Me.lbl_Total_Regs_Onsite.Location = New System.Drawing.Point(4, 87)
        Me.lbl_Total_Regs_Onsite.Name = "lbl_Total_Regs_Onsite"
        Me.lbl_Total_Regs_Onsite.Size = New System.Drawing.Size(768, 396)
        Me.lbl_Total_Regs_Onsite.TabIndex = 18
        Me.lbl_Total_Regs_Onsite.Text = "10,000"
        Me.lbl_Total_Regs_Onsite.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lbl_Time_AMPM_Onsite
        '
        Me.lbl_Time_AMPM_Onsite.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbl_Time_AMPM_Onsite.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_Time_AMPM_Onsite.Font = New System.Drawing.Font("Bahnschrift Condensed", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Time_AMPM_Onsite.ForeColor = System.Drawing.Color.Black
        Me.lbl_Time_AMPM_Onsite.Location = New System.Drawing.Point(340, 6)
        Me.lbl_Time_AMPM_Onsite.Name = "lbl_Time_AMPM_Onsite"
        Me.lbl_Time_AMPM_Onsite.Size = New System.Drawing.Size(78, 57)
        Me.lbl_Time_AMPM_Onsite.TabIndex = 17
        Me.lbl_Time_AMPM_Onsite.Text = "PM"
        Me.lbl_Time_AMPM_Onsite.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lbl_Time_Minute_Onsite
        '
        Me.lbl_Time_Minute_Onsite.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbl_Time_Minute_Onsite.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_Time_Minute_Onsite.Font = New System.Drawing.Font("Bahnschrift Condensed", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Time_Minute_Onsite.ForeColor = System.Drawing.Color.Black
        Me.lbl_Time_Minute_Onsite.Location = New System.Drawing.Point(274, 6)
        Me.lbl_Time_Minute_Onsite.Name = "lbl_Time_Minute_Onsite"
        Me.lbl_Time_Minute_Onsite.Size = New System.Drawing.Size(60, 57)
        Me.lbl_Time_Minute_Onsite.TabIndex = 16
        Me.lbl_Time_Minute_Onsite.Text = "69"
        Me.lbl_Time_Minute_Onsite.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lbl_Time_Colon_Onsite
        '
        Me.lbl_Time_Colon_Onsite.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbl_Time_Colon_Onsite.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_Time_Colon_Onsite.Font = New System.Drawing.Font("Bahnschrift Condensed", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Time_Colon_Onsite.ForeColor = System.Drawing.Color.Black
        Me.lbl_Time_Colon_Onsite.Location = New System.Drawing.Point(245, 6)
        Me.lbl_Time_Colon_Onsite.Name = "lbl_Time_Colon_Onsite"
        Me.lbl_Time_Colon_Onsite.Size = New System.Drawing.Size(23, 57)
        Me.lbl_Time_Colon_Onsite.TabIndex = 15
        Me.lbl_Time_Colon_Onsite.Text = ":"
        Me.lbl_Time_Colon_Onsite.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lbl_Time_Hour_Onsite
        '
        Me.lbl_Time_Hour_Onsite.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbl_Time_Hour_Onsite.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_Time_Hour_Onsite.Font = New System.Drawing.Font("Bahnschrift Condensed", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Time_Hour_Onsite.ForeColor = System.Drawing.Color.Black
        Me.lbl_Time_Hour_Onsite.Location = New System.Drawing.Point(181, 6)
        Me.lbl_Time_Hour_Onsite.Name = "lbl_Time_Hour_Onsite"
        Me.lbl_Time_Hour_Onsite.Size = New System.Drawing.Size(58, 57)
        Me.lbl_Time_Hour_Onsite.TabIndex = 13
        Me.lbl_Time_Hour_Onsite.Text = "12"
        Me.lbl_Time_Hour_Onsite.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lbl_Time_Label_Onsite
        '
        Me.lbl_Time_Label_Onsite.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbl_Time_Label_Onsite.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_Time_Label_Onsite.Font = New System.Drawing.Font("Bahnschrift Condensed", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Time_Label_Onsite.ForeColor = System.Drawing.Color.Black
        Me.lbl_Time_Label_Onsite.Location = New System.Drawing.Point(3, 3)
        Me.lbl_Time_Label_Onsite.Name = "lbl_Time_Label_Onsite"
        Me.lbl_Time_Label_Onsite.Size = New System.Drawing.Size(145, 63)
        Me.lbl_Time_Label_Onsite.TabIndex = 14
        Me.lbl_Time_Label_Onsite.Text = "Time: "
        Me.lbl_Time_Label_Onsite.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'sidenavpan_livetotals_per_district
        '
        Me.sidenavpan_livetotals_per_district.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.sidenavpan_livetotals_per_district.Controls.Add(Me.lbl_Time_AMPM_Area)
        Me.sidenavpan_livetotals_per_district.Controls.Add(Me.lbl_Time_Minute_Area)
        Me.sidenavpan_livetotals_per_district.Controls.Add(Me.lbl_Time_Colon_Area)
        Me.sidenavpan_livetotals_per_district.Controls.Add(Me.lbl_Total_Regs_Area)
        Me.sidenavpan_livetotals_per_district.Controls.Add(Me.lbl_Time_Hour_Area)
        Me.sidenavpan_livetotals_per_district.Controls.Add(Me.lbl_Time_Label_Area)
        Me.sidenavpan_livetotals_per_district.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sidenavpan_livetotals_per_district.ForeColor = System.Drawing.Color.Black
        Me.sidenavpan_livetotals_per_district.Location = New System.Drawing.Point(212, 31)
        Me.sidenavpan_livetotals_per_district.Name = "sidenavpan_livetotals_per_district"
        Me.sidenavpan_livetotals_per_district.Size = New System.Drawing.Size(767, 529)
        Me.sidenavpan_livetotals_per_district.TabIndex = 25
        Me.sidenavpan_livetotals_per_district.Visible = False
        '
        'lbl_Time_AMPM_Area
        '
        Me.lbl_Time_AMPM_Area.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbl_Time_AMPM_Area.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_Time_AMPM_Area.Font = New System.Drawing.Font("Bahnschrift Condensed", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Time_AMPM_Area.ForeColor = System.Drawing.Color.Black
        Me.lbl_Time_AMPM_Area.Location = New System.Drawing.Point(340, 7)
        Me.lbl_Time_AMPM_Area.Name = "lbl_Time_AMPM_Area"
        Me.lbl_Time_AMPM_Area.Size = New System.Drawing.Size(78, 57)
        Me.lbl_Time_AMPM_Area.TabIndex = 12
        Me.lbl_Time_AMPM_Area.Text = "PM"
        Me.lbl_Time_AMPM_Area.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lbl_Time_Minute_Area
        '
        Me.lbl_Time_Minute_Area.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbl_Time_Minute_Area.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_Time_Minute_Area.Font = New System.Drawing.Font("Bahnschrift Condensed", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Time_Minute_Area.ForeColor = System.Drawing.Color.Black
        Me.lbl_Time_Minute_Area.Location = New System.Drawing.Point(274, 7)
        Me.lbl_Time_Minute_Area.Name = "lbl_Time_Minute_Area"
        Me.lbl_Time_Minute_Area.Size = New System.Drawing.Size(60, 57)
        Me.lbl_Time_Minute_Area.TabIndex = 11
        Me.lbl_Time_Minute_Area.Text = "69"
        Me.lbl_Time_Minute_Area.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lbl_Time_Colon_Area
        '
        Me.lbl_Time_Colon_Area.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbl_Time_Colon_Area.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_Time_Colon_Area.Font = New System.Drawing.Font("Bahnschrift Condensed", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Time_Colon_Area.ForeColor = System.Drawing.Color.Black
        Me.lbl_Time_Colon_Area.Location = New System.Drawing.Point(245, 7)
        Me.lbl_Time_Colon_Area.Name = "lbl_Time_Colon_Area"
        Me.lbl_Time_Colon_Area.Size = New System.Drawing.Size(23, 57)
        Me.lbl_Time_Colon_Area.TabIndex = 10
        Me.lbl_Time_Colon_Area.Text = ":"
        Me.lbl_Time_Colon_Area.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lbl_Total_Regs_Area
        '
        Me.lbl_Total_Regs_Area.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbl_Total_Regs_Area.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_Total_Regs_Area.Font = New System.Drawing.Font("Bahnschrift Condensed", 80.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_Total_Regs_Area.ForeColor = System.Drawing.Color.Black
        Me.lbl_Total_Regs_Area.Location = New System.Drawing.Point(-1, 87)
        Me.lbl_Total_Regs_Area.Name = "lbl_Total_Regs_Area"
        Me.lbl_Total_Regs_Area.Size = New System.Drawing.Size(768, 396)
        Me.lbl_Total_Regs_Area.TabIndex = 8
        Me.lbl_Total_Regs_Area.Text = "10,000"
        Me.lbl_Total_Regs_Area.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lbl_Time_Hour_Area
        '
        Me.lbl_Time_Hour_Area.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbl_Time_Hour_Area.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_Time_Hour_Area.Font = New System.Drawing.Font("Bahnschrift Condensed", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Time_Hour_Area.ForeColor = System.Drawing.Color.Black
        Me.lbl_Time_Hour_Area.Location = New System.Drawing.Point(181, 7)
        Me.lbl_Time_Hour_Area.Name = "lbl_Time_Hour_Area"
        Me.lbl_Time_Hour_Area.Size = New System.Drawing.Size(58, 57)
        Me.lbl_Time_Hour_Area.TabIndex = 6
        Me.lbl_Time_Hour_Area.Text = "12"
        Me.lbl_Time_Hour_Area.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lbl_Time_Label_Area
        '
        Me.lbl_Time_Label_Area.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbl_Time_Label_Area.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_Time_Label_Area.Font = New System.Drawing.Font("Bahnschrift Condensed", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Time_Label_Area.ForeColor = System.Drawing.Color.Black
        Me.lbl_Time_Label_Area.Location = New System.Drawing.Point(3, 4)
        Me.lbl_Time_Label_Area.Name = "lbl_Time_Label_Area"
        Me.lbl_Time_Label_Area.Size = New System.Drawing.Size(145, 63)
        Me.lbl_Time_Label_Area.TabIndex = 7
        Me.lbl_Time_Label_Area.Text = "Time: "
        Me.lbl_Time_Label_Area.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'SideNavPanel1
        '
        Me.SideNavPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.SideNavPanel1.Controls.Add(Me.circ_del_prog)
        Me.SideNavPanel1.Controls.Add(Me.lst_del_logs)
        Me.SideNavPanel1.Controls.Add(Me.pan_del_logs_control)
        Me.SideNavPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SideNavPanel1.ForeColor = System.Drawing.Color.Black
        Me.SideNavPanel1.Location = New System.Drawing.Point(212, 31)
        Me.SideNavPanel1.Name = "SideNavPanel1"
        Me.SideNavPanel1.Size = New System.Drawing.Size(767, 529)
        Me.SideNavPanel1.TabIndex = 48
        Me.SideNavPanel1.Visible = False
        '
        'circ_del_prog
        '
        Me.circ_del_prog.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.circ_del_prog.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.circ_del_prog.Location = New System.Drawing.Point(333, 214)
        Me.circ_del_prog.Name = "circ_del_prog"
        Me.circ_del_prog.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot
        Me.circ_del_prog.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.circ_del_prog.ProgressTextFormat = ""
        Me.circ_del_prog.ProgressTextVisible = True
        Me.circ_del_prog.Size = New System.Drawing.Size(100, 100)
        Me.circ_del_prog.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.circ_del_prog.TabIndex = 41
        Me.circ_del_prog.Visible = False
        '
        'pan_del_logs_control
        '
        Me.pan_del_logs_control.CanvasColor = System.Drawing.SystemColors.Control
        Me.pan_del_logs_control.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pan_del_logs_control.Controls.Add(Me.rdo_del_Search_by_Account_Name)
        Me.pan_del_logs_control.Controls.Add(Me.rdo_del_Search_by_Del_Username)
        Me.pan_del_logs_control.Controls.Add(Me.rdo_del_Search_by_Reg_Username)
        Me.pan_del_logs_control.Controls.Add(Me.rdo_del_Search_by_Account_Num)
        Me.pan_del_logs_control.Controls.Add(Me.btn_del_Refresh)
        Me.pan_del_logs_control.Controls.Add(Me.btn_del_Search)
        Me.pan_del_logs_control.Controls.Add(Me.txt_del_Search_Term)
        Me.pan_del_logs_control.Controls.Add(Me.LabelX5)
        Me.pan_del_logs_control.DisabledBackColor = System.Drawing.Color.Empty
        Me.pan_del_logs_control.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_del_logs_control.Location = New System.Drawing.Point(0, 0)
        Me.pan_del_logs_control.Name = "pan_del_logs_control"
        Me.pan_del_logs_control.Size = New System.Drawing.Size(767, 109)
        Me.pan_del_logs_control.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pan_del_logs_control.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pan_del_logs_control.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pan_del_logs_control.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pan_del_logs_control.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pan_del_logs_control.Style.GradientAngle = 90
        Me.pan_del_logs_control.TabIndex = 40
        '
        'rdo_del_Search_by_Account_Name
        '
        Me.rdo_del_Search_by_Account_Name.AutoSize = True
        Me.rdo_del_Search_by_Account_Name.ForeColor = System.Drawing.Color.Black
        Me.rdo_del_Search_by_Account_Name.Location = New System.Drawing.Point(84, 79)
        Me.rdo_del_Search_by_Account_Name.Name = "rdo_del_Search_by_Account_Name"
        Me.rdo_del_Search_by_Account_Name.Size = New System.Drawing.Size(151, 17)
        Me.rdo_del_Search_by_Account_Name.TabIndex = 4
        Me.rdo_del_Search_by_Account_Name.Text = "Search by Account Name"
        Me.rdo_del_Search_by_Account_Name.UseVisualStyleBackColor = True
        '
        'rdo_del_Search_by_Del_Username
        '
        Me.rdo_del_Search_by_Del_Username.AutoSize = True
        Me.rdo_del_Search_by_Del_Username.ForeColor = System.Drawing.Color.Black
        Me.rdo_del_Search_by_Del_Username.Location = New System.Drawing.Point(258, 79)
        Me.rdo_del_Search_by_Del_Username.Name = "rdo_del_Search_by_Del_Username"
        Me.rdo_del_Search_by_Del_Username.Size = New System.Drawing.Size(168, 17)
        Me.rdo_del_Search_by_Del_Username.TabIndex = 6
        Me.rdo_del_Search_by_Del_Username.Text = "Search by Deleter Username"
        Me.rdo_del_Search_by_Del_Username.UseVisualStyleBackColor = True
        '
        'rdo_del_Search_by_Reg_Username
        '
        Me.rdo_del_Search_by_Reg_Username.AutoSize = True
        Me.rdo_del_Search_by_Reg_Username.ForeColor = System.Drawing.Color.Black
        Me.rdo_del_Search_by_Reg_Username.Location = New System.Drawing.Point(258, 56)
        Me.rdo_del_Search_by_Reg_Username.Name = "rdo_del_Search_by_Reg_Username"
        Me.rdo_del_Search_by_Reg_Username.Size = New System.Drawing.Size(184, 17)
        Me.rdo_del_Search_by_Reg_Username.TabIndex = 6
        Me.rdo_del_Search_by_Reg_Username.Text = "Search by Registrant Username"
        Me.rdo_del_Search_by_Reg_Username.UseVisualStyleBackColor = True
        '
        'rdo_del_Search_by_Account_Num
        '
        Me.rdo_del_Search_by_Account_Num.AutoSize = True
        Me.rdo_del_Search_by_Account_Num.Checked = True
        Me.rdo_del_Search_by_Account_Num.ForeColor = System.Drawing.Color.Black
        Me.rdo_del_Search_by_Account_Num.Location = New System.Drawing.Point(84, 56)
        Me.rdo_del_Search_by_Account_Num.Name = "rdo_del_Search_by_Account_Num"
        Me.rdo_del_Search_by_Account_Num.Size = New System.Drawing.Size(163, 17)
        Me.rdo_del_Search_by_Account_Num.TabIndex = 3
        Me.rdo_del_Search_by_Account_Num.TabStop = True
        Me.rdo_del_Search_by_Account_Num.Text = "Search by Account Number"
        Me.rdo_del_Search_by_Account_Num.UseVisualStyleBackColor = True
        '
        'btn_del_Refresh
        '
        Me.btn_del_Refresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_del_Refresh.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.btn_del_Refresh.Location = New System.Drawing.Point(524, 56)
        Me.btn_del_Refresh.Name = "btn_del_Refresh"
        Me.btn_del_Refresh.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btn_del_Refresh.Size = New System.Drawing.Size(134, 35)
        Me.btn_del_Refresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_del_Refresh.TabIndex = 2
        Me.btn_del_Refresh.Text = "Refresh List"
        '
        'btn_del_Search
        '
        Me.btn_del_Search.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_del_Search.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.btn_del_Search.Location = New System.Drawing.Point(524, 15)
        Me.btn_del_Search.Name = "btn_del_Search"
        Me.btn_del_Search.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btn_del_Search.Size = New System.Drawing.Size(134, 35)
        Me.btn_del_Search.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_del_Search.TabIndex = 1
        Me.btn_del_Search.Text = "Search"
        '
        'txt_del_Search_Term
        '
        Me.txt_del_Search_Term.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_del_Search_Term.Border.Class = "TextBoxBorder"
        Me.txt_del_Search_Term.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.txt_del_Search_Term.DisabledBackColor = System.Drawing.Color.White
        Me.txt_del_Search_Term.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txt_del_Search_Term.ForeColor = System.Drawing.Color.Black
        Me.txt_del_Search_Term.Location = New System.Drawing.Point(84, 17)
        Me.txt_del_Search_Term.Name = "txt_del_Search_Term"
        Me.txt_del_Search_Term.PreventEnterBeep = True
        Me.txt_del_Search_Term.Size = New System.Drawing.Size(434, 33)
        Me.txt_del_Search_Term.TabIndex = 0
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.ForeColor = System.Drawing.Color.Black
        Me.LabelX5.Location = New System.Drawing.Point(3, 15)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(75, 23)
        Me.LabelX5.TabIndex = 0
        Me.LabelX5.Text = "Search Term:"
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'sidenavpan_QR_Attendance
        '
        Me.sidenavpan_QR_Attendance.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.sidenavpan_QR_Attendance.Controls.Add(Me.circ_prog_QR)
        Me.sidenavpan_QR_Attendance.Controls.Add(Me.lst_QR_Attendees)
        Me.sidenavpan_QR_Attendance.Controls.Add(Me.pan_QR_control)
        Me.sidenavpan_QR_Attendance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sidenavpan_QR_Attendance.ForeColor = System.Drawing.Color.Black
        Me.sidenavpan_QR_Attendance.Location = New System.Drawing.Point(212, 31)
        Me.sidenavpan_QR_Attendance.Name = "sidenavpan_QR_Attendance"
        Me.sidenavpan_QR_Attendance.Size = New System.Drawing.Size(767, 529)
        Me.sidenavpan_QR_Attendance.TabIndex = 32
        Me.sidenavpan_QR_Attendance.Visible = False
        '
        'circ_prog_QR
        '
        Me.circ_prog_QR.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.circ_prog_QR.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.circ_prog_QR.Location = New System.Drawing.Point(326, 210)
        Me.circ_prog_QR.Name = "circ_prog_QR"
        Me.circ_prog_QR.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot
        Me.circ_prog_QR.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.circ_prog_QR.ProgressTextFormat = ""
        Me.circ_prog_QR.ProgressTextVisible = True
        Me.circ_prog_QR.Size = New System.Drawing.Size(100, 100)
        Me.circ_prog_QR.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.circ_prog_QR.TabIndex = 42
        Me.circ_prog_QR.Visible = False
        '
        'pan_QR_control
        '
        Me.pan_QR_control.CanvasColor = System.Drawing.SystemColors.Control
        Me.pan_QR_control.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pan_QR_control.Controls.Add(Me.rdo_QR_Search_by_Account_Number)
        Me.pan_QR_control.Controls.Add(Me.rdo_QR_Search_by_Account_Name)
        Me.pan_QR_control.Controls.Add(Me.btn_QR_Refresh_List)
        Me.pan_QR_control.Controls.Add(Me.btn_QR_Search)
        Me.pan_QR_control.Controls.Add(Me.txt_QR_Search_Term)
        Me.pan_QR_control.Controls.Add(Me.LabelX4)
        Me.pan_QR_control.DisabledBackColor = System.Drawing.Color.Empty
        Me.pan_QR_control.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_QR_control.Location = New System.Drawing.Point(0, 0)
        Me.pan_QR_control.Name = "pan_QR_control"
        Me.pan_QR_control.Size = New System.Drawing.Size(767, 109)
        Me.pan_QR_control.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pan_QR_control.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pan_QR_control.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pan_QR_control.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pan_QR_control.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pan_QR_control.Style.GradientAngle = 90
        Me.pan_QR_control.TabIndex = 41
        '
        'rdo_QR_Search_by_Account_Number
        '
        Me.rdo_QR_Search_by_Account_Number.AutoSize = True
        Me.rdo_QR_Search_by_Account_Number.ForeColor = System.Drawing.Color.Black
        Me.rdo_QR_Search_by_Account_Number.Location = New System.Drawing.Point(263, 56)
        Me.rdo_QR_Search_by_Account_Number.Name = "rdo_QR_Search_by_Account_Number"
        Me.rdo_QR_Search_by_Account_Number.Size = New System.Drawing.Size(163, 17)
        Me.rdo_QR_Search_by_Account_Number.TabIndex = 4
        Me.rdo_QR_Search_by_Account_Number.Text = "Search by Account Number"
        Me.rdo_QR_Search_by_Account_Number.UseVisualStyleBackColor = True
        '
        'rdo_QR_Search_by_Account_Name
        '
        Me.rdo_QR_Search_by_Account_Name.AutoSize = True
        Me.rdo_QR_Search_by_Account_Name.Checked = True
        Me.rdo_QR_Search_by_Account_Name.ForeColor = System.Drawing.Color.Black
        Me.rdo_QR_Search_by_Account_Name.Location = New System.Drawing.Point(84, 56)
        Me.rdo_QR_Search_by_Account_Name.Name = "rdo_QR_Search_by_Account_Name"
        Me.rdo_QR_Search_by_Account_Name.Size = New System.Drawing.Size(151, 17)
        Me.rdo_QR_Search_by_Account_Name.TabIndex = 3
        Me.rdo_QR_Search_by_Account_Name.TabStop = True
        Me.rdo_QR_Search_by_Account_Name.Text = "Search by Account Name"
        Me.rdo_QR_Search_by_Account_Name.UseVisualStyleBackColor = True
        '
        'btn_QR_Refresh_List
        '
        Me.btn_QR_Refresh_List.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_QR_Refresh_List.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.btn_QR_Refresh_List.Location = New System.Drawing.Point(524, 56)
        Me.btn_QR_Refresh_List.Name = "btn_QR_Refresh_List"
        Me.btn_QR_Refresh_List.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btn_QR_Refresh_List.Size = New System.Drawing.Size(134, 35)
        Me.btn_QR_Refresh_List.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_QR_Refresh_List.TabIndex = 2
        Me.btn_QR_Refresh_List.Text = "Refresh List"
        '
        'btn_QR_Search
        '
        Me.btn_QR_Search.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_QR_Search.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.btn_QR_Search.Location = New System.Drawing.Point(524, 15)
        Me.btn_QR_Search.Name = "btn_QR_Search"
        Me.btn_QR_Search.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btn_QR_Search.Size = New System.Drawing.Size(134, 35)
        Me.btn_QR_Search.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_QR_Search.TabIndex = 1
        Me.btn_QR_Search.Text = "Search"
        '
        'txt_QR_Search_Term
        '
        Me.txt_QR_Search_Term.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_QR_Search_Term.Border.Class = "TextBoxBorder"
        Me.txt_QR_Search_Term.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.txt_QR_Search_Term.DisabledBackColor = System.Drawing.Color.White
        Me.txt_QR_Search_Term.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txt_QR_Search_Term.ForeColor = System.Drawing.Color.Black
        Me.txt_QR_Search_Term.Location = New System.Drawing.Point(84, 17)
        Me.txt_QR_Search_Term.Name = "txt_QR_Search_Term"
        Me.txt_QR_Search_Term.PreventEnterBeep = True
        Me.txt_QR_Search_Term.Size = New System.Drawing.Size(434, 33)
        Me.txt_QR_Search_Term.TabIndex = 0
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.ForeColor = System.Drawing.Color.Black
        Me.LabelX4.Location = New System.Drawing.Point(3, 15)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(75, 23)
        Me.LabelX4.TabIndex = 0
        Me.LabelX4.Text = "Search Term:"
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'sidenavpan_Officer_List
        '
        Me.sidenavpan_Officer_List.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.sidenavpan_Officer_List.Controls.Add(Me.circ_users_prog)
        Me.sidenavpan_Officer_List.Controls.Add(Me.lst_users)
        Me.sidenavpan_Officer_List.Controls.Add(Me.pan_users_control)
        Me.sidenavpan_Officer_List.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sidenavpan_Officer_List.ForeColor = System.Drawing.Color.Black
        Me.sidenavpan_Officer_List.Location = New System.Drawing.Point(212, 31)
        Me.sidenavpan_Officer_List.Name = "sidenavpan_Officer_List"
        Me.sidenavpan_Officer_List.Size = New System.Drawing.Size(767, 529)
        Me.sidenavpan_Officer_List.TabIndex = 10
        Me.sidenavpan_Officer_List.Visible = False
        '
        'circ_users_prog
        '
        Me.circ_users_prog.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.circ_users_prog.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.circ_users_prog.Location = New System.Drawing.Point(326, 210)
        Me.circ_users_prog.Name = "circ_users_prog"
        Me.circ_users_prog.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot
        Me.circ_users_prog.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.circ_users_prog.ProgressTextFormat = ""
        Me.circ_users_prog.ProgressTextVisible = True
        Me.circ_users_prog.Size = New System.Drawing.Size(100, 100)
        Me.circ_users_prog.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.circ_users_prog.TabIndex = 36
        Me.circ_users_prog.Visible = False
        '
        'pan_users_control
        '
        Me.pan_users_control.CanvasColor = System.Drawing.SystemColors.Control
        Me.pan_users_control.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pan_users_control.Controls.Add(Me.rdo_user_search_by_Username)
        Me.pan_users_control.Controls.Add(Me.rdo_user_search_by_Designation)
        Me.pan_users_control.Controls.Add(Me.rdo_user_search_by_Address)
        Me.pan_users_control.Controls.Add(Me.rdo_user_search_by_Real_Name)
        Me.pan_users_control.Controls.Add(Me.btn_user_refresh_list)
        Me.pan_users_control.Controls.Add(Me.btn_user_Search)
        Me.pan_users_control.Controls.Add(Me.txt_user_Search_Term)
        Me.pan_users_control.Controls.Add(Me.LabelX3)
        Me.pan_users_control.DisabledBackColor = System.Drawing.Color.Empty
        Me.pan_users_control.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_users_control.Location = New System.Drawing.Point(0, 0)
        Me.pan_users_control.Name = "pan_users_control"
        Me.pan_users_control.Size = New System.Drawing.Size(767, 109)
        Me.pan_users_control.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pan_users_control.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pan_users_control.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pan_users_control.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pan_users_control.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pan_users_control.Style.GradientAngle = 90
        Me.pan_users_control.TabIndex = 35
        '
        'rdo_user_search_by_Username
        '
        Me.rdo_user_search_by_Username.AutoSize = True
        Me.rdo_user_search_by_Username.ForeColor = System.Drawing.Color.Black
        Me.rdo_user_search_by_Username.Location = New System.Drawing.Point(84, 79)
        Me.rdo_user_search_by_Username.Name = "rdo_user_search_by_Username"
        Me.rdo_user_search_by_Username.Size = New System.Drawing.Size(128, 17)
        Me.rdo_user_search_by_Username.TabIndex = 4
        Me.rdo_user_search_by_Username.Text = "Search by Username"
        Me.rdo_user_search_by_Username.UseVisualStyleBackColor = True
        '
        'rdo_user_search_by_Designation
        '
        Me.rdo_user_search_by_Designation.AutoSize = True
        Me.rdo_user_search_by_Designation.ForeColor = System.Drawing.Color.Black
        Me.rdo_user_search_by_Designation.Location = New System.Drawing.Point(258, 79)
        Me.rdo_user_search_by_Designation.Name = "rdo_user_search_by_Designation"
        Me.rdo_user_search_by_Designation.Size = New System.Drawing.Size(140, 17)
        Me.rdo_user_search_by_Designation.TabIndex = 6
        Me.rdo_user_search_by_Designation.Text = "Search by Designation"
        Me.rdo_user_search_by_Designation.UseVisualStyleBackColor = True
        '
        'rdo_user_search_by_Address
        '
        Me.rdo_user_search_by_Address.AutoSize = True
        Me.rdo_user_search_by_Address.ForeColor = System.Drawing.Color.Black
        Me.rdo_user_search_by_Address.Location = New System.Drawing.Point(258, 56)
        Me.rdo_user_search_by_Address.Name = "rdo_user_search_by_Address"
        Me.rdo_user_search_by_Address.Size = New System.Drawing.Size(118, 17)
        Me.rdo_user_search_by_Address.TabIndex = 6
        Me.rdo_user_search_by_Address.Text = "Search by Address"
        Me.rdo_user_search_by_Address.UseVisualStyleBackColor = True
        '
        'rdo_user_search_by_Real_Name
        '
        Me.rdo_user_search_by_Real_Name.AutoSize = True
        Me.rdo_user_search_by_Real_Name.Checked = True
        Me.rdo_user_search_by_Real_Name.ForeColor = System.Drawing.Color.Black
        Me.rdo_user_search_by_Real_Name.Location = New System.Drawing.Point(84, 56)
        Me.rdo_user_search_by_Real_Name.Name = "rdo_user_search_by_Real_Name"
        Me.rdo_user_search_by_Real_Name.Size = New System.Drawing.Size(131, 17)
        Me.rdo_user_search_by_Real_Name.TabIndex = 3
        Me.rdo_user_search_by_Real_Name.TabStop = True
        Me.rdo_user_search_by_Real_Name.Text = "Search by Real Name"
        Me.rdo_user_search_by_Real_Name.UseVisualStyleBackColor = True
        '
        'btn_user_refresh_list
        '
        Me.btn_user_refresh_list.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_user_refresh_list.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.btn_user_refresh_list.Location = New System.Drawing.Point(524, 56)
        Me.btn_user_refresh_list.Name = "btn_user_refresh_list"
        Me.btn_user_refresh_list.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btn_user_refresh_list.Size = New System.Drawing.Size(134, 35)
        Me.btn_user_refresh_list.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_user_refresh_list.TabIndex = 2
        Me.btn_user_refresh_list.Text = "Refresh List"
        '
        'btn_user_Search
        '
        Me.btn_user_Search.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_user_Search.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.btn_user_Search.Location = New System.Drawing.Point(524, 15)
        Me.btn_user_Search.Name = "btn_user_Search"
        Me.btn_user_Search.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btn_user_Search.Size = New System.Drawing.Size(134, 35)
        Me.btn_user_Search.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_user_Search.TabIndex = 1
        Me.btn_user_Search.Text = "Search"
        '
        'txt_user_Search_Term
        '
        Me.txt_user_Search_Term.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_user_Search_Term.Border.Class = "TextBoxBorder"
        Me.txt_user_Search_Term.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.txt_user_Search_Term.DisabledBackColor = System.Drawing.Color.White
        Me.txt_user_Search_Term.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txt_user_Search_Term.ForeColor = System.Drawing.Color.Black
        Me.txt_user_Search_Term.Location = New System.Drawing.Point(84, 17)
        Me.txt_user_Search_Term.Name = "txt_user_Search_Term"
        Me.txt_user_Search_Term.PreventEnterBeep = True
        Me.txt_user_Search_Term.Size = New System.Drawing.Size(434, 33)
        Me.txt_user_Search_Term.TabIndex = 0
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
        'sidenavpan_self_reg
        '
        Me.sidenavpan_self_reg.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.sidenavpan_self_reg.Controls.Add(Me.circ_self_reg)
        Me.sidenavpan_self_reg.Controls.Add(Me.lst_Self_Reg)
        Me.sidenavpan_self_reg.Controls.Add(Me.pan_self_controls)
        Me.sidenavpan_self_reg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sidenavpan_self_reg.ForeColor = System.Drawing.Color.Black
        Me.sidenavpan_self_reg.Location = New System.Drawing.Point(212, 31)
        Me.sidenavpan_self_reg.Name = "sidenavpan_self_reg"
        Me.sidenavpan_self_reg.Size = New System.Drawing.Size(767, 529)
        Me.sidenavpan_self_reg.TabIndex = 18
        Me.sidenavpan_self_reg.Visible = False
        '
        'circ_self_reg
        '
        Me.circ_self_reg.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.circ_self_reg.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.circ_self_reg.Location = New System.Drawing.Point(326, 240)
        Me.circ_self_reg.Name = "circ_self_reg"
        Me.circ_self_reg.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot
        Me.circ_self_reg.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.circ_self_reg.ProgressTextFormat = ""
        Me.circ_self_reg.ProgressTextVisible = True
        Me.circ_self_reg.Size = New System.Drawing.Size(100, 100)
        Me.circ_self_reg.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.circ_self_reg.TabIndex = 30
        Me.circ_self_reg.Visible = False
        '
        'pan_self_controls
        '
        Me.pan_self_controls.CanvasColor = System.Drawing.SystemColors.Control
        Me.pan_self_controls.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pan_self_controls.Controls.Add(Me.chk_Guest_Sanitation_Only)
        Me.pan_self_controls.Controls.Add(Me.rdo_self_by_number)
        Me.pan_self_controls.Controls.Add(Me.rdo_self_by_address)
        Me.pan_self_controls.Controls.Add(Me.rdo_self_by_name)
        Me.pan_self_controls.Controls.Add(Me.btn_self_refresh)
        Me.pan_self_controls.Controls.Add(Me.btn_self_search)
        Me.pan_self_controls.Controls.Add(Me.txt_Self_Search_Term)
        Me.pan_self_controls.Controls.Add(Me.LabelX2)
        Me.pan_self_controls.DisabledBackColor = System.Drawing.Color.Empty
        Me.pan_self_controls.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_self_controls.Location = New System.Drawing.Point(0, 0)
        Me.pan_self_controls.Name = "pan_self_controls"
        Me.pan_self_controls.Size = New System.Drawing.Size(767, 132)
        Me.pan_self_controls.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pan_self_controls.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pan_self_controls.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pan_self_controls.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pan_self_controls.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pan_self_controls.Style.GradientAngle = 90
        Me.pan_self_controls.TabIndex = 29
        '
        'chk_Guest_Sanitation_Only
        '
        Me.chk_Guest_Sanitation_Only.AutoSize = True
        Me.chk_Guest_Sanitation_Only.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chk_Guest_Sanitation_Only.Checked = True
        Me.chk_Guest_Sanitation_Only.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Guest_Sanitation_Only.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.chk_Guest_Sanitation_Only.ForeColor = System.Drawing.Color.Black
        Me.chk_Guest_Sanitation_Only.Location = New System.Drawing.Point(84, 102)
        Me.chk_Guest_Sanitation_Only.Name = "chk_Guest_Sanitation_Only"
        Me.chk_Guest_Sanitation_Only.Size = New System.Drawing.Size(214, 23)
        Me.chk_Guest_Sanitation_Only.TabIndex = 10
        Me.chk_Guest_Sanitation_Only.Text = "Pending Sanitation Data Only"
        Me.chk_Guest_Sanitation_Only.UseVisualStyleBackColor = False
        '
        'rdo_self_by_number
        '
        Me.rdo_self_by_number.AutoSize = True
        Me.rdo_self_by_number.ForeColor = System.Drawing.Color.Black
        Me.rdo_self_by_number.Location = New System.Drawing.Point(84, 79)
        Me.rdo_self_by_number.Name = "rdo_self_by_number"
        Me.rdo_self_by_number.Size = New System.Drawing.Size(163, 17)
        Me.rdo_self_by_number.TabIndex = 4
        Me.rdo_self_by_number.Text = "Search by Account Number"
        Me.rdo_self_by_number.UseVisualStyleBackColor = True
        '
        'rdo_self_by_address
        '
        Me.rdo_self_by_address.AutoSize = True
        Me.rdo_self_by_address.ForeColor = System.Drawing.Color.Black
        Me.rdo_self_by_address.Location = New System.Drawing.Point(258, 56)
        Me.rdo_self_by_address.Name = "rdo_self_by_address"
        Me.rdo_self_by_address.Size = New System.Drawing.Size(118, 17)
        Me.rdo_self_by_address.TabIndex = 6
        Me.rdo_self_by_address.Text = "Search by Address"
        Me.rdo_self_by_address.UseVisualStyleBackColor = True
        '
        'rdo_self_by_name
        '
        Me.rdo_self_by_name.AutoSize = True
        Me.rdo_self_by_name.Checked = True
        Me.rdo_self_by_name.ForeColor = System.Drawing.Color.Black
        Me.rdo_self_by_name.Location = New System.Drawing.Point(84, 56)
        Me.rdo_self_by_name.Name = "rdo_self_by_name"
        Me.rdo_self_by_name.Size = New System.Drawing.Size(106, 17)
        Me.rdo_self_by_name.TabIndex = 3
        Me.rdo_self_by_name.TabStop = True
        Me.rdo_self_by_name.Text = "Search by Name"
        Me.rdo_self_by_name.UseVisualStyleBackColor = True
        '
        'btn_self_refresh
        '
        Me.btn_self_refresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_self_refresh.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.btn_self_refresh.Location = New System.Drawing.Point(524, 56)
        Me.btn_self_refresh.Name = "btn_self_refresh"
        Me.btn_self_refresh.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btn_self_refresh.Size = New System.Drawing.Size(134, 35)
        Me.btn_self_refresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_self_refresh.TabIndex = 2
        Me.btn_self_refresh.Text = "Refresh List"
        '
        'btn_self_search
        '
        Me.btn_self_search.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_self_search.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.btn_self_search.Location = New System.Drawing.Point(524, 15)
        Me.btn_self_search.Name = "btn_self_search"
        Me.btn_self_search.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btn_self_search.Size = New System.Drawing.Size(134, 35)
        Me.btn_self_search.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_self_search.TabIndex = 1
        Me.btn_self_search.Text = "Search"
        '
        'txt_Self_Search_Term
        '
        Me.txt_Self_Search_Term.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_Self_Search_Term.Border.Class = "TextBoxBorder"
        Me.txt_Self_Search_Term.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.txt_Self_Search_Term.DisabledBackColor = System.Drawing.Color.White
        Me.txt_Self_Search_Term.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txt_Self_Search_Term.ForeColor = System.Drawing.Color.Black
        Me.txt_Self_Search_Term.Location = New System.Drawing.Point(84, 17)
        Me.txt_Self_Search_Term.Name = "txt_Self_Search_Term"
        Me.txt_Self_Search_Term.PreventEnterBeep = True
        Me.txt_Self_Search_Term.Size = New System.Drawing.Size(434, 33)
        Me.txt_Self_Search_Term.TabIndex = 0
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(3, 15)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.TabIndex = 0
        Me.LabelX2.Text = "Search Term:"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'SideNavItem1
        '
        Me.SideNavItem1.IsSystemMenu = True
        Me.SideNavItem1.Name = "SideNavItem1"
        Me.SideNavItem1.Symbol = ""
        Me.SideNavItem1.Text = "Menu"
        '
        'SideNavItem5
        '
        Me.SideNavItem5.Name = "SideNavItem5"
        Me.SideNavItem5.Panel = Me.sidenavpan_LiveTotalReg
        Me.SideNavItem5.Symbol = ""
        Me.SideNavItem5.Text = "Live Total Registrants"
        '
        'Separator1
        '
        Me.Separator1.FixedSize = New System.Drawing.Size(3, 1)
        Me.Separator1.Name = "Separator1"
        Me.Separator1.Padding.Bottom = 2
        Me.Separator1.Padding.Left = 6
        Me.Separator1.Padding.Right = 6
        Me.Separator1.Padding.Top = 2
        Me.Separator1.SeparatorOrientation = DevComponents.DotNetBar.eDesignMarkerOrientation.Vertical
        '
        'SideNavItem7
        '
        Me.SideNavItem7.Name = "SideNavItem7"
        Me.SideNavItem7.Panel = Me.sidenavpan_livetotals_per_district
        Me.SideNavItem7.Symbol = ""
        Me.SideNavItem7.Text = "Live Total Registrants per District"
        '
        'SideNavItem9
        '
        Me.SideNavItem9.Checked = True
        Me.SideNavItem9.Name = "SideNavItem9"
        Me.SideNavItem9.Panel = Me.sidenavpan_livetotals_onsite
        Me.SideNavItem9.Symbol = ""
        Me.SideNavItem9.Text = "Live Onsite Attendance"
        '
        'SideNavItem2
        '
        Me.SideNavItem2.Name = "SideNavItem2"
        Me.SideNavItem2.Panel = Me.sidenavpan_masterlist
        Me.SideNavItem2.Symbol = ""
        Me.SideNavItem2.Text = "Registry Masterlist"
        '
        'SideNavItem6
        '
        Me.SideNavItem6.Name = "SideNavItem6"
        Me.SideNavItem6.Panel = Me.sidenavpan_self_reg
        Me.SideNavItem6.Symbol = ""
        Me.SideNavItem6.Text = "Guest Registration List"
        '
        'SideNavItem4
        '
        Me.SideNavItem4.Name = "SideNavItem4"
        Me.SideNavItem4.Panel = Me.sidenavpan_Officer_List
        Me.SideNavItem4.Symbol = ""
        Me.SideNavItem4.Text = "B-EMPOWER Officers List"
        '
        'SideNavItem3
        '
        Me.SideNavItem3.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far
        Me.SideNavItem3.Name = "SideNavItem3"
        Me.SideNavItem3.Symbol = ""
        Me.SideNavItem3.Text = "Settings"
        '
        'SideNavItem8
        '
        Me.SideNavItem8.Name = "SideNavItem8"
        Me.SideNavItem8.Panel = Me.sidenavpan_QR_Attendance
        Me.SideNavItem8.Symbol = ""
        Me.SideNavItem8.Text = "Onsite Attendance List"
        '
        'SideNavItem10
        '
        Me.SideNavItem10.Name = "SideNavItem10"
        Me.SideNavItem10.Panel = Me.SideNavPanel1
        Me.SideNavItem10.Symbol = ""
        Me.SideNavItem10.Text = "Delete Logs"
        '
        'BW_Load_Masterlist
        '
        Me.BW_Load_Masterlist.WorkerReportsProgress = True
        Me.BW_Load_Masterlist.WorkerSupportsCancellation = True
        '
        'BW_Config_Local_Settings
        '
        Me.BW_Config_Local_Settings.WorkerReportsProgress = True
        Me.BW_Config_Local_Settings.WorkerSupportsCancellation = True
        '
        'circ_prog_overall
        '
        Me.circ_prog_overall.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.circ_prog_overall.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.circ_prog_overall.Location = New System.Drawing.Point(53, 373)
        Me.circ_prog_overall.Name = "circ_prog_overall"
        Me.circ_prog_overall.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot
        Me.circ_prog_overall.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.circ_prog_overall.Size = New System.Drawing.Size(100, 100)
        Me.circ_prog_overall.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.circ_prog_overall.TabIndex = 28
        Me.circ_prog_overall.Visible = False
        '
        'tmr_Circ_overall_anim
        '
        '
        'tmr_Circ_masterlist_anim
        '
        '
        'tmr_Time_Updater
        '
        Me.tmr_Time_Updater.Enabled = True
        Me.tmr_Time_Updater.Interval = 500
        '
        'tmr_Total_Reg_Updater
        '
        Me.tmr_Total_Reg_Updater.Interval = 500
        '
        'BW_Get_Total_Reg
        '
        Me.BW_Get_Total_Reg.WorkerReportsProgress = True
        Me.BW_Get_Total_Reg.WorkerSupportsCancellation = True
        '
        'BW_Mstr_Search
        '
        Me.BW_Mstr_Search.WorkerReportsProgress = True
        Me.BW_Mstr_Search.WorkerSupportsCancellation = True
        '
        'BW_Mstr_Load_Reg_Details
        '
        Me.BW_Mstr_Load_Reg_Details.WorkerReportsProgress = True
        Me.BW_Mstr_Load_Reg_Details.WorkerSupportsCancellation = True
        '
        'BW_PDF_Exporter_Masterlist
        '
        Me.BW_PDF_Exporter_Masterlist.WorkerReportsProgress = True
        Me.BW_PDF_Exporter_Masterlist.WorkerSupportsCancellation = True
        '
        'BW_Export_Excel_Mstr
        '
        Me.BW_Export_Excel_Mstr.WorkerReportsProgress = True
        Me.BW_Export_Excel_Mstr.WorkerSupportsCancellation = True
        '
        'BW_PDF_Exporter_Mstr_Dist
        '
        Me.BW_PDF_Exporter_Mstr_Dist.WorkerReportsProgress = True
        Me.BW_PDF_Exporter_Mstr_Dist.WorkerSupportsCancellation = True
        '
        'BW_Export_Excel_Mstr_Dist
        '
        Me.BW_Export_Excel_Mstr_Dist.WorkerReportsProgress = True
        Me.BW_Export_Excel_Mstr_Dist.WorkerSupportsCancellation = True
        '
        'BW_Load_Self_Reg
        '
        Me.BW_Load_Self_Reg.WorkerReportsProgress = True
        Me.BW_Load_Self_Reg.WorkerSupportsCancellation = True
        '
        'tmr_Circ_self_anim
        '
        '
        'BW_Self_Load_Reg_Details
        '
        Me.BW_Self_Load_Reg_Details.WorkerReportsProgress = True
        Me.BW_Self_Load_Reg_Details.WorkerSupportsCancellation = True
        '
        'BW_Self_Search
        '
        Me.BW_Self_Search.WorkerReportsProgress = True
        Me.BW_Self_Search.WorkerSupportsCancellation = True
        '
        'BW_Load_Users
        '
        Me.BW_Load_Users.WorkerReportsProgress = True
        Me.BW_Load_Users.WorkerSupportsCancellation = True
        '
        'tmr_Circ_user_anim
        '
        '
        'BW_Prof_Details_Fetch
        '
        Me.BW_Prof_Details_Fetch.WorkerReportsProgress = True
        Me.BW_Prof_Details_Fetch.WorkerSupportsCancellation = True
        '
        'BW_User_Search
        '
        Me.BW_User_Search.WorkerReportsProgress = True
        Me.BW_User_Search.WorkerSupportsCancellation = True
        '
        'BW_PDF_Exporter_Usr
        '
        Me.BW_PDF_Exporter_Usr.WorkerReportsProgress = True
        Me.BW_PDF_Exporter_Usr.WorkerSupportsCancellation = True
        '
        'BW_Export_Excel_Usr
        '
        Me.BW_Export_Excel_Usr.WorkerReportsProgress = True
        Me.BW_Export_Excel_Usr.WorkerSupportsCancellation = True
        '
        'BW_Delete_Entry
        '
        Me.BW_Delete_Entry.WorkerReportsProgress = True
        Me.BW_Delete_Entry.WorkerSupportsCancellation = True
        '
        'BW_Fill_QR_Attendance
        '
        Me.BW_Fill_QR_Attendance.WorkerReportsProgress = True
        Me.BW_Fill_QR_Attendance.WorkerSupportsCancellation = True
        '
        'tmr_Circ_QR_anim
        '
        '
        'BW_QR_Search
        '
        Me.BW_QR_Search.WorkerReportsProgress = True
        Me.BW_QR_Search.WorkerSupportsCancellation = True
        '
        'BW_Export_Excel_QR
        '
        Me.BW_Export_Excel_QR.WorkerReportsProgress = True
        Me.BW_Export_Excel_QR.WorkerSupportsCancellation = True
        '
        'BW_QR_Load_Reg_Details
        '
        Me.BW_QR_Load_Reg_Details.WorkerReportsProgress = True
        Me.BW_QR_Load_Reg_Details.WorkerSupportsCancellation = True
        '
        'tmr_Totals_Updater_Area
        '
        Me.tmr_Totals_Updater_Area.Interval = 500
        '
        'BW_Get_Area_Reg
        '
        Me.BW_Get_Area_Reg.WorkerReportsProgress = True
        Me.BW_Get_Area_Reg.WorkerSupportsCancellation = True
        '
        'BW_PDF_Exporter_Self
        '
        Me.BW_PDF_Exporter_Self.WorkerReportsProgress = True
        Me.BW_PDF_Exporter_Self.WorkerSupportsCancellation = True
        '
        'BW_Export_Excel_Self
        '
        Me.BW_Export_Excel_Self.WorkerReportsProgress = True
        Me.BW_Export_Excel_Self.WorkerSupportsCancellation = True
        '
        'tmr_Circ_del_anim
        '
        '
        'BW_Load_Del_Logs
        '
        Me.BW_Load_Del_Logs.WorkerReportsProgress = True
        Me.BW_Load_Del_Logs.WorkerSupportsCancellation = True
        '
        'BW_Del_Load_Reg_Details
        '
        Me.BW_Del_Load_Reg_Details.WorkerReportsProgress = True
        Me.BW_Del_Load_Reg_Details.WorkerSupportsCancellation = True
        '
        'BW_Export_Excel_Del_Logs
        '
        Me.BW_Export_Excel_Del_Logs.WorkerReportsProgress = True
        Me.BW_Export_Excel_Del_Logs.WorkerSupportsCancellation = True
        '
        'BW_Del_Logs_Search
        '
        Me.BW_Del_Logs_Search.WorkerReportsProgress = True
        Me.BW_Del_Logs_Search.WorkerSupportsCancellation = True
        '
        'BW_SMS_Marker_Updater
        '
        Me.BW_SMS_Marker_Updater.WorkerReportsProgress = True
        Me.BW_SMS_Marker_Updater.WorkerSupportsCancellation = True
        '
        'tmr_SMS_Done_Updater
        '
        Me.tmr_SMS_Done_Updater.Enabled = True
        Me.tmr_SMS_Done_Updater.Interval = 1
        '
        'BW_del_logs_laoder
        '
        Me.BW_del_logs_laoder.WorkerReportsProgress = True
        Me.BW_del_logs_laoder.WorkerSupportsCancellation = True
        '
        'tmr_Entries_Loader
        '
        Me.tmr_Entries_Loader.Interval = 5000
        '
        'BW_PDF_Export_Audit_Rpt
        '
        Me.BW_PDF_Export_Audit_Rpt.WorkerReportsProgress = True
        Me.BW_PDF_Export_Audit_Rpt.WorkerSupportsCancellation = True
        '
        'BW_Get_Onsite_Total_Count
        '
        Me.BW_Get_Onsite_Total_Count.WorkerReportsProgress = True
        Me.BW_Get_Onsite_Total_Count.WorkerSupportsCancellation = True
        '
        'tmr_Totals_Updater_Onsite
        '
        Me.tmr_Totals_Updater_Onsite.Interval = 500
        '
        'BW_PDF_Exporter_Onsite_Dist
        '
        Me.BW_PDF_Exporter_Onsite_Dist.WorkerReportsProgress = True
        Me.BW_PDF_Exporter_Onsite_Dist.WorkerSupportsCancellation = True
        '
        'BW_Valid_Entries_Notifier
        '
        Me.BW_Valid_Entries_Notifier.WorkerReportsProgress = True
        Me.BW_Valid_Entries_Notifier.WorkerSupportsCancellation = True
        '
        'BW_SMS_Updater_Overall
        '
        Me.BW_SMS_Updater_Overall.WorkerReportsProgress = True
        Me.BW_SMS_Updater_Overall.WorkerSupportsCancellation = True
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.circ_prog_overall)
        Me.Controls.Add(Me.SideNav1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1000, 600)
        Me.Name = "frm_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AGMA 2024 Report Generator"
        Me.SideNav1.ResumeLayout(False)
        Me.SideNav1.PerformLayout()
        Me.sidenavpan_LiveTotalReg.ResumeLayout(False)
        Me.sidenavpan_masterlist.ResumeLayout(False)
        CType(Me.ContextMenuBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan_masterlist_controls.ResumeLayout(False)
        Me.pan_masterlist_controls.PerformLayout()
        Me.sidenavpan_livetotals_onsite.ResumeLayout(False)
        Me.sidenavpan_livetotals_per_district.ResumeLayout(False)
        Me.SideNavPanel1.ResumeLayout(False)
        Me.pan_del_logs_control.ResumeLayout(False)
        Me.pan_del_logs_control.PerformLayout()
        Me.sidenavpan_QR_Attendance.ResumeLayout(False)
        Me.pan_QR_control.ResumeLayout(False)
        Me.pan_QR_control.PerformLayout()
        Me.sidenavpan_Officer_List.ResumeLayout(False)
        Me.pan_users_control.ResumeLayout(False)
        Me.pan_users_control.PerformLayout()
        Me.sidenavpan_self_reg.ResumeLayout(False)
        Me.pan_self_controls.ResumeLayout(False)
        Me.pan_self_controls.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents SideNav1 As DevComponents.DotNetBar.Controls.SideNav
    Friend WithEvents sidenavpan_masterlist As DevComponents.DotNetBar.Controls.SideNavPanel
    Private WithEvents SideNavItem1 As DevComponents.DotNetBar.Controls.SideNavItem
    Friend WithEvents Separator1 As DevComponents.DotNetBar.Separator
    Private WithEvents SideNavItem2 As DevComponents.DotNetBar.Controls.SideNavItem
    Friend WithEvents sidenavpan_Officer_List As DevComponents.DotNetBar.Controls.SideNavPanel
    Friend WithEvents sidenavpan_LiveTotalReg As DevComponents.DotNetBar.Controls.SideNavPanel
    Private WithEvents SideNavItem5 As DevComponents.DotNetBar.Controls.SideNavItem
    Private WithEvents SideNavItem4 As DevComponents.DotNetBar.Controls.SideNavItem
    Friend WithEvents lst_Masterlist As DevComponents.DotNetBar.Controls.ListViewEx
    Friend WithEvents pan_masterlist_controls As DevComponents.DotNetBar.PanelEx
    Friend WithEvents rdo_Mstr_AccountNumberSearch As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_Mstr_Registrant_Search As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_Mstr_Address_Search As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_Mstr_NameSearch As System.Windows.Forms.RadioButton
    Friend WithEvents btn_Refresh_Masterlist As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_Masterlist_Search As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txt_Mstr_Search_Term As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbl_Main As DevComponents.DotNetBar.LabelX
    Friend WithEvents sidenavpan_self_reg As DevComponents.DotNetBar.Controls.SideNavPanel
    Private WithEvents SideNavItem6 As DevComponents.DotNetBar.Controls.SideNavItem
    Private WithEvents btn_Settings As DevComponents.DotNetBar.Controls.SideNavItem
    Friend WithEvents circ_prog_masterlist As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents BW_Load_Masterlist As System.ComponentModel.BackgroundWorker
    Friend WithEvents BW_Config_Local_Settings As System.ComponentModel.BackgroundWorker
    Friend WithEvents circ_prog_overall As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents tmr_Circ_overall_anim As System.Windows.Forms.Timer
    Friend WithEvents tmr_Circ_masterlist_anim As System.Windows.Forms.Timer
    Friend WithEvents sidenavpan_livetotals_per_district As DevComponents.DotNetBar.Controls.SideNavPanel
    Private WithEvents SideNavItem7 As DevComponents.DotNetBar.Controls.SideNavItem
    Friend WithEvents lbl_Total_Regs As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl_Time_Hour As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl_Time_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl_Total_reg_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents tmr_Time_Updater As System.Windows.Forms.Timer
    Friend WithEvents lbl_Time_AMPM As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl_Time_Minute As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl_Time_Colon As DevComponents.DotNetBar.LabelX
    Friend WithEvents tmr_Total_Reg_Updater As System.Windows.Forms.Timer
    Friend WithEvents BW_Get_Total_Reg As System.ComponentModel.BackgroundWorker
    Private WithEvents SideNavItem3 As DevComponents.DotNetBar.Controls.SideNavItem
    Friend WithEvents BW_Mstr_Search As System.ComponentModel.BackgroundWorker
    Friend WithEvents ContextMenuBar1 As DevComponents.DotNetBar.ContextMenuBar
    Friend WithEvents cntx_Masterlist As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btn_Mstr_View_Details As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btn_mstr_export_PDF As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btn_mstr_export_Excel As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cntx_Self_Reg As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BW_Mstr_Load_Reg_Details As System.ComponentModel.BackgroundWorker
    Friend WithEvents circ_users_prog As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents lst_users As DevComponents.DotNetBar.Controls.ListViewEx
    Friend WithEvents pan_users_control As DevComponents.DotNetBar.PanelEx
    Friend WithEvents rdo_user_search_by_Username As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_user_search_by_Address As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_user_search_by_Real_Name As System.Windows.Forms.RadioButton
    Friend WithEvents btn_user_refresh_list As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_user_Search As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txt_user_Search_Term As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents circ_self_reg As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents lst_Self_Reg As DevComponents.DotNetBar.Controls.ListViewEx
    Friend WithEvents pan_self_controls As DevComponents.DotNetBar.PanelEx
    Friend WithEvents rdo_self_by_number As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_self_by_address As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_self_by_name As System.Windows.Forms.RadioButton
    Friend WithEvents btn_self_refresh As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_self_search As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txt_Self_Search_Term As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ButtonItem9 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btn_mstr_export_district_PDF As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btn_mstr_export_district_Excel As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btn_Self_View_Details As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cntx_MCO_Officers As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btn_Prof_View_Reg_by_User As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btn_Prof_View_Details As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem6 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btn_Prof_Export_Reg_by_User_PDF As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btn_Prof_Export_Reg_by_User_Excel As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BW_PDF_Exporter_Masterlist As System.ComponentModel.BackgroundWorker
    Friend WithEvents BW_Export_Excel_Mstr As System.ComponentModel.BackgroundWorker
    Friend WithEvents BW_PDF_Exporter_Mstr_Dist As System.ComponentModel.BackgroundWorker
    Friend WithEvents BW_Export_Excel_Mstr_Dist As System.ComponentModel.BackgroundWorker
    Friend WithEvents BW_Load_Self_Reg As System.ComponentModel.BackgroundWorker
    Friend WithEvents tmr_Circ_self_anim As System.Windows.Forms.Timer
    Friend WithEvents BW_Self_Load_Reg_Details As System.ComponentModel.BackgroundWorker
    Friend WithEvents BW_Self_Search As System.ComponentModel.BackgroundWorker
    Friend WithEvents BW_Load_Users As System.ComponentModel.BackgroundWorker
    Friend WithEvents tmr_Circ_user_anim As System.Windows.Forms.Timer
    Friend WithEvents BW_Prof_Details_Fetch As System.ComponentModel.BackgroundWorker
    Friend WithEvents BW_User_Search As System.ComponentModel.BackgroundWorker
    Friend WithEvents BW_PDF_Exporter_Usr As System.ComponentModel.BackgroundWorker
    Friend WithEvents BW_Export_Excel_Usr As System.ComponentModel.BackgroundWorker
    Friend WithEvents rdo_user_search_by_Designation As System.Windows.Forms.RadioButton
    Friend WithEvents btn_Mstr_Delete As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btn_Self_Delete_Entry As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BW_Delete_Entry As System.ComponentModel.BackgroundWorker
    Friend WithEvents sidenavpan_QR_Attendance As DevComponents.DotNetBar.Controls.SideNavPanel
    Friend WithEvents circ_prog_QR As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents lst_QR_Attendees As DevComponents.DotNetBar.Controls.ListViewEx
    Friend WithEvents pan_QR_control As DevComponents.DotNetBar.PanelEx
    Friend WithEvents rdo_QR_Search_by_Account_Number As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_QR_Search_by_Account_Name As System.Windows.Forms.RadioButton
    Friend WithEvents btn_QR_Refresh_List As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_QR_Search As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txt_QR_Search_Term As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Private WithEvents SideNavItem8 As DevComponents.DotNetBar.Controls.SideNavItem
    Friend WithEvents QR_Attendance As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btn_QR_Export_to_Excel As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BW_Fill_QR_Attendance As System.ComponentModel.BackgroundWorker
    Friend WithEvents tmr_Circ_QR_anim As System.Windows.Forms.Timer
    Friend WithEvents BW_QR_Search As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_QR_View_Profile As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BW_Export_Excel_QR As System.ComponentModel.BackgroundWorker
    Friend WithEvents BW_QR_Load_Reg_Details As System.ComponentModel.BackgroundWorker
    Friend WithEvents lbl_Time_AMPM_Area As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl_Time_Minute_Area As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl_Time_Colon_Area As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl_Total_Regs_Area As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl_Time_Hour_Area As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl_Time_Label_Area As DevComponents.DotNetBar.LabelX
    Friend WithEvents tmr_Totals_Updater_Area As System.Windows.Forms.Timer
    Friend WithEvents BW_Get_Area_Reg As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_Self_Export_Reg_PDF As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btn_Self_Export_Reg_Excel As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BW_PDF_Exporter_Self As System.ComponentModel.BackgroundWorker
    Friend WithEvents BW_Export_Excel_Self As System.ComponentModel.BackgroundWorker
    Friend WithEvents SideNavPanel1 As DevComponents.DotNetBar.Controls.SideNavPanel
    Friend WithEvents lst_del_logs As DevComponents.DotNetBar.Controls.ListViewEx
    Friend WithEvents pan_del_logs_control As DevComponents.DotNetBar.PanelEx
    Friend WithEvents rdo_del_Search_by_Account_Name As RadioButton
    Friend WithEvents rdo_del_Search_by_Del_Username As RadioButton
    Friend WithEvents rdo_del_Search_by_Reg_Username As RadioButton
    Friend WithEvents rdo_del_Search_by_Account_Num As RadioButton
    Friend WithEvents btn_del_Refresh As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_del_Search As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txt_del_Search_Term As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Private WithEvents SideNavItem10 As DevComponents.DotNetBar.Controls.SideNavItem
    Friend WithEvents circ_del_prog As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents tmr_Circ_del_anim As Timer
    Friend WithEvents BW_Load_Del_Logs As System.ComponentModel.BackgroundWorker
    Friend WithEvents Del_Logs As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btn_View_Del_Prof As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btn_Export_Del_Logs As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BW_Del_Load_Reg_Details As System.ComponentModel.BackgroundWorker
    Friend WithEvents BW_Export_Excel_Del_Logs As System.ComponentModel.BackgroundWorker
    Friend WithEvents BW_Del_Logs_Search As System.ComponentModel.BackgroundWorker
    Friend WithEvents chk_Mark_Sanitation_Only As CheckBox
    Friend WithEvents chk_Guest_Sanitation_Only As CheckBox
    Friend WithEvents btn_Add_New_User As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btn_Send_Sanitation_SMS As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BW_SMS_Marker_Updater As System.ComponentModel.BackgroundWorker
    Friend WithEvents tmr_SMS_Done_Updater As Timer
    Friend WithEvents BW_del_logs_laoder As System.ComponentModel.BackgroundWorker
    Friend WithEvents tmr_Entries_Loader As Timer
    Friend WithEvents btnitm_Export_Audit_Report As ButtonItem
    Friend WithEvents BW_PDF_Export_Audit_Rpt As System.ComponentModel.BackgroundWorker
    Friend WithEvents sidenavpan_livetotals_onsite As Controls.SideNavPanel
    Friend WithEvents lbl_Time_AMPM_Onsite As LabelX
    Friend WithEvents lbl_Time_Minute_Onsite As LabelX
    Friend WithEvents lbl_Time_Colon_Onsite As LabelX
    Friend WithEvents lbl_Time_Hour_Onsite As LabelX
    Friend WithEvents lbl_Time_Label_Onsite As LabelX
    Private WithEvents SideNavItem9 As Controls.SideNavItem
    Friend WithEvents lbl_Total_Regs_Onsite As LabelX
    Friend WithEvents BW_Get_Onsite_Total_Count As System.ComponentModel.BackgroundWorker
    Friend WithEvents tmr_Totals_Updater_Onsite As Timer
    Friend WithEvents btn_QR_Export_to_PDF As ButtonItem
    Friend WithEvents BW_PDF_Exporter_Onsite_Dist As System.ComponentModel.BackgroundWorker
    Friend WithEvents BW_Valid_Entries_Notifier As System.ComponentModel.BackgroundWorker
    Friend WithEvents BW_SMS_Updater_Overall As System.ComponentModel.BackgroundWorker
End Class
