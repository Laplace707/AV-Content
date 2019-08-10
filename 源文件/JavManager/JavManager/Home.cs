using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace JavManager
{
    public partial class Home : Form
    {

        AutoResizeForm asc = new AutoResizeForm();

        public static string path;
        string dic = "";
        string comse = "COM like '%%'";
        string playerse = "PLAYER like '%%'";
        string tagse = "TAG like '%%'";
        string favse = "";
        string tcom = "";
        string tno = "";
        int trow = -1;

        public Home()
        {
            InitializeComponent();
            LoadSystem();
        }


        public void LoadSystem()
        {
            comlist.Items.Clear();
            comlist.Items.Add("所有（0）");
            playerlist.Items.Clear();
            playerlist.Items.Add("所有（0）");
            taglist.Items.Clear();
            taglist.Items.Add("所有（0）");
            path = System.AppDomain.CurrentDomain.BaseDirectory;
            if (!System.IO.File.Exists(path + "vedioindex.sqlite"))
            {
                CreatDataBase();
            }

            String comstr = "";
            String playerstr = "";
            String tagstr = "";

            String dpath = path + "vedioindex.sqlite";
            SQLiteConnection cn = new SQLiteConnection("data source=" + dpath);
            cn.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select COM,PLAYER,TAG from VEDIO";
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comstr += dr.GetString(0).TrimEnd() + ";";
                playerstr += dr.GetString(1).TrimEnd();
                tagstr += dr.GetString(2).TrimEnd();
            }
            dr.Close();
            cn.Close();

            if (!comstr.Equals(""))
            {
                String[] comarray = comstr.Split(';');
                comlist.Items.Clear();
                comlist.Items.Add("所有（"+(comarray.Length-1)+"）");
                Array.Sort(comarray);
                String comtemp = comarray[1];
                int comcount = 1;
                for (int i = 2; i < comarray.Length; i++)
                {
                    if (!comarray[i].Equals(comarray[i - 1]))
                    {
                        comlist.Items.Add(comtemp + "（" + comcount + "）");
                        comtemp = comarray[i];
                        comcount = 1;
                    }
                    else
                    {
                        comcount++;
                    }
                }
                comlist.Items.Add(comtemp + "（" + comcount + "）");
            }

            if (!playerstr.Equals(""))
            {
                String[] playerarray = playerstr.Split(';');
                playerlist.Items.Clear();
                playerlist.Items.Add("所有（" + (playerarray.Length - 1) + "）");
                Array.Sort(playerarray);
                String playertemp = playerarray[1];
                int playercount = 1;
                for (int i = 2; i < playerarray.Length; i++)
                {
                    if (!playerarray[i].Equals(playerarray[i - 1]))
                    {
                        playerlist.Items.Add(playertemp + "（" + playercount + "）");
                        playertemp = playerarray[i];
                        playercount = 1;
                    }
                    else
                    {
                        playercount++;
                    }
                }
                playerlist.Items.Add(playertemp + "（" + playercount + "）");
            }

            if (!tagstr.Equals(""))
            {
                String[] tagarray = tagstr.Split(';');
                taglist.Items.Clear();
                taglist.Items.Add("所有（" + (tagarray.Length - 1) + "）");
                Array.Sort(tagarray);
                String tagtemp = tagarray[1];
                int tagcount = 1;
                for (int i = 2; i < tagarray.Length; i++)
                {
                    if (!tagarray[i].Equals(tagarray[i - 1]))
                    {
                        taglist.Items.Add(tagtemp + "（" + tagcount + "）");
                        tagtemp = tagarray[i];
                        tagcount = 1;
                    }
                    else
                    {
                        tagcount++;
                    }
                }
                taglist.Items.Add(tagtemp + "（" + tagcount + "）");
            }

            comlist.SelectedIndex = 0;
            playerlist.SelectedIndex = 0;
            taglist.SelectedIndex = 0;

            LoadData();
        }

        public void CreatDataBase()
        {
            String dpath = path + "vedioindex.sqlite";
            SQLiteConnection cn = new SQLiteConnection("data source=" + dpath);
            cn.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = cn;
            cmd.CommandText = "create table VEDIO(NAME varchar(50) not null,COM varchar(10) not null,NO varchar(20) not null,PLAYER varchar(50),PICDIC varchar(50),VEDIODIC varchar(50) not null,TAG varchar(50),FAV int not null)";
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void LoadData()
        {
            String dpath = path + "vedioindex.sqlite";
            SQLiteConnection cn = new SQLiteConnection("data source=" + dpath);
            cn.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = cn;
            cmd.CommandText = String.Format("select COM||'-'||NO as 番号,NAME as 标题,PLAYER as 女优,TAG as 标签,PICDIC,VEDIODIC,FAV,COM,NO from VEDIO where {0} and {1} and {2} {3}", comse,playerse,tagse,favse);
            SQLiteDataAdapter adt = new SQLiteDataAdapter(cmd);
            DataSet ds = new DataSet();
            adt.Fill(ds, "VEDIO");
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            cn.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow!=null)
            {
                comnotxt.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                nametxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                playertxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                tagtxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                string picd = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                dic = path.Substring(0, 1) + dataGridView1.CurrentRow.Cells[5].Value.ToString();
                tcom = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                tno = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                dictxt.Text = dic;
                if (Int32.Parse(dataGridView1.CurrentRow.Cells[6].Value.ToString()) == 0)
                {
                    favbt.Text = "收藏";
                }
                else
                {
                    favbt.Text = "取消收藏";
                }
                if (picd == null||picd.Equals(""))
                {
                    pictureBox1.Image = pictureBox1.InitialImage;
                }
                else
                {
                    picd = path.Substring(0, 1) + picd;
                    try
                    {
                        pictureBox1.LoadAsync(picd);
                    }
                    catch
                    {
                        pictureBox1.Image = pictureBox1.ErrorImage;
                    }
                }
            }
        }

        private void opendic_Click(object sender, EventArgs e)
        {
            string tdic = "";
            try
            {
                tdic = Path.GetDirectoryName(dic);
            }
            catch
            {
                MessageBox.Show("路径不合法");
                return;
            }

            try
            {
                System.Diagnostics.Process.Start(tdic);
            }
            catch
            {
                MessageBox.Show("目录不存在");
            }
        }

        private void openvedio_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(dic);
            }
            catch
            {
                MessageBox.Show("文件不存在");
            }
        }

        private void comlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = comlist.SelectedIndices.Count;
            if (count > 1)
            {
                if (comlist.GetSelected(0))
                {
                    comlist.SelectedIndex = -1;
                }
                else
                {
                    comse = "(";
                    for (int i = 0; i < count; i++)
                    {
                        int x = comlist.SelectedIndices[i];
                        if (i == 0)
                        {
                            comse += "COM like '%" + comlist.Items[x].ToString().Split('（')[0] + "%'";
                        }
                        else
                        {
                            comse += " or COM like '%" + comlist.Items[x].ToString().Split('（')[0] + "%'";
                        }
                    }
                    comse += ")";
                    LoadData();
                }
            }
            else
            {
                if (comlist.SelectedIndex == -1)
                {
                    comlist.SelectedIndex = 0;
                }
                else if (comlist.SelectedIndex == 0)
                {
                    comse = "COM like '%%'";
                    LoadData();
                }
                else
                {
                    comse = "COM like '%" + comlist.SelectedItem.ToString().Split('（')[0] + "%'";
                    LoadData();
                }
            }
        }

        private void playerlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = playerlist.SelectedIndices.Count;
            if (count > 1)
            {
                if (playerlist.GetSelected(0))
                {
                    playerlist.SelectedIndex = -1;
                }
                else
                {
                    playerse = "(";
                    for (int i = 0; i < count; i++)
                    {
                        int x = playerlist.SelectedIndices[i];
                        if (i == 0)
                        {
                            playerse += "PLAYER like '%" + playerlist.Items[x].ToString().Split('（')[0] + "%'";
                        }
                        else
                        {
                            playerse += " or PLAYER like '%" + playerlist.Items[x].ToString().Split('（')[0] + "%'";
                        }
                    }
                    playerse += ")";
                    LoadData();
                }
            }
            else
            {
                if (playerlist.SelectedIndex == -1)
                {
                    playerlist.SelectedIndex = 0;
                }
                else if (playerlist.SelectedIndex == 0)
                {
                    playerse = "PLAYER like '%%'";
                    LoadData();
                }
                else
                {
                    playerse = "PLAYER like '%" + playerlist.SelectedItem.ToString().Split('（')[0] + "%'";
                    LoadData();
                }
            }
        }

        private void taglist_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = taglist.SelectedIndices.Count;
            if (count > 1)
            {
                if (taglist.GetSelected(0))
                {
                    taglist.SelectedIndex = -1;
                }
                else
                {
                    tagse = "(";
                    for (int i = 0; i < count; i++)
                    {
                        int x = taglist.SelectedIndices[i];
                        if (i == 0)
                        {
                            tagse += "TAG like '%" + taglist.Items[x].ToString().Split('（')[0] + "%'";
                        }
                        else
                        {
                            tagse += " or TAG like '%" + taglist.Items[x].ToString().Split('（')[0] + "%'";
                        }
                    }
                    tagse += ")";
                    LoadData();
                }
            }
            else
            {
                if (taglist.SelectedIndex == -1)
                {
                    taglist.SelectedIndex = 0;
                }
                else if (taglist.SelectedIndex == 0)
                {
                    tagse = "TAG like '%%'";
                    LoadData();
                }
                else
                {
                    tagse = "TAG like '%" + taglist.SelectedItem.ToString().Split('（')[0] + "%'";
                    LoadData();
                }
            }
        }

        

        private void favbt_Click(object sender, EventArgs e)
        {
            trow = dataGridView1.CurrentRow.Index;
            if (favbt.Text == "收藏")
            {
                if (tcom != null && (!tcom.Equals("")) && tno != null && (!tno.Equals("")))
                {
                    String dpath = path + "vedioindex.sqlite";
                    SQLiteConnection cn = new SQLiteConnection("data source=" + dpath);
                    cn.Open();
                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.Connection = cn;
                    cmd.CommandText = "update VEDIO set FAV=@fav where COM=@com and NO=@no";
                    cmd.Parameters.Add("com", System.Data.DbType.String).Value = tcom;
                    cmd.Parameters.Add("no", System.Data.DbType.String).Value = tno;
                    cmd.Parameters.Add("fav", System.Data.DbType.Int32).Value = 1;
                    int status = cmd.ExecuteNonQuery();
                    cn.Close();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("请选择资源!");
                }
            }
            else
            {
                if (tcom != null && (!tcom.Equals("")) && tno != null && (!tno.Equals("")))
                {
                    String dpath = path + "vedioindex.sqlite";
                    SQLiteConnection cn = new SQLiteConnection("data source=" + dpath);
                    cn.Open();
                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.Connection = cn;
                    cmd.CommandText = "update VEDIO set FAV=@fav where COM=@com and NO=@no";
                    cmd.Parameters.Add("com", System.Data.DbType.String).Value = tcom;
                    cmd.Parameters.Add("no", System.Data.DbType.String).Value = tno;
                    cmd.Parameters.Add("fav", System.Data.DbType.Int32).Value = 0;
                    int status = cmd.ExecuteNonQuery();
                    cn.Close();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("请选择资源!");
                }
            }
            dataGridView1.ClearSelection();
            dataGridView1.Rows[trow].Selected = true;
            dataGridView1.CurrentCell = dataGridView1.Rows[trow].Cells[0];
            dataGridView1.CurrentRow.Selected = true;
            comnotxt.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            nametxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            playertxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tagtxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string picd = path.Substring(0, 1) + dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dic = path.Substring(0, 1) + dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tcom = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            tno = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            dictxt.Text = dic;
            if (Int32.Parse(dataGridView1.CurrentRow.Cells[6].Value.ToString()) == 0)
            {
                favbt.Text = "收藏";
            }
            else
            {
                favbt.Text = "取消收藏";
            }
            if (picd == null || picd.Equals(""))
            {
                pictureBox1.Image = pictureBox1.InitialImage;
            }
            else
            {
                try
                {
                    pictureBox1.LoadAsync(picd);
                }
                catch
                {
                    pictureBox1.Image = pictureBox1.ErrorImage;
                }
            }
        }

        private void 我的收藏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (favse.Equals(""))
            {
                favse = "and FAV = 1";
                我的收藏ToolStripMenuItem.Text = "所有资源";
            }
            else
            {
                favse = "";
                我的收藏ToolStripMenuItem.Text = "我的收藏";
            }
            LoadData();
        }

        private void 管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
            LoadSystem();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }



        private void Home_Load(object sender, EventArgs e)
        {
            asc.controllInitializeSize(this);
        }

        private void Home_SizeChanged(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);
        }

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            LoadSystem();
        }
    }
}
