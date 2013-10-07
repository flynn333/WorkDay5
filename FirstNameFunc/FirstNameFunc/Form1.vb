Option Strict On

Public Class Form1

    Private Sub btnDetermine_Click(sender As System.Object, e As System.EventArgs) Handles btnDetermine.Click
        Dim name As String
        name = txtFullName.Text
        txtFirstName.Text = FirstName(name)
    End Sub

    Function FirstName(ByVal name As String) As String

        name = name.Trim
        Dim FName() As String = Split(name)
        Dim NameReturn = FName(0)
        Return NameReturn

    End Function

End Class
