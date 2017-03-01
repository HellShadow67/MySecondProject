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
        Me.lblNvVehicule = New System.Windows.Forms.Label()
        Me.txtbxNvVehicule = New System.Windows.Forms.TextBox()
        Me.lblVendeur = New System.Windows.Forms.Label()
        Me.cboVendeur = New System.Windows.Forms.ComboBox()
        Me.txtbxAncVehicule = New System.Windows.Forms.TextBox()
        Me.lblAncVehicule = New System.Windows.Forms.Label()
        Me.cmdEnregistrer = New System.Windows.Forms.Button()
        Me.cmdVoiture = New System.Windows.Forms.Button()
        Me.cmdCredit = New System.Windows.Forms.Button()
        Me.cmdPlus = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbdOcc5EtPlus = New System.Windows.Forms.RadioButton()
        Me.rdbOcc3a5 = New System.Windows.Forms.RadioButton()
        Me.rdbOcc3 = New System.Windows.Forms.RadioButton()
        Me.rdbNeuf = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Je m'appelle"
        '
        'cboIdentifiant
        '
        Me.cboIdentifiant.FormattingEnabled = True
        Me.cboIdentifiant.Items.AddRange(New Object() {"Mme", "Mlle", "M"})
        Me.cboIdentifiant.Location = New System.Drawing.Point(28, 71)
        Me.cboIdentifiant.Name = "cboIdentifiant"
        Me.cboIdentifiant.Size = New System.Drawing.Size(121, 21)
        Me.cboIdentifiant.TabIndex = 1
        '
        'txtbxNom
        '
        Me.txtbxNom.Location = New System.Drawing.Point(28, 123)
        Me.txtbxNom.Name = "txtbxNom"
        Me.txtbxNom.Size = New System.Drawing.Size(100, 20)
        Me.txtbxNom.TabIndex = 2
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Location = New System.Drawing.Point(28, 150)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(29, 13)
        Me.lblNom.TabIndex = 3
        Me.lblNom.Text = "Nom"
        '
        'txtbxPrenom
        '
        Me.txtbxPrenom.Location = New System.Drawing.Point(28, 194)
        Me.txtbxPrenom.Name = "txtbxPrenom"
        Me.txtbxPrenom.Size = New System.Drawing.Size(100, 20)
        Me.txtbxPrenom.TabIndex = 4
        '
        'lblPrenom
        '
        Me.lblPrenom.AutoSize = True
        Me.lblPrenom.Location = New System.Drawing.Point(28, 217)
        Me.lblPrenom.Name = "lblPrenom"
        Me.lblPrenom.Size = New System.Drawing.Size(43, 13)
        Me.lblPrenom.TabIndex = 5
        Me.lblPrenom.Text = "Prénom"
        '
        'lblNvVehicule
        '
        Me.lblNvVehicule.AutoSize = True
        Me.lblNvVehicule.Location = New System.Drawing.Point(258, 150)
        Me.lblNvVehicule.Name = "lblNvVehicule"
        Me.lblNvVehicule.Size = New System.Drawing.Size(119, 13)
        Me.lblNvVehicule.TabIndex = 7
        Me.lblNvVehicule.Text = "Mon Nouveau Véhicule"
        '
        'txtbxNvVehicule
        '
        Me.txtbxNvVehicule.Location = New System.Drawing.Point(228, 194)
        Me.txtbxNvVehicule.Name = "txtbxNvVehicule"
        Me.txtbxNvVehicule.Size = New System.Drawing.Size(200, 20)
        Me.txtbxNvVehicule.TabIndex = 6
        '
        'lblVendeur
        '
        Me.lblVendeur.AutoSize = True
        Me.lblVendeur.Location = New System.Drawing.Point(41, 312)
        Me.lblVendeur.Name = "lblVendeur"
        Me.lblVendeur.Size = New System.Drawing.Size(47, 13)
        Me.lblVendeur.TabIndex = 8
        Me.lblVendeur.Text = "Vendeur"
        '
        'cboVendeur
        '
        Me.cboVendeur.FormattingEnabled = True
        Me.cboVendeur.Location = New System.Drawing.Point(31, 339)
        Me.cboVendeur.Name = "cboVendeur"
        Me.cboVendeur.Size = New System.Drawing.Size(121, 21)
        Me.cboVendeur.TabIndex = 9
        '
        'txtbxAncVehicule
        '
        Me.txtbxAncVehicule.Location = New System.Drawing.Point(228, 68)
        Me.txtbxAncVehicule.Name = "txtbxAncVehicule"
        Me.txtbxAncVehicule.Size = New System.Drawing.Size(200, 20)
        Me.txtbxAncVehicule.TabIndex = 10
        '
        'lblAncVehicule
        '
        Me.lblAncVehicule.AutoSize = True
        Me.lblAncVehicule.Location = New System.Drawing.Point(258, 52)
        Me.lblAncVehicule.Name = "lblAncVehicule"
        Me.lblAncVehicule.Size = New System.Drawing.Size(108, 13)
        Me.lblAncVehicule.TabIndex = 11
        Me.lblAncVehicule.Text = "Mon Ancien Véhicule"
        '
        'cmdEnregistrer
        '
        Me.cmdEnregistrer.Location = New System.Drawing.Point(63, 418)
        Me.cmdEnregistrer.Name = "cmdEnregistrer"
        Me.cmdEnregistrer.Size = New System.Drawing.Size(75, 23)
        Me.cmdEnregistrer.TabIndex = 17
        Me.cmdEnregistrer.Text = "J'enregistre"
        Me.cmdEnregistrer.UseVisualStyleBackColor = True
        '
        'cmdVoiture
        '
        Me.cmdVoiture.Location = New System.Drawing.Point(178, 418)
        Me.cmdVoiture.Name = "cmdVoiture"
        Me.cmdVoiture.Size = New System.Drawing.Size(75, 23)
        Me.cmdVoiture.TabIndex = 18
        Me.cmdVoiture.Text = "Voiture"
        Me.cmdVoiture.UseVisualStyleBackColor = True
        '
        'cmdCredit
        '
        Me.cmdCredit.Location = New System.Drawing.Point(302, 418)
        Me.cmdCredit.Name = "cmdCredit"
        Me.cmdCredit.Size = New System.Drawing.Size(75, 23)
        Me.cmdCredit.TabIndex = 19
        Me.cmdCredit.Text = "Crédit"
        Me.cmdCredit.UseVisualStyleBackColor = True
        '
        'cmdPlus
        '
        Me.cmdPlus.Location = New System.Drawing.Point(473, 418)
        Me.cmdPlus.Name = "cmdPlus"
        Me.cmdPlus.Size = New System.Drawing.Size(75, 23)
        Me.cmdPlus.TabIndex = 20
        Me.cmdPlus.Text = "Plus"
        Me.cmdPlus.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbdOcc5EtPlus)
        Me.GroupBox1.Controls.Add(Me.rdbOcc3a5)
        Me.GroupBox1.Controls.Add(Me.rdbOcc3)
        Me.GroupBox1.Controls.Add(Me.rdbNeuf)
        Me.GroupBox1.Location = New System.Drawing.Point(228, 250)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 110)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Type"
        '
        'rbdOcc5EtPlus
        '
        Me.rbdOcc5EtPlus.AutoSize = True
        Me.rbdOcc5EtPlus.Location = New System.Drawing.Point(31, 87)
        Me.rbdOcc5EtPlus.Name = "rbdOcc5EtPlus"
        Me.rbdOcc5EtPlus.Size = New System.Drawing.Size(139, 17)
        Me.rbdOcc5EtPlus.TabIndex = 20
        Me.rbdOcc5EtPlus.TabStop = True
        Me.rbdOcc5EtPlus.Text = "Occasion - 5 ans et plus"
        Me.rbdOcc5EtPlus.UseVisualStyleBackColor = True
        '
        'rdbOcc3a5
        '
        Me.rdbOcc3a5.AutoSize = True
        Me.rdbOcc3a5.Location = New System.Drawing.Point(31, 64)
        Me.rdbOcc3a5.Name = "rdbOcc3a5"
        Me.rdbOcc3a5.Size = New System.Drawing.Size(123, 17)
        Me.rdbOcc3a5.TabIndex = 19
        Me.rdbOcc3a5.TabStop = True
        Me.rdbOcc3a5.Text = "Occasion - 3 à 5 ans"
        Me.rdbOcc3a5.UseVisualStyleBackColor = True
        '
        'rdbOcc3
        '
        Me.rdbOcc3.AutoSize = True
        Me.rdbOcc3.Location = New System.Drawing.Point(31, 41)
        Me.rdbOcc3.Name = "rdbOcc3"
        Me.rdbOcc3.Size = New System.Drawing.Size(105, 17)
        Me.rdbOcc3.TabIndex = 18
        Me.rdbOcc3.TabStop = True
        Me.rdbOcc3.Text = "Occasion - 3 ans"
        Me.rdbOcc3.UseVisualStyleBackColor = True
        '
        'rdbNeuf
        '
        Me.rdbNeuf.AutoSize = True
        Me.rdbNeuf.Location = New System.Drawing.Point(31, 18)
        Me.rdbNeuf.Name = "rdbNeuf"
        Me.rdbNeuf.Size = New System.Drawing.Size(48, 17)
        Me.rdbNeuf.TabIndex = 17
        Me.rdbNeuf.TabStop = True
        Me.rdbNeuf.Text = "Neuf"
        Me.rdbNeuf.UseVisualStyleBackColor = True
        '
        'frmIntro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 462)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdPlus)
        Me.Controls.Add(Me.cmdCredit)
        Me.Controls.Add(Me.cmdVoiture)
        Me.Controls.Add(Me.cmdEnregistrer)
        Me.Controls.Add(Me.lblAncVehicule)
        Me.Controls.Add(Me.txtbxAncVehicule)
        Me.Controls.Add(Me.cboVendeur)
        Me.Controls.Add(Me.lblVendeur)
        Me.Controls.Add(Me.lblNvVehicule)
        Me.Controls.Add(Me.txtbxNvVehicule)
        Me.Controls.Add(Me.lblPrenom)
        Me.Controls.Add(Me.txtbxPrenom)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.txtbxNom)
        Me.Controls.Add(Me.cboIdentifiant)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmIntro"
        Me.Text = "frmIntro"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboIdentifiant As System.Windows.Forms.ComboBox
    Friend WithEvents txtbxNom As System.Windows.Forms.TextBox
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents txtbxPrenom As System.Windows.Forms.TextBox
    Friend WithEvents lblPrenom As System.Windows.Forms.Label
    Friend WithEvents lblNvVehicule As System.Windows.Forms.Label
    Friend WithEvents txtbxNvVehicule As System.Windows.Forms.TextBox
    Friend WithEvents lblVendeur As System.Windows.Forms.Label
    Friend WithEvents cboVendeur As System.Windows.Forms.ComboBox
    Friend WithEvents txtbxAncVehicule As System.Windows.Forms.TextBox
    Friend WithEvents lblAncVehicule As System.Windows.Forms.Label
    Friend WithEvents cmdEnregistrer As System.Windows.Forms.Button
    Friend WithEvents cmdVoiture As System.Windows.Forms.Button
    Friend WithEvents cmdCredit As System.Windows.Forms.Button
    Friend WithEvents cmdPlus As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbdOcc5EtPlus As System.Windows.Forms.RadioButton
    Friend WithEvents rdbOcc3a5 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbOcc3 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbNeuf As System.Windows.Forms.RadioButton
End Class
