<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Profile_Details
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Profile_Details))
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txt_First_Name = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txt_Designation = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.txt_Contact_Number = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.txt_Address = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.txt_Assigned_Username = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btn_Update_Info = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.txt_Mid_Ini = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.txt_Last_Name = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btn_Change_Password = New DevComponents.DotNetBar.ButtonX()
        Me.btn_Exit = New DevComponents.DotNetBar.ButtonX()
        Me.BW_Update_Profile = New System.ComponentModel.BackgroundWorker()
        Me.circ_profile_update = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.tmr_circ_prof_anim = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_Total_reg = New DevComponents.DotNetBar.LabelX()
        Me.SuspendLayout()
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(26, 12)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 11)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "First Name"
        '
        'txt_First_Name
        '
        Me.txt_First_Name.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_First_Name.Border.Class = "TextBoxBorder"
        Me.txt_First_Name.Border.CornerDiameter = 15
        Me.txt_First_Name.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.txt_First_Name.DisabledBackColor = System.Drawing.Color.White
        Me.txt_First_Name.ForeColor = System.Drawing.Color.Black
        Me.txt_First_Name.Location = New System.Drawing.Point(12, 29)
        Me.txt_First_Name.Name = "txt_First_Name"
        Me.txt_First_Name.PreventEnterBeep = True
        Me.txt_First_Name.ReadOnly = True
        Me.txt_First_Name.Size = New System.Drawing.Size(299, 36)
        Me.txt_First_Name.TabIndex = 1
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(26, 180)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(121, 22)
        Me.LabelX2.TabIndex = 0
        Me.LabelX2.Text = "Designation"
        '
        'txt_Designation
        '
        Me.txt_Designation.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_Designation.Border.Class = "TextBoxBorder"
        Me.txt_Designation.Border.CornerDiameter = 15
        Me.txt_Designation.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.txt_Designation.DisabledBackColor = System.Drawing.Color.White
        Me.txt_Designation.ForeColor = System.Drawing.Color.Black
        Me.txt_Designation.Location = New System.Drawing.Point(12, 204)
        Me.txt_Designation.Name = "txt_Designation"
        Me.txt_Designation.PreventEnterBeep = True
        Me.txt_Designation.ReadOnly = True
        Me.txt_Designation.Size = New System.Drawing.Size(299, 36)
        Me.txt_Designation.TabIndex = 1
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(331, 12)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(152, 11)
        Me.LabelX3.TabIndex = 0
        Me.LabelX3.Text = "Contact Number"
        '
        'txt_Contact_Number
        '
        Me.txt_Contact_Number.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_Contact_Number.Border.Class = "TextBoxBorder"
        Me.txt_Contact_Number.Border.CornerDiameter = 15
        Me.txt_Contact_Number.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.txt_Contact_Number.DisabledBackColor = System.Drawing.Color.White
        Me.txt_Contact_Number.ForeColor = System.Drawing.Color.Black
        Me.txt_Contact_Number.Location = New System.Drawing.Point(317, 29)
        Me.txt_Contact_Number.Name = "txt_Contact_Number"
        Me.txt_Contact_Number.PreventEnterBeep = True
        Me.txt_Contact_Number.ReadOnly = True
        Me.txt_Contact_Number.Size = New System.Drawing.Size(299, 36)
        Me.txt_Contact_Number.TabIndex = 1
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.ForeColor = System.Drawing.Color.Black
        Me.LabelX4.Location = New System.Drawing.Point(331, 130)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(152, 11)
        Me.LabelX4.TabIndex = 0
        Me.LabelX4.Text = "Address"
        '
        'txt_Address
        '
        Me.txt_Address.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_Address.Border.Class = "TextBoxBorder"
        Me.txt_Address.Border.CornerDiameter = 15
        Me.txt_Address.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.txt_Address.DisabledBackColor = System.Drawing.Color.White
        Me.txt_Address.ForeColor = System.Drawing.Color.Black
        Me.txt_Address.Location = New System.Drawing.Point(317, 147)
        Me.txt_Address.Multiline = True
        Me.txt_Address.Name = "txt_Address"
        Me.txt_Address.PreventEnterBeep = True
        Me.txt_Address.ReadOnly = True
        Me.txt_Address.Size = New System.Drawing.Size(299, 93)
        Me.txt_Address.TabIndex = 1
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.ForeColor = System.Drawing.Color.Black
        Me.LabelX5.Location = New System.Drawing.Point(331, 65)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(152, 23)
        Me.LabelX5.TabIndex = 0
        Me.LabelX5.Text = "Assigned Username"
        '
        'txt_Assigned_Username
        '
        Me.txt_Assigned_Username.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_Assigned_Username.Border.Class = "TextBoxBorder"
        Me.txt_Assigned_Username.Border.CornerDiameter = 15
        Me.txt_Assigned_Username.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.txt_Assigned_Username.DisabledBackColor = System.Drawing.Color.White
        Me.txt_Assigned_Username.ForeColor = System.Drawing.Color.Black
        Me.txt_Assigned_Username.Location = New System.Drawing.Point(317, 88)
        Me.txt_Assigned_Username.Name = "txt_Assigned_Username"
        Me.txt_Assigned_Username.PreventEnterBeep = True
        Me.txt_Assigned_Username.ReadOnly = True
        Me.txt_Assigned_Username.Size = New System.Drawing.Size(299, 36)
        Me.txt_Assigned_Username.TabIndex = 1
        '
        'btn_Update_Info
        '
        Me.btn_Update_Info.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Update_Info.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.btn_Update_Info.Location = New System.Drawing.Point(342, 246)
        Me.btn_Update_Info.Name = "btn_Update_Info"
        Me.btn_Update_Info.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btn_Update_Info.Size = New System.Drawing.Size(134, 35)
        Me.btn_Update_Info.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Update_Info.TabIndex = 8
        Me.btn_Update_Info.Text = "Update Information"
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.ForeColor = System.Drawing.Color.Black
        Me.LabelX6.Location = New System.Drawing.Point(26, 71)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(75, 11)
        Me.LabelX6.TabIndex = 0
        Me.LabelX6.Text = "Middle Initial"
        '
        'txt_Mid_Ini
        '
        Me.txt_Mid_Ini.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_Mid_Ini.Border.Class = "TextBoxBorder"
        Me.txt_Mid_Ini.Border.CornerDiameter = 15
        Me.txt_Mid_Ini.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.txt_Mid_Ini.DisabledBackColor = System.Drawing.Color.White
        Me.txt_Mid_Ini.ForeColor = System.Drawing.Color.Black
        Me.txt_Mid_Ini.Location = New System.Drawing.Point(12, 88)
        Me.txt_Mid_Ini.MaxLength = 1
        Me.txt_Mid_Ini.Name = "txt_Mid_Ini"
        Me.txt_Mid_Ini.PreventEnterBeep = True
        Me.txt_Mid_Ini.ReadOnly = True
        Me.txt_Mid_Ini.Size = New System.Drawing.Size(299, 36)
        Me.txt_Mid_Ini.TabIndex = 1
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.ForeColor = System.Drawing.Color.Black
        Me.LabelX7.Location = New System.Drawing.Point(26, 130)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(75, 11)
        Me.LabelX7.TabIndex = 0
        Me.LabelX7.Text = "Last Name"
        '
        'txt_Last_Name
        '
        Me.txt_Last_Name.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_Last_Name.Border.Class = "TextBoxBorder"
        Me.txt_Last_Name.Border.CornerDiameter = 15
        Me.txt_Last_Name.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.txt_Last_Name.DisabledBackColor = System.Drawing.Color.White
        Me.txt_Last_Name.ForeColor = System.Drawing.Color.Black
        Me.txt_Last_Name.Location = New System.Drawing.Point(12, 147)
        Me.txt_Last_Name.Name = "txt_Last_Name"
        Me.txt_Last_Name.PreventEnterBeep = True
        Me.txt_Last_Name.ReadOnly = True
        Me.txt_Last_Name.Size = New System.Drawing.Size(299, 36)
        Me.txt_Last_Name.TabIndex = 1
        '
        'btn_Change_Password
        '
        Me.btn_Change_Password.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Change_Password.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.btn_Change_Password.Location = New System.Drawing.Point(202, 246)
        Me.btn_Change_Password.Name = "btn_Change_Password"
        Me.btn_Change_Password.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btn_Change_Password.Size = New System.Drawing.Size(134, 35)
        Me.btn_Change_Password.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Change_Password.TabIndex = 8
        Me.btn_Change_Password.Text = "Change Password"
        '
        'btn_Exit
        '
        Me.btn_Exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Exit.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.btn_Exit.Location = New System.Drawing.Point(482, 246)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btn_Exit.Size = New System.Drawing.Size(134, 35)
        Me.btn_Exit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Exit.TabIndex = 8
        Me.btn_Exit.Text = "Exit"
        '
        'BW_Update_Profile
        '
        Me.BW_Update_Profile.WorkerReportsProgress = True
        Me.BW_Update_Profile.WorkerSupportsCancellation = True
        '
        'circ_profile_update
        '
        Me.circ_profile_update.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.circ_profile_update.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.circ_profile_update.Location = New System.Drawing.Point(142, 246)
        Me.circ_profile_update.Name = "circ_profile_update"
        Me.circ_profile_update.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot
        Me.circ_profile_update.Size = New System.Drawing.Size(54, 35)
        Me.circ_profile_update.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.circ_profile_update.TabIndex = 9
        '
        'tmr_circ_prof_anim
        '
        '
        'lbl_Total_reg
        '
        Me.lbl_Total_reg.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.lbl_Total_reg.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_Total_reg.ForeColor = System.Drawing.Color.Black
        Me.lbl_Total_reg.Location = New System.Drawing.Point(26, 246)
        Me.lbl_Total_reg.Name = "lbl_Total_reg"
        Me.lbl_Total_reg.Size = New System.Drawing.Size(121, 22)
        Me.lbl_Total_reg.TabIndex = 0
        Me.lbl_Total_reg.Text = "Total Reg:"
        '
        'frm_Profile_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 289)
        Me.Controls.Add(Me.circ_profile_update)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.btn_Change_Password)
        Me.Controls.Add(Me.btn_Update_Info)
        Me.Controls.Add(Me.txt_Last_Name)
        Me.Controls.Add(Me.txt_Mid_Ini)
        Me.Controls.Add(Me.txt_First_Name)
        Me.Controls.Add(Me.txt_Address)
        Me.Controls.Add(Me.txt_Assigned_Username)
        Me.Controls.Add(Me.txt_Contact_Number)
        Me.Controls.Add(Me.txt_Designation)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.LabelX5)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.lbl_Total_reg)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX7)
        Me.Controls.Add(Me.LabelX6)
        Me.Controls.Add(Me.LabelX1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Profile_Details"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Profile Details"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_First_Name As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_Designation As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_Contact_Number As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_Address As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_Assigned_Username As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btn_Update_Info As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_Mid_Ini As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_Last_Name As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btn_Change_Password As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_Exit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BW_Update_Profile As System.ComponentModel.BackgroundWorker
    Friend WithEvents circ_profile_update As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents tmr_circ_prof_anim As System.Windows.Forms.Timer
    Friend WithEvents lbl_Total_reg As DevComponents.DotNetBar.LabelX
End Class
