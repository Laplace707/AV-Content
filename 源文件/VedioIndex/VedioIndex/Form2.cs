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

namespace VedioIndex
{
    

    public partial class Form2 : Form
    {

        string path = "";
        int focus = -1;
        List<string> coms;
        List<string> players;
        List<string> tags;

        public Form2()
        {
            InitializeComponent();
            path = Form1.path;

            String comstr = "";
            String playerstr = "";
            String tagstr = "";
            
            coms = new List<string>();
            players = new List<string>();
            tags = new List<string>();

            String dpath = path + "vedioindex.sqlite";
            SQLiteConnection cn = new SQLiteConnection("data source=" + dpath);
            cn.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select distinct COM,PLAYER,TAG from VEDIO";
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
                Array.Sort(comarray);
                for (int i = 1; i < comarray.Length; i++)
                {
                    if (!comarray[i].Equals(comarray[i - 1]))
                    {
                        coms.Add(comarray[i]);
                    }
                }
            }

            if (!playerstr.Equals(""))
            {
                String[] playerarray = playerstr.Split(';');
                Array.Sort(playerarray);
                for (int i = 1; i < playerarray.Length; i++)
                {
                    if (!playerarray[i].Equals(playerarray[i - 1]))
                    {
                        players.Add(playerarray[i]);
                    }
                }
            }

            if (!tagstr.Equals(""))
            {
                String[] tagarray = tagstr.Split(';');
                Array.Sort(tagarray);
                for (int i = 1; i < tagarray.Length; i++)
                {
                    if (!tagarray[i].Equals(tagarray[i - 1]))
                    {
                        tags.Add(tagarray[i]);
                    }
                }
            }
            
        }

        public int InsertData(string name, string com, string no, string player, string picdic, string vediodic, string tag)
        {
            String dpath = path + "vedioindex.sqlite";
            SQLiteConnection cn = new SQLiteConnection("data source=" + dpath);
            cn.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = cn;
            cmd.CommandText = "insert into VEDIO(NAME,COM,NO,PLAYER,PICDIC,VEDIODIC,TAG,FAV) VALUES(@name,@com,@no,@player,@picdic,@vediodic,@tag,@fav)";
            cmd.Parameters.Add("name", System.Data.DbType.String).Value = name;
            cmd.Parameters.Add("com", System.Data.DbType.String).Value = com;
            cmd.Parameters.Add("no", System.Data.DbType.String).Value = no;
            cmd.Parameters.Add("player", System.Data.DbType.String).Value = player;
            cmd.Parameters.Add("picdic", System.Data.DbType.String).Value = picdic;
            cmd.Parameters.Add("vediodic", System.Data.DbType.String).Value = vediodic;
            cmd.Parameters.Add("tag", System.Data.DbType.String).Value = tag;
            cmd.Parameters.Add("fav", System.Data.DbType.Int32).Value = 0;
            int status = cmd.ExecuteNonQuery();
            cn.Close();
            if (status == 1)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        public void LoadList()
        {
            listBox1.Items.Clear();
            switch (focus)
            {
                case 0:
                    foreach (string item in coms)
                    {
                        listBox1.Items.Add(item);
                    }
                    break;
                case 1:
                    foreach (string item in players)
                    {
                        listBox1.Items.Add(item);
                    }
                    break;
                case 2:
                    foreach (string item in tags)
                    {
                        listBox1.Items.Add(item);
                    }
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            focus = -1;
            LoadList();

            string com = comtxt.Text.TrimEnd();
            string no = notxt.Text.TrimEnd();
            string name = nametxt.Text.TrimEnd();
            string player = playertxt.Text.TrimEnd();
            string tag = tagtxt.Text.TrimEnd();
            string picdic = picdictxt.Text.TrimEnd();
            string vediodic = vediodictxt.Text.TrimEnd();

            if (com == null || com.Equals(""))
            {
                MessageBox.Show("请输入系列！");
            }
            else if (no == null || no.Equals(""))
            {
                MessageBox.Show("请输入编号！");
            }
            else if (name == null || name.Equals(""))
            {
                MessageBox.Show("请输入标题！");
            }
            else if (vediodic == null || vediodic.Equals(""))
            {
                MessageBox.Show("请选择资源文件！");
            }
            else
            {
                String dpath = path + "vedioindex.sqlite";
                SQLiteConnection cn = new SQLiteConnection("data source=" + dpath);
                cn.Open();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = cn;
                cmd.CommandText = string.Format("select count(*) from VEDIO where COM = '{0}' and NO = '{1}'",com,no);
                int i = -1;
                SQLiteDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    i = dr.GetInt32(0);
                }
                dr.Close();
                cn.Close();
                if (i == 0)
                {
                    if (InsertData(name, com, no, player, picdic, vediodic, tag) == 0)
                    {
                        MessageBox.Show("添加成功！");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("添加失败！");
                    }
                }
                else
                {
                    MessageBox.Show("已存在相同系列和编号的资源");
                }
            }
        }

        private void findpic_Click(object sender, EventArgs e)
        {
            focus = -1;
            LoadList();
            openFileDialog1.ShowDialog();
        }

        private void findvedio_Click(object sender, EventArgs e)
        {
            focus = -1;
            LoadList();
            openFileDialog2.ShowDialog();
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = listBox1.IndexFromPoint(e.X, e.Y);
            listBox1.SelectedIndex = index;
            if (listBox1.SelectedIndex != -1)
            {
                switch (focus)
                {
                    case 0:comtxt.Text = listBox1.SelectedItem.ToString(); break;
                    case 1:playertxt.AppendText(listBox1.SelectedItem.ToString() + ";"); break;
                    case 2:tagtxt.AppendText(listBox1.SelectedItem.ToString() + ";"); break;
                }
            }
        }

        private void comtxt_Enter(object sender, EventArgs e)
        {
            focus = 0;
            LoadList();
        }

        private void playertxt_Enter(object sender, EventArgs e)
        {
            focus = 1;
            LoadList();
        }
        
        private void tagtxt_Enter(object sender, EventArgs e)
        {
            focus = 2;
            LoadList();
        }
        
        private void notxt_Enter(object sender, EventArgs e)
        {
            focus = -1;
            LoadList();
        }

        private void nametxt_Enter(object sender, EventArgs e)
        {
            focus = -1;
            LoadList();
        }

        private void picdictxt_Enter(object sender, EventArgs e)
        {
            focus = -1;
            LoadList();
        }

        private void vediodictxt_Enter(object sender, EventArgs e)
        {
            focus = -1;
            LoadList();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string pan = path.Substring(0, 1);
            string filepath = Path.GetFullPath(openFileDialog1.FileName);
            if (pan.Equals(filepath.Substring(0, 1)))
            {
                picdictxt.Text = filepath.Substring(1);
            }
            else
            {
                MessageBox.Show("只能选择" + pan + "盘的文件");
            }
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            string pan = path.Substring(0, 1);
            string filepath = Path.GetFullPath(openFileDialog2.FileName);
            if (pan.Equals(filepath.Substring(0, 1)))
            {
                vediodictxt.Text = filepath.Substring(1);
            }
            else
            {
                MessageBox.Show("只能选择" + pan + "盘的文件");
            }
        }
    }
}
