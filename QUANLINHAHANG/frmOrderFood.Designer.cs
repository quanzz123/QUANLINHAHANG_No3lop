
namespace QUANLINHAHANG
{
    partial class frmOrderFood
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
            this.btnSearchFood = new System.Windows.Forms.Button();
            this.btnMakeFood = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvOrderFood = new System.Windows.Forms.DataGridView();
            this.txtSearchfood = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.lable_day = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.elipseControl1 = new ElipseControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderFood)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSearchFood);
            this.panel1.Controls.Add(this.btnMakeFood);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.dgvOrderFood);
            this.panel1.Controls.Add(this.txtSearchfood);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1033, 603);
            this.panel1.TabIndex = 0;
            // 
            // btnSearchFood
            // 
            this.btnSearchFood.BackColor = System.Drawing.Color.DarkBlue;
            this.btnSearchFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchFood.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearchFood.Location = new System.Drawing.Point(467, 20);
            this.btnSearchFood.Name = "btnSearchFood";
            this.btnSearchFood.Size = new System.Drawing.Size(93, 32);
            this.btnSearchFood.TabIndex = 6;
            this.btnSearchFood.Text = "Tìm";
            this.btnSearchFood.UseVisualStyleBackColor = false;
            this.btnSearchFood.Click += new System.EventHandler(this.btnSearchFood_Click);
            // 
            // btnMakeFood
            // 
            this.btnMakeFood.BackColor = System.Drawing.Color.DarkBlue;
            this.btnMakeFood.ForeColor = System.Drawing.Color.White;
            this.btnMakeFood.Location = new System.Drawing.Point(920, 519);
            this.btnMakeFood.Name = "btnMakeFood";
            this.btnMakeFood.Size = new System.Drawing.Size(100, 36);
            this.btnMakeFood.TabIndex = 5;
            this.btnMakeFood.Text = "Chế Biến";
            this.btnMakeFood.UseVisualStyleBackColor = false;
            this.btnMakeFood.Click += new System.EventHandler(this.btnMakeFood_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.DarkBlue;
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(708, 519);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 36);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Xoá món";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkBlue;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(596, 519);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 36);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm món";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvOrderFood
            // 
            this.dgvOrderFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderFood.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvOrderFood.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrderFood.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvOrderFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderFood.GridColor = System.Drawing.Color.White;
            this.dgvOrderFood.Location = new System.Drawing.Point(596, 127);
            this.dgvOrderFood.Name = "dgvOrderFood";
            this.dgvOrderFood.RowHeadersVisible = false;
            this.dgvOrderFood.RowHeadersWidth = 51;
            this.dgvOrderFood.RowTemplate.Height = 24;
            this.dgvOrderFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderFood.Size = new System.Drawing.Size(434, 350);
            this.dgvOrderFood.TabIndex = 4;
            this.dgvOrderFood.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderFood_CellClick);
            // 
            // txtSearchfood
            // 
            this.txtSearchfood.Location = new System.Drawing.Point(23, 20);
            this.txtSearchfood.Multiline = true;
            this.txtSearchfood.Name = "txtSearchfood";
            this.txtSearchfood.Size = new System.Drawing.Size(274, 32);
            this.txtSearchfood.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkBlue;
            this.panel2.Controls.Add(this.cbTable);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label_date);
            this.panel2.Controls.Add(this.lable_day);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(596, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 100);
            this.panel2.TabIndex = 1;
            // 
            // cbTable
            // 
            this.cbTable.BackColor = System.Drawing.Color.White;
            this.cbTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTable.ForeColor = System.Drawing.Color.DarkBlue;
            this.cbTable.FormattingEnabled = true;
            this.cbTable.Location = new System.Drawing.Point(339, 17);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(67, 24);
            this.cbTable.TabIndex = 8;
            this.cbTable.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(286, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bàn";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.ForeColor = System.Drawing.Color.White;
            this.label_date.Location = new System.Drawing.Point(108, 51);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(53, 20);
            this.label_date.TabIndex = 5;
            this.label_date.Text = "label4";
            // 
            // lable_day
            // 
            this.lable_day.AutoSize = true;
            this.lable_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_day.ForeColor = System.Drawing.Color.White;
            this.lable_day.Location = new System.Drawing.Point(27, 51);
            this.lable_day.Name = "lable_day";
            this.lable_day.Size = new System.Drawing.Size(53, 20);
            this.lable_day.TabIndex = 6;
            this.lable_day.Text = "label4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Order";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(27, 74);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(563, 529);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkBlue;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(814, 519);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 36);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Huỷ gọi";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // elipseControl1
            // 
            this.elipseControl1.BottomLeft = false;
            this.elipseControl1.BottomRight = false;
            this.elipseControl1.CornerRadius = 30;
            this.elipseControl1.TargetControl = this.panel2;
            this.elipseControl1.TopLeft = true;
            this.elipseControl1.TopRight = true;
            // 
            // frmOrderFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1057, 627);
            this.Controls.Add(this.panel1);
            this.Name = "frmOrderFood";
            this.Text = "frmOrderFood";
            this.Load += new System.EventHandler(this.frmOrderFood_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderFood)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvOrderFood;
        private System.Windows.Forms.TextBox txtSearchfood;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ElipseControl elipseControl1;
        private System.Windows.Forms.Button btnMakeFood;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearchFood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label lable_day;
        private System.Windows.Forms.ComboBox cbTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
    }
}