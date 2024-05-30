
namespace QUANLINHAHANG
{
    partial class fmenu
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnViewListFood = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(577, 549);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnViewListFood
            // 
            this.btnViewListFood.Location = new System.Drawing.Point(656, 205);
            this.btnViewListFood.Name = "btnViewListFood";
            this.btnViewListFood.Size = new System.Drawing.Size(174, 136);
            this.btnViewListFood.TabIndex = 1;
            this.btnViewListFood.Text = "xem";
            this.btnViewListFood.UseVisualStyleBackColor = true;
            this.btnViewListFood.Click += new System.EventHandler(this.btnViewListFood_Click);
            // 
            // fmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 605);
            this.Controls.Add(this.btnViewListFood);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "fmenu";
            this.Text = "menu";
            this.Load += new System.EventHandler(this.menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnViewListFood;
    }
}