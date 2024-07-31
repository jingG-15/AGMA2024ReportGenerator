<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Settings))
        Me.btn_Test_IP = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.IpAddressInput1 = New DevComponents.Editors.IpAddressInput()
        Me.btn_Save_IP = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.cmb_COM_Ports = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.btn_Refresh_Ports = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.cmb_Baudrate = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        CType(Me.IpAddressInput1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Test_IP
        '
        Me.btn_Test_IP.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Test_IP.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.btn_Test_IP.Location = New System.Drawing.Point(191, 43)
        Me.btn_Test_IP.Name = "btn_Test_IP"
        Me.btn_Test_IP.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btn_Test_IP.Size = New System.Drawing.Size(134, 35)
        Me.btn_Test_IP.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Test_IP.TabIndex = 4
        Me.btn_Test_IP.Text = "Test IP"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(12, 12)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(98, 23)
        Me.LabelX1.TabIndex = 3
        Me.LabelX1.Text = "Server IP Address:"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'IpAddressInput1
        '
        Me.IpAddressInput1.AutoOverwrite = True
        '
        '
        '
        Me.IpAddressInput1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.IpAddressInput1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.IpAddressInput1.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.IpAddressInput1.ButtonFreeText.Visible = True
        Me.IpAddressInput1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.IpAddressInput1.Location = New System.Drawing.Point(118, 12)
        Me.IpAddressInput1.Name = "IpAddressInput1"
        Me.IpAddressInput1.Size = New System.Drawing.Size(209, 25)
        Me.IpAddressInput1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.IpAddressInput1.TabIndex = 5
        '
        'btn_Save_IP
        '
        Me.btn_Save_IP.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Save_IP.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.btn_Save_IP.Location = New System.Drawing.Point(193, 197)
        Me.btn_Save_IP.Name = "btn_Save_IP"
        Me.btn_Save_IP.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btn_Save_IP.Size = New System.Drawing.Size(134, 35)
        Me.btn_Save_IP.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Save_IP.TabIndex = 4
        Me.btn_Save_IP.Text = "Save"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(14, 94)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(98, 23)
        Me.LabelX2.TabIndex = 3
        Me.LabelX2.Text = "SMS Port:"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'cmb_COM_Ports
        '
        Me.cmb_COM_Ports.DisplayMember = "Text"
        Me.cmb_COM_Ports.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_COM_Ports.Font = New System.Drawing.Font("Bahnschrift SemiLight", 11.0!)
        Me.cmb_COM_Ports.ForeColor = System.Drawing.Color.Black
        Me.cmb_COM_Ports.FormattingEnabled = True
        Me.cmb_COM_Ports.ItemHeight = 19
        Me.cmb_COM_Ports.Location = New System.Drawing.Point(120, 94)
        Me.cmb_COM_Ports.Name = "cmb_COM_Ports"
        Me.cmb_COM_Ports.Size = New System.Drawing.Size(207, 25)
        Me.cmb_COM_Ports.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmb_COM_Ports.TabIndex = 6
        Me.cmb_COM_Ports.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.cmb_COM_Ports.WatermarkText = "COM21"
        '
        'btn_Refresh_Ports
        '
        Me.btn_Refresh_Ports.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Refresh_Ports.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.btn_Refresh_Ports.Location = New System.Drawing.Point(193, 156)
        Me.btn_Refresh_Ports.Name = "btn_Refresh_Ports"
        Me.btn_Refresh_Ports.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btn_Refresh_Ports.Size = New System.Drawing.Size(134, 35)
        Me.btn_Refresh_Ports.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Refresh_Ports.TabIndex = 4
        Me.btn_Refresh_Ports.Text = "Refresh Ports"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(16, 127)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(98, 23)
        Me.LabelX3.TabIndex = 3
        Me.LabelX3.Text = "Baudrate:"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'cmb_Baudrate
        '
        Me.cmb_Baudrate.DisplayMember = "Text"
        Me.cmb_Baudrate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_Baudrate.Font = New System.Drawing.Font("Bahnschrift SemiLight", 11.0!)
        Me.cmb_Baudrate.ForeColor = System.Drawing.Color.Black
        Me.cmb_Baudrate.FormattingEnabled = True
        Me.cmb_Baudrate.ItemHeight = 19
        Me.cmb_Baudrate.Location = New System.Drawing.Point(120, 125)
        Me.cmb_Baudrate.Name = "cmb_Baudrate"
        Me.cmb_Baudrate.Size = New System.Drawing.Size(207, 25)
        Me.cmb_Baudrate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmb_Baudrate.TabIndex = 7
        Me.cmb_Baudrate.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.cmb_Baudrate.WatermarkText = "9600"
        '
        'frm_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 251)
        Me.Controls.Add(Me.cmb_Baudrate)
        Me.Controls.Add(Me.cmb_COM_Ports)
        Me.Controls.Add(Me.IpAddressInput1)
        Me.Controls.Add(Me.btn_Refresh_Ports)
        Me.Controls.Add(Me.btn_Save_IP)
        Me.Controls.Add(Me.btn_Test_IP)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        CType(Me.IpAddressInput1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_Test_IP As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents IpAddressInput1 As DevComponents.Editors.IpAddressInput
    Friend WithEvents btn_Save_IP As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmb_COM_Ports As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents btn_Refresh_Ports As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmb_Baudrate As DevComponents.DotNetBar.Controls.ComboBoxEx
End Class
