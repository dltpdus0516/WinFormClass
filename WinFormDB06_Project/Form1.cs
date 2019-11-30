using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormDB06_Project
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        MySqlDataAdapter dataAdapter;
        DataSet dataSet;
        int selectedRowIndex;

        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_select_Click(object sender, EventArgs e)
        {
            string queryStr;

            #region Select QueryString 만들기
            string[] conditions = new string[9];
            conditions[0] = (textBoxid.Text != "") ? "고객아이디=@id" : null;
            conditions[1] = (textBoxname.Text != "") ? "고객이름=@name" : null;
            string condition_textBoxage;
            if (textBoxage1.Text != "" && textBoxage2.Text != "")
            {
                condition_textBoxage = "나이>=@min and 나이<=@max";
            }
            else if (textBoxage1.Text != "" || textBoxage2.Text != "")
            {
                if (textBoxage1.Text != "")
                    condition_textBoxage = "나이>=@min";
                else
                    condition_textBoxage = "나이 <= @max";
            }
            else
            {
                condition_textBoxage = null;
            }
            conditions[2] = condition_textBoxage;
            conditions[3] = (textBoxrank.Text != "") ? "등급=@rank" : null;
            conditions[4] = (textBoxjob.Text != "") ? "직업=@job" : null;
            string condition_reverse;
            if (textBoxreverse1.Text != "" && textBoxreverse2.Text != "")
            {
                condition_reverse = "적립금>=@min1 and 적립금<=@max1";
            }
            else if (textBoxreverse1.Text != "" || textBoxreverse2.Text != "")
            {
                if (textBoxreverse1.Text != "")
                    condition_reverse = "적립금>=@min1";
                else
                    condition_reverse = "적립금 <= @max1";
            }
            else
            {
                condition_reverse = null;
            }
            conditions[5] = condition_reverse;

            if (conditions[0] != null || conditions[1] != null || conditions[2] != null || conditions[3] != null || conditions[4] != null || conditions[5] != null)
            {
                queryStr = $"SELECT * FROM 고객 WHERE ";
                bool firstCondition = true;
                for (int i = 0; i < conditions.Length; i++)
                {
                    if (conditions[i] != null)
                        if (firstCondition)
                        {
                            queryStr += conditions[i];
                            firstCondition = false;
                        }
                        else
                        {
                            queryStr += " and " + conditions[i];
                        }
                }
            }
            else
            {
                queryStr = "SELECT * FROM 고객";
            }
            #endregion

            #region SelectCommand 객체 생성 및 Parameters 설정
            dataAdapter.SelectCommand = new MySqlCommand(queryStr, conn);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@id", textBoxid.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@name", textBoxname.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@min", textBoxage1.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@max", textBoxage2.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@rank", textBoxrank.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@job", textBoxjob.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@min1", textBoxreverse1.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@max1", textBoxreverse2.Text);
            #endregion

            try
            {
                conn.Open();
                dataSet.Clear();
                if (dataAdapter.Fill(dataSet, "고객") > 0)
                    dataGridView1.DataSource = dataSet.Tables["고객"];
                else
                    MessageBox.Show("찾는 데이터가 없습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        internal void DeleteRow(string id)
        {
            string sql = "DELETE FROM 고객 WHERE 고객아이디=@id";
            dataAdapter.DeleteCommand = new MySqlCommand(sql, conn);
            dataAdapter.DeleteCommand.Parameters.AddWithValue("@id", id);

            try
            {
                conn.Open();
                dataAdapter.DeleteCommand.ExecuteNonQuery();

                dataSet.Clear();
                dataAdapter.Fill(dataSet, "고객");
                dataGridView1.DataSource = dataSet.Tables["고객"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        internal void UpdateRow(string[] rowDatas)
        {
            string sql = "UPDATE 고객 SET 고객이름=@name, 나이=@age, 등급=@rank, 직업=@job, 적립금=@reverse WHERE 고객아이디=@id";
            dataAdapter.UpdateCommand = new MySqlCommand(sql, conn);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@id", rowDatas[0]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@name", rowDatas[1]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@age", rowDatas[2]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@rank", rowDatas[3]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@job", rowDatas[4]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@reverse", rowDatas[5]);

            try
            {
                conn.Open();
                dataAdapter.UpdateCommand.ExecuteNonQuery();

                dataSet.Clear();  // 이전 데이터 지우기
                dataAdapter.Fill(dataSet, "고객");
                dataGridView1.DataSource = dataSet.Tables["고객"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void InsertRow(string[] rowDatas)
        {
            string queryStr = "INSERT INTO 고객 (고객아이디,고객이름, 나이, 등급, 직업, 적립금) " +
                "VALUES(@id,@name, @age, @rank, @job, @reverse)";
            dataAdapter.InsertCommand = new MySqlCommand(queryStr, conn);
            dataAdapter.InsertCommand.Parameters.Add("@id", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@name", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@age", MySqlDbType.Int32);
            dataAdapter.InsertCommand.Parameters.Add("@rank", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@job", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@reverse", MySqlDbType.Int32);

            #region Parameter를 이용한 처리
            dataAdapter.InsertCommand.Parameters["@id"].Value = rowDatas[0];
            dataAdapter.InsertCommand.Parameters["@name"].Value = rowDatas[1];
            dataAdapter.InsertCommand.Parameters["@age"].Value = rowDatas[2];
            dataAdapter.InsertCommand.Parameters["@rank"].Value = rowDatas[3];
            dataAdapter.InsertCommand.Parameters["@job"].Value = rowDatas[4];
            dataAdapter.InsertCommand.Parameters["@reverse"].Value = rowDatas[5];

            try
            {
                conn.Open();
                dataAdapter.InsertCommand.ExecuteNonQuery();

                dataSet.Clear();                              
                dataAdapter.Fill(dataSet, "고객");                     
                dataGridView1.DataSource = dataSet.Tables["고객"];             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            #endregion
        }

        private void Btn_insert_Click(object sender, EventArgs e)
        {
            Form2 Dig = new Form2();
            Dig.Owner = this; 
            Dig.ShowDialog();              
            Dig.Dispose();
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            textBoxid.Clear();
            textBoxname.Clear();
            textBoxage1.Clear();
            textBoxage2.Clear();
            textBoxrank.Clear();
            textBoxjob.Clear();
            textBoxreverse1.Clear();
            textBoxreverse2.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRowIndex];

            // 새로운 폼에 선택된 row의 정보를 담아서 생성
            Form2 Dig = new Form2(
                selectedRowIndex,
                row.Cells[0].Value.ToString(),
                row.Cells[1].Value.ToString(),
                row.Cells[2].Value.ToString(),
                row.Cells[3].Value.ToString(),
                row.Cells[4].Value.ToString(),
                row.Cells[5].Value.ToString()
                );

            Dig.Owner = this;               // 새로운 폼의 부모가 Form1 인스턴스임을 지정
            Dig.ShowDialog();               // 폼 띄우기(Modal)
            Dig.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connStr = "server=localhost;port=3306;database=world;uid=root;pwd=dltpdus0516";
            conn = new MySqlConnection(connStr);
            dataAdapter = new MySqlDataAdapter("SELECT * FROM 고객", conn);
            dataSet = new DataSet();

            dataAdapter.Fill(dataSet, "고객");
            dataGridView1.DataSource = dataSet.Tables["고객"];
        }

        private void product_CLEAR_Click(object sender, EventArgs e)
        {

        }
    }
}
