<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stat
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
        Me.cmbMois = New System.Windows.Forms.ComboBox()
        Me.lblNomVendeur = New System.Windows.Forms.Label()
        Me.lblCommProf = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCommPourc = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblNbrVente = New System.Windows.Forms.Label()
        Me.lblMontantVente = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnAccueil = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmbMois
        '
        Me.cmbMois.FormattingEnabled = True
        Me.cmbMois.Location = New System.Drawing.Point(375, 12)
        Me.cmbMois.Name = "cmbMois"
        Me.cmbMois.Size = New System.Drawing.Size(121, 21)
        Me.cmbMois.TabIndex = 1
        '
        'lblNomVendeur
        '
        Me.lblNomVendeur.AutoSize = True
        Me.lblNomVendeur.Location = New System.Drawing.Point(24, 20)
        Me.lblNomVendeur.Name = "lblNomVendeur"
        Me.lblNomVendeur.Size = New System.Drawing.Size(0, 13)
        Me.lblNomVendeur.TabIndex = 2
        '
        'lblCommProf
        '
        Me.lblCommProf.AutoSize = True
        Me.lblCommProf.Location = New System.Drawing.Point(372, 287)
        Me.lblCommProf.Name = "lblCommProf"
        Me.lblCommProf.Size = New System.Drawing.Size(0, 13)
        Me.lblCommProf.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 278)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Montant rapporté par les commissions"
        '
        'lblCommPourc
        '
        Me.lblCommPourc.AutoSize = True
        Me.lblCommPourc.Location = New System.Drawing.Point(372, 212)
        Me.lblCommPourc.Name = "lblCommPourc"
        Me.lblCommPourc.Size = New System.Drawing.Size(0, 13)
        Me.lblCommPourc.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Commission en %"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(56, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Nombre de ventes"
        '
        'lblNbrVente
        '
        Me.lblNbrVente.AutoSize = True
        Me.lblNbrVente.Location = New System.Drawing.Point(372, 103)
        Me.lblNbrVente.Name = "lblNbrVente"
        Me.lblNbrVente.Size = New System.Drawing.Size(0, 13)
        Me.lblNbrVente.TabIndex = 8
        '
        'lblMontantVente
        '
        Me.lblMontantVente.AutoSize = True
        Me.lblMontantVente.Location = New System.Drawing.Point(372, 152)
        Me.lblMontantVente.Name = "lblMontantVente"
        Me.lblMontantVente.Size = New System.Drawing.Size(0, 13)
        Me.lblMontantVente.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(56, 152)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Montant des ventes"
        '
        'btnAccueil
        '
        Me.btnAccueil.Location = New System.Drawing.Point(421, 346)
        Me.btnAccueil.Name = "btnAccueil"
        Me.btnAccueil.Size = New System.Drawing.Size(75, 23)
        Me.btnAccueil.TabIndex = 11
        Me.btnAccueil.Text = "Accueil"
        Me.btnAccueil.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(112, 235)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(139, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "(dépend du mois précédent)"
        '
        'Stat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 381)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnAccueil)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblMontantVente)
        Me.Controls.Add(Me.lblNbrVente)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblCommPourc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblCommProf)
        Me.Controls.Add(Me.lblNomVendeur)
        Me.Controls.Add(Me.cmbMois)
        Me.Name = "Stat"
        Me.Text = "Stat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbMois As System.Windows.Forms.ComboBox
    Friend WithEvents lblNomVendeur As System.Windows.Forms.Label
    Friend WithEvents lblCommProf As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblCommPourc As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblNbrVente As System.Windows.Forms.Label
    Friend WithEvents lblMontantVente As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnAccueil As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
