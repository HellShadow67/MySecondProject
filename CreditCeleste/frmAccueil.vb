Public Class frmAccueil

    Private Sub frmAccueil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        uneConcession = New Concession("garage des halles", "65 rue Duarte Samanta")

        Dim unVendeur As New Vendeur() '' variable locale



        unVendeur.setVendeur("M", "Stark", "Tony")

        Dim unVendeur2 As New Vendeur()
        unVendeur2.setIdVendeur("mlle.")
        unVendeur2.setNomVendeur("Duarte")
        unVendeur2.setPrenomVendeur("Samanta")


        Dim vendeur3 As New Vendeur("Mme", "Quinn", "Harley") '' avec constructeur


        ''mise a jour de la concession

        Dim Vendeur4 As New Vendeur("M", "Dead", "Pool")

        uneConcession.LesVendeurs.Add(Vendeur4)
        uneConcession.LesVendeurs.Add(vendeur3)
        uneConcession.LesVendeurs.Add(unVendeur2)
        uneConcession.LesVendeurs.Add(unVendeur)

        '' uneConcession.LesVendeurs.Add("Mlle Duarte Samanta")


    End Sub

    Private Sub cmdIntroduction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIntroduction.Click


        '' affichage de la fenetre d'introduction

        fenIntro = New frmIntro
        fenIntro.Show()
        Me.Hide()

    End Sub
End Class
