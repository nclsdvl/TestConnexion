Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing
Imports System.Security.Cryptography
Imports System.Text

Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim maConnexion As New SqlConnection("Data Source=DESKTOP-TA82I0L;Initial Catalog=Active_Final_Commun;Integrated Security=True")

        Dim maRequete1 As New SqlCommand()
        maRequete1.Connection = maConnexion
        maRequete1.CommandType = CommandType.StoredProcedure
        maRequete1.CommandText = "rapat_VB_login"

        Dim valeurAjouter As SqlParameter = maRequete1.Parameters.Add("@return", SqlDbType.VarChar)
        valeurAjouter.Direction = ParameterDirection.ReturnValue
        Dim listVal As SqlDataReader


        maConnexion.Open()
        listVal = maRequete1.ExecuteReader()
        If (listVal.HasRows) Then

            While (listVal.Read())

                Dim maConnexion3 As New SqlConnection("Data Source=DESKTOP-TA82I0L;Initial Catalog=Active_Final_Commun;Integrated Security=True")
                maConnexion3.Open()
                listVal.GetString(0)
                Dim md5 As New MD5CryptoServiceProvider()
                Dim result As Byte() = md5.ComputeHash(Encoding.GetEncoding(1252).GetBytes(listVal.GetString(0)))

                Dim maRequete2 As New SqlCommand()
                maRequete2.Connection = maConnexion3
                maRequete2.CommandType = CommandType.Text

                Dim paramMdp As SqlParameter = maRequete2.Parameters.Add("@mdp", SqlDbType.VarBinary)
                paramMdp.SqlValue = result
                maRequete2.CommandText = "UPDATE UTILISATEURS Set MDP= @mdp where LOGIN = " & listVal.GetString(0)

                maRequete2.ExecuteNonQuery()
                maConnexion3.Close()
            End While
        Else

            Console.WriteLine("No rows found.")

            listVal.Close()

        End If

        For Each Line As String In listVal

        Next

    End Sub

    Private Sub Label(listVal As SqlDataReader)
        Throw New NotImplementedException()
    End Sub
End Class