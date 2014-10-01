Option Strict On

Public Class Form1

    Private Sub btnDetermine_Click(sender As System.Object, e As System.EventArgs) Handles btnDetermine.Click
        Dim name As String
        name = txtFullName.Text.Trim
        txtFirstName.Text = FirstName(name)
        MessageBox.Show("RYAN IS SHREEPY")
        MessageBox.Show("JENNY IS SHREEPY")
    End Sub

    Function FirstName(ByVal name As String) As String
        Dim space As Integer
        Dim first As String
        space = name.IndexOf(" ")

        first = name.Substring(0, space)
        Return first
    End Function

End Class
