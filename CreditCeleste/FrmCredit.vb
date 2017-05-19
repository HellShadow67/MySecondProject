Public Class FrmCredit

    Private Sub FrmCredit_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnCalculer_Click(sender As System.Object, e As System.EventArgs) Handles BtnCalculer.Click


        Dim Duree As Double
        Dim Montant As Double
        Dim Mensualite As Double
        Dim Taux As Double



        If (TxtDuree.Text = "") Then
            Montant = Convert.ToDouble(TxtMensualite.Text)
            Mensualite = Convert.ToDouble(TxtMontant.Text)
            Taux = Convert.ToDouble(TxtTaux.Text)

            LblMsg.Text = "Le calcul de la durée effectué!"
        End If

        If (TxtMensualite.Text = "") Then
            Montant = Convert.ToDouble(TxtMontant.Text)

            Taux = Convert.ToDouble(TxtTaux.Text)
            Duree = Convert.ToDouble(TxtDuree.Text)

            Mensualite = ((Montant * ((Taux / 100)) / (1 - (1 + (Taux / 100)) ^ (-Duree))) / 12)

            TxtMensualite.Text = Mensualite


            LblMsg.Text = "Le calcul des mensualités effectué!"
        End If

        If (TxtTaux.Text = "") Then
            Mensualite = Convert.ToDouble(TxtMensualite.Text)
            Montant = Convert.ToDouble(TxtMontant.Text)
            Duree = Convert.ToDouble(TxtDuree.Text)

            Dim tx = 50.0
            Dim resultat = False

            While resultat <> True

            End While

            Taux = 0

            LblMsg.Text = "Le calcul du taux effectué!"
        End If

        If (TxtMontant.Text = "") Then

            Mensualite = Convert.ToDouble(TxtMensualite.Text)
            Taux = Convert.ToDouble(TxtTaux.Text)
            Duree = Convert.ToDouble(TxtDuree.Text)

            Montant = Mensualite * (1 - (1 + ((Taux / 100) / 12)) ^ (-Duree)) / ((Taux / 100) / 12)


            LblMsg.Text = "Le calcul du montant effectué!"

            TxtMontant.Text = Montant

        End If

    End Sub

    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click
        Controls.Clear()
        InitializeComponent()
    End Sub
End Class