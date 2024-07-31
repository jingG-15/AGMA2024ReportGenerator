<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_User_Account_Enrollment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_User_Account_Enrollment))
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.txt_En_Password = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txt_En_Confirm_Password = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txt_En_Username = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.txt_En_Last_Name = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.txt_En_MI = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.txt_En_First_Name = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.txt_En_Position = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.txt_En_Contact_Number = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.txt_En_Address = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btn_Save = New DevComponents.DotNetBar.ButtonX()
        Me.chk_Employee_Mark = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(12, 12)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(98, 23)
        Me.LabelX2.TabIndex = 29
        Me.LabelX2.Text = "Username:"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(12, 80)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(98, 23)
        Me.LabelX1.TabIndex = 29
        Me.LabelX1.Text = "Password:"
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(12, 148)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(98, 23)
        Me.LabelX3.TabIndex = 29
        Me.LabelX3.Text = "Confirm Password:"
        '
        'txt_En_Password
        '
        Me.txt_En_Password.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_En_Password.Border.Class = "TextBoxBorder"
        Me.txt_En_Password.Border.CornerDiameter = 15
        Me.txt_En_Password.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.txt_En_Password.ButtonCustom.Symbol = ""
        Me.txt_En_Password.ButtonCustom.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_En_Password.ButtonCustom.Tooltip = "Show Password"
        Me.txt_En_Password.ButtonCustom.Visible = True
        Me.txt_En_Password.ButtonCustom2.Symbol = ""
        Me.txt_En_Password.ButtonCustom2.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_En_Password.ButtonCustom2.Tooltip = "Hide Password"
        Me.txt_En_Password.ButtonCustom2.Visible = True
        Me.txt_En_Password.DisabledBackColor = System.Drawing.Color.White
        Me.txt_En_Password.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_En_Password.ForeColor = System.Drawing.Color.Black
        Me.txt_En_Password.Location = New System.Drawing.Point(12, 103)
        Me.txt_En_Password.Name = "txt_En_Password"
        Me.txt_En_Password.PreventEnterBeep = True
        Me.txt_En_Password.Size = New System.Drawing.Size(366, 39)
        Me.txt_En_Password.TabIndex = 31
        Me.txt_En_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_En_Password.UseSystemPasswordChar = True
        '
        'txt_En_Confirm_Password
        '
        Me.txt_En_Confirm_Password.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_En_Confirm_Password.Border.Class = "TextBoxBorder"
        Me.txt_En_Confirm_Password.Border.CornerDiameter = 15
        Me.txt_En_Confirm_Password.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.txt_En_Confirm_Password.ButtonCustom.Symbol = ""
        Me.txt_En_Confirm_Password.ButtonCustom.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_En_Confirm_Password.ButtonCustom.Tooltip = "Show Password"
        Me.txt_En_Confirm_Password.ButtonCustom.Visible = True
        Me.txt_En_Confirm_Password.ButtonCustom2.Symbol = ""
        Me.txt_En_Confirm_Password.ButtonCustom2.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_En_Confirm_Password.ButtonCustom2.Tooltip = "Hide Password"
        Me.txt_En_Confirm_Password.ButtonCustom2.Visible = True
        Me.txt_En_Confirm_Password.DisabledBackColor = System.Drawing.Color.White
        Me.txt_En_Confirm_Password.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_En_Confirm_Password.ForeColor = System.Drawing.Color.Black
        Me.txt_En_Confirm_Password.Location = New System.Drawing.Point(12, 177)
        Me.txt_En_Confirm_Password.Name = "txt_En_Confirm_Password"
        Me.txt_En_Confirm_Password.PreventEnterBeep = True
        Me.txt_En_Confirm_Password.Size = New System.Drawing.Size(366, 39)
        Me.txt_En_Confirm_Password.TabIndex = 31
        Me.txt_En_Confirm_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_En_Confirm_Password.UseSystemPasswordChar = True
        '
        'txt_En_Username
        '
        Me.txt_En_Username.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_En_Username.Border.Class = "TextBoxBorder"
        Me.txt_En_Username.Border.CornerDiameter = 15
        Me.txt_En_Username.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.txt_En_Username.DisabledBackColor = System.Drawing.Color.White
        Me.txt_En_Username.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_En_Username.ForeColor = System.Drawing.Color.Black
        Me.txt_En_Username.Location = New System.Drawing.Point(12, 41)
        Me.txt_En_Username.Name = "txt_En_Username"
        Me.txt_En_Username.PreventEnterBeep = True
        Me.txt_En_Username.Size = New System.Drawing.Size(366, 39)
        Me.txt_En_Username.TabIndex = 32
        Me.txt_En_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.ForeColor = System.Drawing.Color.Black
        Me.LabelX4.Location = New System.Drawing.Point(12, 222)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(98, 23)
        Me.LabelX4.TabIndex = 29
        Me.LabelX4.Text = "Last Name:"
        '
        'txt_En_Last_Name
        '
        Me.txt_En_Last_Name.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_En_Last_Name.Border.Class = "TextBoxBorder"
        Me.txt_En_Last_Name.Border.CornerDiameter = 15
        Me.txt_En_Last_Name.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.txt_En_Last_Name.DisabledBackColor = System.Drawing.Color.White
        Me.txt_En_Last_Name.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_En_Last_Name.ForeColor = System.Drawing.Color.Black
        Me.txt_En_Last_Name.Location = New System.Drawing.Point(12, 251)
        Me.txt_En_Last_Name.Name = "txt_En_Last_Name"
        Me.txt_En_Last_Name.PreventEnterBeep = True
        Me.txt_En_Last_Name.Size = New System.Drawing.Size(366, 39)
        Me.txt_En_Last_Name.TabIndex = 32
        Me.txt_En_Last_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.ForeColor = System.Drawing.Color.Black
        Me.LabelX5.Location = New System.Drawing.Point(12, 296)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(98, 23)
        Me.LabelX5.TabIndex = 29
        Me.LabelX5.Text = "Middle Initial:"
        '
        'txt_En_MI
        '
        Me.txt_En_MI.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_En_MI.Border.Class = "TextBoxBorder"
        Me.txt_En_MI.Border.CornerDiameter = 15
        Me.txt_En_MI.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.txt_En_MI.DisabledBackColor = System.Drawing.Color.White
        Me.txt_En_MI.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_En_MI.ForeColor = System.Drawing.Color.Black
        Me.txt_En_MI.Location = New System.Drawing.Point(12, 325)
        Me.txt_En_MI.MaxLength = 1
        Me.txt_En_MI.Name = "txt_En_MI"
        Me.txt_En_MI.PreventEnterBeep = True
        Me.txt_En_MI.Size = New System.Drawing.Size(366, 39)
        Me.txt_En_MI.TabIndex = 32
        Me.txt_En_MI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.ForeColor = System.Drawing.Color.Black
        Me.LabelX6.Location = New System.Drawing.Point(12, 370)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(98, 23)
        Me.LabelX6.TabIndex = 29
        Me.LabelX6.Text = "First Name:"
        '
        'txt_En_First_Name
        '
        Me.txt_En_First_Name.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_En_First_Name.Border.Class = "TextBoxBorder"
        Me.txt_En_First_Name.Border.CornerDiameter = 15
        Me.txt_En_First_Name.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.txt_En_First_Name.DisabledBackColor = System.Drawing.Color.White
        Me.txt_En_First_Name.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_En_First_Name.ForeColor = System.Drawing.Color.Black
        Me.txt_En_First_Name.Location = New System.Drawing.Point(12, 399)
        Me.txt_En_First_Name.Name = "txt_En_First_Name"
        Me.txt_En_First_Name.PreventEnterBeep = True
        Me.txt_En_First_Name.Size = New System.Drawing.Size(366, 39)
        Me.txt_En_First_Name.TabIndex = 32
        Me.txt_En_First_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.ForeColor = System.Drawing.Color.Black
        Me.LabelX7.Location = New System.Drawing.Point(416, 12)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(98, 23)
        Me.LabelX7.TabIndex = 29
        Me.LabelX7.Text = "Position:"
        '
        'txt_En_Position
        '
        Me.txt_En_Position.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_En_Position.Border.Class = "TextBoxBorder"
        Me.txt_En_Position.Border.CornerDiameter = 15
        Me.txt_En_Position.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.txt_En_Position.DisabledBackColor = System.Drawing.Color.White
        Me.txt_En_Position.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_En_Position.ForeColor = System.Drawing.Color.Black
        Me.txt_En_Position.Location = New System.Drawing.Point(416, 41)
        Me.txt_En_Position.Name = "txt_En_Position"
        Me.txt_En_Position.PreventEnterBeep = True
        Me.txt_En_Position.Size = New System.Drawing.Size(366, 39)
        Me.txt_En_Position.TabIndex = 32
        Me.txt_En_Position.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelX8
        '
        Me.LabelX8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.ForeColor = System.Drawing.Color.Black
        Me.LabelX8.Location = New System.Drawing.Point(416, 86)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(98, 23)
        Me.LabelX8.TabIndex = 29
        Me.LabelX8.Text = "Contact Number:"
        '
        'txt_En_Contact_Number
        '
        Me.txt_En_Contact_Number.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_En_Contact_Number.Border.Class = "TextBoxBorder"
        Me.txt_En_Contact_Number.Border.CornerDiameter = 15
        Me.txt_En_Contact_Number.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.txt_En_Contact_Number.DisabledBackColor = System.Drawing.Color.White
        Me.txt_En_Contact_Number.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_En_Contact_Number.ForeColor = System.Drawing.Color.Black
        Me.txt_En_Contact_Number.Location = New System.Drawing.Point(416, 115)
        Me.txt_En_Contact_Number.Name = "txt_En_Contact_Number"
        Me.txt_En_Contact_Number.PreventEnterBeep = True
        Me.txt_En_Contact_Number.Size = New System.Drawing.Size(366, 39)
        Me.txt_En_Contact_Number.TabIndex = 32
        Me.txt_En_Contact_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelX9
        '
        Me.LabelX9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.ForeColor = System.Drawing.Color.Black
        Me.LabelX9.Location = New System.Drawing.Point(416, 160)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(98, 23)
        Me.LabelX9.TabIndex = 29
        Me.LabelX9.Text = "Address:"
        '
        'txt_En_Address
        '
        Me.txt_En_Address.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_En_Address.Border.Class = "TextBoxBorder"
        Me.txt_En_Address.Border.CornerDiameter = 15
        Me.txt_En_Address.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.txt_En_Address.DisabledBackColor = System.Drawing.Color.White
        Me.txt_En_Address.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_En_Address.ForeColor = System.Drawing.Color.Black
        Me.txt_En_Address.Location = New System.Drawing.Point(416, 189)
        Me.txt_En_Address.Multiline = True
        Me.txt_En_Address.Name = "txt_En_Address"
        Me.txt_En_Address.PreventEnterBeep = True
        Me.txt_En_Address.Size = New System.Drawing.Size(366, 175)
        Me.txt_En_Address.TabIndex = 32
        Me.txt_En_Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_Save
        '
        Me.btn_Save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Save.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.btn_Save.Location = New System.Drawing.Point(648, 403)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btn_Save.Size = New System.Drawing.Size(134, 35)
        Me.btn_Save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Save.TabIndex = 33
        Me.btn_Save.Text = "Save"
        '
        'chk_Employee_Mark
        '
        Me.chk_Employee_Mark.AutoSize = True
        Me.chk_Employee_Mark.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chk_Employee_Mark.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
        Me.chk_Employee_Mark.ForeColor = System.Drawing.Color.Black
        Me.chk_Employee_Mark.Location = New System.Drawing.Point(662, 15)
        Me.chk_Employee_Mark.Name = "chk_Employee_Mark"
        Me.chk_Employee_Mark.Size = New System.Drawing.Size(120, 19)
        Me.chk_Employee_Mark.TabIndex = 34
        Me.chk_Employee_Mark.Text = "BILECO Employee"
        Me.chk_Employee_Mark.UseVisualStyleBackColor = False
        '
        'frm_User_Account_Enrollment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 448)
        Me.Controls.Add(Me.chk_Employee_Mark)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.txt_En_First_Name)
        Me.Controls.Add(Me.txt_En_MI)
        Me.Controls.Add(Me.txt_En_Address)
        Me.Controls.Add(Me.txt_En_Contact_Number)
        Me.Controls.Add(Me.txt_En_Position)
        Me.Controls.Add(Me.txt_En_Last_Name)
        Me.Controls.Add(Me.txt_En_Username)
        Me.Controls.Add(Me.txt_En_Confirm_Password)
        Me.Controls.Add(Me.txt_En_Password)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.LabelX6)
        Me.Controls.Add(Me.LabelX5)
        Me.Controls.Add(Me.LabelX9)
        Me.Controls.Add(Me.LabelX8)
        Me.Controls.Add(Me.LabelX7)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.LabelX2)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_User_Account_Enrollment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Account Enrollment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_En_Password As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txt_En_Confirm_Password As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txt_En_Username As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_En_Last_Name As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_En_MI As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_En_First_Name As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_En_Position As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_En_Contact_Number As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_En_Address As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btn_Save As DevComponents.DotNetBar.ButtonX
    Friend WithEvents chk_Employee_Mark As CheckBox
End Class
