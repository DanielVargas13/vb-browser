Public Class Browser

    Dim browsing As Boolean = False

    Private Sub BackBt_Click(sender As Object, e As EventArgs) Handles BackBt.Click
        WebBrowser.GoBack()
    End Sub

    Private Sub ForwordBt_Click(sender As Object, e As EventArgs) Handles ForwordBt.Click
        WebBrowser.GoForward()
    End Sub

    Private Sub HomeBt_Click(sender As Object, e As EventArgs) Handles HomeBt.Click
        WebBrowser.GoHome()
    End Sub

    Private Sub GoBt_Click(sender As Object, e As EventArgs) Handles GoBt.Click
        WebBrowser.Navigate(SearchTb.Text)
    End Sub

    Private Sub WebBrowser_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles WebBrowser.Navigating
        browsing = True
    End Sub

    Private Sub WebBrowser_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser.DocumentCompleted
        browsing = False
    End Sub

    Private Sub RefreshBt_Click(sender As Object, e As EventArgs)
        If browsing = False Then
            WebBrowser.Refresh()
        Else
            WebBrowser.Stop()
        End If
    End Sub
End Class
