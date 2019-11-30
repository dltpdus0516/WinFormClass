using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormProjectTest;

namespace WinFormDB_Project
{
    public partial class Form2 : Form
    {
        private string id;
        private string name;
        private string age;
        private string job;
        private string rank;
        private string reverse;
        private int selectedRowIndex;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(int selectedRowIndex, string v1, string v2, string v3, string v4, string v5, string v6)
        {
            InitializeComponent();
            this.selectedRowIndex = selectedRowIndex;
            this.id = v1;
            this.name = v2;
            this.age = v3;
            this.rank = v4;
            this.job = v5;
            this.reverse = v6;
        }

        Form1 mainform;
        private void Form2_Load(object sender, EventArgs e)
        {
            txtid.Text = id;
            txtname.Text = name;
            txtage.Text = age;
            txtrank.Text = rank;
            txtjob.Text = job;
            txtreverse.Text = reverse;

            if (Owner != null)
            {
                mainform = Owner as Form1;
            }
        }


        private void btnTextBoxClear_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtname.Clear();
            txtage.Clear();
            txtrank.Clear();
            txtjob.Clear();
            txtreverse.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            mainform.DeleteRow2(id);
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string[] rowDatas = {
                txtid.Text,
                txtname.Text,
                txtage.Text,
                txtrank.Text,
                txtjob.Text,
                txtreverse.Text};
            mainform.UpdateRow(rowDatas);
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string[] rowDatas = {
                txtid.Text,
                txtname.Text,
                txtage.Text,
                txtrank.Text,
                txtjob.Text,
                txtreverse.Text};
            mainform.InsertRow(rowDatas);
            this.Close();
        }


    }
}
