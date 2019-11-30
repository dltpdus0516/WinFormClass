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
using WinFormDB_Project;

namespace WinFormProjectTest
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

        private void Form1_Load(object sender, EventArgs e)
        {
            string connStr = "server=localhost;port=3306;database=mart;uid=root;pwd=dltpdus0516";
            conn = new MySqlConnection(connStr);
            dataAdapter = new MySqlDataAdapter("SELECT * FROM 고객", conn);
            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "고객");
            dataAdapter = new MySqlDataAdapter("SELECT * FROM 제품", conn);
            dataAdapter.Fill(dataSet, "제품");
            dataAdapter = new MySqlDataAdapter("SELECT * FROM 주문", conn);
            dataAdapter.Fill(dataSet, "주문");
            dataGridView1.DataSource = dataSet.Tables["고객"];
            dataGridView2.DataSource = dataSet.Tables["제품"];
            dataGridView3.DataSource = dataSet.Tables["주문"];

        }

        #region 고객 테이블
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
                dataSet.Tables["고객"].Clear();
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

                dataSet.Tables["고객"].Clear();
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

                dataSet.Tables["고객"].Clear();
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

                dataSet.Tables["고객"].Clear();
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

            Form2 Dig = new Form2(
                selectedRowIndex,
                row.Cells[0].Value.ToString(),
                row.Cells[1].Value.ToString(),
                row.Cells[2].Value.ToString(),
                row.Cells[3].Value.ToString(),
                row.Cells[4].Value.ToString(),
                row.Cells[5].Value.ToString()
                );

            Dig.Owner = this;
            Dig.ShowDialog();
            Dig.Dispose();
        }
        #endregion

        #region 제품 테이블

        private void product_SELECT_Click(object sender, EventArgs e)
        {
            string queryStr;

            #region Select QueryString 만들기
            string[] conditions = new string[9];
            conditions[0] = (productnum.Text != "") ? "제품번호=@pdnum" : null;
            conditions[1] = (productname.Text != "") ? "제품명=@pdname" : null;
            string condition_inventoryvol;
            if (inventoryvol1.Text != "" && inventoryvol2.Text != "")
            {
                condition_inventoryvol = "재고량>=@min2 and 재고량<=@max2";
            }
            else if (inventoryvol1.Text != "" || inventoryvol2.Text != "")
            {
                if (inventoryvol1.Text != "")
                    condition_inventoryvol = "재고량>=@min2";
                else
                    condition_inventoryvol = "재고량 <= @max2";
            }
            else
            {
                condition_inventoryvol = null;
            }
            conditions[2] = condition_inventoryvol;
            string condition_price;
            if (price1.Text != "" && price2.Text != "")
            {
                condition_price = "단가>=@min3 and 단가<=@max3";
            }
            else if (price1.Text != "" || price2.Text != "")
            {
                if (price1.Text != "")
                    condition_price = "단가>=@min3";
                else
                    condition_price = "단가 <= @max3";
            }
            else
            {
                condition_price = null;
            }
            conditions[3] = condition_price;
            conditions[4] = (Manufacturer.Text != "") ? "제조업체=@manuf" : null;

            if (conditions[0] != null || conditions[1] != null || conditions[2] != null || conditions[3] != null || conditions[4] != null)
            {
                queryStr = $"SELECT * FROM 제품 WHERE ";
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
                queryStr = "SELECT * FROM 제품 ";
            }
            #endregion

            #region SelectCommand 객체 생성 및 Parameters 설정
            dataAdapter.SelectCommand = new MySqlCommand(queryStr, conn);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@pdnum", productnum.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@pdname", productname.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@min2", inventoryvol1.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@max2", inventoryvol2.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@min3", price1.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@max3", price2.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@manuf", Manufacturer.Text);
            #endregion

            try
            {
                conn.Open();
                dataSet.Tables["제품"].Clear();
                if (dataAdapter.Fill(dataSet, "제품") > 0)
                    dataGridView2.DataSource = dataSet.Tables["제품"];
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

        internal void DeleteRow1(string pdnum)
        {
            string sql = "DELETE FROM 제품 WHERE 제품번호=@pdnum";
            dataAdapter.DeleteCommand = new MySqlCommand(sql, conn);
            dataAdapter.DeleteCommand.Parameters.AddWithValue("@pdnum", pdnum);

            try
            {
                conn.Open();
                dataAdapter.DeleteCommand.ExecuteNonQuery();

                dataSet.Clear();
                dataAdapter.Fill(dataSet, "제품");
                dataGridView1.DataSource = dataSet.Tables["제품"];
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

        public void InsertRow1(string[] rowDatas)
        {
            string queryStr = "INSERT INTO 제품 (제품번호,제품명, 재고량, 단가, 제조업체) " +
                "VALUES(@pdnum,@pdname, @inventroy, @price, @manuf)";
            dataAdapter.InsertCommand = new MySqlCommand(queryStr, conn);
            dataAdapter.InsertCommand.Parameters.Add("@pdnum", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@pdname", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@inventory", MySqlDbType.Int32);
            dataAdapter.InsertCommand.Parameters.Add("@price", MySqlDbType.Int32);
            dataAdapter.InsertCommand.Parameters.Add("@manuf", MySqlDbType.VarChar);

            #region Parameter를 이용한 처리
            dataAdapter.InsertCommand.Parameters["@pdnum"].Value = rowDatas[0];
            dataAdapter.InsertCommand.Parameters["@pdname"].Value = rowDatas[1];
            dataAdapter.InsertCommand.Parameters["@inventory"].Value = rowDatas[2];
            dataAdapter.InsertCommand.Parameters["@price"].Value = rowDatas[3];
            dataAdapter.InsertCommand.Parameters["@manuf"].Value = rowDatas[4];

            try
            {
                conn.Open();
                dataAdapter.InsertCommand.ExecuteNonQuery();

                dataSet.Clear();
                dataAdapter.Fill(dataSet, "제품");
                dataGridView1.DataSource = dataSet.Tables["제품"];
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

        internal void UpdateRow1(string[] rowDatas)
        {
            string sql = "UPDATE 제품 SET 제품명=@pdname, 재고량=@inventory, 단가=@price, 제조업체=@manuf WHERE 제품번호=@pdnum";
            dataAdapter.UpdateCommand = new MySqlCommand(sql, conn);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@pdnum", rowDatas[0]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@pdname", rowDatas[1]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@inventory", rowDatas[2]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@price", rowDatas[3]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@manuf", rowDatas[4]);

            try
            {
                conn.Open();
                dataAdapter.UpdateCommand.ExecuteNonQuery();

                dataSet.Clear();
                dataAdapter.Fill(dataSet, "제품");
                dataGridView1.DataSource = dataSet.Tables["제품"];
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

        private void product_INSERT_Click(object sender, EventArgs e)
        {
            Form3 Dig = new Form3();
            Dig.Owner = this;
            Dig.ShowDialog();
            Dig.Dispose();
        }

        private void product_CLEAR_Click(object sender, EventArgs e)
        {
            productnum.Clear();
            productname.Clear();
            inventoryvol1.Clear();
            inventoryvol2.Clear();
            price1.Clear();
            price2.Clear();
            Manufacturer.Clear();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView2.Rows[selectedRowIndex];

            Form3 Dig = new Form3(
                selectedRowIndex,
                row.Cells[0].Value.ToString(),
                row.Cells[1].Value.ToString(),
                row.Cells[2].Value.ToString(),
                row.Cells[3].Value.ToString(),
                row.Cells[4].Value.ToString()
                );

            Dig.Owner = this;
            Dig.ShowDialog();
            Dig.Dispose();
        }

        #endregion

        #region 주문테이블
        private void od_select_Click(object sender, EventArgs e)
        {
            string queryStr;

            #region Select QueryString 만들기
            string[] conditions = new string[9];
            conditions[0] = (ordernum.Text != "") ? "주문번호=@odnum" : null;
            conditions[1] = (orderclient.Text != "") ? "주문고객=@client" : null;
            conditions[2] = (orderproduct.Text != "") ? "주문제품=@odproduct" : null;
            string condition_odQuantity;
            if (odQuantity1.Text != "" && odQuantity2.Text != "")
            {
                condition_odQuantity = "수량>=@min4 and 수량<=@max4";
            }
            else if (odQuantity1.Text != "" || odQuantity2.Text != "")
            {
                if (textBoxage1.Text != "")
                    condition_odQuantity = "수량>=@min4";
                else
                    condition_odQuantity = "수량<= @max4";
            }
            else
            {
                condition_odQuantity = null;
            }
            conditions[3] = condition_odQuantity;
            conditions[4] = (oddelivery.Text != "") ? "배송지=@oddelivery" : null;
            conditions[5] = (orderdate.Text != "") ? "주문일자=@oddate" : null;

            if (conditions[0] != null || conditions[1] != null || conditions[2] != null || conditions[3] != null || conditions[4] != null || conditions[5] != null)
            {
                queryStr = $"SELECT * FROM 주문 WHERE ";
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
                queryStr = "SELECT * FROM 주문";
            }
            #endregion

            #region SelectCommand 객체 생성 및 Parameters 설정
            dataAdapter.SelectCommand = new MySqlCommand(queryStr, conn);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@odnum", ordernum.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@client", orderclient.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@odproduct", orderproduct.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@min4", odQuantity1.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@max4", odQuantity2.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@oddelivery", oddelivery.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@oddate", orderdate.Text);
            #endregion

            try
            {
                conn.Open();
                dataSet.Tables["주문"].Clear();
                if (dataAdapter.Fill(dataSet, "주문") > 0)
                    dataGridView1.DataSource = dataSet.Tables["주문"];
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

        private void od_insert_Click(object sender, EventArgs e)
        {
            Form4 Dig = new Form4();
            Dig.Owner = this;
            Dig.ShowDialog();
            Dig.Dispose();
        }

        private void od_clear_Click(object sender, EventArgs e)
        {
            ordernum.Clear();
            orderclient.Clear();
            orderproduct.Clear();
            odQuantity1.Clear();
            odQuantity2.Clear();
            oddelivery.Clear();
            oddate.Clear();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView3.Rows[selectedRowIndex];

            Form4 Dig = new Form4(
                selectedRowIndex,
                row.Cells[0].Value.ToString(),
                row.Cells[1].Value.ToString(),
                row.Cells[2].Value.ToString(),
                row.Cells[3].Value.ToString(),
                row.Cells[4].Value.ToString(),
                row.Cells[5].Value.ToString()
                );

            Dig.Owner = this;
            Dig.ShowDialog();
            Dig.Dispose();
        }

        internal void DeleteRow2(string num)
        {
            string sql = "DELETE FROM 주문 WHERE 주문번호=@id";
            dataAdapter.DeleteCommand = new MySqlCommand(sql, conn);
            dataAdapter.DeleteCommand.Parameters.AddWithValue("@id", num);

            try
            {
                conn.Open();
                dataAdapter.DeleteCommand.ExecuteNonQuery();

                dataSet.Clear();
                dataAdapter.Fill(dataSet, "주문");
                dataGridView1.DataSource = dataSet.Tables["주문"];
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

        internal void UpdateRow2(string[] rowDatas)
        {
            string sql = "UPDATE 주문 SET 주문고객=@client, 주문제품=@odproduct, 수량=@odQuantity, 배송지=@delivery, 주문일자=@date WHERE 주문번호=@odnum";
            dataAdapter.UpdateCommand = new MySqlCommand(sql, conn);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@odnum", rowDatas[0]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@client", rowDatas[1]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@odproduct", rowDatas[2]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@odQuantity", rowDatas[3]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@delivery", rowDatas[4]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@date", rowDatas[5]);

            try
            {
                conn.Open();
                dataAdapter.UpdateCommand.ExecuteNonQuery();

                dataSet.Clear();  // 이전 데이터 지우기
                dataAdapter.Fill(dataSet, "주문");
                dataGridView1.DataSource = dataSet.Tables["주문"];
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

        internal void InsertRow2(string[] rowDatas)
        {
            string queryStr = "INSERT INTO 고객 (주문번호,주문고객, 주문제품, 수량, 배송지, 주문일자) " +
                "VALUES(@odnum,@client, @odproduct, @odQuantity, @delivery, @date)";
            dataAdapter.InsertCommand = new MySqlCommand(queryStr, conn);
            dataAdapter.InsertCommand.Parameters.Add("@odnum", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@client", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@odproduct", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@odQuantity", MySqlDbType.Int32);
            dataAdapter.InsertCommand.Parameters.Add("@delivery", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@date", MySqlDbType.VarChar);

            dataAdapter.InsertCommand.Parameters["@odnum"].Value = rowDatas[0];
            dataAdapter.InsertCommand.Parameters["@client"].Value = rowDatas[1];
            dataAdapter.InsertCommand.Parameters["@odproduct"].Value = rowDatas[2];
            dataAdapter.InsertCommand.Parameters["@odQuantity"].Value = rowDatas[3];
            dataAdapter.InsertCommand.Parameters["@delivery"].Value = rowDatas[4];
            dataAdapter.InsertCommand.Parameters["@date"].Value = rowDatas[5];

            try
            {
                conn.Open();
                dataAdapter.InsertCommand.ExecuteNonQuery();

                dataSet.Clear();
                dataAdapter.Fill(dataSet, "주문");
                dataGridView1.DataSource = dataSet.Tables["주문"];
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
        #endregion

    }
}
