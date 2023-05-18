Public Class Form1

    Dim num1 As Double
    Dim num2 As Double
    Dim op As String
    Dim result As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text & "1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text & "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text & "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text & "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = TextBox1.Text & "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text & "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text & "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text & "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text & "9"
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        TextBox1.Text = TextBox1.Text & "0"
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles btn_arti.Click
        If IsNumeric(TextBox1.Text) Then
            num1 = CDbl(TextBox1.Text)
            op = "+"
            TextBox1.Clear()
        End If
    End Sub

    Private Sub ButtonSubtract_Click(sender As Object, e As EventArgs) Handles btn_eksi.Click
        If IsNumeric(TextBox1.Text) Then
            num1 = CDbl(TextBox1.Text)
            op = "-"
            TextBox1.Clear()
        End If
    End Sub

    Private Sub ButtonMultiply_Click(sender As Object, e As EventArgs) Handles btn_carpi.Click
        If IsNumeric(TextBox1.Text) Then
            num1 = CDbl(TextBox1.Text)
            op = "*"
            TextBox1.Clear()
        End If
    End Sub

    Private Sub ButtonDivide_Click(sender As Object, e As EventArgs) Handles btn_bolum.Click
        If IsNumeric(TextBox1.Text) Then
            num1 = CDbl(TextBox1.Text)
            op = "/"
            TextBox1.Clear()
        End If
    End Sub

    Private Sub ButtonEquals_Click(sender As Object, e As EventArgs) Handles btn_hesapla.Click
        If IsNumeric(TextBox1.Text) Then
            num2 = CDbl(TextBox1.Text)
            If op = "+" Then
                result = num1 + num2
            ElseIf op = "-" Then
                result = num1 - num2
            ElseIf op = "*" Then
                result = num1 * num2
            ElseIf op = "/" Then
                result = num1 / num2
            End If
            TextBox1.Text = result.ToString()
        End If
    End Sub

    Private Sub Temizle(sender As Object, e As EventArgs) Handles btn_temizle.Click

        TextBox1.Clear()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
