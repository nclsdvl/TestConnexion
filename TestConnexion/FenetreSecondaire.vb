Public Class FRM_Secondaire

    Public maVariable As String
    Public profil As Integer


    Private Sub Label1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = "Bienvenue " + maVariable
    End Sub

    Private Sub Button1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If profil = 3 Then
            Button1.Visible = False

        Else Button1.Visible = True
        End If
    End Sub

    Private Sub BTN_Collabo_Click(sender As Object, e As EventArgs) Handles BTN_Collabo.Click
        FRM_Collabo.Show()
    End Sub

    Private Sub BTN_Client_Click(sender As Object, e As EventArgs) Handles BTN_Client.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
    End Sub
End Class