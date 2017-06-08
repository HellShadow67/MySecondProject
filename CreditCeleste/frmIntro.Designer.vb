<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIntro
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboIdentifiant = New System.Windows.Forms.ComboBox()
        Me.txtbxNom = New System.Windows.Forms.TextBox()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.txtbxPrenom = New System.Windows.Forms.TextBox()
        Me.lblPrenom = New System.Windows.Forms.Label()
        Me.cmdEnregistrer = New System.Windows.Forms.Button()
        Me.cmdAcheterVoiture = New System.Windows.Forms.Button()
        Me.cmdCredit = New System.Windows.Forms.Button()
        Me.cmdVendreVoit = New System.Windows.Forms.Button()
        Me.btnAccueil = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtVille = New System.Windows.Forms.TextBox()
        Me.txtCp = New System.Windows.Forms.TextBox()
        Me.txtRue = New System.Windows.Forms.TextBox()
        Me.txtNumRue = New System.Windows.Forms.TextBox()
        Me.cmbRue = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Je m'appelle"
        '
        'cboIdentifiant
        '
        Me.cboIdentifiant.FormattingEnabled = True
        Me.cboIdentifiant.Items.AddRange(New Object() {"Mme", "Mlle", "M"})
        Me.cboIdentifiant.Location = New System.Drawing.Point(31, 97)
        Me.cboIdentifiant.Name = "cboIdentifiant"
        Me.cboIdentifiant.Size = New System.Drawing.Size(121, 21)
        Me.cboIdentifiant.TabIndex = 1
        '
        'txtbxNom
        '
        Me.txtbxNom.Location = New System.Drawing.Point(199, 98)
        Me.txtbxNom.Name = "txtbxNom"
        Me.txtbxNom.Size = New System.Drawing.Size(100, 20)
        Me.txtbxNom.TabIndex = 2
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Location = New System.Drawing.Point(196, 125)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(29, 13)
        Me.lblNom.TabIndex = 3
        Me.lblNom.Text = "Nom"
        '
        'txtbxPrenom
        '
        Me.txtbxPrenom.Location = New System.Drawing.Point(353, 97)
        Me.txtbxPrenom.Name = "txtbxPrenom"
        Me.txtbxPrenom.Size = New System.Drawing.Size(100, 20)
        Me.txtbxPrenom.TabIndex = 4
        '
        'lblPrenom
        '
        Me.lblPrenom.AutoSize = True
        Me.lblPrenom.Location = New System.Drawing.Point(350, 125)
        Me.lblPrenom.Name = "lblPrenom"
        Me.lblPrenom.Size = New System.Drawing.Size(43, 13)
        Me.lblPrenom.TabIndex = 5
        Me.lblPrenom.Text = "Prénom"
        '
        'cmdEnregistrer
        '
        Me.cmdEnregistrer.Location = New System.Drawing.Point(31, 384)
        Me.cmdEnregistrer.Name = "cmdEnregistrer"
        Me.cmdEnregistrer.Size = New System.Drawing.Size(75, 23)
        Me.cmdEnregistrer.TabIndex = 17
        Me.cmdEnregistrer.Text = "J'enregistre"
        Me.cmdEnregistrer.UseVisualStyleBackColor = True
        '
        'cmdAcheterVoiture
        '
        Me.cmdAcheterVoiture.Enabled = False
        Me.cmdAcheterVoiture.Location = New System.Drawing.Point(178, 384)
        Me.cmdAcheterVoiture.Name = "cmdAcheterVoiture"
        Me.cmdAcheterVoiture.Size = New System.Drawing.Size(118, 23)
        Me.cmdAcheterVoiture.TabIndex = 18
        Me.cmdAcheterVoiture.Text = "Acheter une voiture"
        Me.cmdAcheterVoiture.UseVisualStyleBackColor = True
        '
        'cmdCredit
        '
        Me.cmdCredit.Enabled = False
        Me.cmdCredit.Location = New System.Drawing.Point(497, 384)
        Me.cmdCredit.Name = "cmdCredit"
        Me.cmdCredit.Size = New System.Drawing.Size(75, 23)
        Me.cmdCredit.TabIndex = 19
        Me.cmdCredit.Text = "Crédit"
        Me.cmdCredit.UseVisualStyleBackColor = True
        '
        'cmdVendreVoit
        '
        Me.cmdVendreVoit.Enabled = False
        Me.cmdVendreVoit.Location = New System.Drawing.Point(324, 384)
        Me.cmdVendreVoit.Name = "cmdVendreVoit"
        Me.cmdVendreVoit.Size = New System.Drawing.Size(114, 23)
        Me.cmdVendreVoit.TabIndex = 20
        Me.cmdVendreVoit.Text = "Vendre une voiture"
        Me.cmdVendreVoit.UseVisualStyleBackColor = True
        '
        'btnAccueil
        '
        Me.btnAccueil.Location = New System.Drawing.Point(480, 33)
        Me.btnAccueil.Name = "btnAccueil"
        Me.btnAccueil.Size = New System.Drawing.Size(75, 23)
        Me.btnAccueil.TabIndex = 21
        Me.btnAccueil.Text = "Accueil"
        Me.btnAccueil.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Adresse"
        '
        'txtVille
        '
        Me.txtVille.Location = New System.Drawing.Point(472, 263)
        Me.txtVille.Name = "txtVille"
        Me.txtVille.Size = New System.Drawing.Size(100, 20)
        Me.txtVille.TabIndex = 23
        '
        'txtCp
        '
        Me.txtCp.Location = New System.Drawing.Point(371, 263)
        Me.txtCp.Name = "txtCp"
        Me.txtCp.Size = New System.Drawing.Size(67, 20)
        Me.txtCp.TabIndex = 24
        '
        'txtRue
        '
        Me.txtRue.Location = New System.Drawing.Point(238, 264)
        Me.txtRue.Name = "txtRue"
        Me.txtRue.Size = New System.Drawing.Size(100, 20)
        Me.txtRue.TabIndex = 25
        '
        'txtNumRue
        '
        Me.txtNumRue.Location = New System.Drawing.Point(31, 264)
        Me.txtNumRue.Name = "txtNumRue"
        Me.txtNumRue.Size = New System.Drawing.Size(42, 20)
        Me.txtNumRue.TabIndex = 26
        '
        'cmbRue
        '
        Me.cmbRue.FormattingEnabled = True
        Me.cmbRue.Items.AddRange(New Object() {"Boulevard", "Imapasse", "Place", "Route", "Rue"})
        Me.cmbRue.Location = New System.Drawing.Point(91, 263)
        Me.cmbRue.Name = "cmbRue"
        Me.cmbRue.Size = New System.Drawing.Size(121, 21)
        Me.cmbRue.TabIndex = 27
        '
        'frmIntro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 416)
        Me.Controls.Add(Me.cmbRue)
        Me.Controls.Add(Me.txtNumRue)
        Me.Controls.Add(Me.txtRue)
        Me.Controls.Add(Me.txtCp)
        Me.Controls.Add(Me.txtVille)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAccueil)
        Me.Controls.Add(Me.cmdVendreVoit)
        Me.Controls.Add(Me.cmdCredit)
        Me.Controls.Add(Me.cmdAcheterVoiture)
        Me.Controls.Add(Me.cmdEnregistrer)
        Me.Controls.Add(Me.lblPrenom)
        Me.Controls.Add(Me.txtbxPrenom)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.txtbxNom)
        Me.Controls.Add(Me.cboIdentifiant)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmIntro"
        Me.Text = "frmIntro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboIdentifiant As System.Windows.Forms.ComboBox
    Friend WithEvents txtbxNom As System.Windows.Forms.TextBox
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents txtbxPrenom As System.Windows.Forms.TextBox
    Friend WithEvents lblPrenom As System.Windows.Forms.Label
    Friend WithEvents cmdEnregistrer As System.Windows.Forms.Button
    Friend WithEvents cmdAcheterVoiture As System.Windows.Forms.Button
    Friend WithEvents cmdCredit As System.Windows.Forms.Button
    Friend WithEvents cmdVendreVoit As System.Windows.Forms.Button
    Friend WithEvents btnAccueil As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtVille As System.Windows.Forms.TextBox
    Friend WithEvents txtCp As System.Windows.Forms.TextBox
    Friend WithEvents txtRue As System.Windows.Forms.TextBox
    Friend WithEvents txtNumRue As System.Windows.Forms.TextBox
    Friend WithEvents cmbRue As System.Windows.Forms.ComboBox
End Class
