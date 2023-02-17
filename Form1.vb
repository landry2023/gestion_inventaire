Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.SqlServerCe.SqlCeConnection

Public Class Form1

    Private Sub Label4_ParentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.ParentChanged

    End Sub
    Private Sub Label3_ParentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Label2_ParentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.ParentChanged

    End Sub

    Private Sub BtnValider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnValider.Click
        Dim connection As New SqlConnection("Data source = SQLEXPRESS; user id = Landry; Password=bonjour; Database = MyDatabase#1.sdf")
        Dim command As New SqlCommand("SELECT * FROM personne WHERE NomPersonne = @NomPersonne AND PrenomPersonne = @PrenomPersonne AND MotDePasse = @MotDePasse", connection)
        command.Parameters.Add("@NomPersonne", Data.SqlDbType.NVarChar).Value = TxbNom.Text
        command.Parameters.Add("@PrenomPersonne", Data.SqlDbType.NVarChar).Value = TbxPrenom.Text
        command.Parameters.Add("@MotDePasse", Data.SqlDbType.NVarChar).Value = TbxMotDePasse.Text
        'Dim result As String
        'connection.Open()
        'result = command.ExecuteScalar

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MessageBox.Show("Nom ou Prénom ou Mot de Passe invalide")
        Else
            Me.Hide()
            ListeMenu.Show()
        End If
        'If result <> "" Then
        'Me.Hide()
        'ListeMenu.Show()
        'Else
        'MessageBox.Show("Nom ou Prénom ou Mot de Passe invalide")
        'End If
    End Sub

    Private Sub BtnAnnuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnnuler.Click
        TxbNom.Text = ""
        TbxPrenom.Text = ""
        TbxMotDePasse.Text = ""
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
