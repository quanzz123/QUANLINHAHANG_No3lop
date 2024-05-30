using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLINHAHANG
{
    public partial class fmenu : Form
    {
        private ListView listView1;
        private ImageList imageList1;
        private DataServices myDataServices;
        public fmenu()
        {
            InitializeComponent();

        }
        private void LoadImagesFromDatabaseToListView()
        {
           /* // Khởi tạo DataServices
            myDataServices = new DataServices();

            // Lấy dữ liệu hình ảnh từ cơ sở dữ liệu
            string ssql = "SELECT AnhMonAn FROM dbo.MENU"; // Thay YourTable và ImageColumn bằng tên bảng và cột hình ảnh của bạn
            DataTable dtImages = myDataServices.RunQuery(ssql);

            // Thêm hình ảnh vào ImageList
            foreach (DataRow row in dtImages.Rows)
            {
                if (row["AnhMonAn"] != DBNull.Value)
                {
                    byte[] imageData = (byte[])row["AnhMonAn"];
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        Image img = Image.FromStream(ms);
                        imageList1.Images.Add(img);
                    }
                }
            }

            // Gán ImageList cho ListView
            lsvImageFood.LargeImageList = imageList1;*/
        }

        private void menu_Load(object sender, EventArgs e)
        {
            
        }

        private void btnViewListFood_Click(object sender, EventArgs e)
        {
            //1.tạo đối tượng DataServices
            myDataServices = new DataServices();
            //2.định nghĩa câu lệnh sql
            string ssql = "select TenMon, AnhMonAn, Gia from MENU";
            // đưa dữ liệu bảng lên datatable
            DataTable dtFood = myDataServices.RunQuery(ssql);

            //4.duyệt từng dòng trong DataTable
            foreach (DataRow row in dtFood.Rows)
            {
                //tạo một buton mội khi duyệt qua mộ dòng
                Button buton = new Button();
                buton.Size = new Size(120, 120);
                if (row["AnhMonAn"] != null)
                {
                    //ép kiểu từ kiểu object sang mảng byte
                    byte[] imageData = (byte[])row["AnhMonAn"];
                    //là một luồng(stream) sử dụng dữ liệu trong bộ nhớ 
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        // tạo đội tượng Image, đọc dữ  liệu từ luồng bằng FromStream 
                        Image img = Image.FromStream(ms);
                        // thiết lập cách hiển thị hình ảnh của nut, stretch lập đầy vùng nền của nút
                        buton.BackgroundImageLayout = ImageLayout.Stretch;
                        //thiết lập ảnh nền cho nnút
                        buton.BackgroundImage = img;
                    }
                }
                Panel pan = new Panel();
                pan.Size = new Size(120, 160);
                Label label = new Label();
                label.Size = new Size(120, 40);
                label.Text = (string)row["TenMon"];
                label.Font = new Font(pan.Font.FontFamily, 9);
                label.TextAlign = ContentAlignment.TopCenter;
                label.BackColor = Color.Violet;

                Label labelGia = new Label();
                labelGia.Size = new Size(120, 20);
                labelGia.Text = ((decimal)row["Gia"]).ToString("C");
                labelGia.Font = new Font(pan.Font.FontFamily, 9);
                labelGia.TextAlign = ContentAlignment.MiddleCenter;
                labelGia.BackColor = Color.LightYellow;

                /*pan.Controls.Add(labelGia); // Thêm nhãn giá trước để nó nằm dưới
                labelGia.Dock = DockStyle.Bottom;

                pan.Controls.Add(buton);
                buton.Dock = DockStyle.Top;
                pan.Controls.Add(label);
                label.Dock = DockStyle.Bottom;*/

                // Thêm các điều khiển vào panel
               

                pan.Controls.Add(label); // Thêm nhãn tên món vào giữa
                label.Dock = DockStyle.Bottom;

                pan.Controls.Add(labelGia); // Thêm nhãn giá trước để nó nằm dưới
                labelGia.Dock = DockStyle.Bottom;

                pan.Controls.Add(buton); // Thêm nút vào panel
                buton.Dock = DockStyle.Top;

                // Thêm panel vào form hoặc container chính của bạn
                this.Controls.Add(pan);
                pan.Dock = DockStyle.Top;



                flowLayoutPanel1.Controls.Add(pan);
            }
        }
    }
}
