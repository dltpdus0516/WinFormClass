namespace WinFormProjectTest
{
    partial class Form3
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
            this.btnpdClear = new System.Windows.Forms.Button();
            this.btnpdDelete = new System.Windows.Forms.Button();
            this.btnpdUpdate = new System.Windows.Forms.Button();
            this.btnpdInsert = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtpdname = new System.Windows.Forms.TextBox();
            this.txtinv = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtman = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnpdClear
            // 
            this.btnpdClear.Location = new System.Drawing.Point(420, 208);
            this.btnpdClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnpdClear.Name = "btnpdClear";
            this.btnpdClear.Size = new System.Drawing.Size(214, 32);
            this.btnpdClear.TabIndex = 18;
            this.btnpdClear.Text = "텍스트 박스 내용 지우기";
            this.btnpdClear.UseVisualStyleBackColor = true;
            this.btnpdClear.Click += new System.EventHandler(this.btnpdClear_Click);
            // 
            // btnpdDelete
            // 
            this.btnpdDelete.Location = new System.Drawing.Point(420, 160);
            this.btnpdDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnpdDelete.Name = "btnpdDelete";
            this.btnpdDelete.Size = new System.Drawing.Size(214, 32);
            this.btnpdDelete.TabIndex = 17;
            this.btnpdDelete.Text = "Delete";
            this.btnpdDelete.UseVisualStyleBackColor = true;
            this.btnpdDelete.Click += new System.EventHandler(this.btnpdDelete_Click);
            // 
            // btnpdUpdate
            // 
            this.btnpdUpdate.Location = new System.Drawing.Point(420, 114);
            this.btnpdUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnpdUpdate.Name = "btnpdUpdate";
            this.btnpdUpdate.Size = new System.Drawing.Size(214, 32);
            this.btnpdUpdate.TabIndex = 16;
            this.btnpdUpdate.Text = "Update";
            this.btnpdUpdate.UseVisualStyleBackColor = true;
            this.btnpdUpdate.Click += new System.EventHandler(this.btnpdUpdate_Click);
            // 
            // btnpdInsert
            // 
            this.btnpdInsert.Location = new System.Drawing.Point(420, 68);
            this.btnpdInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnpdInsert.Name = "btnpdInsert";
            this.btnpdInsert.Size = new System.Drawing.Size(214, 32);
            this.btnpdInsert.TabIndex = 15;
            this.btnpdInsert.Text = "Insert";
            this.btnpdInsert.UseVisualStyleBackColor = true;
            this.btnpdInsert.Click += new System.EventHandler(this.btnpdInsert_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(99, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(417, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Selected Row in Mart Database 제품 Table";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtman);
            this.panel1.Controls.Add(this.txtprice);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtpdname);
            this.panel1.Controls.Add(this.txtinv);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtnumber);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(21, 59);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 194);
            this.panel1.TabIndex = 13;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(32, 148);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 15);
            this.label17.TabIndex = 53;
            this.label17.Text = "제조업체";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(62, 118);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 15);
            this.label15.TabIndex = 52;
            this.label15.Text = "단가";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(47, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 15);
            this.label13.TabIndex = 48;
            this.label13.Text = "재고량";
            // 
            // txtpdname
            // 
            this.txtpdname.Location = new System.Drawing.Point(105, 52);
            this.txtpdname.Name = "txtpdname";
            this.txtpdname.Size = new System.Drawing.Size(239, 25);
            this.txtpdname.TabIndex = 44;
            // 
            // txtinv
            // 
            this.txtinv.Location = new System.Drawing.Point(105, 83);
            this.txtinv.Name = "txtinv";
            this.txtinv.Size = new System.Drawing.Size(239, 25);
            this.txtinv.TabIndex = 47;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(47, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 15);
            this.label12.TabIndex = 43;
            this.label12.Text = "제품명";
            // 
            // txtnumber
            // 
            this.txtnumber.Location = new System.Drawing.Point(105, 21);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(239, 25);
            this.txtnumber.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 41;
            this.label11.Text = "제품번호";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(105, 115);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(239, 25);
            this.txtprice.TabIndex = 54;
            // 
            // txtman
            // 
            this.txtman.Location = new System.Drawing.Point(105, 148);
            this.txtman.Name = "txtman";
            this.txtman.Size = new System.Drawing.Size(239, 25);
            this.txtman.TabIndex = 55;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 278);
            this.Controls.Add(this.btnpdClear);
            this.Controls.Add(this.btnpdDelete);
            this.Controls.Add(this.btnpdUpdate);
            this.Controls.Add(this.btnpdInsert);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnpdClear;
        private System.Windows.Forms.Button btnpdDelete;
        private System.Windows.Forms.Button btnpdUpdate;
        private System.Windows.Forms.Button btnpdInsert;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtpdname;
        private System.Windows.Forms.TextBox txtinv;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtman;
        private System.Windows.Forms.TextBox txtprice;
    }
}