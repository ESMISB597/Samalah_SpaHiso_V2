Public Class RoomBook

    Function Init(v As Integer)
        Dim i = 9
        Dim j = 10
        Dim Room As String
        For b As Integer = 1 To v

            Dim lbl As Button = Me.Controls.Find("Button" & b, True).FirstOrDefault
            If b <= 11 And i <= 19 And j <= 20 Then
                lbl.BackColor = Color.LightGreen
                Room = "R1"
                lbl.Text = Room + vbNewLine + "ว่างค่ะ" + vbNewLine + i.ToString + ":" + "00" + "-" + j.ToString + ":" + "00"
                i += 1
                j += 1
                If i > 19 And j > 20 Then
                    i = 9
                    j = 10
                End If
            ElseIf b <= 22 And i <= 19 And j <= 20 Then
                lbl.BackColor = Color.LightGreen
                Room = "R2"
                lbl.Text = Room + vbNewLine + "ว่างค่ะ" + vbNewLine + i.ToString + ":" + "00" + "-" + j.ToString + ":" + "00"
                i += 1
                j += 1
                If i > 19 And j > 20 Then
                    i = 9
                    j = 10
                End If
            ElseIf b <= 33 And i <= 19 And j <= 20 Then
                lbl.BackColor = Color.LightGreen
                Room = "R3"
                lbl.Text = Room + vbNewLine + "ว่างค่ะ" + vbNewLine + i.ToString + ":" + "00" + "-" + j.ToString + ":" + "00"
                i += 1
                j += 1
                If i > 19 And j > 20 Then
                    i = 9
                    j = 10
                End If
            ElseIf b <= 44 And i <= 19 And j <= 20 Then
                lbl.BackColor = Color.LightGreen
                Room = "R4"
                lbl.Text = Room + vbNewLine + "ว่างค่ะ" + vbNewLine + i.ToString + ":" + "00" + "-" + j.ToString + ":" + "00"
                i += 1
                j += 1
                If i > 19 And j > 20 Then
                    i = 9
                    j = 10
                End If
            ElseIf b <= 55 And i <= 19 And j <= 20 Then
                lbl.BackColor = Color.LightGreen
                Room = "R5"
                lbl.Text = Room + vbNewLine + "ว่างค่ะ" + vbNewLine + i.ToString + ":" + "00" + "-" + j.ToString + ":" + "00"
                i += 1
                j += 1
                If i > 19 And j > 20 Then
                    i = 9
                    j = 10
                End If
            End If
        Next

        Return 0
    End Function
    Function ButtonRC(bt As Button, room As String, i As Integer, j As Integer)

        Dim St As String

        If room = "R1" And i <= 19 And j <= 20 Then
            bt.BackColor = Color.Red
            St = room + vbNewLine + "จองแล้วค่ะ" + vbNewLine + i.ToString + ":" + "00" + "-" + j.ToString + ":" + "00"
            bt.Text = St.ToString

            i += 1
            j += 1

        ElseIf room = "R2" And i <= 19 And j <= 20 Then
            bt.BackColor = Color.Red
            St = room + vbNewLine + "จองแล้วค่ะ" + vbNewLine + i.ToString + ":" + "00" + "-" + j.ToString + ":" + "00"
            bt.Text = St.ToString


            i += 1
            j += 1

        ElseIf room = "R3" And i <= 19 And j <= 20 Then
            bt.BackColor = Color.Red
            St = room + vbNewLine + "จองแล้วค่ะ" + vbNewLine + i.ToString + ":" + "00" + "-" + j.ToString + ":" + "00"
            bt.Text = St.ToString


            i += 1
            j += 1

        ElseIf room = "R4" And i <= 19 And j <= 20 Then
            bt.BackColor = Color.Red
            St = room + vbNewLine + "จองแล้วค่ะ" + vbNewLine + i.ToString + ":" + "00" + "-" + j.ToString + ":" + "00"
            bt.Text = St.ToString


            i += 1
            j += 1

        ElseIf room = "R5" And i <= 19 And j <= 20 Then
            bt.BackColor = Color.Red
            St = room + vbNewLine + "จองแล้วค่ะ" + vbNewLine + i.ToString + ":" + "00" + "-" + j.ToString + ":" + "00"
            bt.Text = St.ToString


            i += 1
            j += 1

        End If

        Return 0
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ButtonRC(sender, "R1", 9, 10)
    End Sub

    Private Sub RoomBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim V As Integer = 55
        Init(v)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ButtonRC(sender, "R1", 10, 11)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ButtonRC(sender, "R1", 11, 12)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ButtonRC(sender, "R1", 12, 13)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ButtonRC(sender, "R1", 13, 14)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ButtonRC(sender, "R1", 14, 15)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ButtonRC(sender, "R1", 15, 16)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ButtonRC(sender, "R1", 16, 17)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ButtonRC(sender, "R1", 17, 18)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        ButtonRC(sender, "R1", 18, 19)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        ButtonRC(sender, "R1", 19, 20)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        ButtonRC(sender, "R2", 9, 10)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        ButtonRC(sender, "R2", 10, 11)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        ButtonRC(sender, "R2", 11, 12)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        ButtonRC(sender, "R2", 12, 13)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        ButtonRC(sender, "R2", 13, 14)

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        ButtonRC(sender, "R2", 14, 15)

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        ButtonRC(sender, "R2", 15, 16)
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        ButtonRC(sender, "R2", 16, 17)
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        ButtonRC(sender, "R2", 17, 18)
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        ButtonRC(sender, "R2", 18, 19)

    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        ButtonRC(sender, "R2", 19, 20)
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        ButtonRC(sender, "R3", 9, 10)
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        ButtonRC(sender, "R3", 10, 11)

    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        ButtonRC(sender, "R3", 11, 12)

    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        ButtonRC(sender, "R3", 12, 13)

    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        ButtonRC(sender, "R3", 13, 14)

    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        ButtonRC(sender, "R3", 14, 15)

    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        ButtonRC(sender, "R3", 15, 16)

    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        ButtonRC(sender, "R3", 16, 17)

    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        ButtonRC(sender, "R3", 17, 18)

    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        ButtonRC(sender, "R3", 18, 19)

    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        ButtonRC(sender, "R3", 19, 20)

    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        ButtonRC(sender, "R4", 9, 10)
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        ButtonRC(sender, "R4", 10, 11)

    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        ButtonRC(sender, "R4", 11, 12)

    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        ButtonRC(sender, "R4", 12, 13)

    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        ButtonRC(sender, "R4", 13, 14)

    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        ButtonRC(sender, "R4", 14, 15)

    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        ButtonRC(sender, "R4", 15, 16)

    End Sub

    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        ButtonRC(sender, "R4", 16, 17)

    End Sub

    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Button42.Click
        ButtonRC(sender, "R4", 17, 18)

    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        ButtonRC(sender, "R4", 18, 19)

    End Sub

    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        ButtonRC(sender, "R4", 19, 20)

    End Sub

    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        ButtonRC(sender, "R5", 9, 10)
    End Sub

    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        ButtonRC(sender, "R5", 10, 11)

    End Sub

    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        ButtonRC(sender, "R5", 11, 12)

    End Sub

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        ButtonRC(sender, "R5", 12, 13)

    End Sub

    Private Sub Button49_Click(sender As Object, e As EventArgs) Handles Button49.Click
        ButtonRC(sender, "R5", 13, 14)
    End Sub

    Private Sub Button50_Click(sender As Object, e As EventArgs) Handles Button50.Click
        ButtonRC(sender, "R5", 14, 15)
    End Sub

    Private Sub Button51_Click(sender As Object, e As EventArgs) Handles Button51.Click
        ButtonRC(sender, "R5", 15, 16)
    End Sub

    Private Sub Button52_Click(sender As Object, e As EventArgs) Handles Button52.Click
        ButtonRC(sender, "R5", 16, 17)
    End Sub

    Private Sub Button53_Click(sender As Object, e As EventArgs) Handles Button53.Click
        ButtonRC(sender, "R5", 17, 18)
    End Sub

    Private Sub Button54_Click(sender As Object, e As EventArgs) Handles Button54.Click
        ButtonRC(sender, "R5", 18, 19)
    End Sub

    Private Sub Button55_Click(sender As Object, e As EventArgs) Handles Button55.Click
        ButtonRC(sender, "R5", 19, 20)
    End Sub
End Class