Imports System.Data.SqlClient

Public Class FRM_Collabo

    Dim maConnexion As New SqlConnection("Data Source=DESKTOP-TA82I0L;Initial Catalog=Active_Final_Commun;Integrated Security=True")
    Dim Cmd As New SqlCommand()
    Dim da As New SqlDataAdapter
    Public ds As New DataSet

    Private Sub ComboBox1_SelectedIndexChange(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged


        Cmd.Connection = maConnexion
        Cmd.CommandType = CommandType.Text
        Cmd.CommandText = "select  NOM_COLLABORATEUR +' '+ PRENOM_COLLABORATEUR from COLLABORATEUR"
        Me.Show()

        Try
            Dim Afficher
            maConnexion.Open()
            Cmd.ExecuteScalar()
            maConnexion.Close()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub FRM_Collabo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'Active_Final_CommunDataSet.COLLABORATEUR'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.COLLABORATEURTableAdapter.Fill(Me.Active_Final_CommunDataSet.COLLABORATEUR)

    End Sub
End Class