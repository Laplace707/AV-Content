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
    public partial class Form4 : Form
    {

        string path = "";
        int focus = -1;
        List<string> players;
        List<string> tags;

        public Form4()
        {
            InitializeComponent();

            path = Form1.path;

            String playerstr = "";
            String tagstr = "";
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
                playerstr += dr.GetString(1);
                tagstr += dr.GetString(2);
            }
            dr.Close();

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
            
            SQLiteCommand cmd2 = new SQLiteCommand();
            cmd2.Connection = cn;
            cmd2.CommandText = String.Format("select * from VEDIO where COM = '{0}' and NO = '{1}'",Form3.scom,Form3.sno);
            SQLiteDataReader dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                nametxt.Text = dr2.GetString(0).TrimEnd() ;
                comtxt.Text = dr2.GetString(1).TrimEnd();
                notxt.Text = dr2.GetString(2).TrimEnd();
                playertxt.Text = dr2.GetString(3).TrimEnd();
                picdictxt.Text = dr2.GetString(4).TrimEnd();
                vediodictxt.Text = dr2.GetString(5).TrimEnd();
                tagtxt.Text = dr2.GetString(6).TrimEnd();
            }
            dr2.Close();

            cn.Close();

        }

        public void LoadList()
        {
            listBox1.Items.Clear();
            switch (focus)
            {
                case 0:
                    foreach (string item in players)
                    {
                        listBox1.Items.Add(item);
                    }
                    break;
                case 1:
                    foreach (string item in tags)
                    {
                        listBox1.Items.Add(item);
                    }
                    break;
            }
        }

        public int UpdateData(string name, string com, string no, string player, string picdic, string vediodic, string tag)
        {
            String dpath = path + "vedioindex.sqlite";
            SQLiteConnection cn = new SQLiteConnection("data source=" + dpath);
            cn.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = cn;
            cmd.CommandText = "update VEDIO set NAME=@name,PLAYER=@player,PICDIC=@picdic,VEDIODIC=@vediodic,TAG=@tag where COM=@com and NO=@no";
            cmd.Parameters.Add("name", System.Data.DbType.String).Value = name;
            cmd.Parameters.Add("com", System.Data.DbType.String).Value = com;
            cmd.Parameters.Add("no", System.Data.DbType.String).Value = no;
            cmd.Parameters.Add("player", System.Data.DbType.String).Value = player;
            cmd.Parameters.Add("picdic", System.Data.DbType.String).Value = picdic;
            cmd.Parameters.Add("vediodic", System.Data.DbType.String).Value = vediodic;
            cmd.Parameters.Add("tag", System.Data.DbType.String).Value = tag;
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

            if (name == null || name.Equals(""))
            {
                MessageBox.Show("请输入标题！");
            }
            else if (vediodic == null || vediodic.Equals(""))
            {
                MessageBox.Show("请选择资源文件！");
            }
            else
            {

                if (UpdateData(name, com, no, player, picdic, vediodic, tag) == 0)
                {
                    MessageBox.Show("保存成功！");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("保存失败！");
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

        private void comtxt_Enter(object sender, EventArgs e)
        {
            focus = -1;
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

        private void playertxt_Enter(object sender, EventArgs e)
        {
            focus = 0;
            LoadList();
        }

        private void tagtxt_Enter(object sender, EventArgs e)
        {
            focus = 1;
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

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = listBox1.IndexFromPoint(e.X, e.Y);
            listBox1.SelectedIndex = index;
            if (listBox1.SelectedIndex != -1)
            {
                switch (focus)
                {
                    case 0: playertxt.AppendText(listBox1.SelectedItem.ToString() + ";"); break;
                    case 1: tagtxt.AppendText(listBox1.SelectedItem.ToString() + ";"); break;
                }
            }
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
