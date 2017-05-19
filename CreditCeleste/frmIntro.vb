Imports CsClient
Imports System.Data.SqlClient

Public Class frmIntro

    Private Sub cboIdentifiant_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboIdentifiant.SelectedIndexChanged

    End Sub

    Private Sub frmIntro_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        ''DESKTOP-R0IJ4CS\SQLEXPRESSS

        Dim connectionString As String = "Server=DESKTOP-R0IJ4CS\SQLEXPRESS; Initial Catalog=CreditCeleste;Trusted_Connection=Yes"

        '=> pas de connexion ici, appelle de la collection dans accueil

        Dim con As New SqlConnection(connectionString)
        Dim dr As SqlDataReader

        Dim myCommand = New SqlCommand("Select * from Vendeur", con)

        con.Open()
        dr = myCommand.ExecuteReader()


        While dr.Read()
            cboVendeur.Items.Add(dr("NomVendeur").ToString())
            dr.NextResult()
        End While

        con.Close()

        ''For Each xVendeur As Vendeur In uneConcession.LesVendeurs

        ''   cboVendeur.Items.Add(xVendeur.getInfoVendeur)

        '' Next
    End Sub

    Private Sub cmdEnregistrer_Click(sender As System.Object, e As System.EventArgs) Handles cmdEnregistrer.Click

        Dim age As String
        Dim radio As RadioButton
        Dim i As Integer
        i = 0

        unClient.setNomClient(txtbxNom.Text)
        unClient.setPrenomClient(txtbxPrenom.Text)
        unClient.setIdentClient(cboIdentifiant.Text)

        uneVoiture.setNomVehicule(txtbxNvVehicule.Text)
        uneVoiture.setMonAcienVehicule(txtbxAncVehicule.Text)


        '' ou : unClient.saVoiture.setNomVehicule(txtNouvVehicule.Tesxt)

        For i = 0 To GroupBox1.Controls.Count - 1
            radio = GroupBox1.Controls(i)

            If radio.Checked Then
                age = radio.Text
            End If

            uneVoiture.setMonAgeVehicule(age)

            '' radio=GroupBox1.controls
            '' for each radio in GroupBox1.controls
            '' If radio.Checked Then
            '' age= radio.text
            '' End If

            '' leVendeur = cboVendeur.Text

            ''  MsgBox()


        Next

    End Sub

    Private Sub lblType_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub cmdVoiture_Click(sender As System.Object, e As System.EventArgs) Handles cmdVoiture.Click

        fenVoiture = New FrmVoiture
        fenVoiture.Show()
        Me.Hide()

    End Sub

    Private Sub cmdCredit_Click(sender As System.Object, e As System.EventArgs) Handles cmdCredit.Click
        fenCredit = New FrmCredit
        fenCredit.Show()
        Me.Hide()
    End Sub

    Private Sub cboVendeur_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboVendeur.SelectedIndexChanged

    End Sub
End Class