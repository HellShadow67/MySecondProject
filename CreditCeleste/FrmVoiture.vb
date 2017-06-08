Imports System.Data.SqlClient

Public Class FrmVoiture

    Dim connectionString As String = "Server=DESKTOP-R0IJ4CS\SQLEXPRESS; Initial Catalog=CreditCeleste;Trusted_Connection=Yes"
    Dim con As New SqlConnection(connectionString)
    Dim dr As SqlDataReader


    Private Sub FrmVoiture_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Label1.Text = "Client: " + unClient.getNomPrenom()

        Label3.Text = "Vendeur: " + unVendeur.getNomPrenom()
    End Sub



    Private Sub BtnEnr_Click(sender As System.Object, e As System.EventArgs) Handles BtnEnr.Click

        con.Open()

        Dim myCommand = New SqlCommand("insert into vehicule(marque, modele, puissance, etat, tarif) values('" + txtMarque.Text + "','" + txtModele.Text + "'," + txtPuissance.Text + ",'" + txtEtat.Text + "'," + txtPrixReprise.Text + ")", con)


        dr = myCommand.ExecuteReader()
        dr.Close()

        con.Close()

        MessageBox.Show("Enregistrement effectué!")

    End Sub



    Private Sub BtnCred_Click(sender As System.Object, e As System.EventArgs) Handles BtnCred.Click
        fenCredit = New FrmCredit
        fenCredit.Show()
        Me.Hide()
    End Sub

    Private Sub GrpBxNouvVeh_Enter(sender As System.Object, e As System.EventArgs) Handles GrpBxNouvVeh.Enter

    End Sub

    Private Sub btnAccueil_Click(sender As System.Object, e As System.EventArgs) Handles btnAccueil.Click
        unPageAccueil = New frmAccueil
        unPageAccueil.Show()
        Me.Hide()
    End Sub

    Private Sub cmdAcheterVoiture_Click(sender As System.Object, e As System.EventArgs) Handles cmdAcheterVoiture.Click
        fenCatalogueVoiture = New frmCatalogueVoiture
        fenCatalogueVoiture.Show()
        Me.Hide()
    End Sub

 

End Class