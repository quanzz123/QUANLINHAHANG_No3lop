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
    public partial class FDatmon : Form
    {
        //khai báo lớp dataseviecs
        private DataServices myDataSevices;
        public FDatmon()
        {
            InitializeComponent();
        }

        private void dgvListFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearchFoodName_Click(object sender, EventArgs e)
        {
            // Kiểm tra myDataSevices không null
            if (myDataSevices != null)
            {
                string sSql = "select TenMon as N'Tên Món',Gia as N'Giá' from dbo.MENU where TenMon like N'%"+ txtfoodName.Text+"%'";
                DataTable dtFood = myDataSevices.RunQuery(sSql);
                dgvListFood.DataSource = dtFood;
            }
            else
            {
                MessageBox.Show("DataServices object is not initialized.");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FDatmon_Load(object sender, EventArgs e)
        {
            myDataSevices = new DataServices();
            DateTime d = DateTime.Now;
            lable_day.Text = d.ToString("dddd");
            label_date.Text = d.ToString("dd/MM/yyyy");
            laydulieuTable();
        }

        private void btnSearchTable_Click(object sender, EventArgs e)
        {
            string ssql = "select soban as N'Số bàn', TrangThai as N'Trạng thái' from dbo.BAN";
            DataTable dtTable = myDataSevices.RunQuery(ssql);
            
            dgvTablelist.DataSource = dtTable;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void laydulieuTable()
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
         
        }


        private void dgvTablelist_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            int r = dgvTablelist.CurrentRow.Index;
            string soban = dgvTablelist.Rows[r].Cells[0].Value.ToString();
            label_table.Text = soban;
            string ssql = "exec getbillbyTable " + soban + "";
            DataTable dtbill = myDataSevices.RunQuery(ssql);
            dgvbill.DataSource = dtbill;

            // tính tôngr tiền
            decimal tong = 0;
            foreach(DataRow row in dtbill.Rows)
            {
                if(row["Thành tiền"] != null)
                {
                    tong += Convert.ToDecimal(row["Thành tiền"]);
                }
            }
            txtTotal.Text = tong.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
