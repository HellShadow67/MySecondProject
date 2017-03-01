Public Class FrmCredit

    Private Sub FrmCredit_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnCalculer_Click(sender As System.Object, e As System.EventArgs) Handles BtnCalculer.Click


        Dim Duree As Integer
        Dim Montant As Double
        Dim Mensualite As Double
        Dim Taux As Double

        If (TxtDuree.Text = "") Then
            Montant = TxtMensualite.Text
            Mensualite = TxtMontant.Text
            Taux = TxtTaux.Text
            '' Taux = CDbl(TxtTaux.Text.ToString)

            Duree = Math.Log(-Mensualite / ((Taux / 100) / (12 * Montant) - Mensualite)) / Math.Log(1 + (Taux / 100) / 12)
            TxtDuree.Text = Duree

            LblMsg.Text = "Le calcul de la durée effectué!"

        Else
            Duree = TxtDuree.Text
        End If

        '' la mensualité (m), du taux (t) et du nombre de mois du crédit (n) 

        ''    _________m(x(1 - (1 + t / 12) ^ (-n)))
        ''Capital = ---------------------------------- 
        ''______________t/12 

        ''ou cette formule pour déterminer la mensualité en fonction du capital emprunté (c), du taux (t) et du nombre de mois du crédit (n) 

        ''________________c x t/12 
        ''Mensualité = ----------------------------- 
        ''      _____________1(-(1 + t / 12) ^ (-n))





        ''LblMsg: erreur si tous les champs sont remplis ou si un manque, ...
    End Sub

End Class