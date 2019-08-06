using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;


namespace AVManager
{
    public partial class Form3 : Form
    {

        AutoResizeForm asc = new AutoResizeForm();

        string path = "";
        public static string scom;
        public static string sno;

        public Form3()
        {
            InitializeComponent();
            path = Home.path;


            LoadData();
        }



        public void LoadData()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = true;
            String dpath = path + "vedioindex.sqlite";
            SQLiteConnection cn = new SQLiteConnection("data source=" + dpath);
            cn.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select COM as 系列,NO as 编号,NAME as 标题,PLAYER as 女优,TAG as 标签,PICDIC as 封面路径,VEDIODIC as 资源路径 from VEDIO";
            SQLiteDataAdapter adt = new SQLiteDataAdapter(cmd);
            DataSet ds = new DataSet();
            adt.Fill(ds, "VEDIO");
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cn.Close();

            dataGridView1.AutoGenerateColumns = false;

            DataGridViewButtonColumn elink = new DataGridViewButtonColumn();
            elink.Text = "编辑";
            elink.Name = "Edit";
            elink.HeaderText = "编辑";
            elink.UseColumnTextForButtonValue = true;
            elink.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns.Add(elink);


            DataGridViewButtonColumn dlink = new DataGridViewButtonColumn();
            dlink.Text = "删除";
            dlink.Name = "Delete";
            dlink.HeaderText = "删除";
            dlink.UseColumnTextForButtonValue = true;
            dlink.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns.Add(dlink);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewColumn column = dataGridView1.Columns[e.ColumnIndex];
                if (column.Name == "Edit")
                {
                    scom = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    sno = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    Form4 f4 = new Form4();
                    f4.ShowDialog();
                    LoadData();
                }
                else if (column.Name == "Delete")
                {
                    string com = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    string no = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    String dpath = path + "vedioindex.sqlite";
                    SQLiteConnection cn = new SQLiteConnection("data source=" + dpath);
                    cn.Open();
                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.Connection = cn;
                    cmd.CommandText = "delete from VEDIO where COM=@com and NO=@no";
                    cmd.Parameters.Add("com", System.Data.DbType.String).Value = com;
                    cmd.Parameters.Add("no", System.Data.DbType.String).Value = no;
                    int status = cmd.ExecuteNonQuery();
                    cn.Close();
                    if (status == 1)
                    {
                        MessageBox.Show("删除成功！");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("删除失败！");
                        LoadData();
                    }
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            asc.controllInitializeSize(this);
        }

        private void Form3_SizeChanged(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);
        }
    }
}
