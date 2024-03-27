<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        ImportToolStripMenuItem = New ToolStripMenuItem()
        ExportToolStripMenuItem = New ToolStripMenuItem()
        DataGridView1 = New DataGridView()
        ProgramName = New DataGridViewTextBoxColumn()
        Program_DisplayName = New DataGridViewTextBoxColumn()
        Program_Executable = New DataGridViewTextBoxColumn()
        Program_Url = New DataGridViewTextBoxColumn()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        MenuStrip1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ImportToolStripMenuItem, ExportToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' ImportToolStripMenuItem
        ' 
        ImportToolStripMenuItem.Name = "ImportToolStripMenuItem"
        ImportToolStripMenuItem.Size = New Size(180, 22)
        ImportToolStripMenuItem.Text = "Import"
        ' 
        ' ExportToolStripMenuItem
        ' 
        ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        ExportToolStripMenuItem.Size = New Size(180, 22)
        ExportToolStripMenuItem.Text = "Export"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ProgramName, Program_DisplayName, Program_Executable, Program_Url})
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(0, 24)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(800, 426)
        DataGridView1.TabIndex = 1
        ' 
        ' ProgramName
        ' 
        ProgramName.HeaderText = "Name"
        ProgramName.Name = "ProgramName"
        ' 
        ' Program_DisplayName
        ' 
        Program_DisplayName.HeaderText = "DisplayName"
        Program_DisplayName.Name = "Program_DisplayName"
        ' 
        ' Program_Executable
        ' 
        Program_Executable.HeaderText = "Executable"
        Program_Executable.Name = "Program_Executable"
        ' 
        ' Program_Url
        ' 
        Program_Url.HeaderText = "Url"
        Program_Url.Name = "Program_Url"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ProgramName As DataGridViewTextBoxColumn
    Friend WithEvents Program_DisplayName As DataGridViewTextBoxColumn
    Friend WithEvents Program_Executable As DataGridViewTextBoxColumn
    Friend WithEvents Program_Url As DataGridViewTextBoxColumn
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog

End Class
