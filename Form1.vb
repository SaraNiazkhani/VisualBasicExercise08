Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub RunButton_Click(sender As Object, e As EventArgs) Handles RunButton.Click

        ' دریافت عدد n از ورودی کاربر
        Dim n As Integer = CInt(NumberTextBox.Text)

        ' محاسبه فاکتوریل n
        Dim factorial As Long = 1
        For i As Integer = 1 To n
            factorial *= i
        Next

        ' نمایش نتیجه
        OutputLabel.Text = ("factorial " & n & " = " & factorial)
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        End
    End Sub
End Class
