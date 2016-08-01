Public Class Form1

    'Plan A:覆写过程，拦截消息
    Protected Overrides Sub WndProc(ByRef Message As Message)
        If Message.Msg = 6 Then
            'WParam=2 时表示窗体被激活
            If Message.WParam = 0 Then Me.WindowState = FormWindowState.Minimized
        End If
        MyBase.WndProc(Message)
    End Sub

    'Plan B:使用Deactivate事件
    Private Sub Form1_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
