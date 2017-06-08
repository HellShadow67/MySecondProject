Imports System.Data.SqlClient

Public Class Stat

    Dim connectionString As String = "Server=DESKTOP-R0IJ4CS\SQLEXPRESS; Initial Catalog=CreditCeleste;Trusted_Connection=Yes"

    Dim con As New SqlConnection(connectionString)
    Dim dr As SqlDataReader
    Dim dr2 As SqlDataReader

    Dim idMoisPrec = 0
    Dim mois = 0
    Dim annee = 0
    Dim idHistSel = 0
    Dim idVendeurSel = 0


    Private Sub btnAccueil_Click(sender As System.Object, e As System.EventArgs) Handles btnAccueil.Click

        unPageAccueil = New frmAccueil
        unPageAccueil.Show()
        Me.Hide()

    End Sub

    Private Sub Stat_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load




            lblNomVendeur.Text = unVendeur.getNomPrenom()

            Dim myCommand = New SqlCommand("Select * from historique", con)

            con.Open()
            dr = myCommand.ExecuteReader()



            While dr.Read()

                cmbMois.Items.Add(dr("mois").ToString() + "/" + dr("annee").ToString())
            End While

            dr.Close()

            Dim myCommand2 = New SqlCommand("Select IdentifiantVendeur from Vendeur where NomVendeur= '" + unVendeur.getNom() + "' and PrenomVendeur= '" + unVendeur.getPrenom() + "';", con)
            dr = myCommand2.ExecuteReader()

            While dr.Read()
            idVendeurSel = CInt(dr("IdentifiantVendeur"))

        End While

            dr.Close()

            con.Close()
    End Sub


    Private Sub cmbMois_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbMois.SelectedIndexChanged

        lblCommPourc.Text = ""
        lblCommProf.Text = ""
        lblMontantVente.Text = ""
        lblNbrVente.Text = ""

        Dim words As String() = cmbMois.SelectedItem.ToString().Split("/")
        Dim moisA As String = words(0)
        Dim anneeA As String = words(1)

        mois = CInt(moisA)
        annee = CInt(anneeA)

        con.Open()

        Dim myCommand3 = New SqlCommand("Select idhist from historique where mois = " + mois.ToString() + " and annee = " + annee.ToString() + ";", con)
        dr = myCommand3.ExecuteReader()

        ' MessageBox.Show("Select idhist from historique where mois = " + mois.ToString() + " and annee = " + annee.ToString() + ";")

        While dr.Read()
            idHistSel = CInt(dr("idhist"))
        End While
        dr.Close()

        Dim myCommand = New SqlCommand("Select * from vente where idHist = " + idHistSel.ToString() + " and idVendeur = " + idVendeurSel.ToString(), con)



        'MessageBox.Show("idHist = " + idHistSel.ToString() + " and idVendeur = " + idVendeurSel.ToString())

        dr = myCommand.ExecuteReader()


        While dr.Read()
            lblCommProf.Text = dr("cummulComm").ToString()
            lblMontantVente.Text = dr("montant").ToString()
            lblNbrVente.Text = dr("nbrVente").ToString()

        End While
        dr.Close()




        If (idHistSel > 1) Then
            idMoisPrec = idHistSel - 1

            Dim myCommand4 = New SqlCommand("Select * from vente where idHist = " + idMoisPrec.ToString() + " and idVendeur = " + idVendeurSel.ToString(), con)


            dr2 = myCommand4.ExecuteReader()


            Dim PourComm = 0
            Dim PourCommMont = 0

            While dr2.Read()
                If CInt(dr2("nbrVente")) > 5 And CInt(dr2("nbrVente")) < 10 Then
                    PourCommMont = 1
                ElseIf CInt(dr2("nbrVente")) >= 10 And CInt(dr2("nbrVente")) < 15 Then
                    PourCommMont = 2
                ElseIf CInt(dr2("nbrVente")) >= 15 Then
                    PourCommMont = 3
                End If

                If CInt(dr2("montant")) > 100000 And CInt(dr2("montant")) < 200000 Then
                    PourComm = 1
                ElseIf CInt(dr2("montant")) >= 200000 And CInt(dr2("montant")) < 300000 Then
                    PourComm = 2
                ElseIf CInt(dr2("montant")) >= 300000 Then
                    PourComm = 3
                End If


            End While

            lblCommPourc.Text = (PourCommMont + PourComm).ToString()


            dr2.Close()
        End If




        con.Close()

    End Sub
End Class