<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_District_Selection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_District_Selection))
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.cmb_Districts = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.btn_Confirm = New DevComponents.DotNetBar.ButtonX()
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
        Me.LabelX1.Location = New System.Drawing.Point(12, 12)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(76, 20)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Select District:"
        '
        'cmb_Districts
        '
        Me.cmb_Districts.DisplayMember = "Text"
        Me.cmb_Districts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_Districts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Districts.ForeColor = System.Drawing.Color.Black
        Me.cmb_Districts.FormattingEnabled = True
        Me.cmb_Districts.ItemHeight = 16
        Me.cmb_Districts.Location = New System.Drawing.Point(12, 38)
        Me.cmb_Districts.Name = "cmb_Districts"
        Me.cmb_Districts.Size = New System.Drawing.Size(182, 22)
        Me.cmb_Districts.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmb_Districts.TabIndex = 1
        '
        'btn_Confirm
        '
        Me.btn_Confirm.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Confirm.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.btn_Confirm.Location = New System.Drawing.Point(119, 66)
        Me.btn_Confirm.Name = "btn_Confirm"
        Me.btn_Confirm.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btn_Confirm.Size = New System.Drawing.Size(75, 23)
        Me.btn_Confirm.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Confirm.TabIndex = 2
        Me.btn_Confirm.Text = "Confirm"
        '
        'frm_District_Selection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(201, 94)
        Me.Controls.Add(Me.btn_Confirm)
        Me.Controls.Add(Me.cmb_Districts)
        Me.Controls.Add(Me.LabelX1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_District_Selection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Select District"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmb_Districts As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents btn_Confirm As DevComponents.DotNetBar.ButtonX
End Class
