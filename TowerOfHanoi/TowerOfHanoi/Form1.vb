Option Strict On

Public Class Form1

    Dim stepNo As Integer

    Private Sub btnCompute_Click(sender As System.Object, e As System.EventArgs) Handles btnCompute.Click
        Dim N As Integer

        ' Check for valid input
        If Not IsNumeric(txtNumDisks.Text) Then
            MessageBox.Show("Please type a number.", "Error")
            Return
        End If

        N = CInt(txtNumDisks.Text)

        If (N < 1) Or (N > 12) Then
            MessageBox.Show("Please type a positive number between 1 and 12.", "Error")
            Return
        End If

        stepNo = 0
        lstInstructions.Items.Clear()

        ' Write your code below
        lstInstructions.Items.Add("Not implemented yet.")

        Dim LastOnTower1 As Integer
        Dim LastOnTower2 As Integer
        Dim LastOnTower3 As Integer
        Dim Complete As Boolean
        Dim Tower1() As Integer
        Dim Tower2() As Integer
        Dim Tower3() As Integer
        Dim i As Integer = 0
        Dim HowMany As Integer
        HowMany = CInt(txtNumDisks.Text)
        ReDim Tower1(HowMany - 1)
        'initialize the tower with an array
        While i < HowMany
            Tower1(i) = (i + 1)
        End While




    End Sub

End Class
