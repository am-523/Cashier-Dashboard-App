Public Class Form1
    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        Application.ExitThread()
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2MouseStateHandler1.Add(Guna2Panel2)
    End Sub



    Private Sub Guna2MouseStateHandler1_HoverState(sender As Object, e As EventArgs) Handles Guna2MouseStateHandler1.HoverState

        Guna2Panel2.FillColor = Color.FromArgb(255, 218, 109)
    End Sub

    Private Sub Guna2MouseStateHandler1_PressedState(sender As Object, e As EventArgs) Handles Guna2MouseStateHandler1.PressedState
        Guna2Panel2.FillColor = Color.FromArgb(255, 35, 81)
    End Sub

    Private Sub Guna2MouseStateHandler1_IdleState(sender As Object, e As EventArgs) Handles Guna2MouseStateHandler1.IdleState
        Guna2Panel2.FillColor = Color.White
    End Sub
End Class
