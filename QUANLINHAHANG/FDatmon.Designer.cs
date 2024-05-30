
namespace QUANLINHAHANG
{
    partial class FDatmon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnView = new System.Windows.Forms.Button();
            this.dgvTablelist = new System.Windows.Forms.DataGridView();
            this.btnSearchTable = new System.Windows.Forms.Button();
            this.btnSearchFoodName = new System.Windows.Forms.Button();
            this.txtfoodName = new System.Windows.Forms.TextBox();
            this.dgvListFood = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label_table = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddnew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.dgvbill = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.lable_day = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.elipseControl1 = new ElipseControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablelist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListFood)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbill)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Controls.Add(this.dgvTablelist);
            this.panel1.Controls.Add(this.btnSearchTable);
            this.panel1.Controls.Add(this.btnSearchFoodName);
            this.panel1.Controls.Add(this.txtfoodName);
            this.panel1.Controls.Add(this.dgvListFood);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 693);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(325, 450);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(137, 46);
            this.btnView.TabIndex = 5;
            this.btnView.Text = "Xem";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // dgvTablelist
            // 
            this.dgvTablelist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTablelist.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTablelist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTablelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablelist.Location = new System.Drawing.Point(14, 522);
            this.dgvTablelist.Name = "dgvTablelist";
            this.dgvTablelist.RowHeadersVisible = false;
            this.dgvTablelist.RowHeadersWidth = 51;
            this.dgvTablelist.RowTemplate.Height = 24;
            this.dgvTablelist.Size = new System.Drawing.Size(459, 168);
            this.dgvTablelist.TabIndex = 3;
            this.dgvTablelist.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTablelist_RowEnter);
            // 
            // btnSearchTable
            // 
            this.btnSearchTable.Location = new System.Drawing.Point(14, 450);
            this.btnSearchTable.Name = "btnSearchTable";
            this.btnSearchTable.Size = new System.Drawing.Size(157, 46);
            this.btnSearchTable.TabIndex = 2;
            this.btnSearchTable.Text = "Tìm";
            this.btnSearchTable.UseVisualStyleBackColor = true;
            this.btnSearchTable.Click += new System.EventHandler(this.btnSearchTable_Click);
            // 
            // btnSearchFoodName
            // 
            this.btnSearchFoodName.Location = new System.Drawing.Point(288, 24);
            this.btnSearchFoodName.Name = "btnSearchFoodName";
            this.btnSearchFoodName.Size = new System.Drawing.Size(141, 23);
            this.btnSearchFoodName.TabIndex = 2;
            this.btnSearchFoodName.Text = "Tìm";
            this.btnSearchFoodName.UseVisualStyleBackColor = true;
            this.btnSearchFoodName.Click += new System.EventHandler(this.btnSearchFoodName_Click);
            // 
            // txtfoodName
            // 
            this.txtfoodName.Location = new System.Drawing.Point(14, 25);
            this.txtfoodName.Name = "txtfoodName";
            this.txtfoodName.Size = new System.Drawing.Size(225, 22);
            this.txtfoodName.TabIndex = 1;
            // 
            // dgvListFood
            // 
            this.dgvListFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListFood.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvListFood.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListFood.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvListFood.Location = new System.Drawing.Point(9, 65);
            this.dgvListFood.Name = "dgvListFood";
            this.dgvListFood.RowHeadersVisible = false;
            this.dgvListFood.RowHeadersWidth = 51;
            this.dgvListFood.RowTemplate.Height = 24;
            this.dgvListFood.Size = new System.Drawing.Size(462, 343);
            this.dgvListFood.TabIndex = 0;
            this.dgvListFood.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListFood_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(478, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Đặt";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label_date);
            this.panel3.Controls.Add(this.lable_day);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label_table);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(576, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(546, 119);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(25, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "New Order";
            // 
            // label_table
            // 
            this.label_table.AutoSize = true;
            this.label_table.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_table.ForeColor = System.Drawing.Color.Transparent;
            this.label_table.Location = new System.Drawing.Point(450, 19);
            this.label_table.Name = "label_table";
            this.label_table.Size = new System.Drawing.Size(0, 24);
            this.label_table.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(379, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bàn";
            // 
            // btnAddnew
            // 
            this.btnAddnew.Location = new System.Drawing.Point(551, 612);
            this.btnAddnew.Name = "btnAddnew";
            this.btnAddnew.Size = new System.Drawing.Size(103, 79);
            this.btnAddnew.TabIndex = 3;
            this.btnAddnew.Text = "Thêm mới";
            this.btnAddnew.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(687, 612);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(103, 79);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(824, 612);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(103, 79);
            this.btnPay.TabIndex = 3;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(979, 612);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(103, 79);
            this.button6.TabIndex = 3;
            this.button6.Text = "Huỷ";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(335, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tổng";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Location = new System.Drawing.Point(383, 11);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(160, 15);
            this.txtTotal.TabIndex = 5;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // dgvbill
            // 
            this.dgvbill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvbill.BackgroundColor = System.Drawing.Color.White;
            this.dgvbill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvbill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvbill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbill.Location = new System.Drawing.Point(3, 40);
            this.dgvbill.Name = "dgvbill";
            this.dgvbill.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvbill.RowHeadersVisible = false;
            this.dgvbill.RowHeadersWidth = 51;
            this.dgvbill.RowTemplate.Height = 24;
            this.dgvbill.Size = new System.Drawing.Size(540, 372);
            this.dgvbill.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvbill);
            this.panel2.Location = new System.Drawing.Point(576, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(546, 415);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(478, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "Huỷ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // lable_day
            // 
            this.lable_day.AutoSize = true;
            this.lable_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_day.ForeColor = System.Drawing.Color.White;
            this.lable_day.Location = new System.Drawing.Point(27, 58);
            this.lable_day.Name = "lable_day";
            this.lable_day.Size = new System.Drawing.Size(53, 20);
            this.lable_day.TabIndex = 4;
            this.lable_day.Text = "label4";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.ForeColor = System.Drawing.Color.White;
            this.label_date.Location = new System.Drawing.Point(94, 58);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(53, 20);
            this.label_date.TabIndex = 4;
            this.label_date.Text = "label4";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.txtTotal);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(576, 506);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(546, 66);
            this.panel4.TabIndex = 6;
            // 
            // elipseControl1
            // 
            this.elipseControl1.BottomLeft = false;
            this.elipseControl1.BottomRight = false;
            this.elipseControl1.CornerRadius = 30;
            this.elipseControl1.TargetControl = this.panel3;
            this.elipseControl1.TopLeft = true;
            this.elipseControl1.TopRight = true;
            // 
            // FDatmon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 734);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddnew);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FDatmon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FDatmon";
            this.Load += new System.EventHandler(this.FDatmon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablelist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListFood)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbill)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvListFood;
        private System.Windows.Forms.Button btnSearchFoodName;
        private System.Windows.Forms.TextBox txtfoodName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvTablelist;
        private System.Windows.Forms.Button btnSearchTable;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAddnew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotal;
        private ElipseControl elipseControl1;
        private System.Windows.Forms.DataGridView dgvbill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label label_table;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lable_day;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Panel panel4;
    }
}