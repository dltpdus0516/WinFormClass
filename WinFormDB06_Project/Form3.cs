using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormProjectSample
{
    public partial class Form3 : Form
    {
        private string num;
        private string pdname;
        private string inventory;
        private string price;
        private string manuf;
        private int selectedRowIndex;

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(int selectedRowIndex, string v1, string v2, string v3, string v4, string v5)
        {
            InitializeComponent();
            this.selectedRowIndex = selectedRowIndex;
            this.num = v1;
            this.pdname = v2;
            this.inventory = v3;
            this.price = v4;
            this.manuf = v5;
        }

        Form1 mainForm;
        private void Form3_Load(object sender, EventArgs e)
        {
            txtnumber.Text = num;
            txtpdname.Text = pdname;
            txtinv.Text = inventory;
            txtprice.Text = price;
            txtman.Text = manuf;

            if (Owner != null)
            {
                mainForm = Owner as Form1;
            }
        }


        private void btnpdInsert_Click(object sender, EventArgs e)
        {
            string[] rowDatas = {
                txtnumber.Text,
                txtpdname.Text,
                txtinv.Text,
                txtprice.Text,
                txtman.Text};
            mainform.InsertRow(rowDatas);
            this.Close();
        }

        private void btnpdUpdate_Click(object sender, EventArgs e)
        {
            string[] rowDatas = {
                txtnumber.Text,
                txtpdname.Text,
                txtinv.Text,
                txtprice.Text,
                txtman.Text};
            mainform.UpdateRow(rowDatas);
            this.Close();
        }

        private void btnpdDelete_Click(object sender, EventArgs e)
        {
            mainform.DeleteRow(num);
            this.Close();
        }

        private void btnpdClear_Click(object sender, EventArgs e)
        {
            txtnumber.Clear();
            txtpdname.Clear();
            txtinv.Clear();
            txtprice.Clear();
            txtman.Clear();
        }

        
    }
}
