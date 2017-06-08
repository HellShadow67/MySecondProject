Imports CsClient
Imports System.Data.SqlClient


Public Class frmAccueil

    Private Sub frmAccueil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        Dim connectionString As String = "Server=DESKTOP-R0IJ4CS\SQLEXPRESS; Initial Catalog=CreditCeleste;Trusted_Connection=Yes"

        Dim con As New SqlConnection(connectionString)
        Dim dr As SqlDataReader

        Dim myCommand = New SqlCommand("Select * from Vendeur", con)

        con.Open()
        dr = myCommand.ExecuteReader()

        Dim nomVendeur = ""
        Dim PrenomVendeur = ""

        While dr.Read()
            nomVendeur = dr("NomVendeur").ToString()
            PrenomVendeur = dr("PrenomVendeur").ToString()
            cboVendeur.Items.Add(nomVendeur + " " + PrenomVendeur)
            '' dr.NextResult()
        End While

        con.Close()

        Dim unVendeur As New Vendeur





    End Sub

    Private Sub cmdIntroduction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIntroduction.Click

        fenIntro = New frmIntro
        fenIntro.Show()
        Me.Hide()

    End Sub

    Private Sub btnEtude_Click(sender As System.Object, e As System.EventArgs) Handles btnEtude.Click

        fenEtude = New Stat
        fenEtude.Show()
        Me.Hide()
    End Sub

    Private Sub cboVendeur_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboVendeur.SelectedIndexChanged

        btnEtude.Enabled = True
        cmdIntroduction.Enabled = True


        Dim words As String() = cboVendeur.SelectedItem.ToString().Split(" ")
        Dim nom As String = words(0)
        Dim prenom As String = words(1)

        unVendeur.setVendeur(0, nom, prenom)

    End Sub
End Class
