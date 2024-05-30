using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QUANLINHAHANG
{
    public partial class frmOrderFood : Form
    {
        private DataServices myDataServices;
        private string clickedButton;
        private string namefood;
        private string temon;
        DataTable dtiamgefood;
        private DataTable dtfood;

        public frmOrderFood()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            myDataServices = new DataServices();
            string sSql = "select TenMon, AnhMonAn, Gia from MENU ";
            dtiamgefood = new DataTable();
            dtiamgefood = myDataServices.RunQuery(sSql);

            foreach(DataRow row in dtiamgefood.Rows)
            {
                Button buton = new Button();
                buton.Size = new Size(120, 120);
                //xử lí sự kiện mõi lần  click
                buton.Click += Buton_Click;
                // thuộc tính tag trả về giá trị là object, gán giá trị cột cho tag
                buton.Tag = row;
                if(row["AnhMonAn"] != null)
                {
                    byte[] imagedata = (byte[])row["AnhMonAn"];
                    using (MemoryStream ms = new MemoryStream(imagedata))
                    {
                        Image img = Image.FromStream(ms);
                        buton.BackgroundImageLayout = ImageLayout.Stretch;
                        buton.BackgroundImage = img;
                    }

                }

                //tạo một pannel
                Panel pan = new Panel();
                pan.Size = new Size(120, 160);
                pan.BorderStyle = BorderStyle.None;
                

                //tạo một nhãn  chứa tên món
                Label lablTenmon = new Label();
                lablTenmon.Size = new Size(120, 40);
                lablTenmon.Text = (string)row["TenMon"];
                //
                lablTenmon.Font = new Font(pan.Font.FontFamily, 9);
                //Căn giữa văn bản theo chiều ngang
                lablTenmon.TextAlign = ContentAlignment.TopCenter;
                lablTenmon.BackColor = Color.White;

                //thêm nhãn ten món ăn vào pannel
                pan.Controls.Add(lablTenmon);
                //vại trí phía dưới của panel
                lablTenmon.Dock = DockStyle.Bottom;

                //thêm nút vào panel
                pan.Controls.Add(buton);
                buton.Dock = DockStyle.Top;
                //hiển thị pan lên layoutflowpanel

                flowLayoutPanel1.Controls.Add(pan);
            }
        }



        #region event
        private void setcontrol( bool edit)
        {
            btnAdd.Enabled = edit;
            if(btnMakeFood.Enabled = !edit)
            {
                btnMakeFood.BackColor = Color.LightGray;
            }
            btnRemove.Enabled = !edit;
            flowLayoutPanel1.Enabled = !edit;
            btnCancel.Enabled = !edit;
            cbTable.Enabled = !edit;
            txtSearchfood.Enabled = !edit;
            
        }
        private void Buton_Click(object sender, EventArgs e)
        {
            myDataServices = new DataServices();
            Button clickedButton = sender as Button;
            DataRow row = clickedButton.Tag as DataRow;
            string tenmon = row["TenMon"].ToString();
            decimal giatien = Convert.ToDecimal(row["Gia"]);
            if(dtfood == null)
            {
                //khởi tạo dt
                dtfood = new DataTable();
                //thêm các cột vào dat

                dtfood.Columns.Add("TenMon", typeof(string));
                dtfood.Columns.Add("Gia", typeof(decimal));
                dtfood.Columns.Add("SoLuong", typeof(int));
                dtfood.Columns.Add("ThanhTien", typeof(decimal));


            }
            // Biến kiểm tra xem món đã tồn tại hay chưa
            bool found = false;
            foreach (DataRow item in dtfood.Rows)
            {
                if ((string)item["TenMon"] == tenmon)
                {
                    int soLuong = (int)item["SoLuong"] + 1;
                    decimal thanhTien = soLuong * giatien;

                    item["SoLuong"] = soLuong;
                    item["ThanhTien"] = thanhTien;

                    found = true;
                    break;
                }
            }

            // Nếu món ăn chưa tồn tại trong DataTable, thêm một hàng mới
            if (!found)
            {
                DataRow newRow = dtfood.NewRow();
                newRow["TenMon"] = tenmon;
                newRow["Gia"] = giatien;
                newRow["SoLuong"] = 1;
                newRow["ThanhTien"] = giatien;

                dtfood.Rows.Add(newRow);
                dgvOrderFood.DataSource = dtfood;
            }
            /*  bool tontai = false;

              }*/
            /* foreach(DataGridViewRow dgv in dgvOrderFood.Rows)
             {
                 if((string)dgv.Cells["TenMon"].Value == tenmon)
                 {
                     int soluong = (int)dgv.Cells["SoLuong"].Value + 1;
                     dgv.Cells["SoLuong"].Value = soluong;
                     dgv.Cells["Gia"].Value = giatien;
                     dgv.Cells["ThanhTien"].Value = soluong * giatien;
                     tontai = true;
                     break;
                 }
             }

             //nếu món ăn đã tòn tại
             if(!tontai)
             {
                 int newRowId = dgvOrderFood.Rows.Add();
                 DataGridViewRow newRow = dgvOrderFood.Rows[newRowId];
                 newRow.Cells["TenMon"].Value = tenmon;
                 newRow.Cells["Gia"].Value = giatien;
                 newRow.Cells["SoLuong"].Value = 1;
                 newRow.Cells["ThanhTien"].Value = giatien;
             }*/

            /* string sql = "select TenMon,Gia from MENU where TenMon = N'" + tenmon + "'";
             //string sql = "select TenMon,Gia from MENU where ";
             DataTable dt = myDataServices.RunQuery(sql);
             dataGridView1.DataSource = dt;*/
        }
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            setcontrol(false);
           

            /*  dgvOrderFood.Columns.Add("TenMon", "Tên Món");
              dgvOrderFood.Columns.Add("Gia", "Giá");
              dgvOrderFood.Columns.Add("SoLuong", "Số Lượng");
              dgvOrderFood.Columns.Add("ThanhTien", "Thành Tiền");*/

            /*dgvOrderFood.Columns["Gia"].ValueType = typeof(decimal);
            dgvOrderFood.Columns["SoLuong"].ValueType = typeof(int);
            dgvOrderFood.Columns["ThanhTien"].ValueType = typeof(decimal);*/


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int r = dgvOrderFood.CurrentRow.Index;
            dgvOrderFood.Rows.RemoveAt(r);
            /* for(int i =0;i< dgvOrderFood.Rows.Count-1; i++)
             {
                 dgvOrderFood.Rows.RemoveAt(i);
             }*//*
            dtfood = null;
            dgvOrderFood.DataSource = null;*/
        }
        private void laydulieuBan()
        {
            string Ssql = "select * from BAN";
            cbTable.DisplayMember = "SoBan";
            cbTable.ValueMember = "SoBan";
            cbTable.DataSource = myDataServices.RunQuery(Ssql);
        }

        private void frmOrderFood_Load(object sender, EventArgs e)
        {
            myDataServices = new DataServices();
            DateTime d = DateTime.Now;
            lable_day.Text = d.ToString("dddd");
            label_date.Text = d.ToString("dd/MM/yyyy");
            laydulieuBan();
            setcontrol(true);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnMakeFood_Click(object sender, EventArgs e)
        {

            /* myDataServices = new DataServices();
             *//*int r = dgvOrderFood.CurrentRow.Index;

             string temon = dgvOrderFood.Rows[r].Cells["TenMon"].Value.ToString();
             //lấy lại mã món
             string Ssql = "select * from MENU where TenMon = N'" + temon + "'";
             DataTable dtmenu = myDataServices.RunQuery(Ssql);
             string MaMon = dtmenu.Rows[0]["MaMon"].ToString();
             string SoLuong = dgvOrderFood.Rows[r].Cells["SoLuong"].Value.ToString();*//*
             //lấy só bàn nằm trên combobox
             //SelectedItem? kiểm tra xem giá trị có bị null
             *//*string SoBan = cbTable.SelectedValue?.ToString();
             int soban2= int.Parse(SoBan);*//*
             // Kiểm tra nếu có mục được chọn

             int soban = Convert.ToInt32(cbTable.SelectedValue);

             foreach (DataGridViewRow row in dgvOrderFood.Rows)
             {

                 if (row.IsNewRow) continue; //bỏ qua hàng mới chưa có dữ liệu
                 string temon = row.Cells[0].Value.ToString();
                 // Lấy mã món từ cơ sở dữ liệu dựa trên tên món
                 string Ssql = "select * from MENU where TenMon = N'" + temon + "'";
                 dtfood = myDataServices.RunQuery(Ssql);
                 string maMon = dtfood.Rows[0]["MaMon"].ToString();


                 int SoLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                 //cập nhật
                 string stringsql = "exec InsertorUpdateintoCHEBIEN '" + maMon + "', " + soban + ", " + SoLuong + "";
                 myDataServices.ExecuteNonQuery(stringsql);

             }


         ///===========================================
         ///
*/
            myDataServices = new DataServices();

            try
            {
                // Kiểm tra nếu có mục được chọn
                if (cbTable.SelectedValue != null)
                {
                    int soban = Convert.ToInt32(cbTable.SelectedValue);

                    foreach (DataGridViewRow row in dgvOrderFood.Rows)
                    {
                        if (row.IsNewRow) continue; // Bỏ qua hàng mới chưa có dữ liệu

                        string temon = row.Cells[0].Value.ToString();
                        // Lấy mã món từ cơ sở dữ liệu dựa trên tên món
                        string Ssql = "select * from MENU where TenMon = N'" + temon + "'";
                        DataTable dtfood = myDataServices.RunQuery(Ssql);
                        if (dtfood.Rows.Count > 0)
                        {
                            string maMon = dtfood.Rows[0]["MaMon"].ToString();
                            int SoLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);

                            // Cập nhật vào cơ sở dữ liệu
                            string stringsql = $"exec InsertorUpdateintoCHEBIEN '{maMon}', {soban}, {SoLuong}";
                            myDataServices.ExecuteNonQuery(stringsql);
                        }
                        else
                        {
                            
                            MessageBox.Show($"Món {temon} không tồn tại trong MENU.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    // Xóa các hàng trên DataGridView sau khi cập nhật xong
                    //dgvOrderFood.Rows.Clear();
                    MessageBox.Show("Đặt Món thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn số bàn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dtfood = null;
            dgvOrderFood.DataSource = null;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            setcontrol(true);
            dtfood = null;
            dgvOrderFood.DataSource = null;
        }

        private void dgvOrderFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
               //dgvOrderFood.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
            
        }
    }
}
