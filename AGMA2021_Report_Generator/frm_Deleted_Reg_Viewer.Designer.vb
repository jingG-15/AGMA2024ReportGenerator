<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Deleted_Reg_Viewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Deleted_Reg_Viewer))
        Me.btn_ID_Fullscreen = New DevComponents.DotNetBar.ButtonX()
        Me.btn_Sign_FullScreen = New DevComponents.DotNetBar.ButtonX()
        Me.btn_Exit = New DevComponents.DotNetBar.ButtonX()
        Me.txt_Address = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txt_Registered_By = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txt_Contact_Number = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txt_Account_Class = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txt_Date_Deleted = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txt_Account_Number = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txt_Account_Name = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txt_Stub_Number = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.BW_Update_Marker = New System.ComponentModel.BackgroundWorker()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.tmr_save_anim = New System.Windows.Forms.Timer(Me.components)
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.pic_ID_Snapshot = New System.Windows.Forms.PictureBox()
        Me.pic_Signature = New System.Windows.Forms.PictureBox()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.txt_Deleted_by = New DevComponents.DotNetBar.Controls.TextBoxX()
        CType(Me.pic_ID_Snapshot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Signature, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_ID_Fullscreen
        '
        Me.btn_ID_Fullscreen.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_ID_Fullscreen.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.btn_ID_Fullscreen.Location = New System.Drawing.Point(580, 583)
        Me.btn_ID_Fullscreen.Name = "btn_ID_Fullscreen"
        Me.btn_ID_Fullscreen.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btn_ID_Fullscreen.Size = New System.Drawing.Size(134, 23)
        Me.btn_ID_Fullscreen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_ID_Fullscreen.TabIndex = 33
        Me.btn_ID_Fullscreen.Text = "View in Fullscreen"
        '
        'btn_Sign_FullScreen
        '
        Me.btn_Sign_FullScreen.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Sign_FullScreen.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.btn_Sign_FullScreen.Location = New System.Drawing.Point(580, 282)
        Me.btn_Sign_FullScreen.Name = "btn_Sign_FullScreen"
        Me.btn_Sign_FullScreen.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btn_Sign_FullScreen.Size = New System.Drawing.Size(134, 23)
        Me.btn_Sign_FullScreen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Sign_FullScreen.TabIndex = 32
        Me.btn_Sign_FullScreen.Text = "View in Fullscreen"
        '
        'btn_Exit
        '
        Me.btn_Exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Exit.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.btn_Exit.Location = New System.Drawing.Point(580, 674)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btn_Exit.Size = New System.Drawing.Size(134, 35)
        Me.btn_Exit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Exit.TabIndex = 31
        Me.btn_Exit.Text = "Exit"
        '
        'txt_Address
        '
        Me.txt_Address.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_Address.Border.Class = "TextBoxBorder"
        Me.txt_Address.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.txt_Address.DisabledBackColor = System.Drawing.Color.White
        Me.txt_Address.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txt_Address.ForeColor = System.Drawing.Color.Black
        Me.txt_Address.Location = New System.Drawing.Point(12, 567)
        Me.txt_Address.Multiline = True
        Me.txt_Address.Name = "txt_Address"
        Me.txt_Address.PreventEnterBeep = True
        Me.txt_Address.ReadOnly = True
        Me.txt_Address.Size = New System.Drawing.Size(330, 142)
        Me.txt_Address.TabIndex = 27
        Me.txt_Address.Text = "AAAAAA"
        '
        'txt_Registered_By
        '
        Me.txt_Registered_By.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_Registered_By.Border.Class = "TextBoxBorder"
        Me.txt_Registered_By.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.txt_Registered_By.DisabledBackColor = System.Drawing.Color.White
        Me.txt_Registered_By.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txt_Registered_By.ForeColor = System.Drawing.Color.Black
        Me.txt_Registered_By.Location = New System.Drawing.Point(12, 431)
        Me.txt_Registered_By.Name = "txt_Registered_By"
        Me.txt_Registered_By.PreventEnterBeep = True
        Me.txt_Registered_By.ReadOnly = True
        Me.txt_Registered_By.Size = New System.Drawing.Size(330, 33)
        Me.txt_Registered_By.TabIndex = 26
        Me.txt_Registered_By.Text = "AAAAAA"
        '
        'txt_Contact_Number
        '
        Me.txt_Contact_Number.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_Contact_Number.Border.Class = "TextBoxBorder"
        Me.txt_Contact_Number.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.txt_Contact_Number.DisabledBackColor = System.Drawing.Color.White
        Me.txt_Contact_Number.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txt_Contact_Number.ForeColor = System.Drawing.Color.Black
        Me.txt_Contact_Number.Location = New System.Drawing.Point(12, 371)
        Me.txt_Contact_Number.Name = "txt_Contact_Number"
        Me.txt_Contact_Number.PreventEnterBeep = True
        Me.txt_Contact_Number.ReadOnly = True
        Me.txt_Contact_Number.Size = New System.Drawing.Size(330, 33)
        Me.txt_Contact_Number.TabIndex = 25
        Me.txt_Contact_Number.Text = "AAAAAA"
        '
        'txt_Account_Class
        '
        Me.txt_Account_Class.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_Account_Class.Border.Class = "TextBoxBorder"
        Me.txt_Account_Class.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.txt_Account_Class.DisabledBackColor = System.Drawing.Color.White
        Me.txt_Account_Class.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txt_Account_Class.ForeColor = System.Drawing.Color.Black
        Me.txt_Account_Class.Location = New System.Drawing.Point(12, 251)
        Me.txt_Account_Class.Name = "txt_Account_Class"
        Me.txt_Account_Class.PreventEnterBeep = True
        Me.txt_Account_Class.ReadOnly = True
        Me.txt_Account_Class.Size = New System.Drawing.Size(330, 33)
        Me.txt_Account_Class.TabIndex = 24
        Me.txt_Account_Class.Text = "AAAAAA"
        '
        'txt_Date_Deleted
        '
        Me.txt_Date_Deleted.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_Date_Deleted.Border.Class = "TextBoxBorder"
        Me.txt_Date_Deleted.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.txt_Date_Deleted.DisabledBackColor = System.Drawing.Color.White
        Me.txt_Date_Deleted.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txt_Date_Deleted.ForeColor = System.Drawing.Color.Black
        Me.txt_Date_Deleted.Location = New System.Drawing.Point(12, 311)
        Me.txt_Date_Deleted.Name = "txt_Date_Deleted"
        Me.txt_Date_Deleted.PreventEnterBeep = True
        Me.txt_Date_Deleted.ReadOnly = True
        Me.txt_Date_Deleted.Size = New System.Drawing.Size(330, 33)
        Me.txt_Date_Deleted.TabIndex = 23
        Me.txt_Date_Deleted.Text = "AAAAAA"
        '
        'txt_Account_Number
        '
        Me.txt_Account_Number.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_Account_Number.Border.Class = "TextBoxBorder"
        Me.txt_Account_Number.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.txt_Account_Number.DisabledBackColor = System.Drawing.Color.White
        Me.txt_Account_Number.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txt_Account_Number.ForeColor = System.Drawing.Color.Black
        Me.txt_Account_Number.Location = New System.Drawing.Point(12, 191)
        Me.txt_Account_Number.Name = "txt_Account_Number"
        Me.txt_Account_Number.PreventEnterBeep = True
        Me.txt_Account_Number.ReadOnly = True
        Me.txt_Account_Number.Size = New System.Drawing.Size(330, 33)
        Me.txt_Account_Number.TabIndex = 22
        Me.txt_Account_Number.Text = "AAAAAA"
        '
        'txt_Account_Name
        '
        Me.txt_Account_Name.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_Account_Name.Border.Class = "TextBoxBorder"
        Me.txt_Account_Name.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.txt_Account_Name.DisabledBackColor = System.Drawing.Color.White
        Me.txt_Account_Name.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txt_Account_Name.ForeColor = System.Drawing.Color.Black
        Me.txt_Account_Name.Location = New System.Drawing.Point(12, 131)
        Me.txt_Account_Name.Name = "txt_Account_Name"
        Me.txt_Account_Name.PreventEnterBeep = True
        Me.txt_Account_Name.ReadOnly = True
        Me.txt_Account_Name.Size = New System.Drawing.Size(330, 33)
        Me.txt_Account_Name.TabIndex = 28
        Me.txt_Account_Name.Text = "AAAAAA"
        '
        'txt_Stub_Number
        '
        Me.txt_Stub_Number.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_Stub_Number.Border.Class = "TextBoxBorder"
        Me.txt_Stub_Number.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.txt_Stub_Number.DisabledBackColor = System.Drawing.Color.White
        Me.txt_Stub_Number.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Stub_Number.ForeColor = System.Drawing.Color.Black
        Me.txt_Stub_Number.Location = New System.Drawing.Point(12, 39)
        Me.txt_Stub_Number.Name = "txt_Stub_Number"
        Me.txt_Stub_Number.PreventEnterBeep = True
        Me.txt_Stub_Number.ReadOnly = True
        Me.txt_Stub_Number.Size = New System.Drawing.Size(330, 43)
        Me.txt_Stub_Number.TabIndex = 21
        Me.txt_Stub_Number.Text = "AAAAAA"
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.ForeColor = System.Drawing.Color.Black
        Me.LabelX4.Location = New System.Drawing.Point(12, 538)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(98, 23)
        Me.LabelX4.TabIndex = 20
        Me.LabelX4.Text = "Address:"
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.ForeColor = System.Drawing.Color.Black
        Me.LabelX7.Location = New System.Drawing.Point(12, 402)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(98, 23)
        Me.LabelX7.TabIndex = 19
        Me.LabelX7.Text = "Registered by:"
        '
        'BW_Update_Marker
        '
        Me.BW_Update_Marker.WorkerReportsProgress = True
        Me.BW_Update_Marker.WorkerSupportsCancellation = True
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.ForeColor = System.Drawing.Color.Black
        Me.LabelX6.Location = New System.Drawing.Point(12, 342)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(98, 23)
        Me.LabelX6.TabIndex = 17
        Me.LabelX6.Text = "Contact Number:"
        '
        'LabelX10
        '
        Me.LabelX10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.ForeColor = System.Drawing.Color.Black
        Me.LabelX10.Location = New System.Drawing.Point(12, 222)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(98, 23)
        Me.LabelX10.TabIndex = 16
        Me.LabelX10.Text = "Account Class:"
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.ForeColor = System.Drawing.Color.Black
        Me.LabelX5.Location = New System.Drawing.Point(12, 282)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(98, 23)
        Me.LabelX5.TabIndex = 15
        Me.LabelX5.Text = "Date Deleted:"
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(12, 162)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(98, 23)
        Me.LabelX3.TabIndex = 14
        Me.LabelX3.Text = "Account Number:"
        '
        'LabelX9
        '
        Me.LabelX9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.ForeColor = System.Drawing.Color.Black
        Me.LabelX9.Location = New System.Drawing.Point(384, 311)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(98, 23)
        Me.LabelX9.TabIndex = 13
        Me.LabelX9.Text = "ID Snapshot:"
        '
        'LabelX8
        '
        Me.LabelX8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.ForeColor = System.Drawing.Color.Black
        Me.LabelX8.Location = New System.Drawing.Point(384, 10)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(98, 23)
        Me.LabelX8.TabIndex = 12
        Me.LabelX8.Text = "Signature:"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(12, 10)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(98, 23)
        Me.LabelX1.TabIndex = 11
        Me.LabelX1.Text = "Stub Number:"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(12, 102)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(98, 23)
        Me.LabelX2.TabIndex = 10
        Me.LabelX2.Text = "Account Name:"
        '
        'pic_ID_Snapshot
        '
        Me.pic_ID_Snapshot.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pic_ID_Snapshot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_ID_Snapshot.ForeColor = System.Drawing.Color.Black
        Me.Highlighter1.SetHighlightColor(Me.pic_ID_Snapshot, DevComponents.DotNetBar.Validator.eHighlightColor.Orange)
        Me.Highlighter1.SetHighlightOnFocus(Me.pic_ID_Snapshot, True)
        Me.pic_ID_Snapshot.Location = New System.Drawing.Point(384, 340)
        Me.pic_ID_Snapshot.Name = "pic_ID_Snapshot"
        Me.pic_ID_Snapshot.Size = New System.Drawing.Size(330, 237)
        Me.pic_ID_Snapshot.TabIndex = 30
        Me.pic_ID_Snapshot.TabStop = False
        '
        'pic_Signature
        '
        Me.pic_Signature.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pic_Signature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_Signature.ForeColor = System.Drawing.Color.Black
        Me.Highlighter1.SetHighlightColor(Me.pic_Signature, DevComponents.DotNetBar.Validator.eHighlightColor.Orange)
        Me.Highlighter1.SetHighlightOnFocus(Me.pic_Signature, True)
        Me.pic_Signature.Location = New System.Drawing.Point(384, 39)
        Me.pic_Signature.Name = "pic_Signature"
        Me.pic_Signature.Size = New System.Drawing.Size(330, 237)
        Me.pic_Signature.TabIndex = 29
        Me.pic_Signature.TabStop = False
        '
        'LabelX11
        '
        Me.LabelX11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX11.ForeColor = System.Drawing.Color.Black
        Me.LabelX11.Location = New System.Drawing.Point(12, 470)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(98, 23)
        Me.LabelX11.TabIndex = 19
        Me.LabelX11.Text = "Deleted by:"
        '
        'txt_Deleted_by
        '
        Me.txt_Deleted_by.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_Deleted_by.Border.Class = "TextBoxBorder"
        Me.txt_Deleted_by.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.txt_Deleted_by.DisabledBackColor = System.Drawing.Color.White
        Me.txt_Deleted_by.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txt_Deleted_by.ForeColor = System.Drawing.Color.Black
        Me.txt_Deleted_by.Location = New System.Drawing.Point(12, 499)
        Me.txt_Deleted_by.Name = "txt_Deleted_by"
        Me.txt_Deleted_by.PreventEnterBeep = True
        Me.txt_Deleted_by.ReadOnly = True
        Me.txt_Deleted_by.Size = New System.Drawing.Size(330, 33)
        Me.txt_Deleted_by.TabIndex = 26
        Me.txt_Deleted_by.Text = "AAAAAA"
        '
        'frm_Deleted_Reg_Viewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 715)
        Me.Controls.Add(Me.btn_ID_Fullscreen)
        Me.Controls.Add(Me.btn_Sign_FullScreen)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.pic_ID_Snapshot)
        Me.Controls.Add(Me.pic_Signature)
        Me.Controls.Add(Me.txt_Address)
        Me.Controls.Add(Me.txt_Deleted_by)
        Me.Controls.Add(Me.txt_Registered_By)
        Me.Controls.Add(Me.txt_Contact_Number)
        Me.Controls.Add(Me.txt_Account_Class)
        Me.Controls.Add(Me.txt_Date_Deleted)
        Me.Controls.Add(Me.txt_Account_Number)
        Me.Controls.Add(Me.txt_Account_Name)
        Me.Controls.Add(Me.txt_Stub_Number)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.LabelX11)
        Me.Controls.Add(Me.LabelX7)
        Me.Controls.Add(Me.LabelX6)
        Me.Controls.Add(Me.LabelX10)
        Me.Controls.Add(Me.LabelX5)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.LabelX9)
        Me.Controls.Add(Me.LabelX8)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.LabelX2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Deleted_Reg_Viewer"
        Me.Text = "Deleted Registration Details"
        CType(Me.pic_ID_Snapshot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Signature, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_ID_Fullscreen As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_Sign_FullScreen As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_Exit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents pic_ID_Snapshot As PictureBox
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents pic_Signature As PictureBox
    Friend WithEvents txt_Address As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txt_Registered_By As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txt_Contact_Number As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txt_Account_Class As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txt_Date_Deleted As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txt_Account_Number As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txt_Account_Name As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txt_Stub_Number As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents BW_Update_Marker As System.ComponentModel.BackgroundWorker
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tmr_save_anim As Timer
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_Deleted_by As DevComponents.DotNetBar.Controls.TextBoxX
End Class
