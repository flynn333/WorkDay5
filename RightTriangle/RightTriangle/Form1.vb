Option Strict On
Public Class Form1


    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click

        Dim Number1 As Double
        Dim number2 As Double

        If String.IsNullOrWhiteSpace(txtSideOne.Text) = False And String.IsNullOrWhiteSpace(txtSideTwo.Text) = False And IsNumeric(txtSideOne.Text) And IsNumeric(txtSideTwo.Text) Then
            Number1 = CDbl(txtSideOne.Text)
            number2 = CDbl(txtSideTwo.Text)
            txtHyp.Text = CStr(Hypot(Number1, number2))
        Else
            MessageBox.Show("please put numbers in")

        End If

    End Sub
    Function Hypot(ByVal A As Double, B As Double) As Double
        Dim C As Double
        C = Math.Sqrt((B * B) + (A * A))
        Return C

    End Function
End Class
