<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Login))
        Me.circ_login = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.btn_Login = New DevComponents.DotNetBar.ButtonX()
        Me.txt_Username = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txt_Password = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.tmr_circ_login_animator = New System.Windows.Forms.Timer(Me.components)
        Me.BW_Check_Credentials = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'circ_login
        '
        Me.circ_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.circ_login.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.circ_login.Location = New System.Drawing.Point(134, 130)
        Me.circ_login.Name = "circ_login"
        Me.circ_login.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot
        Me.circ_login.Size = New System.Drawing.Size(54, 35)
        Me.circ_login.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.circ_login.TabIndex = 13
        '
        'btn_Login
        '
        Me.btn_Login.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Login.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.btn_Login.Location = New System.Drawing.Point(228, 130)
        Me.btn_Login.Name = "btn_Login"
        Me.btn_Login.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btn_Login.Size = New System.Drawing.Size(83, 35)
        Me.btn_Login.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Login.TabIndex = 2
        Me.btn_Login.Text = "Login"
        '
        'txt_Username
        '
        Me.txt_Username.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_Username.Border.Class = "TextBoxBorder"
        Me.txt_Username.Border.CornerDiameter = 15
        Me.txt_Username.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.txt_Username.DisabledBackColor = System.Drawing.Color.White
        Me.txt_Username.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Username.ForeColor = System.Drawing.Color.Black
        Me.txt_Username.Location = New System.Drawing.Point(12, 29)
        Me.txt_Username.Name = "txt_Username"
        Me.txt_Username.PreventEnterBeep = True
        Me.txt_Username.Size = New System.Drawing.Size(299, 39)
        Me.txt_Username.TabIndex = 0
        Me.txt_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.ForeColor = System.Drawing.Color.Black
        Me.LabelX7.Location = New System.Drawing.Point(26, 12)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(75, 11)
        Me.LabelX7.TabIndex = 10
        Me.LabelX7.Text = "Username"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(26, 71)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 11)
        Me.LabelX1.TabIndex = 10
        Me.LabelX1.Text = "Password"
        '
        'txt_Password
        '
        Me.txt_Password.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_Password.Border.Class = "TextBoxBorder"
        Me.txt_Password.Border.CornerDiameter = 15
        Me.txt_Password.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.txt_Password.ButtonCustom.Symbol = ""
        Me.txt_Password.ButtonCustom.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_Password.ButtonCustom.Tooltip = "Show Password"
        Me.txt_Password.ButtonCustom.Visible = True
        Me.txt_Password.ButtonCustom2.Symbol = ""
        Me.txt_Password.ButtonCustom2.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_Password.ButtonCustom2.Tooltip = "Hide Password"
        Me.txt_Password.ButtonCustom2.Visible = True
        Me.txt_Password.DisabledBackColor = System.Drawing.Color.White
        Me.txt_Password.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Password.ForeColor = System.Drawing.Color.Black
        Me.txt_Password.Location = New System.Drawing.Point(12, 88)
        Me.txt_Password.Name = "txt_Password"
        Me.txt_Password.PreventEnterBeep = True
        Me.txt_Password.Size = New System.Drawing.Size(299, 39)
        Me.txt_Password.TabIndex = 1
        Me.txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_Password.UseSystemPasswordChar = True
        '
        'tmr_circ_login_animator
        '
        '
        'BW_Check_Credentials
        '
        Me.BW_Check_Credentials.WorkerReportsProgress = True
        Me.BW_Check_Credentials.WorkerSupportsCancellation = True
        '
        'frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 172)
        Me.Controls.Add(Me.txt_Password)
        Me.Controls.Add(Me.circ_login)
        Me.Controls.Add(Me.btn_Login)
        Me.Controls.Add(Me.txt_Username)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.LabelX7)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents circ_login As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents btn_Login As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txt_Username As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_Password As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents tmr_circ_login_animator As System.Windows.Forms.Timer
    Friend WithEvents BW_Check_Credentials As System.ComponentModel.BackgroundWorker
End Class
