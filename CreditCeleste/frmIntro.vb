Imports System.Data.SqlClient



Public Class frmIntro

    Dim connectionString As String = "Server=DESKTOP-R0IJ4CS\SQLEXPRESS; Initial Catalog=CreditCeleste;Trusted_Connection=Yes"
    Dim con As New SqlConnection(connectionString)
    Dim dr As SqlDataReader





    Private Sub cmdEnregistrer_Click(sender As System.Object, e As System.EventArgs) Handles cmdEnregistrer.Click

        cmdCredit.Enabled = True
        cmdVendreVoit.Enabled = True
        cmdAcheterVoiture.Enabled = True


        Dim nom = txtbxNom.Text
        Dim prenom = txtbxPrenom.Text

        unClient.setClientNomPrenom(nom, prenom)
        unClient.setIdClient("oui")

        con.Open()

        Dim myCommand = New SqlCommand("insert into client(Nom,Prenom,numRue,rue,cp,ville) values('" + txtbxNom.Text + "','" + txtbxPrenom.Text + "'," + txtNumRue.Text + ",'" + cmbRue.Text + " " + txtRue.Text + "','" + txtCp.Text + "','" + txtVille.Text + "')", con)
        dr = myCommand.ExecuteReader()

        con.Close()


        MessageBox.Show("La sauvegarde a bien été effectuée!")

    End Sub


    Private Sub cmdVoiture_Click(sender As System.Object, e As System.EventArgs) Handles cmdAcheterVoiture.Click

        fenCatalogueVoiture = New frmCatalogueVoiture
        fenCatalogueVoiture.Show()
        Me.Hide()

    End Sub

    Private Sub cmdCredit_Click(sender As System.Object, e As System.EventArgs) Handles cmdCredit.Click
        fenCredit = New FrmCredit
        fenCredit.Show()
        Me.Hide()
    End Sub


    Private Sub btnAccueil_Click(sender As System.Object, e As System.EventArgs) Handles btnAccueil.Click
        unPageAccueil = New frmAccueil
        unPageAccueil.Show()
        Me.Hide()
    End Sub



    Private Sub frmIntro_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim unClient As New Client

    End Sub

    Private Sub cmdVendreVoit_Click(sender As System.Object, e As System.EventArgs) Handles cmdVendreVoit.Click
        fenvoiture = New FrmVoiture
        fenvoiture.Show()
        Me.Hide()
    End Sub
End Class