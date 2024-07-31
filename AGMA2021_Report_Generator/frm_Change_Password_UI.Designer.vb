<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Change_Password_UI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Change_Password_UI))
        Me.txt_Old_Password = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txt_New_Password = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.txt_Confirm_Password = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btn_Update_Info = New DevComponents.DotNetBar.ButtonX()
        Me.BW_Password_Compare = New System.ComponentModel.BackgroundWorker()
        Me.circ_password = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.tmr_prog_password_anim = New System.Windows.Forms.Timer(Me.components)
        Me.BW_Password_Change = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'txt_Old_Password
        '
        Me.txt_Old_Password.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_Old_Password.Border.Class = "TextBoxBorder"
        Me.txt_Old_Password.Border.CornerDiameter = 15
        Me.txt_Old_Password.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.txt_Old_Password.ButtonCustom.Symbol = ""
        Me.txt_Old_Password.ButtonCustom.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_Old_Password.ButtonCustom.Tooltip = "Show Password"
        Me.txt_Old_Password.ButtonCustom.Visible = True
        Me.txt_Old_Password.ButtonCustom2.Symbol = ""
        Me.txt_Old_Password.ButtonCustom2.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_Old_Password.ButtonCustom2.Tooltip = "Hide Password"
        Me.txt_Old_Password.ButtonCustom2.Visible = True
        Me.txt_Old_Password.DisabledBackColor = System.Drawing.Color.White
        Me.txt_Old_Password.ForeColor = System.Drawing.Color.Black
        Me.txt_Old_Password.Location = New System.Drawing.Point(12, 28)
        Me.txt_Old_Password.Name = "txt_Old_Password"
        Me.txt_Old_Password.PreventEnterBeep = True
        Me.txt_Old_Password.Size = New System.Drawing.Size(299, 36)
        Me.txt_Old_Password.TabIndex = 0
        Me.txt_Old_Password.UseSystemPasswordChar = True
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(26, 11)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 11)
        Me.LabelX1.TabIndex = 2
        Me.LabelX1.Text = "Old Password"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(26, 99)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 11)
        Me.LabelX2.TabIndex = 2
        Me.LabelX2.Text = "New Password"
        '
        'txt_New_Password
        '
        Me.txt_New_Password.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_New_Password.Border.Class = "TextBoxBorder"
        Me.txt_New_Password.Border.CornerDiameter = 15
        Me.txt_New_Password.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.txt_New_Password.ButtonCustom.Symbol = ""
        Me.txt_New_Password.ButtonCustom.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_New_Password.ButtonCustom.Tooltip = "Show Password"
        Me.txt_New_Password.ButtonCustom.Visible = True
        Me.txt_New_Password.ButtonCustom2.Symbol = ""
        Me.txt_New_Password.ButtonCustom2.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_New_Password.ButtonCustom2.Tooltip = "Hide Password"
        Me.txt_New_Password.ButtonCustom2.Visible = True
        Me.txt_New_Password.DisabledBackColor = System.Drawing.Color.White
        Me.txt_New_Password.ForeColor = System.Drawing.Color.Black
        Me.txt_New_Password.Location = New System.Drawing.Point(12, 116)
        Me.txt_New_Password.Name = "txt_New_Password"
        Me.txt_New_Password.PreventEnterBeep = True
        Me.txt_New_Password.Size = New System.Drawing.Size(299, 36)
        Me.txt_New_Password.TabIndex = 1
        Me.txt_New_Password.UseSystemPasswordChar = True
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(26, 152)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(137, 22)
        Me.LabelX3.TabIndex = 2
        Me.LabelX3.Text = "Confirm New Password"
        '
        'txt_Confirm_Password
        '
        Me.txt_Confirm_Password.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_Confirm_Password.Border.Class = "TextBoxBorder"
        Me.txt_Confirm_Password.Border.CornerDiameter = 15
        Me.txt_Confirm_Password.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.txt_Confirm_Password.ButtonCustom.Symbol = ""
        Me.txt_Confirm_Password.ButtonCustom.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_Confirm_Password.ButtonCustom.Tooltip = "Show Password"
        Me.txt_Confirm_Password.ButtonCustom.Visible = True
        Me.txt_Confirm_Password.ButtonCustom2.Symbol = ""
        Me.txt_Confirm_Password.ButtonCustom2.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_Confirm_Password.ButtonCustom2.Tooltip = "Hide Password"
        Me.txt_Confirm_Password.ButtonCustom2.Visible = True
        Me.txt_Confirm_Password.DisabledBackColor = System.Drawing.Color.White
        Me.txt_Confirm_Password.ForeColor = System.Drawing.Color.Black
        Me.txt_Confirm_Password.Location = New System.Drawing.Point(12, 175)
        Me.txt_Confirm_Password.Name = "txt_Confirm_Password"
        Me.txt_Confirm_Password.PreventEnterBeep = True
        Me.txt_Confirm_Password.Size = New System.Drawing.Size(299, 36)
        Me.txt_Confirm_Password.TabIndex = 2
        Me.txt_Confirm_Password.UseSystemPasswordChar = True
        '
        'btn_Update_Info
        '
        Me.btn_Update_Info.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Update_Info.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.btn_Update_Info.Location = New System.Drawing.Point(177, 217)
        Me.btn_Update_Info.Name = "btn_Update_Info"
        Me.btn_Update_Info.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btn_Update_Info.Size = New System.Drawing.Size(134, 35)
        Me.btn_Update_Info.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Update_Info.TabIndex = 3
        Me.btn_Update_Info.Text = "Confirm"
        '
        'BW_Password_Compare
        '
        '
        'circ_password
        '
        Me.circ_password.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.circ_password.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.circ_password.Location = New System.Drawing.Point(124, 217)
        Me.circ_password.Name = "circ_password"
        Me.circ_password.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot
        Me.circ_password.Size = New System.Drawing.Size(47, 35)
        Me.circ_password.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.circ_password.TabIndex = 10
        Me.circ_password.TabStop = False
        '
        'tmr_prog_password_anim
        '
        '
        'BW_Password_Change
        '
        Me.BW_Password_Change.WorkerReportsProgress = True
        Me.BW_Password_Change.WorkerSupportsCancellation = True
        '
        'frm_Change_Password_UI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 264)
        Me.Controls.Add(Me.circ_password)
        Me.Controls.Add(Me.btn_Update_Info)
        Me.Controls.Add(Me.txt_Confirm_Password)
        Me.Controls.Add(Me.txt_New_Password)
        Me.Controls.Add(Me.txt_Old_Password)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Change_Password_UI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Change Password"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_Old_Password As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_New_Password As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_Confirm_Password As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btn_Update_Info As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BW_Password_Compare As System.ComponentModel.BackgroundWorker
    Friend WithEvents circ_password As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents tmr_prog_password_anim As System.Windows.Forms.Timer
    Friend WithEvents BW_Password_Change As System.ComponentModel.BackgroundWorker
End Class
