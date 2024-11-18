using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscapeRun2
{
    public partial class FormCreate : Form
    {
        private Form1 parentForm;
        private FormGame parentForm1;
        public FormCreate(Form1 parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            lblName.Text = txtName.Text;
            if (rBtnM.Checked
                && cBoxRole.SelectedItem != null
                && cBoxRole.SelectedItem.ToString() == "Knight")
            {
                pbChar.Image = Properties.Resources.knight;
            }
            else if (rBtnM.Checked
                     && cBoxRole.SelectedItem != null
                     && cBoxRole.SelectedItem.ToString() == "human")
            {
                pbChar.Image = Properties.Resources.boy;
            }
            else if (rBtnF.Checked
                     && cBoxRole.SelectedItem != null
                     && cBoxRole.SelectedItem.ToString() == "human")
            {
                pbChar.Image = Properties.Resources.girl;
            }
            else if (rBtnF.Checked
                     && cBoxRole.SelectedItem != null
                     && cBoxRole.SelectedItem.ToString() == "Knight")
            {
                pbChar.Image = Properties.Resources.dame;
            }

            if (string.IsNullOrEmpty(lblName.Text) || gBoxGender == null || cBoxRole.SelectedItem == null)
            {
                MessageBox.Show("Please fill all required fields to continue.");
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (pbChar.Image == Properties.Resources.nullis && lblName.Text == "")
            {
                MessageBox.Show("Please generate a character to enter.");
            }
            else
            {
                parentForm1.Show();
                this.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Close();
        }
    }
}
