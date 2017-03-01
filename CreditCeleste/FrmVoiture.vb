Public Class FrmVoiture

    Private Sub FrmVoiture_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub



    Private Sub BtnEnr_Click(sender As System.Object, e As System.EventArgs) Handles BtnEnr.Click

        uneVoiture.setReste(TxtDateImm.Text, TxtAnneeModele.Text, txtNumImm.Text, TxtNumSerie.Text, TxtPuissance.Text)
        LblAff.Text = uneVoiture.getAll()

    End Sub

    Private Sub BtnInt_Click(sender As System.Object, e As System.EventArgs) Handles BtnInt.Click
        fenIntro = New frmIntro
        fenIntro.Show()
        Me.Hide()
    End Sub

    Private Sub BtnCred_Click(sender As System.Object, e As System.EventArgs) Handles BtnCred.Click
        fenCredit = New FrmCredit
        fenCredit.Show()
        Me.Hide()
    End Sub

    Private Sub GrpBxNouvVeh_Enter(sender As System.Object, e As System.EventArgs) Handles GrpBxNouvVeh.Enter

    End Sub
End Class