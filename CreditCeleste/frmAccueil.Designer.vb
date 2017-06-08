<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccueil
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
        Me.cmdIntroduction = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEtude = New System.Windows.Forms.Button()
        Me.cboVendeur = New System.Windows.Forms.ComboBox()
        Me.lblVendeur = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdIntroduction
        '
        Me.cmdIntroduction.Enabled = False
        Me.cmdIntroduction.Location = New System.Drawing.Point(39, 208)
        Me.cmdIntroduction.Name = "cmdIntroduction"
        Me.cmdIntroduction.Size = New System.Drawing.Size(75, 23)
        Me.cmdIntroduction.TabIndex = 0
        Me.cmdIntroduction.Text = "&Introduction"
        Me.cmdIntroduction.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(148, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "BIENVENUE AU CREDIT CELESTE"
        '
        'btnEtude
        '
        Me.btnEtude.Enabled = False
        Me.btnEtude.Location = New System.Drawing.Point(375, 208)
        Me.btnEtude.Name = "btnEtude"
        Me.btnEtude.Size = New System.Drawing.Size(66, 23)
        Me.btnEtude.TabIndex = 2
        Me.btnEtude.Text = "&Etude"
        Me.btnEtude.UseVisualStyleBackColor = True
        '
        'cboVendeur
        '
        Me.cboVendeur.FormattingEnabled = True
        Me.cboVendeur.Location = New System.Drawing.Point(320, 41)
        Me.cboVendeur.Name = "cboVendeur"
        Me.cboVendeur.Size = New System.Drawing.Size(121, 21)
        Me.cboVendeur.TabIndex = 11
        '
        'lblVendeur
        '
        Me.lblVendeur.AutoSize = True
        Me.lblVendeur.Location = New System.Drawing.Point(330, 14)
        Me.lblVendeur.Name = "lblVendeur"
        Me.lblVendeur.Size = New System.Drawing.Size(47, 13)
        Me.lblVendeur.TabIndex = 10
        Me.lblVendeur.Text = "Vendeur"
        '
        'frmAccueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 262)
        Me.Controls.Add(Me.cboVendeur)
        Me.Controls.Add(Me.lblVendeur)
        Me.Controls.Add(Me.btnEtude)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdIntroduction)
        Me.Name = "frmAccueil"
        Me.Text = "ACCUEIL"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdIntroduction As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnEtude As System.Windows.Forms.Button
    Friend WithEvents cboVendeur As System.Windows.Forms.ComboBox
    Friend WithEvents lblVendeur As System.Windows.Forms.Label

End Class
