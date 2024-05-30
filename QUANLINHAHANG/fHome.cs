using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLINHAHANG
{
    public partial class fHome : Form
    {
        public fHome()
        {
            InitializeComponent();
        }
        private Form CurrentFormChild;

        private void OpenChildForm(Form childForm)
        {
            if(CurrentFormChild != null)
            {
                CurrentFormChild.Close();
            }
            CurrentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnBody.Controls.Add(childForm);
            pnBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void íconbtnmenu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmOrderFood());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDatmon());
        }

        private void fHome_Load(object sender, EventArgs e)
        {
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.PlaneLock;
        }
    }
}
