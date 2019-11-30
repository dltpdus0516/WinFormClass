namespace WinFormDB06_Project
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxreverse2 = new System.Windows.Forms.TextBox();
            this.textBoxreverse1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxjob = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxrank = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxage1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxage2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_select = new System.Windows.Forms.Button();
            this.Btn_insert = new System.Windows.Forms.Button();
            this.Btn_clear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Manufacturer = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.price1 = new System.Windows.Forms.TextBox();
            this.productname = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.inventoryvol1 = new System.Windows.Forms.TextBox();
            this.price2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.productnum = new System.Windows.Forms.TextBox();
            this.inventoryvol2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.product_SELECT = new System.Windows.Forms.Button();
            this.product_INSERT = new System.Windows.Forms.Button();
            this.product_CLEAR = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.oddate = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.delivery = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.orderpd = new System.Windows.Forms.TextBox();
            this.Quantity1 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.odclient = new System.Windows.Forms.TextBox();
            this.Quantity2 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.odnum = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.od_select = new System.Windows.Forms.Button();
            this.od_insert = new System.Windows.Forms.Button();
            this.od_clear = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(990, 408);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.Btn_select);
            this.tabPage1.Controls.Add(this.Btn_insert);
            this.tabPage1.Controls.Add(this.Btn_clear);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(982, 379);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "고객";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBoxreverse2);
            this.panel1.Controls.Add(this.textBoxreverse1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBoxjob);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxrank);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxage1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxage2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(587, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 273);
            this.panel1.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(215, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 15);
            this.label9.TabIndex = 31;
            this.label9.Text = "~";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(215, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 15);
            this.label8.TabIndex = 30;
            this.label8.Text = "~";
            // 
            // textBoxreverse2
            // 
            this.textBoxreverse2.Location = new System.Drawing.Point(246, 232);
            this.textBoxreverse2.Name = "textBoxreverse2";
            this.textBoxreverse2.Size = new System.Drawing.Size(98, 25);
            this.textBoxreverse2.TabIndex = 29;
            // 
            // textBoxreverse1
            // 
            this.textBoxreverse1.Location = new System.Drawing.Point(105, 232);
            this.textBoxreverse1.Name = "textBoxreverse1";
            this.textBoxreverse1.Size = new System.Drawing.Size(98, 25);
            this.textBoxreverse1.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 27;
            this.label7.Text = "적립금";
            // 
            // textBoxjob
            // 
            this.textBoxjob.Location = new System.Drawing.Point(105, 201);
            this.textBoxjob.Name = "textBoxjob";
            this.textBoxjob.Size = new System.Drawing.Size(239, 25);
            this.textBoxjob.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "직업";
            // 
            // textBoxrank
            // 
            this.textBoxrank.Location = new System.Drawing.Point(105, 170);
            this.textBoxrank.Name = "textBoxrank";
            this.textBoxrank.Size = new System.Drawing.Size(239, 25);
            this.textBoxrank.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "등급";
            // 
            // textBoxage1
            // 
            this.textBoxage1.Location = new System.Drawing.Point(105, 136);
            this.textBoxage1.Name = "textBoxage1";
            this.textBoxage1.Size = new System.Drawing.Size(98, 25);
            this.textBoxage1.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "나이";
            // 
            // textBoxage2
            // 
            this.textBoxage2.Location = new System.Drawing.Point(246, 136);
            this.textBoxage2.Name = "textBoxage2";
            this.textBoxage2.Size = new System.Drawing.Size(98, 25);
            this.textBoxage2.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "고객이름";
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(105, 105);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(239, 25);
            this.textBoxname.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "고객아이디";
            // 
            // textBoxid
            // 
            this.textBoxid.Location = new System.Drawing.Point(105, 74);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(239, 25);
            this.textBoxid.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20F);
            this.label1.Location = new System.Drawing.Point(102, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 34);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mart.고객";
            // 
            // Btn_select
            // 
            this.Btn_select.Location = new System.Drawing.Point(568, 319);
            this.Btn_select.Name = "Btn_select";
            this.Btn_select.Size = new System.Drawing.Size(131, 42);
            this.Btn_select.TabIndex = 13;
            this.Btn_select.Text = "SELECT";
            this.Btn_select.UseVisualStyleBackColor = true;
            this.Btn_select.Click += new System.EventHandler(this.Btn_select_Click);
            // 
            // Btn_insert
            // 
            this.Btn_insert.Location = new System.Drawing.Point(705, 319);
            this.Btn_insert.Name = "Btn_insert";
            this.Btn_insert.Size = new System.Drawing.Size(131, 42);
            this.Btn_insert.TabIndex = 12;
            this.Btn_insert.Text = "INSERT";
            this.Btn_insert.UseVisualStyleBackColor = true;
            this.Btn_insert.Click += new System.EventHandler(this.Btn_insert_Click);
            // 
            // Btn_clear
            // 
            this.Btn_clear.Location = new System.Drawing.Point(842, 319);
            this.Btn_clear.Name = "Btn_clear";
            this.Btn_clear.Size = new System.Drawing.Size(131, 42);
            this.Btn_clear.TabIndex = 11;
            this.Btn_clear.Text = "CLEAR";
            this.Btn_clear.UseVisualStyleBackColor = true;
            this.Btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(542, 366);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.product_SELECT);
            this.tabPage2.Controls.Add(this.product_INSERT);
            this.tabPage2.Controls.Add(this.product_CLEAR);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(982, 379);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "제품";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Manufacturer);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.price1);
            this.panel2.Controls.Add(this.productname);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.inventoryvol1);
            this.panel2.Controls.Add(this.price2);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.productnum);
            this.panel2.Controls.Add(this.inventoryvol2);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(587, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 235);
            this.panel2.TabIndex = 9;
            // 
            // Manufacturer
            // 
            this.Manufacturer.Location = new System.Drawing.Point(110, 195);
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.Size = new System.Drawing.Size(239, 25);
            this.Manufacturer.TabIndex = 40;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(37, 198);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 15);
            this.label17.TabIndex = 39;
            this.label17.Text = "제조업체";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(67, 168);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 15);
            this.label15.TabIndex = 38;
            this.label15.Text = "단가";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(52, 136);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 15);
            this.label13.TabIndex = 34;
            this.label13.Text = "재고량";
            // 
            // price1
            // 
            this.price1.Location = new System.Drawing.Point(110, 164);
            this.price1.Name = "price1";
            this.price1.Size = new System.Drawing.Size(98, 25);
            this.price1.TabIndex = 37;
            // 
            // productname
            // 
            this.productname.Location = new System.Drawing.Point(110, 102);
            this.productname.Name = "productname";
            this.productname.Size = new System.Drawing.Size(239, 25);
            this.productname.TabIndex = 19;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(221, 168);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(18, 15);
            this.label16.TabIndex = 36;
            this.label16.Text = "~";
            // 
            // inventoryvol1
            // 
            this.inventoryvol1.Location = new System.Drawing.Point(110, 133);
            this.inventoryvol1.Name = "inventoryvol1";
            this.inventoryvol1.Size = new System.Drawing.Size(98, 25);
            this.inventoryvol1.TabIndex = 33;
            // 
            // price2
            // 
            this.price2.Location = new System.Drawing.Point(251, 164);
            this.price2.Name = "price2";
            this.price2.Size = new System.Drawing.Size(98, 25);
            this.price2.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(52, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 15);
            this.label12.TabIndex = 18;
            this.label12.Text = "제품명";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(221, 137);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 15);
            this.label14.TabIndex = 32;
            this.label14.Text = "~";
            // 
            // productnum
            // 
            this.productnum.Location = new System.Drawing.Point(110, 71);
            this.productnum.Name = "productnum";
            this.productnum.Size = new System.Drawing.Size(239, 25);
            this.productnum.TabIndex = 17;
            // 
            // inventoryvol2
            // 
            this.inventoryvol2.Location = new System.Drawing.Point(251, 133);
            this.inventoryvol2.Name = "inventoryvol2";
            this.inventoryvol2.Size = new System.Drawing.Size(98, 25);
            this.inventoryvol2.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "제품번호";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 20F);
            this.label10.Location = new System.Drawing.Point(98, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 34);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mart.제품";
            // 
            // product_SELECT
            // 
            this.product_SELECT.Location = new System.Drawing.Point(568, 319);
            this.product_SELECT.Name = "product_SELECT";
            this.product_SELECT.Size = new System.Drawing.Size(131, 42);
            this.product_SELECT.TabIndex = 8;
            this.product_SELECT.Text = "SELECT";
            this.product_SELECT.UseVisualStyleBackColor = true;
            // 
            // product_INSERT
            // 
            this.product_INSERT.Location = new System.Drawing.Point(705, 319);
            this.product_INSERT.Name = "product_INSERT";
            this.product_INSERT.Size = new System.Drawing.Size(131, 42);
            this.product_INSERT.TabIndex = 7;
            this.product_INSERT.Text = "INSERT";
            this.product_INSERT.UseVisualStyleBackColor = true;
            // 
            // product_CLEAR
            // 
            this.product_CLEAR.Location = new System.Drawing.Point(842, 319);
            this.product_CLEAR.Name = "product_CLEAR";
            this.product_CLEAR.Size = new System.Drawing.Size(131, 42);
            this.product_CLEAR.TabIndex = 6;
            this.product_CLEAR.Text = "CLEAR";
            this.product_CLEAR.UseVisualStyleBackColor = true;
            this.product_CLEAR.Click += new System.EventHandler(this.product_CLEAR_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(10, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(542, 366);
            this.dataGridView2.TabIndex = 5;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Controls.Add(this.od_select);
            this.tabPage3.Controls.Add(this.od_insert);
            this.tabPage3.Controls.Add(this.od_clear);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(982, 379);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "주문";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.oddate);
            this.panel3.Controls.Add(this.label25);
            this.panel3.Controls.Add(this.delivery);
            this.panel3.Controls.Add(this.label24);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.orderpd);
            this.panel3.Controls.Add(this.Quantity1);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.label23);
            this.panel3.Controls.Add(this.odclient);
            this.panel3.Controls.Add(this.Quantity2);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.odnum);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Location = new System.Drawing.Point(586, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(368, 273);
            this.panel3.TabIndex = 5;
            // 
            // oddate
            // 
            this.oddate.Location = new System.Drawing.Point(104, 234);
            this.oddate.Name = "oddate";
            this.oddate.Size = new System.Drawing.Size(239, 25);
            this.oddate.TabIndex = 25;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(31, 237);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(67, 15);
            this.label25.TabIndex = 24;
            this.label25.Text = "주문일자";
            // 
            // delivery
            // 
            this.delivery.Location = new System.Drawing.Point(104, 203);
            this.delivery.Name = "delivery";
            this.delivery.Size = new System.Drawing.Size(239, 25);
            this.delivery.TabIndex = 44;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(46, 206);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(52, 15);
            this.label24.TabIndex = 43;
            this.label24.Text = "배송지";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(61, 176);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(37, 15);
            this.label22.TabIndex = 42;
            this.label22.Text = "수량";
            // 
            // orderpd
            // 
            this.orderpd.Location = new System.Drawing.Point(104, 141);
            this.orderpd.Name = "orderpd";
            this.orderpd.Size = new System.Drawing.Size(239, 25);
            this.orderpd.TabIndex = 23;
            // 
            // Quantity1
            // 
            this.Quantity1.Location = new System.Drawing.Point(104, 172);
            this.Quantity1.Name = "Quantity1";
            this.Quantity1.Size = new System.Drawing.Size(98, 25);
            this.Quantity1.TabIndex = 41;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(31, 144);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 15);
            this.label21.TabIndex = 22;
            this.label21.Text = "주문제품";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(215, 176);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(18, 15);
            this.label23.TabIndex = 40;
            this.label23.Text = "~";
            // 
            // odclient
            // 
            this.odclient.Location = new System.Drawing.Point(104, 107);
            this.odclient.Name = "odclient";
            this.odclient.Size = new System.Drawing.Size(239, 25);
            this.odclient.TabIndex = 21;
            // 
            // Quantity2
            // 
            this.Quantity2.Location = new System.Drawing.Point(245, 172);
            this.Quantity2.Name = "Quantity2";
            this.Quantity2.Size = new System.Drawing.Size(98, 25);
            this.Quantity2.TabIndex = 39;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(31, 110);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 15);
            this.label20.TabIndex = 20;
            this.label20.Text = "주문고객";
            // 
            // odnum
            // 
            this.odnum.Location = new System.Drawing.Point(104, 74);
            this.odnum.Name = "odnum";
            this.odnum.Size = new System.Drawing.Size(239, 25);
            this.odnum.TabIndex = 19;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(31, 77);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 15);
            this.label19.TabIndex = 18;
            this.label19.Text = "주문번호";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("굴림", 20F);
            this.label18.Location = new System.Drawing.Point(98, 17);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(163, 34);
            this.label18.TabIndex = 1;
            this.label18.Text = "Mart.주문";
            // 
            // od_select
            // 
            this.od_select.Location = new System.Drawing.Point(568, 319);
            this.od_select.Name = "od_select";
            this.od_select.Size = new System.Drawing.Size(131, 42);
            this.od_select.TabIndex = 8;
            this.od_select.Text = "SELECT";
            this.od_select.UseVisualStyleBackColor = true;
            // 
            // od_insert
            // 
            this.od_insert.Location = new System.Drawing.Point(705, 319);
            this.od_insert.Name = "od_insert";
            this.od_insert.Size = new System.Drawing.Size(131, 42);
            this.od_insert.TabIndex = 7;
            this.od_insert.Text = "INSERT";
            this.od_insert.UseVisualStyleBackColor = true;
            // 
            // od_clear
            // 
            this.od_clear.Location = new System.Drawing.Point(842, 319);
            this.od_clear.Name = "od_clear";
            this.od_clear.Size = new System.Drawing.Size(131, 42);
            this.od_clear.TabIndex = 6;
            this.od_clear.Text = "CLEAR";
            this.od_clear.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(10, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 27;
            this.dataGridView3.Size = new System.Drawing.Size(542, 366);
            this.dataGridView3.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 429);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button product_SELECT;
        private System.Windows.Forms.Button product_INSERT;
        private System.Windows.Forms.Button product_CLEAR;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button od_select;
        private System.Windows.Forms.Button od_insert;
        private System.Windows.Forms.Button od_clear;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_select;
        private System.Windows.Forms.Button Btn_insert;
        private System.Windows.Forms.Button Btn_clear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxjob;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxrank;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxreverse2;
        private System.Windows.Forms.TextBox textBoxreverse1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox productname;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox productnum;
        private System.Windows.Forms.TextBox Manufacturer;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox price1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox inventoryvol1;
        private System.Windows.Forms.TextBox price2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox inventoryvol2;
        private System.Windows.Forms.TextBox oddate;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox delivery;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox orderpd;
        private System.Windows.Forms.TextBox Quantity1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox odclient;
        private System.Windows.Forms.TextBox Quantity2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox odnum;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
    }
}

