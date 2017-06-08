<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVoiture
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
        Me.GrpBxNouvVeh = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblAff = New System.Windows.Forms.Label()
        Me.BtnCred = New System.Windows.Forms.Button()
        Me.BtnEnr = New System.Windows.Forms.Button()
        Me.LblAnneeMod = New System.Windows.Forms.Label()
        Me.LblNumSerie = New System.Windows.Forms.Label()
        Me.LblNumImm = New System.Windows.Forms.Label()
        Me.txtModele = New System.Windows.Forms.TextBox()
        Me.txtPuissance = New System.Windows.Forms.TextBox()
        Me.txtEtat = New System.Windows.Forms.TextBox()
        Me.LblDateImm = New System.Windows.Forms.Label()
        Me.txtMarque = New System.Windows.Forms.TextBox()
        Me.btnAccueil = New System.Windows.Forms.Button()
        Me.cmdAcheterVoiture = New System.Windows.Forms.Button()
        Me.txtPrixReprise = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GrpBxNouvVeh.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpBxNouvVeh
        '
        Me.GrpBxNouvVeh.Controls.Add(Me.Label3)
        Me.GrpBxNouvVeh.Controls.Add(Me.Label1)
        Me.GrpBxNouvVeh.Controls.Add(Me.LblAff)
        Me.GrpBxNouvVeh.Location = New System.Drawing.Point(208, 26)
        Me.GrpBxNouvVeh.Name = "GrpBxNouvVeh"
        Me.GrpBxNouvVeh.Size = New System.Drawing.Size(357, 175)
        Me.GrpBxNouvVeh.TabIndex = 0
        Me.GrpBxNouvVeh.TabStop = False
        Me.GrpBxNouvVeh.Text = "Mon dossier"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Label3"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Label1"
        '
        'LblAff
        '
        Me.LblAff.AutoSize = True
        Me.LblAff.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LblAff.Location = New System.Drawing.Point(64, 66)
        Me.LblAff.Name = "LblAff"
        Me.LblAff.Size = New System.Drawing.Size(0, 13)
        Me.LblAff.TabIndex = 12
        '
        'BtnCred
        '
        Me.BtnCred.Location = New System.Drawing.Point(670, 404)
        Me.BtnCred.Name = "BtnCred"
        Me.BtnCred.Size = New System.Drawing.Size(75, 23)
        Me.BtnCred.TabIndex = 0
        Me.BtnCred.Text = "&Credit"
        Me.BtnCred.UseVisualStyleBackColor = True
        '
        'BtnEnr
        '
        Me.BtnEnr.Location = New System.Drawing.Point(86, 404)
        Me.BtnEnr.Name = "BtnEnr"
        Me.BtnEnr.Size = New System.Drawing.Size(75, 23)
        Me.BtnEnr.TabIndex = 2
        Me.BtnEnr.Text = "&J'enregistre"
        Me.BtnEnr.UseVisualStyleBackColor = True
        '
        'LblAnneeMod
        '
        Me.LblAnneeMod.AutoSize = True
        Me.LblAnneeMod.Location = New System.Drawing.Point(178, 331)
        Me.LblAnneeMod.Name = "LblAnneeMod"
        Me.LblAnneeMod.Size = New System.Drawing.Size(42, 13)
        Me.LblAnneeMod.TabIndex = 4
        Me.LblAnneeMod.Text = "Modele"
        '
        'LblNumSerie
        '
        Me.LblNumSerie.AutoSize = True
        Me.LblNumSerie.Location = New System.Drawing.Point(529, 331)
        Me.LblNumSerie.Name = "LblNumSerie"
        Me.LblNumSerie.Size = New System.Drawing.Size(55, 13)
        Me.LblNumSerie.TabIndex = 5
        Me.LblNumSerie.Text = "puissance"
        '
        'LblNumImm
        '
        Me.LblNumImm.AutoSize = True
        Me.LblNumImm.Location = New System.Drawing.Point(342, 331)
        Me.LblNumImm.Name = "LblNumImm"
        Me.LblNumImm.Size = New System.Drawing.Size(25, 13)
        Me.LblNumImm.TabIndex = 6
        Me.LblNumImm.Text = "etat"
        '
        'txtModele
        '
        Me.txtModele.Location = New System.Drawing.Point(181, 283)
        Me.txtModele.Name = "txtModele"
        Me.txtModele.Size = New System.Drawing.Size(100, 20)
        Me.txtModele.TabIndex = 7
        '
        'txtPuissance
        '
        Me.txtPuissance.Location = New System.Drawing.Point(532, 283)
        Me.txtPuissance.Name = "txtPuissance"
        Me.txtPuissance.Size = New System.Drawing.Size(100, 20)
        Me.txtPuissance.TabIndex = 9
        '
        'txtEtat
        '
        Me.txtEtat.Location = New System.Drawing.Point(345, 283)
        Me.txtEtat.Name = "txtEtat"
        Me.txtEtat.Size = New System.Drawing.Size(100, 20)
        Me.txtEtat.TabIndex = 10
        '
        'LblDateImm
        '
        Me.LblDateImm.AutoSize = True
        Me.LblDateImm.Location = New System.Drawing.Point(22, 331)
        Me.LblDateImm.Name = "LblDateImm"
        Me.LblDateImm.Size = New System.Drawing.Size(43, 13)
        Me.LblDateImm.TabIndex = 0
        Me.LblDateImm.Text = "Marque"
        '
        'txtMarque
        '
        Me.txtMarque.Location = New System.Drawing.Point(25, 283)
        Me.txtMarque.Name = "txtMarque"
        Me.txtMarque.Size = New System.Drawing.Size(100, 20)
        Me.txtMarque.TabIndex = 11
        '
        'btnAccueil
        '
        Me.btnAccueil.Location = New System.Drawing.Point(731, 26)
        Me.btnAccueil.Name = "btnAccueil"
        Me.btnAccueil.Size = New System.Drawing.Size(75, 23)
        Me.btnAccueil.TabIndex = 12
        Me.btnAccueil.Text = "Accueil"
        Me.btnAccueil.UseVisualStyleBackColor = True
        '
        'cmdAcheterVoiture
        '
        Me.cmdAcheterVoiture.Location = New System.Drawing.Point(327, 404)
        Me.cmdAcheterVoiture.Name = "cmdAcheterVoiture"
        Me.cmdAcheterVoiture.Size = New System.Drawing.Size(118, 23)
        Me.cmdAcheterVoiture.TabIndex = 23
        Me.cmdAcheterVoiture.Text = "Acheter une voiture"
        Me.cmdAcheterVoiture.UseVisualStyleBackColor = True
        '
        'txtPrixReprise
        '
        Me.txtPrixReprise.Location = New System.Drawing.Point(695, 283)
        Me.txtPrixReprise.Name = "txtPrixReprise"
        Me.txtPrixReprise.Size = New System.Drawing.Size(100, 20)
        Me.txtPrixReprise.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(692, 331)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Prix de reprise"
        '
        'FrmVoiture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 483)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPrixReprise)
        Me.Controls.Add(Me.cmdAcheterVoiture)
        Me.Controls.Add(Me.btnAccueil)
        Me.Controls.Add(Me.txtMarque)
        Me.Controls.Add(Me.LblDateImm)
        Me.Controls.Add(Me.BtnCred)
        Me.Controls.Add(Me.BtnEnr)
        Me.Controls.Add(Me.LblNumSerie)
        Me.Controls.Add(Me.LblNumImm)
        Me.Controls.Add(Me.txtPuissance)
        Me.Controls.Add(Me.LblAnneeMod)
        Me.Controls.Add(Me.txtEtat)
        Me.Controls.Add(Me.GrpBxNouvVeh)
        Me.Controls.Add(Me.txtModele)
        Me.Name = "FrmVoiture"
        Me.Text = "FrmVoiture"
        Me.GrpBxNouvVeh.ResumeLayout(False)
        Me.GrpBxNouvVeh.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpBxNouvVeh As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCred As System.Windows.Forms.Button
    Friend WithEvents BtnEnr As System.Windows.Forms.Button
    Friend WithEvents LblAnneeMod As System.Windows.Forms.Label
    Friend WithEvents LblNumSerie As System.Windows.Forms.Label
    Friend WithEvents LblNumImm As System.Windows.Forms.Label
    Friend WithEvents txtModele As System.Windows.Forms.TextBox
    Friend WithEvents txtPuissance As System.Windows.Forms.TextBox
    Friend WithEvents txtEtat As System.Windows.Forms.TextBox
    Friend WithEvents LblDateImm As System.Windows.Forms.Label
    Friend WithEvents txtMarque As System.Windows.Forms.TextBox
    Friend WithEvents LblAff As System.Windows.Forms.Label
    Friend WithEvents btnAccueil As System.Windows.Forms.Button
    Friend WithEvents cmdAcheterVoiture As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPrixReprise As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
