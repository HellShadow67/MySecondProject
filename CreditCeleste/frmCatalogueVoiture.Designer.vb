<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCatalogueVoiture
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
        Me.btnValider = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.lblMarque = New System.Windows.Forms.Label()
        Me.lblEtat = New System.Windows.Forms.Label()
        Me.lblPuissance = New System.Windows.Forms.Label()
        Me.lblModele = New System.Windows.Forms.Label()
        Me.cmbMarque = New System.Windows.Forms.ComboBox()
        Me.cmbPuissance = New System.Windows.Forms.ComboBox()
        Me.cmbModele = New System.Windows.Forms.ComboBox()
        Me.cmbEtat = New System.Windows.Forms.ComboBox()
        Me.lblTarif = New System.Windows.Forms.Label()
        Me.cmbPrix = New System.Windows.Forms.ComboBox()
        Me.btnAccueil = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnValider
        '
        Me.btnValider.Location = New System.Drawing.Point(117, 292)
        Me.btnValider.Name = "btnValider"
        Me.btnValider.Size = New System.Drawing.Size(75, 23)
        Me.btnValider.TabIndex = 0
        Me.btnValider.Text = "Valider l'achat"
        Me.btnValider.UseVisualStyleBackColor = True
        '
        'btnAnnuler
        '
        Me.btnAnnuler.Location = New System.Drawing.Point(242, 292)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(75, 23)
        Me.btnAnnuler.TabIndex = 1
        Me.btnAnnuler.Text = "Annuler"
        Me.btnAnnuler.UseVisualStyleBackColor = True
        '
        'lblMarque
        '
        Me.lblMarque.AutoSize = True
        Me.lblMarque.Location = New System.Drawing.Point(68, 51)
        Me.lblMarque.Name = "lblMarque"
        Me.lblMarque.Size = New System.Drawing.Size(43, 13)
        Me.lblMarque.TabIndex = 2
        Me.lblMarque.Text = "Marque"
        '
        'lblEtat
        '
        Me.lblEtat.AutoSize = True
        Me.lblEtat.Location = New System.Drawing.Point(430, 121)
        Me.lblEtat.Name = "lblEtat"
        Me.lblEtat.Size = New System.Drawing.Size(26, 13)
        Me.lblEtat.TabIndex = 3
        Me.lblEtat.Text = "Etat"
        '
        'lblPuissance
        '
        Me.lblPuissance.AutoSize = True
        Me.lblPuissance.Location = New System.Drawing.Point(68, 121)
        Me.lblPuissance.Name = "lblPuissance"
        Me.lblPuissance.Size = New System.Drawing.Size(56, 13)
        Me.lblPuissance.TabIndex = 4
        Me.lblPuissance.Text = "Puissance"
        '
        'lblModele
        '
        Me.lblModele.AutoSize = True
        Me.lblModele.Location = New System.Drawing.Point(430, 51)
        Me.lblModele.Name = "lblModele"
        Me.lblModele.Size = New System.Drawing.Size(42, 13)
        Me.lblModele.TabIndex = 5
        Me.lblModele.Text = "Modele"
        '
        'cmbMarque
        '
        Me.cmbMarque.FormattingEnabled = True
        Me.cmbMarque.Location = New System.Drawing.Point(143, 51)
        Me.cmbMarque.Name = "cmbMarque"
        Me.cmbMarque.Size = New System.Drawing.Size(121, 21)
        Me.cmbMarque.TabIndex = 6
        '
        'cmbPuissance
        '
        Me.cmbPuissance.FormattingEnabled = True
        Me.cmbPuissance.Location = New System.Drawing.Point(143, 121)
        Me.cmbPuissance.Name = "cmbPuissance"
        Me.cmbPuissance.Size = New System.Drawing.Size(121, 21)
        Me.cmbPuissance.TabIndex = 7
        '
        'cmbModele
        '
        Me.cmbModele.FormattingEnabled = True
        Me.cmbModele.Location = New System.Drawing.Point(505, 51)
        Me.cmbModele.Name = "cmbModele"
        Me.cmbModele.Size = New System.Drawing.Size(121, 21)
        Me.cmbModele.TabIndex = 8
        '
        'cmbEtat
        '
        Me.cmbEtat.FormattingEnabled = True
        Me.cmbEtat.Location = New System.Drawing.Point(505, 121)
        Me.cmbEtat.Name = "cmbEtat"
        Me.cmbEtat.Size = New System.Drawing.Size(121, 21)
        Me.cmbEtat.TabIndex = 9
        '
        'lblTarif
        '
        Me.lblTarif.AutoSize = True
        Me.lblTarif.Location = New System.Drawing.Point(68, 196)
        Me.lblTarif.Name = "lblTarif"
        Me.lblTarif.Size = New System.Drawing.Size(24, 13)
        Me.lblTarif.TabIndex = 10
        Me.lblTarif.Text = "Prix"
        '
        'cmbPrix
        '
        Me.cmbPrix.FormattingEnabled = True
        Me.cmbPrix.Location = New System.Drawing.Point(143, 196)
        Me.cmbPrix.Name = "cmbPrix"
        Me.cmbPrix.Size = New System.Drawing.Size(121, 21)
        Me.cmbPrix.TabIndex = 11
        '
        'btnAccueil
        '
        Me.btnAccueil.Location = New System.Drawing.Point(674, 292)
        Me.btnAccueil.Name = "btnAccueil"
        Me.btnAccueil.Size = New System.Drawing.Size(75, 23)
        Me.btnAccueil.TabIndex = 12
        Me.btnAccueil.Text = "Accueil"
        Me.btnAccueil.UseVisualStyleBackColor = True
        '
        'frmCatalogueVoiture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 354)
        Me.Controls.Add(Me.btnAccueil)
        Me.Controls.Add(Me.cmbPrix)
        Me.Controls.Add(Me.lblTarif)
        Me.Controls.Add(Me.cmbEtat)
        Me.Controls.Add(Me.cmbModele)
        Me.Controls.Add(Me.cmbPuissance)
        Me.Controls.Add(Me.cmbMarque)
        Me.Controls.Add(Me.lblModele)
        Me.Controls.Add(Me.lblPuissance)
        Me.Controls.Add(Me.lblEtat)
        Me.Controls.Add(Me.lblMarque)
        Me.Controls.Add(Me.btnAnnuler)
        Me.Controls.Add(Me.btnValider)
        Me.Name = "frmCatalogueVoiture"
        Me.Text = "frmCatalogueVoiture"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnValider As System.Windows.Forms.Button
    Friend WithEvents btnAnnuler As System.Windows.Forms.Button
    Friend WithEvents lblMarque As System.Windows.Forms.Label
    Friend WithEvents lblEtat As System.Windows.Forms.Label
    Friend WithEvents lblPuissance As System.Windows.Forms.Label
    Friend WithEvents lblModele As System.Windows.Forms.Label
    Friend WithEvents cmbMarque As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPuissance As System.Windows.Forms.ComboBox
    Friend WithEvents cmbModele As System.Windows.Forms.ComboBox
    Friend WithEvents cmbEtat As System.Windows.Forms.ComboBox
    Friend WithEvents lblTarif As System.Windows.Forms.Label
    Friend WithEvents cmbPrix As System.Windows.Forms.ComboBox
    Friend WithEvents btnAccueil As System.Windows.Forms.Button
End Class
