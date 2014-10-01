Option Strict On

Public Class Form1

    Private Sub btnDetermine_Click(sender As System.Object, e As System.EventArgs) Handles btnDetermine.Click
        Dim name As String
        name = txtFullName.Text
        txtFirstName.Text = FirstName(name)
    End Sub

    Function FirstName(ByVal name As String) As String
        Dim ind1 As Integer
        ind1 = name.IndexOf(" ")

        Dim fstname As String
        fstname = name.Substring(0, ind1)

        Return fstname
    End Function

End Class
