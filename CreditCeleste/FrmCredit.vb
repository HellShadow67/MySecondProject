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

            Dim tps = 100
            Dim resultat = False

            While resultat <> True
                Dim monMontant = Mensualite * (1 - (1 + ((Taux / 100) / 12)) ^ (-Duree)) / ((Taux / 100) / 12)
                If Format(monMontant, "0") = Montant Then
                    resultat = True
                ElseIf monMontant < Montant Then
                    tps = (tps + tps / 2)
                Else
                    tps = (tps / 2)
                End If
            End While

            TxtDuree.Text = Format(tps, "0")

            LblMsg.Text = "Calcul de la durée effectué!"
        End If

        If (TxtMensualite.Text = "") Then
            Montant = Convert.ToDouble(TxtMontant.Text)

            Taux = Convert.ToDouble(TxtTaux.Text)
            Duree = Convert.ToDouble(TxtDuree.Text)

            Mensualite = (Montant * ((Taux / 100) / 12) / (1 - (1 + (Taux / 100) / 12) ^ (-Duree)))

            TxtMensualite.Text = Format(Mensualite, "0.00")


            LblMsg.Text = "Calcul des mensualités effectué!"
        End If

        If (TxtTaux.Text = "") Then
            Mensualite = Convert.ToDouble(TxtMensualite.Text)
            Montant = Convert.ToDouble(TxtMontant.Text)
            Duree = Convert.ToDouble(TxtDuree.Text)

            Dim tx = 50.0
            Dim resultat = False

            While resultat <> True
                Dim monMontant = Mensualite * (1 - (1 + ((Taux / 100) / 12)) ^ (-Duree)) / ((Taux / 100) / 12)
                If Format(monMontant, "0.00") = Montant Then
                    resultat = True
                ElseIf monMontant > Montant Then
                    tx = (tx + tx / 2)
                Else
                    tx = (tx / 2)
                End If
            End While

            TxtTaux.Text = Format(tx, "0.00")

            LblMsg.Text = "Calcul du taux effectué!"
        End If

        If (TxtMontant.Text = "") Then

            Mensualite = Convert.ToDouble(TxtMensualite.Text)
            Taux = Convert.ToDouble(TxtTaux.Text)
            Duree = Convert.ToDouble(TxtDuree.Text)

            Montant = Mensualite * (1 - (1 + ((Taux / 100) / 12)) ^ (-Duree)) / ((Taux / 100) / 12)


            LblMsg.Text = "Calcul du montant effectué!"

            TxtMontant.Text = Format(Montant, "0.00")

        End If

    End Sub

    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click
        Controls.Clear()
        InitializeComponent()
    End Sub
End Class