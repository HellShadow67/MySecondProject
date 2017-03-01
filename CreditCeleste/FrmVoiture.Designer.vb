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
        Me.BtnCred = New System.Windows.Forms.Button()
        Me.BtnInt = New System.Windows.Forms.Button()
        Me.BtnEnr = New System.Windows.Forms.Button()
        Me.LblPuissance = New System.Windows.Forms.Label()
        Me.LblAnneeMod = New System.Windows.Forms.Label()
        Me.LblNumSerie = New System.Windows.Forms.Label()
        Me.LblNumImm = New System.Windows.Forms.Label()
        Me.TxtAnneeModele = New System.Windows.Forms.TextBox()
        Me.TxtPuissance = New System.Windows.Forms.TextBox()
        Me.TxtNumSerie = New System.Windows.Forms.TextBox()
        Me.txtNumImm = New System.Windows.Forms.TextBox()
        Me.LblDateImm = New System.Windows.Forms.Label()
        Me.TxtDateImm = New System.Windows.Forms.TextBox()
        Me.LblAff = New System.Windows.Forms.Label()
        Me.GrpBxNouvVeh.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpBxNouvVeh
        '
        Me.GrpBxNouvVeh.Controls.Add(Me.LblAff)
        Me.GrpBxNouvVeh.Location = New System.Drawing.Point(208, 26)
        Me.GrpBxNouvVeh.Name = "GrpBxNouvVeh"
        Me.GrpBxNouvVeh.Size = New System.Drawing.Size(357, 175)
        Me.GrpBxNouvVeh.TabIndex = 0
        Me.GrpBxNouvVeh.TabStop = False
        Me.GrpBxNouvVeh.Text = "Mon Nouveau Véhicule"
        '
        'BtnCred
        '
        Me.BtnCred.Location = New System.Drawing.Point(495, 404)
        Me.BtnCred.Name = "BtnCred"
        Me.BtnCred.Size = New System.Drawing.Size(75, 23)
        Me.BtnCred.TabIndex = 0
        Me.BtnCred.Text = "&Credit"
        Me.BtnCred.UseVisualStyleBackColor = True
        '
        'BtnInt
        '
        Me.BtnInt.Location = New System.Drawing.Point(352, 404)
        Me.BtnInt.Name = "BtnInt"
        Me.BtnInt.Size = New System.Drawing.Size(75, 23)
        Me.BtnInt.TabIndex = 1
        Me.BtnInt.Text = "&Introduction"
        Me.BtnInt.UseVisualStyleBackColor = True
        '
        'BtnEnr
        '
        Me.BtnEnr.Location = New System.Drawing.Point(195, 404)
        Me.BtnEnr.Name = "BtnEnr"
        Me.BtnEnr.Size = New System.Drawing.Size(75, 23)
        Me.BtnEnr.TabIndex = 2
        Me.BtnEnr.Text = "&J'enregistre"
        Me.BtnEnr.UseVisualStyleBackColor = True
        '
        'LblPuissance
        '
        Me.LblPuissance.AutoSize = True
        Me.LblPuissance.Location = New System.Drawing.Point(703, 331)
        Me.LblPuissance.Name = "LblPuissance"
        Me.LblPuissance.Size = New System.Drawing.Size(55, 13)
        Me.LblPuissance.TabIndex = 3
        Me.LblPuissance.Text = "puissance"
        '
        'LblAnneeMod
        '
        Me.LblAnneeMod.AutoSize = True
        Me.LblAnneeMod.Location = New System.Drawing.Point(178, 331)
        Me.LblAnneeMod.Name = "LblAnneeMod"
        Me.LblAnneeMod.Size = New System.Drawing.Size(74, 13)
        Me.LblAnneeMod.TabIndex = 4
        Me.LblAnneeMod.Text = "année modèle"
        '
        'LblNumSerie
        '
        Me.LblNumSerie.AutoSize = True
        Me.LblNumSerie.Location = New System.Drawing.Point(529, 331)
        Me.LblNumSerie.Name = "LblNumSerie"
        Me.LblNumSerie.Size = New System.Drawing.Size(82, 13)
        Me.LblNumSerie.TabIndex = 5
        Me.LblNumSerie.Text = "numero de serie"
        '
        'LblNumImm
        '
        Me.LblNumImm.AutoSize = True
        Me.LblNumImm.Location = New System.Drawing.Point(342, 331)
        Me.LblNumImm.Name = "LblNumImm"
        Me.LblNumImm.Size = New System.Drawing.Size(128, 13)
        Me.LblNumImm.TabIndex = 6
        Me.LblNumImm.Text = "numero d'immatricumation"
        '
        'TxtAnneeModele
        '
        Me.TxtAnneeModele.Location = New System.Drawing.Point(181, 283)
        Me.TxtAnneeModele.Name = "TxtAnneeModele"
        Me.TxtAnneeModele.Size = New System.Drawing.Size(100, 20)
        Me.TxtAnneeModele.TabIndex = 7
        '
        'TxtPuissance
        '
        Me.TxtPuissance.Location = New System.Drawing.Point(706, 283)
        Me.TxtPuissance.Name = "TxtPuissance"
        Me.TxtPuissance.Size = New System.Drawing.Size(100, 20)
        Me.TxtPuissance.TabIndex = 8
        '
        'TxtNumSerie
        '
        Me.TxtNumSerie.Location = New System.Drawing.Point(532, 283)
        Me.TxtNumSerie.Name = "TxtNumSerie"
        Me.TxtNumSerie.Size = New System.Drawing.Size(100, 20)
        Me.TxtNumSerie.TabIndex = 9
        '
        'txtNumImm
        '
        Me.txtNumImm.Location = New System.Drawing.Point(345, 283)
        Me.txtNumImm.Name = "txtNumImm"
        Me.txtNumImm.Size = New System.Drawing.Size(100, 20)
        Me.txtNumImm.TabIndex = 10
        '
        'LblDateImm
        '
        Me.LblDateImm.AutoSize = True
        Me.LblDateImm.Location = New System.Drawing.Point(22, 331)
        Me.LblDateImm.Name = "LblDateImm"
        Me.LblDateImm.Size = New System.Drawing.Size(139, 13)
        Me.LblDateImm.TabIndex = 0
        Me.LblDateImm.Text = "date de 1ere immatriculation"
        '
        'TxtDateImm
        '
        Me.TxtDateImm.Location = New System.Drawing.Point(25, 283)
        Me.TxtDateImm.Name = "TxtDateImm"
        Me.TxtDateImm.Size = New System.Drawing.Size(100, 20)
        Me.TxtDateImm.TabIndex = 11
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
        'FrmVoiture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 483)
        Me.Controls.Add(Me.TxtDateImm)
        Me.Controls.Add(Me.LblDateImm)
        Me.Controls.Add(Me.BtnCred)
        Me.Controls.Add(Me.BtnInt)
        Me.Controls.Add(Me.BtnEnr)
        Me.Controls.Add(Me.LblPuissance)
        Me.Controls.Add(Me.LblNumSerie)
        Me.Controls.Add(Me.LblNumImm)
        Me.Controls.Add(Me.TxtPuissance)
        Me.Controls.Add(Me.TxtNumSerie)
        Me.Controls.Add(Me.LblAnneeMod)
        Me.Controls.Add(Me.txtNumImm)
        Me.Controls.Add(Me.GrpBxNouvVeh)
        Me.Controls.Add(Me.TxtAnneeModele)
        Me.Name = "FrmVoiture"
        Me.Text = "FrmVoiture"
        Me.GrpBxNouvVeh.ResumeLayout(False)
        Me.GrpBxNouvVeh.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpBxNouvVeh As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCred As System.Windows.Forms.Button
    Friend WithEvents BtnInt As System.Windows.Forms.Button
    Friend WithEvents BtnEnr As System.Windows.Forms.Button
    Friend WithEvents LblPuissance As System.Windows.Forms.Label
    Friend WithEvents LblAnneeMod As System.Windows.Forms.Label
    Friend WithEvents LblNumSerie As System.Windows.Forms.Label
    Friend WithEvents LblNumImm As System.Windows.Forms.Label
    Friend WithEvents TxtAnneeModele As System.Windows.Forms.TextBox
    Friend WithEvents TxtPuissance As System.Windows.Forms.TextBox
    Friend WithEvents TxtNumSerie As System.Windows.Forms.TextBox
    Friend WithEvents txtNumImm As System.Windows.Forms.TextBox
    Friend WithEvents LblDateImm As System.Windows.Forms.Label
    Friend WithEvents TxtDateImm As System.Windows.Forms.TextBox
    Friend WithEvents LblAff As System.Windows.Forms.Label
End Class
