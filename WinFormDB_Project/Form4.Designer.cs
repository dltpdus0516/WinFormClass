namespace WinFormDB_Project
{
    partial class Form4
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
            this.btn주문Clear = new System.Windows.Forms.Button();
            this.주문_Delete = new System.Windows.Forms.Button();
            this.주문_Update = new System.Windows.Forms.Button();
            this.주문_Insert = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtdelivery = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtodproduct = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtclient = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtodnum = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn주문Clear
            // 
            this.btn주문Clear.Location = new System.Drawing.Point(418, 226);
            this.btn주문Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn주문Clear.Name = "btn주문Clear";
            this.btn주문Clear.Size = new System.Drawing.Size(214, 32);
            this.btn주문Clear.TabIndex = 24;
            this.btn주문Clear.Text = "텍스트 박스 내용 지우기";
            this.btn주문Clear.UseVisualStyleBackColor = true;
            this.btn주문Clear.Click += new System.EventHandler(this.btn주문Clear_Click);
            // 
            // 주문_Delete
            // 
            this.주문_Delete.Location = new System.Drawing.Point(418, 178);
            this.주문_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.주문_Delete.Name = "주문_Delete";
            this.주문_Delete.Size = new System.Drawing.Size(214, 32);
            this.주문_Delete.TabIndex = 23;
            this.주문_Delete.Text = "Delete";
            this.주문_Delete.UseVisualStyleBackColor = true;
            this.주문_Delete.Click += new System.EventHandler(this.주문_Delete_Click);
            // 
            // 주문_Update
            // 
            this.주문_Update.Location = new System.Drawing.Point(418, 132);
            this.주문_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.주문_Update.Name = "주문_Update";
            this.주문_Update.Size = new System.Drawing.Size(214, 32);
            this.주문_Update.TabIndex = 22;
            this.주문_Update.Text = "Update";
            this.주문_Update.UseVisualStyleBackColor = true;
            this.주문_Update.Click += new System.EventHandler(this.주문_Update_Click);
            // 
            // 주문_Insert
            // 
            this.주문_Insert.Location = new System.Drawing.Point(418, 86);
            this.주문_Insert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.주문_Insert.Name = "주문_Insert";
            this.주문_Insert.Size = new System.Drawing.Size(214, 32);
            this.주문_Insert.TabIndex = 21;
            this.주문_Insert.Text = "Insert";
            this.주문_Insert.UseVisualStyleBackColor = true;
            this.주문_Insert.Click += new System.EventHandler(this.주문_Insert_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(98, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(417, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Selected Row in Mart Database 주문 Table";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtdate);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.txtdelivery);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.txtodproduct);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.txtclient);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.txtodnum);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Location = new System.Drawing.Point(20, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 231);
            this.panel1.TabIndex = 19;
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(105, 183);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(239, 25);
            this.txtdate.TabIndex = 53;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(32, 186);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(67, 15);
            this.label25.TabIndex = 52;
            this.label25.Text = "주문일자";
            // 
            // txtdelivery
            // 
            this.txtdelivery.Location = new System.Drawing.Point(105, 152);
            this.txtdelivery.Name = "txtdelivery";
            this.txtdelivery.Size = new System.Drawing.Size(239, 25);
            this.txtdelivery.TabIndex = 59;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(47, 155);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(52, 15);
            this.label24.TabIndex = 58;
            this.label24.Text = "배송지";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(62, 125);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(37, 15);
            this.label22.TabIndex = 57;
            this.label22.Text = "수량";
            // 
            // txtodproduct
            // 
            this.txtodproduct.Location = new System.Drawing.Point(105, 90);
            this.txtodproduct.Name = "txtodproduct";
            this.txtodproduct.Size = new System.Drawing.Size(239, 25);
            this.txtodproduct.TabIndex = 51;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(105, 121);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(239, 25);
            this.txtQuantity.TabIndex = 56;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(32, 93);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 15);
            this.label21.TabIndex = 50;
            this.label21.Text = "주문제품";
            // 
            // txtclient
            // 
            this.txtclient.Location = new System.Drawing.Point(105, 56);
            this.txtclient.Name = "txtclient";
            this.txtclient.Size = new System.Drawing.Size(239, 25);
            this.txtclient.TabIndex = 49;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(32, 59);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 15);
            this.label20.TabIndex = 48;
            this.label20.Text = "주문고객";
            // 
            // txtodnum
            // 
            this.txtodnum.Location = new System.Drawing.Point(105, 23);
            this.txtodnum.Name = "txtodnum";
            this.txtodnum.Size = new System.Drawing.Size(239, 25);
            this.txtodnum.TabIndex = 47;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(32, 26);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 15);
            this.label19.TabIndex = 46;
            this.label19.Text = "주문번호";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 314);
            this.Controls.Add(this.btn주문Clear);
            this.Controls.Add(this.주문_Delete);
            this.Controls.Add(this.주문_Update);
            this.Controls.Add(this.주문_Insert);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn주문Clear;
        private System.Windows.Forms.Button 주문_Delete;
        private System.Windows.Forms.Button 주문_Update;
        private System.Windows.Forms.Button 주문_Insert;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtdelivery;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtodproduct;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtclient;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtodnum;
        private System.Windows.Forms.Label label19;
    }
}