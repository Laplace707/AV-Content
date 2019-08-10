using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JavManager
{
    public partial class AVSearch : Form
    {
        string baseurl = "https://www.libredmm.com/";
        string searchurl = "https://www.libredmm.com/search?utf8=%E2%9C%93&q={0}&commit=Search";
        public static List<string> selecteditem;
        JArray ja;
        int index;


        public AVSearch()
        {
            InitializeComponent();
            data.code = null;
            data.title = null;
            data.actresses = null;
            data.genres = null;
        }

        private bool PingWebSite() {
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(baseurl);
                req.Timeout = 5000;
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                if (resp.StatusCode == HttpStatusCode.OK)
                {
                    return true;
                }
                return false;
            }
            catch (WebException webex) {
                return false;
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            search.Text = "搜索中";
            search.Enabled = false;
            try
            {
                if (PingWebSite())
                {
                    index = -1;
                    string url = string.Format(searchurl, textBox1.Text.Trim());
                    string getJson = HttpUitls.Get(url);
                    if (getJson.Equals("error"))
                    {
                        MessageBox.Show("连接到服务器失败!", "连接失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (getJson.Equals("[]"))
                    {
                        MessageBox.Show("未找到符合的结果", "未找到", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (getJson[0] == '[')
                        {
                            dataGridView1.Rows.Clear();
                            ja = (JArray)JsonConvert.DeserializeObject(getJson);
                        }
                        else if (getJson[0] == '{')
                        {
                            dataGridView1.Rows.Clear();
                            JObject jjo = (JObject)JsonConvert.DeserializeObject(getJson);
                            ja = new JArray();
                            ja.Add(jjo);
                        }
                        foreach (JObject jo in ja)
                        {
                            int index = dataGridView1.Rows.Add();
                            dataGridView1.Rows[index].Cells[0].Value = jo["code"];
                            dataGridView1.Rows[index].Cells[1].Value = jo["title"];
                            if (jo["actresses"] != null)
                            {
                                dataGridView1.Rows[index].Cells[2].Value = string.Join(";", jo["actresses"]) + ";";
                            }
                            if (jo["genres"] != null)
                            {
                                dataGridView1.Rows[index].Cells[3].Value = string.Join(";", jo["genres"]) + ";";
                            }
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("连接到网站失败！");
                }
            }
            catch (Exception xe) {
                MessageBox.Show("数据错误");
            }
            search.Text = "搜索";
            search.Enabled = true;
        }

        private void DataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                index = dataGridView1.CurrentRow.Index;
                string image_url = ja[index]["cover_image"].ToString();
                pictureBox1.LoadAsync(image_url);
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewColumn column = dataGridView1.Columns[e.ColumnIndex];
                if (column.Name == "add")
                {
                    data.code = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    data.title = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    data.actresses = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    data.genres = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    this.Close();
                }
            }
        }

        
    }
}
