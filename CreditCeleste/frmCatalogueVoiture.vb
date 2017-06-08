Imports CsClient
Imports System.Data.SqlClient

Public Class frmCatalogueVoiture

    Dim connectionString As String = "Server=DESKTOP-R0IJ4CS\SQLEXPRESS; Initial Catalog=CreditCeleste;Trusted_Connection=Yes"
    Dim con As New SqlConnection(connectionString)
    Dim dr As SqlDataReader





    Private Sub frmCatalogueVoiture_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim myCommand = New SqlCommand("Select distinct  marque from vehicule", con)
        con.Open()
        dr = myCommand.ExecuteReader()


        While dr.Read()
            cmbMarque.Items.Add(dr("marque").ToString())
        End While

        con.Close()
    End Sub


    Private Sub btnValider_Click(sender As System.Object, e As System.EventArgs) Handles btnValider.Click
        Dim myCommand = New SqlCommand("Select idVehicule, tarif  from vehicule where marque='" + cmbMarque.Text + "' and modele='" + cmbModele.Text + "';", con)
        con.Open()
        dr = myCommand.ExecuteReader()
        Dim idVeh = 0
        Dim idClient = 0
        Dim montantAchat = 0

        While dr.Read()
            idVeh = (dr("idVehicule").ToString())
            montantAchat = (dr("tarif").ToString())
        End While
        dr.Close()

        Dim myCommand4 = New SqlCommand("SELECT idClient FROM client where Nom='" + unClient.getNom() + "' and Prenom='" + unClient.getPrenom() + "';", con)
        dr = myCommand4.ExecuteReader()
        While dr.Read()
            idClient = CInt(dr("idClient"))
        End While
        dr.Close()

        Dim idVendeur = 0
        Dim myCommand5 = New SqlCommand("SELECT IdentifiantVendeur FROM vendeur where NomVendeur='" + unVendeur.getNom() + "' and PrenomVendeur='" + unVendeur.getPrenom() + "';", con)
        dr = myCommand5.ExecuteReader()
        While dr.Read()
            idVendeur = CInt(dr("IdentifiantVendeur"))
        End While
        dr.Close()

        Dim myCommand2 = New SqlCommand(" Update client set idNouveauVeh = " + idVeh.ToString() + " WHERE idClient =" + idClient.ToString() + ";", con)
        'MessageBox.Show(" Update client set idPret = " + idPret.ToString() + " WHERE idClient =" + idClient.ToString() + ";")
        dr = myCommand2.ExecuteReader()
        dr.Close()

        Dim myCommand3 = New SqlCommand("UPDATE vente SET nbrVente = nbrVente + 1,cummulComm = cummulComm+(montant*commission/100), montant=montant + " + montantAchat.ToString() + "  WHERE idhist=3 and idVendeur=" + idVendeur.ToString() + ";", con)
        dr = myCommand3.ExecuteReader()
        dr.Close()

        con.Close()

        MessageBox.Show("Enregistrement effectué!")

    End Sub

    Private Sub btnAnnuler_Click(sender As System.Object, e As System.EventArgs) Handles btnVendre.Click
        fenvoiture = New FrmVoiture
        fenvoiture.Show()
        Me.Hide()
    End Sub

    Private Sub cmbMarque_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbMarque.SelectedIndexChanged
        Dim myCommand = New SqlCommand("Select modele from vehicule where marque='" + cmbMarque.Text + "';", con)
        'MessageBox.Show("Select modele from vehicule where marque=" + cmbMarque.Text + ";")
        con.Open()
        dr = myCommand.ExecuteReader()


        While dr.Read()
            cmbModele.Items.Add(dr("modele").ToString())
        End While

        con.Close()
    End Sub

    Private Sub cmbModele_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbModele.SelectedIndexChanged
        Dim myCommand = New SqlCommand("Select * from vehicule where marque='" + cmbMarque.Text + "' and modele='" + cmbModele.Text + "';", con)
        con.Open()
        dr = myCommand.ExecuteReader()


        While dr.Read()
            cmbEtat.Items.Add(dr("etat").ToString())
            cmbPrix.Items.Add(dr("tarif").ToString())
            cmbPuissance.Items.Add(dr("puissance").ToString())
        End While

        con.Close()
    End Sub


    Private Sub btnAccueil_Click(sender As System.Object, e As System.EventArgs) Handles btnAccueil.Click
        unPageAccueil = New frmAccueil
        unPageAccueil.Show()
        Me.Hide()
    End Sub

    Private Sub btnCredit_Click(sender As System.Object, e As System.EventArgs) Handles btnCredit.Click
        fenCredit = New FrmCredit
        fenCredit.Show()
        Me.Hide()
    End Sub
End Class