<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPage_Spa
    Inherits System.Windows.Forms.Form

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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Customer_Service = New System.Windows.Forms.ToolStripLabel()
        Me.Spa_Buy_Service = New System.Windows.Forms.ToolStripLabel()
        Me.CheckRoom_Service = New System.Windows.Forms.ToolStripLabel()
        Me.PointCard_Service = New System.Windows.Forms.ToolStripLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ServiceName = New System.Windows.Forms.Label()
        Me.UpdatedListBox = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Customer_Service, Me.Spa_Buy_Service, Me.CheckRoom_Service, Me.PointCard_Service})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(819, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Customer_Service
        '
        Me.Customer_Service.Name = "Customer_Service"
        Me.Customer_Service.Size = New System.Drawing.Size(61, 22)
        Me.Customer_Service.Text = "บริการลูกค้า"
        '
        'Spa_Buy_Service
        '
        Me.Spa_Buy_Service.Name = "Spa_Buy_Service"
        Me.Spa_Buy_Service.Size = New System.Drawing.Size(114, 22)
        Me.Spa_Buy_Service.Text = "ซื้อสินค้า และ บริการสปา"
        '
        'CheckRoom_Service
        '
        Me.CheckRoom_Service.Name = "CheckRoom_Service"
        Me.CheckRoom_Service.Size = New System.Drawing.Size(67, 22)
        Me.CheckRoom_Service.Text = "ตรวจสอบห้อง"
        '
        'PointCard_Service
        '
        Me.PointCard_Service.Name = "PointCard_Service"
        Me.PointCard_Service.Size = New System.Drawing.Size(81, 22)
        Me.PointCard_Service.Text = "คะแนนสะสมแต้ม"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ServiceName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(264, 148)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Greetings"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "สวัสดีค่ะ"
        '
        'ServiceName
        '
        Me.ServiceName.AutoSize = True
        Me.ServiceName.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ServiceName.Location = New System.Drawing.Point(20, 80)
        Me.ServiceName.Name = "ServiceName"
        Me.ServiceName.Size = New System.Drawing.Size(220, 37)
        Me.ServiceName.TabIndex = 1
        Me.ServiceName.Text = "คุณ หัทยา เจนชัย"
        '
        'UpdatedListBox
        '
        Me.UpdatedListBox.FormattingEnabled = True
        Me.UpdatedListBox.Location = New System.Drawing.Point(13, 183)
        Me.UpdatedListBox.Name = "UpdatedListBox"
        Me.UpdatedListBox.Size = New System.Drawing.Size(263, 134)
        Me.UpdatedListBox.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Samalah_SpaHiso.My.Resources.Resources.spa_hiso_banner
        Me.PictureBox1.Location = New System.Drawing.Point(291, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(516, 289)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'MainPage_Spa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 327)
        Me.Controls.Add(Me.UpdatedListBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainPage_Spa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "หน้าหลัก"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Customer_Service As ToolStripLabel
    Friend WithEvents Spa_Buy_Service As ToolStripLabel
    Friend WithEvents CheckRoom_Service As ToolStripLabel
    Friend WithEvents PointCard_Service As ToolStripLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ServiceName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents UpdatedListBox As ListBox
End Class
