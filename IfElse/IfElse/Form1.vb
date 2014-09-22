Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click

        ' Modify the program such that it does not crash 
        ' if the user types incorrect input

        If Not (IsNumeric(txtFirstNum.Text) And IsNumeric(txtSecondNum.Text)) Then
            MessageBox.Show("Positive Numbers Only")
            Return
        End If

        Dim num1 As Double = CDbl(txtFirstNum.Text)
        Dim num2 As Double = CDbl(txtSecondNum.Text)

        If Not (num1 >= 0 And num2 >= 0) Then
            MessageBox.Show("Positive Numbers Only")
            Return
        End If

        If num1 > num2 Then
            txtResult.Text = "The larger number is " & num1
        ElseIf num1 < num2 Then
            txtResult.Text = "The larger number is " & num2
        Else
            txtResult.Text = "They are equal"
        End If

    End Sub

End Class
