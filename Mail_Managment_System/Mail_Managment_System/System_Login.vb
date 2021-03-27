Imports MySql.Data.MySqlClient
Public Class System_Login
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=root;database=Payroll")
    Dim cmd As New MySqlCommand
    Dim i As Integer


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        connection.Open()
        lblConnection.Text = "Database Connection Successful"
        connection.Close()
        lblConnection.Text = "Database Connection Fail"

        '    ElseIf
        '    connection.Close() Then
        '        lblConnection.Text = "Database Connection Fail"
        '    End If
        Me.Close()
        HomePage.MenuStrip1.Show()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        HomePage.Close()
    End Sub

    Private Sub System_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
