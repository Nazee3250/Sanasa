<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomePage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ScanDocumentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MailManagmentSystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonalProductivityManagmentSystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdvertismentManagmentSystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayrollManagmentSystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HumanResourceManagmentSystemToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalaryManagmentSystemToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(210, 118)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(927, 473)
        Me.Panel1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ScanDocumentToolStripMenuItem, Me.MailManagmentSystemToolStripMenuItem, Me.PersonalProductivityManagmentSystemToolStripMenuItem, Me.AdvertismentManagmentSystemToolStripMenuItem, Me.PayrollManagmentSystemToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1366, 30)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ScanDocumentToolStripMenuItem
        '
        Me.ScanDocumentToolStripMenuItem.Name = "ScanDocumentToolStripMenuItem"
        Me.ScanDocumentToolStripMenuItem.Size = New System.Drawing.Size(271, 26)
        Me.ScanDocumentToolStripMenuItem.Text = "Document Managment System"
        '
        'MailManagmentSystemToolStripMenuItem
        '
        Me.MailManagmentSystemToolStripMenuItem.Name = "MailManagmentSystemToolStripMenuItem"
        Me.MailManagmentSystemToolStripMenuItem.Size = New System.Drawing.Size(226, 26)
        Me.MailManagmentSystemToolStripMenuItem.Text = "Mail Managment System"
        '
        'PersonalProductivityManagmentSystemToolStripMenuItem
        '
        Me.PersonalProductivityManagmentSystemToolStripMenuItem.Name = "PersonalProductivityManagmentSystemToolStripMenuItem"
        Me.PersonalProductivityManagmentSystemToolStripMenuItem.Size = New System.Drawing.Size(364, 26)
        Me.PersonalProductivityManagmentSystemToolStripMenuItem.Text = "Personal Productivity Managment System"
        '
        'AdvertismentManagmentSystemToolStripMenuItem
        '
        Me.AdvertismentManagmentSystemToolStripMenuItem.Name = "AdvertismentManagmentSystemToolStripMenuItem"
        Me.AdvertismentManagmentSystemToolStripMenuItem.Size = New System.Drawing.Size(296, 26)
        Me.AdvertismentManagmentSystemToolStripMenuItem.Text = "Advertisment Managment System"
        '
        'PayrollManagmentSystemToolStripMenuItem
        '
        Me.PayrollManagmentSystemToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HumanResourceManagmentSystemToolStripMenuItem1, Me.SalaryManagmentSystemToolStripMenuItem1, Me.LeaveToolStripMenuItem})
        Me.PayrollManagmentSystemToolStripMenuItem.Name = "PayrollManagmentSystemToolStripMenuItem"
        Me.PayrollManagmentSystemToolStripMenuItem.Size = New System.Drawing.Size(247, 26)
        Me.PayrollManagmentSystemToolStripMenuItem.Text = "Payroll Managment System"
        '
        'HumanResourceManagmentSystemToolStripMenuItem1
        '
        Me.HumanResourceManagmentSystemToolStripMenuItem1.Name = "HumanResourceManagmentSystemToolStripMenuItem1"
        Me.HumanResourceManagmentSystemToolStripMenuItem1.Size = New System.Drawing.Size(387, 26)
        Me.HumanResourceManagmentSystemToolStripMenuItem1.Text = "Human Resource Managment System"
        '
        'SalaryManagmentSystemToolStripMenuItem1
        '
        Me.SalaryManagmentSystemToolStripMenuItem1.Name = "SalaryManagmentSystemToolStripMenuItem1"
        Me.SalaryManagmentSystemToolStripMenuItem1.Size = New System.Drawing.Size(387, 26)
        Me.SalaryManagmentSystemToolStripMenuItem1.Text = "Salary Managment System"
        '
        'LeaveToolStripMenuItem
        '
        Me.LeaveToolStripMenuItem.Name = "LeaveToolStripMenuItem"
        Me.LeaveToolStripMenuItem.Size = New System.Drawing.Size(387, 26)
        Me.LeaveToolStripMenuItem.Text = "Leave"
        '
        'HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1366, 706)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "HomePage"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HomePage"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MailManagmentSystemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PersonalProductivityManagmentSystemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdvertismentManagmentSystemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PayrollManagmentSystemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HumanResourceManagmentSystemToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SalaryManagmentSystemToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LeaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScanDocumentToolStripMenuItem As ToolStripMenuItem
End Class
