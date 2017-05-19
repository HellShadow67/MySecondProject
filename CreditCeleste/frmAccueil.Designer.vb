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
        Me.btnRelance = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdIntroduction
        '
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
        Me.btnEtude.Location = New System.Drawing.Point(195, 208)
        Me.btnEtude.Name = "btnEtude"
        Me.btnEtude.Size = New System.Drawing.Size(66, 23)
        Me.btnEtude.TabIndex = 2
        Me.btnEtude.Text = "&Etude"
        Me.btnEtude.UseVisualStyleBackColor = True
        '
        'btnRelance
        '
        Me.btnRelance.Location = New System.Drawing.Point(362, 208)
        Me.btnRelance.Name = "btnRelance"
        Me.btnRelance.Size = New System.Drawing.Size(75, 23)
        Me.btnRelance.TabIndex = 3
        Me.btnRelance.Text = "&Relance"
        Me.btnRelance.UseVisualStyleBackColor = True
        '
        'frmAccueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 262)
        Me.Controls.Add(Me.btnRelance)
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
    Friend WithEvents btnRelance As System.Windows.Forms.Button

End Class
