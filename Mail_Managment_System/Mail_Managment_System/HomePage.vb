Imports MySql.Data.MySqlClient

Public Class HomePage
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=root;database=Payroll")
    Dim cmd As New MySqlCommand
    Dim i As Integer


    Sub switchPanel(ByVal Panel As Form)
        Panel1.Controls.Clear()
        Panel.TopLevel = False
        Panel1.Controls.Add(Panel)
        Panel.Show()
    End Sub
    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        switchPanel(System_Login)
        MenuStrip1.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub ScanDocumentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScanDocumentToolStripMenuItem.Click

    End Sub

End Class