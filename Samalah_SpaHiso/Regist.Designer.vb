<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Regist
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AgeSelect = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Incoming_Box = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Carrier_Box = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Address_Box = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SurnameReg = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NameReg = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Enquire_Button = New System.Windows.Forms.Button()
        Me.Edit_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.CheckDuplicate_Button = New System.Windows.Forms.Button()
        Me.TelephoneReg = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TelephoneReg)
        Me.GroupBox1.Controls.Add(Me.AgeSelect)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Incoming_Box)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Carrier_Box)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Address_Box)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.SurnameReg)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.NameReg)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(287, 394)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ข้อมูลทั่วไป"
        '
        'AgeSelect
        '
        Me.AgeSelect.FormattingEnabled = True
        Me.AgeSelect.Location = New System.Drawing.Point(14, 125)
        Me.AgeSelect.Name = "AgeSelect"
        Me.AgeSelect.Size = New System.Drawing.Size(259, 21)
        Me.AgeSelect.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 341)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "เบอร์โทรศัพท์"
        '
        'Incoming_Box
        '
        Me.Incoming_Box.Location = New System.Drawing.Point(14, 314)
        Me.Incoming_Box.Name = "Incoming_Box"
        Me.Incoming_Box.Size = New System.Drawing.Size(259, 20)
        Me.Incoming_Box.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 298)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "รายได้"
        '
        'Carrier_Box
        '
        Me.Carrier_Box.Location = New System.Drawing.Point(14, 268)
        Me.Carrier_Box.Name = "Carrier_Box"
        Me.Carrier_Box.Size = New System.Drawing.Size(259, 20)
        Me.Carrier_Box.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "อาชีพ"
        '
        'Address_Box
        '
        Me.Address_Box.Location = New System.Drawing.Point(14, 169)
        Me.Address_Box.Multiline = True
        Me.Address_Box.Name = "Address_Box"
        Me.Address_Box.Size = New System.Drawing.Size(259, 77)
        Me.Address_Box.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "ที่อยู่"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "อายุ"
        '
        'SurnameReg
        '
        Me.SurnameReg.Location = New System.Drawing.Point(14, 82)
        Me.SurnameReg.Name = "SurnameReg"
        Me.SurnameReg.Size = New System.Drawing.Size(259, 20)
        Me.SurnameReg.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "นามสกุล"
        '
        'NameReg
        '
        Me.NameReg.Location = New System.Drawing.Point(14, 39)
        Me.NameReg.Name = "NameReg"
        Me.NameReg.Size = New System.Drawing.Size(259, 20)
        Me.NameReg.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ชื่อลูกค้า"
        '
        'Enquire_Button
        '
        Me.Enquire_Button.Location = New System.Drawing.Point(27, 452)
        Me.Enquire_Button.Name = "Enquire_Button"
        Me.Enquire_Button.Size = New System.Drawing.Size(259, 23)
        Me.Enquire_Button.TabIndex = 1
        Me.Enquire_Button.Text = "บันทึก"
        Me.Enquire_Button.UseVisualStyleBackColor = True
        '
        'Edit_Button
        '
        Me.Edit_Button.Location = New System.Drawing.Point(27, 481)
        Me.Edit_Button.Name = "Edit_Button"
        Me.Edit_Button.Size = New System.Drawing.Size(259, 23)
        Me.Edit_Button.TabIndex = 2
        Me.Edit_Button.Text = "แก้ไข"
        Me.Edit_Button.UseVisualStyleBackColor = True
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Location = New System.Drawing.Point(27, 510)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(259, 23)
        Me.Cancel_Button.TabIndex = 3
        Me.Cancel_Button.Text = "ยกเลิก"
        Me.Cancel_Button.UseVisualStyleBackColor = True
        '
        'CheckDuplicate_Button
        '
        Me.CheckDuplicate_Button.Location = New System.Drawing.Point(27, 423)
        Me.CheckDuplicate_Button.Name = "CheckDuplicate_Button"
        Me.CheckDuplicate_Button.Size = New System.Drawing.Size(259, 23)
        Me.CheckDuplicate_Button.TabIndex = 4
        Me.CheckDuplicate_Button.Text = "ตรวจสอบ"
        Me.CheckDuplicate_Button.UseVisualStyleBackColor = True
        '
        'TelephoneReg
        '
        Me.TelephoneReg.Location = New System.Drawing.Point(14, 358)
        Me.TelephoneReg.Mask = "000-000-0000"
        Me.TelephoneReg.Name = "TelephoneReg"
        Me.TelephoneReg.Size = New System.Drawing.Size(259, 20)
        Me.TelephoneReg.TabIndex = 15
        '
        'Regist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 548)
        Me.Controls.Add(Me.CheckDuplicate_Button)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.Edit_Button)
        Me.Controls.Add(Me.Enquire_Button)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Regist"
        Me.Text = "ลงทะเบียนลูกค้า"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Incoming_Box As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Carrier_Box As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Address_Box As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SurnameReg As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NameReg As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Enquire_Button As Button
    Friend WithEvents Edit_Button As Button
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents CheckDuplicate_Button As Button
    Friend WithEvents AgeSelect As ComboBox
    Friend WithEvents TelephoneReg As MaskedTextBox
End Class
