Public Class Form1
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim Result As String
        If DocTypeHtml.Checked = True Then
            Result = "<!DOCTYPE html>" & vbNewLine & "<html>" & vbNewLine & "<head>" & vbNewLine & "<title>" & txtTitle.Text & "</title>" & vbNewLine & "</head>" & vbNewLine & "<body>" & vbNewLine & rtbStdIn.Text & vbNewLine & "</body>" & vbNewLine & "</html>"
        Else
            Result = "<html>" & vbNewLine & "<head>" & vbNewLine & "<title>" & txtTitle.Text & "</title>" & vbNewLine & "</head>" & vbNewLine & "<body>" & vbNewLine & rtbStdIn.Text & vbNewLine & "</body>" & vbNewLine & "</html>"
        End If
        rtbStdOut.Text = Result
    End Sub
    Private Sub Bold_Click(sender As Object, e As EventArgs) Handles Bold.Click
        rtbStdIn.Text = rtbStdIn.Text + "<b>Input text here. This will be bold</b>"
    End Sub
    Private Sub Italic_Click(sender As Object, e As EventArgs) Handles Italic.Click
        rtbStdIn.Text = rtbStdIn.Text + "<i>Input text here. This will be italic</i>"
    End Sub
End Class