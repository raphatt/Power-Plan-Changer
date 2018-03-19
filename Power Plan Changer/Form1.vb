Public Class Form1
    Private Sub RadioButton1_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim startinfo As New ProcessStartInfo("cmd", "/c powercfg /s 381b4222-f694-41f0-9685-ff5bb260df2e")
        startinfo.WindowStyle = ProcessWindowStyle.Hidden
        Process.Start(startinfo)
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim startinfo As New ProcessStartInfo("cmd", "/c powercfg /s 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c")
        startinfo.WindowStyle = ProcessWindowStyle.Hidden
        Process.Start(startinfo)
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim startinfo As New ProcessStartInfo("cmd", "/c powercfg /s a1841308-3541-4fab-bc81-f71556f20b4a")
        startinfo.WindowStyle = ProcessWindowStyle.Hidden
        Process.Start(startinfo)
        Close()
    End Sub
End Class
