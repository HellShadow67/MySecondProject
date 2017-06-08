using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CsAddition
{
    public partial class frmCalcul : Form   //héritage
    {
        calc unCalcul;
        calcPar2 unCalculPar2;
        calc unCalculNew;
        calcPar2 unCalculNewPar2;

        public frmCalcul()
        {
            InitializeComponent();
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            lblResultat.Text = unCalcul.addition(txtA.Text, txtB.Text);
        }

        private void frmCalcul_Load(object sender, EventArgs e)
        {
            unCalcul = new calc();
            unCalculPar2 = new calcPar2();
            
        }

        private void cmdAdditionDbl_Click(object sender, EventArgs e)
        {
            lblResultat.Text = Convert.ToString(unCalcul.addition(Convert.ToDouble(txtA.Text), Convert.ToDouble(txtB.Text)));
        }

        private void btnAdditionPar2_Click(object sender, EventArgs e)
        {
            lblResultat.Text = unCalculPar2.addition(txtA.Text, txtB.Text);
        }

        private void btnAdditionDblPar2_Click(object sender, EventArgs e)
        {
            lblResultat.Text = Convert.ToString(unCalculPar2.addition(Convert.ToDouble(txtA.Text), Convert.ToDouble(txtB.Text)));
        }

        private void btnAdditionDblNew_Click(object sender, EventArgs e)
        {
            unCalculNew = new calc(Convert.ToDouble(txtA.Text), Convert.ToDouble(txtB.Text));
            lblResultat.Text = Convert.ToString(unCalculNew.addition());
        }

        private void btnAdditionDblNewPar2_Click(object sender, EventArgs e)
        {
            unCalculNewPar2 = new calcPar2(Convert.ToDouble(txtA.Text), Convert.ToDouble(txtB.Text));
            lblResultat.Text = Convert.ToString(unCalculNewPar2.addition());
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn3val_Click(object sender, EventArgs e)
        {
            lblResultat.Text = Convert.ToString(unCalcul.addition(Convert.ToDouble(txtA.Text), Convert.ToDouble(txtB.Text), Convert.ToDouble(txtc.Text)));
        }

        private void btn4val_Click(object sender, EventArgs e)
        {
            lblResultat.Text = Convert.ToString(unCalcul.addition(Convert.ToDouble(txtA.Text), Convert.ToDouble(txtB.Text), Convert.ToDouble(txtc.Text), Convert.ToDouble(txt4.Text)));
        }

        private void cmdBonjour_Click(object sender, EventArgs e)
        {
            MessageBox.Show(unCalcul.disBonjour());
        }


       
    }
}
