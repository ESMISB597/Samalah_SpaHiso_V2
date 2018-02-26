Public Class Regist
    Public Structure customer
        Public name As String
        Public surname As String
        Public age As Integer
        Public address As String
        Public carrier As String
        Public salary As Double
        Public telephone As String
    End Structure

    Function SQLFx(Switcher As Integer) As String
        Dim cus As customer

        ' This will be declared fnc '
        cus.name = NameReg.Text
        cus.surname = SurnameReg.Text
        cus.age = AgeSelect.SelectedItem
        cus.address = Address_Box.Text
        cus.carrier = Carrier_Box.Text
        cus.salary = CDbl(Incoming_Box.Text)
        cus.telephone = TelephoneReg.Text

        Dim SQLStatement As String
        If Switcher = 1 Then
            SQLStatement = "SELECT Cus_Id , Cus_Name , Count(Cus_Tel) from customer WHERE Cus_Tel = " & cus.telephone & " and Cus_Name = " & cus.name
            MessageBox.Show(SQLStatement)
        ElseIf Switcher = 2 Then
            SQLStatement = "INSERT INTO customer (Cus_name,Cus_Age,Cus_Address,Cus_Income,Cus_Tel,Cus_Job) VALUES ('" & cus.name & "','" & cus.surname & "','" & cus.age & "','" & cus.address & "','" & cus.carrier & "','" & cus.salary & "','" & cus.telephone & "')"
            MessageBox.Show(SQLStatement)
        ElseIf Switcher = 3 Then

        End If


        Return 0
    End Function

    Private Sub Regist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        For i = 0 To 100
            AgeSelect.Items.Add(i)
        Next
    End Sub

    Private Sub Regist_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Login_Page.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.Hide()
        Login_Page.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles CheckDuplicate_Button.Click

        SQLFx(1)

        If SQLFx(15) Then
            MessageBox.Show("ลูกค้ามีรายการชื่ออยู่แล้ว", "แจ้งเตือน")
        ElseIf SQLFx(20) Then
            MessageBox.Show("ลูกค้าไม่มีรายชื่อออยู่ สามารถลงทะเบียนใหม่ได้ค่ะ", "แจ้งเตือน")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Enquire_Button.Click
        NameReg.Enabled = False
        SurnameReg.Enabled = False
        Address_Box.Enabled = False
        Carrier_Box.Enabled = False
        Incoming_Box.Enabled = False
        TelephoneReg.Enabled = False
        AgeSelect.Enabled = False

        SQLFx(2)
        MessageBox.Show("ลงทะเบียนสำเร็จแล้วค่ะ", "ข้อความจากระบบ")

        NameReg.Enabled = True
        SurnameReg.Enabled = True
        Address_Box.Enabled = True
        Carrier_Box.Enabled = True
        Incoming_Box.Enabled = True
        TelephoneReg.Enabled = True
        AgeSelect.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Edit_Button.Click
    End Sub
End Class