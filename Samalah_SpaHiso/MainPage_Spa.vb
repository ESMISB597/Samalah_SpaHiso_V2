Public Class MainPage_Spa

    Private Sub MainPage_Spa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdatedListBox.Items.Add("เวอร์ชันที่ 0.02 สมาหลาสปาไฮโซ ซิสเทม")
        UpdatedListBox.Items.Add("อัปเดตระบบ")
        UpdatedListBox.Items.Add("- แก้ระบบการทำงานที่ผิดพลาด")
        UpdatedListBox.Items.Add("- แก้การทำงานที่ผิดเป้าหมาย")
        UpdatedListBox.Items.Add("- มาสคอตน้องหมา")
        UpdatedListBox.Items.Add("- เพิ่มสแปลช")
    End Sub

    Private Sub MainPage_Spa_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim closeMsg = MessageBox.Show("ต้องการออกจากระบบหรือไม่?", "ข้อความแจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If closeMsg = DialogResult.Yes Then
            Me.Hide()
            Login_Page.Show()
        Else

        End If
    End Sub

    Private Sub CheckRoom_Service_Click(sender As Object, e As EventArgs) Handles CheckRoom_Service.Click
        RoomBook.Show()
    End Sub
End Class