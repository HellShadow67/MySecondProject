Imports System.Data.SqlClient



Public Class FrmCredit

    Dim connectionString As String = "Server=DESKTOP-R0IJ4CS\SQLEXPRESS; Initial Catalog=CreditCeleste;Trusted_Connection=Yes"
    Dim con As New SqlConnection(connectionString)
    Dim dr As SqlDataReader
    Dim idClient = 0

    Dim unCredit As New Credit
    Dim idPret = 0


    Private Sub BtnCalculer_Click(sender As System.Object, e As System.EventArgs) Handles BtnCalculer.Click


        Dim Duree As Double
        Dim Montant As Double
        Dim Mensualite As Double
        Dim Taux As Double



        If (String.IsNullOrEmpty(TxtDuree.Text) Or String.IsNullOrEmpty(TxtTaux.Text)) Then
            MessageBox.Show("La durée et le taux doivent être remplis!")
        End If
        If (String.IsNullOrEmpty(TxtMensualite.Text) And String.IsNullOrEmpty(TxtMontant.Text)) Then
            MessageBox.Show("La mensualité ou le montant doit être rempli!")
        Else
            If (String.IsNullOrEmpty(TxtMensualite.Text)) Then

                Montant = Convert.ToDouble(TxtMontant.Text)
                Taux = Convert.ToDouble(TxtTaux.Text)
                Duree = Convert.ToDouble(TxtDuree.Text)

                TxtMensualite.Text = Format(unCredit.getMensualite(Duree, Montant, Taux), "0.00")

                LblMsg.Text = "Le calcul des mensualités a été effectué!"
            End If

            If (String.IsNullOrEmpty(TxtMontant.Text)) Then

                Mensualite = Convert.ToDouble(TxtMensualite.Text)
                Taux = Convert.ToDouble(TxtTaux.Text)
                Duree = Convert.ToDouble(TxtDuree.Text)

                TxtMontant.Text = Format(unCredit.getMontant(Duree, Mensualite, Taux), "0.00")

                LblMsg.Text = "Le calcul du montant a été effectué!"

            End If
        End If

    End Sub

    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click
        Controls.Clear()
        InitializeComponent()
    End Sub

    Private Sub btnEnregistrer_Click(sender As System.Object, e As System.EventArgs) Handles btnEnregistrer.Click
        con.Open()

        Dim Mensualite = TxtMensualite.Text
        Dim Taux = TxtTaux.Text
        Dim Duree = TxtDuree.Text
        Dim montant = TxtMontant.Text

        Mensualite = CInt(Mensualite)
        Taux = CInt(Taux)
        Duree = CInt(Duree)
        montant = CInt(montant)

        Mensualite = Mensualite.ToString()
        Taux = Taux.ToString()
        Duree = Duree.ToString()
        montant = montant.ToString()


        Dim myCommand1 = New SqlCommand("insert into Pret(capital, mensualite, taux, duree) values(" + montant + "," + Mensualite + "," + Taux + "," + Duree + ")", con)
        dr = myCommand1.ExecuteReader()
        dr.Close()

        Dim myCommand = New SqlCommand("SELECT idPret FROM Pret where capital=" + montant + " and mensualite=" + Mensualite + " and taux=" + Taux + "and duree=" + Duree + ";", con)
        'MessageBox.Show("SELECT idPret FROM Pret where capital=" + montant + " and mensualite=" + Mensualite + " and taux=" + Taux + "and duree=" + Duree + ";")
        dr = myCommand.ExecuteReader()
        While dr.Read()
            idPret = CInt(dr("idPret"))
        End While
        dr.Close()

        Dim myCommand4 = New SqlCommand("SELECT idClient FROM client where Nom='" + unClient.getNom() + "' and Prenom='" + unClient.getPrenom() + "';", con)
        dr = myCommand4.ExecuteReader()
        While dr.Read()
            idClient = CInt(dr("idClient"))
        End While
        dr.Close()

        Dim myCommand2 = New SqlCommand(" Update client set idPret = " + idPret.ToString() + " WHERE idClient =" + idClient.ToString() + ";", con)
        'MessageBox.Show(" Update client set idPret = " + idPret.ToString() + " WHERE idClient =" + idClient.ToString() + ";")
        dr = myCommand2.ExecuteReader()
        dr.Close()

        con.Close()
        MessageBox.Show("L'enregistrement a bien été effectué!")
    End Sub

 
    Private Sub FrmCredit_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAccueil_Click(sender As System.Object, e As System.EventArgs) Handles btnAccueil.Click
        unPageAccueil = New frmAccueil
        unPageAccueil.Show()
        Me.Hide()
    End Sub
End Class