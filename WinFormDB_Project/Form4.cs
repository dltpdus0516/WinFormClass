using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormDB_Project
{
    public partial class Form4 : Form
    {
        private string num;
        private string client;
        private string odproduct;
        private string Quantity;
        private string delivery;
        private string date;
        private int selectedRowIndex;

        public Form4()
        {
            InitializeComponent();
        }

        public Form4(int selectedRowIndex, string v1, string v2, string v3, string v4, string v5, string v6)
        {
            InitializeComponent();
            this.selectedRowIndex = selectedRowIndex;
            this.num = v1;
            this.client = v2;
            this.odproduct = v3;
            this.Quantity = v4;
            this.delivery = v5;
            this.date = v6;
        }

        Form1 mainform;
        private void Form4_Load(object sender, EventArgs e)
        {
            txtodnum.Text = num;
            txtclient.Text = client;
            txtodproduct.Text = odproduct;
            txtQuantity.Text = Quantity;
            txtdelivery.Text = delivery;
            txtdate.Text = date;

            if (Owner != null)
            {
                mainform = Owner as Form1;
            }
        }


        private void 주문_Insert_Click(object sender, EventArgs e)
        {
            string[] rowDatas = {
                txtodnum.Text,
                txtclient.Text,
                txtodproduct.Text,
                txtQuantity.Text,
                txtdelivery.Text,
                txtdate.Text};
            mainform.InsertRow2(rowDatas);
            this.Close();
        }

        private void 주문_Update_Click(object sender, EventArgs e)
        {
            string[] rowDatas = {
                txtodnum.Text,
                txtclient.Text,
                txtodproduct.Text,
                txtQuantity.Text,
                txtdelivery.Text,
                txtdate.Text};
            mainform.UpdateRow2(rowDatas);
            this.Close();
        }

        private void 주문_Delete_Click(object sender, EventArgs e)
        {
            mainform.DeleteRow2(num);
            this.Close();
        }

        private void btn주문Clear_Click(object sender, EventArgs e)
        {
            txtodnum.Clear();
            txtclient.Clear();
            txtodproduct.Clear();
            txtQuantity.Clear();
            txtdelivery.Clear();
            txtdate.Clear();
        }


    }
}
