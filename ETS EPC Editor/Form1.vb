Imports System.IO
Imports Newtonsoft.Json

Public Class Form1
    Private Sub ImportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName IsNot "" Then
            Dim a As New FileInfo(OpenFileDialog1.FileName)
            Dim b = JsonConvert.DeserializeObject(Of List(Of Programinfo))(a.OpenText.ReadToEnd)
            DataGridView1.Rows.Clear()
            For Each info As Programinfo In b
                DataGridView1.Rows.Add(info.ProgramName, info.ProgramDisplayName, info.ProgramExecutable, info.ProgramUrl)
                My.Application.DoEvents()
            Next
        End If

    End Sub

    Private Sub ExportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToolStripMenuItem.Click
        Dim data As New List(Of Programinfo)
        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim da As New Programinfo
            da.ProgramName = row.Cells.Item(0).Value
            da.ProgramDisplayName = row.Cells.Item(1).Value
            da.ProgramExecutable = row.Cells.Item(2).Value
            da.ProgramUrl = row.Cells.Item(3).Value
            If ((da.ProgramName IsNot Nothing) And (da.ProgramDisplayName IsNot Nothing) And (da.ProgramExecutable IsNot Nothing) And (da.ProgramUrl IsNot Nothing)) Then
                data.Add(da)
            End If
            My.Application.DoEvents()
        Next
        SaveFileDialog1.ShowDialog()
        If SaveFileDialog1.FileName IsNot "" Then
            File.WriteAllText(SaveFileDialog1.FileName, JsonConvert.SerializeObject(data))
        End If
    End Sub
End Class
