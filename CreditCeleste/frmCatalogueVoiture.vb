Imports CsClient
Imports System.Data.SqlClient

Public Class frmCatalogueVoiture

    Private Sub frmCatalogueVoiture_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim connectionString As String = "Server=DESKTOP-R0IJ4CS\SQLEXPRESS; Initial Catalog=CreditCeleste;Trusted_Connection=Yes"

        '=> pas de connexion ici, appelle de la collection dans accueil

        Dim con As New SqlConnection(connectionString)
        Dim dr As SqlDataReader

        Dim myCommand = New SqlCommand("Select * from vehicule", con)

        con.Open()
        dr = myCommand.ExecuteReader()


        While dr.Read()
            cmbMarque.Items.Add(dr("marque").ToString())
            cmbMarque.Items.Add(dr("modele").ToString())
            cmbMarque.Items.Add(dr("puissance").ToString())
            cmbMarque.Items.Add(dr("etat").ToString())
            cmbMarque.Items.Add(dr("tarif").ToString())
            dr.NextResult()
        End While

        con.Close()
    End Sub


    Private Sub btnValider_Click(sender As System.Object, e As System.EventArgs) Handles btnValider.Click

    End Sub

    Private Sub btnAnnuler_Click(sender As System.Object, e As System.EventArgs) Handles btnAnnuler.Click

    End Sub
End Class