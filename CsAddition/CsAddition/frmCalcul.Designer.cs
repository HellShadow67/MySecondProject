namespace CsAddition
{
    partial class frmCalcul
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblResultat = new System.Windows.Forms.Label();
            this.btnAddition = new System.Windows.Forms.Button();
            this.cmdAdditionDbl = new System.Windows.Forms.Button();
            this.btnAdditionPar2 = new System.Windows.Forms.Button();
            this.btnAdditionDblPar2 = new System.Windows.Forms.Button();
            this.btnAdditionDblNew = new System.Windows.Forms.Button();
            this.btnAdditionDblNewPar2 = new System.Windows.Forms.Button();
            this.btn3val = new System.Windows.Forms.Button();
            this.txtc = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.btn4val = new System.Windows.Forms.Button();
            this.cmdBonjour = new System.Windows.Forms.Button();
            this.lblCrea = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(31, 22);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 0;
            this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(31, 48);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 1;
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.Location = new System.Drawing.Point(28, 71);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(46, 13);
            this.lblResultat.TabIndex = 2;
            this.lblResultat.Text = "Resultat";
            // 
            // btnAddition
            // 
            this.btnAddition.Location = new System.Drawing.Point(12, 102);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(100, 23);
            this.btnAddition.TabIndex = 3;
            this.btnAddition.Text = "&Addition";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // cmdAdditionDbl
            // 
            this.cmdAdditionDbl.Location = new System.Drawing.Point(12, 131);
            this.cmdAdditionDbl.Name = "cmdAdditionDbl";
            this.cmdAdditionDbl.Size = new System.Drawing.Size(100, 23);
            this.cmdAdditionDbl.TabIndex = 4;
            this.cmdAdditionDbl.Text = "Addition dbl";
            this.cmdAdditionDbl.UseVisualStyleBackColor = true;
            this.cmdAdditionDbl.Click += new System.EventHandler(this.cmdAdditionDbl_Click);
            // 
            // btnAdditionPar2
            // 
            this.btnAdditionPar2.Location = new System.Drawing.Point(161, 102);
            this.btnAdditionPar2.Name = "btnAdditionPar2";
            this.btnAdditionPar2.Size = new System.Drawing.Size(98, 23);
            this.btnAdditionPar2.TabIndex = 5;
            this.btnAdditionPar2.Text = "Addition par 2";
            this.btnAdditionPar2.UseVisualStyleBackColor = true;
            this.btnAdditionPar2.Click += new System.EventHandler(this.btnAdditionPar2_Click);
            // 
            // btnAdditionDblPar2
            // 
            this.btnAdditionDblPar2.Location = new System.Drawing.Point(161, 131);
            this.btnAdditionDblPar2.Name = "btnAdditionDblPar2";
            this.btnAdditionDblPar2.Size = new System.Drawing.Size(98, 23);
            this.btnAdditionDblPar2.TabIndex = 6;
            this.btnAdditionDblPar2.Text = "Addition dbl par 2";
            this.btnAdditionDblPar2.UseVisualStyleBackColor = true;
            this.btnAdditionDblPar2.Click += new System.EventHandler(this.btnAdditionDblPar2_Click);
            // 
            // btnAdditionDblNew
            // 
            this.btnAdditionDblNew.Location = new System.Drawing.Point(12, 190);
            this.btnAdditionDblNew.Name = "btnAdditionDblNew";
            this.btnAdditionDblNew.Size = new System.Drawing.Size(100, 23);
            this.btnAdditionDblNew.TabIndex = 7;
            this.btnAdditionDblNew.Text = "Addition dbl new";
            this.btnAdditionDblNew.UseVisualStyleBackColor = true;
            this.btnAdditionDblNew.Click += new System.EventHandler(this.btnAdditionDblNew_Click);
            // 
            // btnAdditionDblNewPar2
            // 
            this.btnAdditionDblNewPar2.Location = new System.Drawing.Point(159, 190);
            this.btnAdditionDblNewPar2.Name = "btnAdditionDblNewPar2";
            this.btnAdditionDblNewPar2.Size = new System.Drawing.Size(100, 23);
            this.btnAdditionDblNewPar2.TabIndex = 8;
            this.btnAdditionDblNewPar2.Text = "Addition dbl new par 2";
            this.btnAdditionDblNewPar2.UseVisualStyleBackColor = true;
            this.btnAdditionDblNewPar2.Click += new System.EventHandler(this.btnAdditionDblNewPar2_Click);
            // 
            // btn3val
            // 
            this.btn3val.Location = new System.Drawing.Point(12, 272);
            this.btn3val.Name = "btn3val";
            this.btn3val.Size = new System.Drawing.Size(75, 23);
            this.btn3val.TabIndex = 9;
            this.btn3val.Text = "addition 3 val";
            this.btn3val.UseVisualStyleBackColor = true;
            this.btn3val.Click += new System.EventHandler(this.btn3val_Click);
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(161, 22);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(100, 20);
            this.txtc.TabIndex = 10;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(161, 48);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(100, 20);
            this.txt4.TabIndex = 11;
            // 
            // btn4val
            // 
            this.btn4val.Location = new System.Drawing.Point(161, 272);
            this.btn4val.Name = "btn4val";
            this.btn4val.Size = new System.Drawing.Size(75, 23);
            this.btn4val.TabIndex = 12;
            this.btn4val.Text = "addition 4 val";
            this.btn4val.UseVisualStyleBackColor = true;
            this.btn4val.Click += new System.EventHandler(this.btn4val_Click);
            // 
            // cmdBonjour
            // 
            this.cmdBonjour.Location = new System.Drawing.Point(95, 232);
            this.cmdBonjour.Name = "cmdBonjour";
            this.cmdBonjour.Size = new System.Drawing.Size(75, 23);
            this.cmdBonjour.TabIndex = 13;
            this.cmdBonjour.Text = "Bonjour";
            this.cmdBonjour.UseVisualStyleBackColor = true;
            this.cmdBonjour.Click += new System.EventHandler(this.cmdBonjour_Click);
            // 
            // lblCrea
            // 
            this.lblCrea.AutoSize = true;
            this.lblCrea.Location = new System.Drawing.Point(52, 362);
            this.lblCrea.Name = "lblCrea";
            this.lblCrea.Size = new System.Drawing.Size(0, 13);
            this.lblCrea.TabIndex = 15;
            // 
            // frmCalcul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 431);
            this.Controls.Add(this.lblCrea);
            this.Controls.Add(this.cmdBonjour);
            this.Controls.Add(this.btn4val);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.btn3val);
            this.Controls.Add(this.btnAdditionDblNewPar2);
            this.Controls.Add(this.btnAdditionDblNew);
            this.Controls.Add(this.btnAdditionDblPar2);
            this.Controls.Add(this.btnAdditionPar2);
            this.Controls.Add(this.cmdAdditionDbl);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Name = "frmCalcul";
            this.Text = "Calcul";
            this.Load += new System.EventHandler(this.frmCalcul_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button cmdAdditionDbl;
        private System.Windows.Forms.Button btnAdditionPar2;
        private System.Windows.Forms.Button btnAdditionDblPar2;
        private System.Windows.Forms.Button btnAdditionDblNew;
        private System.Windows.Forms.Button btnAdditionDblNewPar2;
        private System.Windows.Forms.Button btn3val;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Button btn4val;
        private System.Windows.Forms.Button cmdBonjour;
        private System.Windows.Forms.Label lblCrea;
    }
}

