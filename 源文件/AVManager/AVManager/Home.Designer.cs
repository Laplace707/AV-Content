namespace AVManager
{
    partial class Home
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.comlist = new System.Windows.Forms.ListBox();
            this.playerlist = new System.Windows.Forms.ListBox();
            this.taglist = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.手动添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自动添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.我的收藏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.favbt = new System.Windows.Forms.Button();
            this.dictxt = new System.Windows.Forms.Label();
            this.tagtxt = new System.Windows.Forms.Label();
            this.playertxt = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.Label();
            this.comnotxt = new System.Windows.Forms.Label();
            this.openvedio = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.opendic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comlist
            // 
            this.comlist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.comlist.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comlist.FormattingEnabled = true;
            this.comlist.ItemHeight = 21;
            this.comlist.Items.AddRange(new object[] {
            "所有"});
            this.comlist.Location = new System.Drawing.Point(12, 40);
            this.comlist.Name = "comlist";
            this.comlist.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.comlist.Size = new System.Drawing.Size(221, 338);
            this.comlist.TabIndex = 0;
            this.comlist.SelectedIndexChanged += new System.EventHandler(this.comlist_SelectedIndexChanged);
            // 
            // playerlist
            // 
            this.playerlist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerlist.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.playerlist.FormattingEnabled = true;
            this.playerlist.ItemHeight = 21;
            this.playerlist.Items.AddRange(new object[] {
            "所有"});
            this.playerlist.Location = new System.Drawing.Point(251, 40);
            this.playerlist.Name = "playerlist";
            this.playerlist.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.playerlist.Size = new System.Drawing.Size(221, 338);
            this.playerlist.TabIndex = 1;
            this.playerlist.SelectedIndexChanged += new System.EventHandler(this.playerlist_SelectedIndexChanged);
            // 
            // taglist
            // 
            this.taglist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taglist.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.taglist.FormattingEnabled = true;
            this.taglist.ItemHeight = 21;
            this.taglist.Items.AddRange(new object[] {
            "所有"});
            this.taglist.Location = new System.Drawing.Point(490, 40);
            this.taglist.Name = "taglist";
            this.taglist.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.taglist.Size = new System.Drawing.Size(221, 338);
            this.taglist.TabIndex = 2;
            this.taglist.SelectedIndexChanged += new System.EventHandler(this.taglist_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 397);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 47;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(700, 350);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加ToolStripMenuItem,
            this.管理ToolStripMenuItem,
            this.我的收藏ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1230, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 添加ToolStripMenuItem
            // 
            this.添加ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.手动添加ToolStripMenuItem,
            this.自动添加ToolStripMenuItem});
            this.添加ToolStripMenuItem.Name = "添加ToolStripMenuItem";
            this.添加ToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.添加ToolStripMenuItem.Text = "添加";
            // 
            // 手动添加ToolStripMenuItem
            // 
            this.手动添加ToolStripMenuItem.Name = "手动添加ToolStripMenuItem";
            this.手动添加ToolStripMenuItem.Size = new System.Drawing.Size(168, 30);
            this.手动添加ToolStripMenuItem.Text = "手动添加";
            this.手动添加ToolStripMenuItem.Click += new System.EventHandler(this.手动添加ToolStripMenuItem_Click);
            // 
            // 自动添加ToolStripMenuItem
            // 
            this.自动添加ToolStripMenuItem.Name = "自动添加ToolStripMenuItem";
            this.自动添加ToolStripMenuItem.Size = new System.Drawing.Size(168, 30);
            this.自动添加ToolStripMenuItem.Text = "自动添加";
            this.自动添加ToolStripMenuItem.Click += new System.EventHandler(this.自动添加ToolStripMenuItem_Click);
            // 
            // 管理ToolStripMenuItem
            // 
            this.管理ToolStripMenuItem.Name = "管理ToolStripMenuItem";
            this.管理ToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.管理ToolStripMenuItem.Text = "管理";
            this.管理ToolStripMenuItem.Click += new System.EventHandler(this.管理ToolStripMenuItem_Click);
            // 
            // 我的收藏ToolStripMenuItem
            // 
            this.我的收藏ToolStripMenuItem.Name = "我的收藏ToolStripMenuItem";
            this.我的收藏ToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.我的收藏ToolStripMenuItem.Text = "我的收藏";
            this.我的收藏ToolStripMenuItem.Click += new System.EventHandler(this.我的收藏ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.favbt);
            this.groupBox1.Controls.Add(this.dictxt);
            this.groupBox1.Controls.Add(this.tagtxt);
            this.groupBox1.Controls.Add(this.playertxt);
            this.groupBox1.Controls.Add(this.nametxt);
            this.groupBox1.Controls.Add(this.comnotxt);
            this.groupBox1.Controls.Add(this.openvedio);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.opendic);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(731, 397);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 350);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // favbt
            // 
            this.favbt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.favbt.Location = new System.Drawing.Point(345, 280);
            this.favbt.Name = "favbt";
            this.favbt.Size = new System.Drawing.Size(110, 43);
            this.favbt.TabIndex = 12;
            this.favbt.Text = "收藏";
            this.favbt.UseVisualStyleBackColor = true;
            this.favbt.Click += new System.EventHandler(this.favbt_Click);
            // 
            // dictxt
            // 
            this.dictxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dictxt.Location = new System.Drawing.Point(93, 210);
            this.dictxt.Name = "dictxt";
            this.dictxt.Size = new System.Drawing.Size(362, 24);
            this.dictxt.TabIndex = 11;
            // 
            // tagtxt
            // 
            this.tagtxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tagtxt.Location = new System.Drawing.Point(93, 163);
            this.tagtxt.Name = "tagtxt";
            this.tagtxt.Size = new System.Drawing.Size(362, 24);
            this.tagtxt.TabIndex = 10;
            // 
            // playertxt
            // 
            this.playertxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.playertxt.Location = new System.Drawing.Point(93, 117);
            this.playertxt.Name = "playertxt";
            this.playertxt.Size = new System.Drawing.Size(362, 24);
            this.playertxt.TabIndex = 9;
            // 
            // nametxt
            // 
            this.nametxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nametxt.Location = new System.Drawing.Point(93, 70);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(362, 24);
            this.nametxt.TabIndex = 8;
            // 
            // comnotxt
            // 
            this.comnotxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comnotxt.Location = new System.Drawing.Point(93, 23);
            this.comnotxt.Name = "comnotxt";
            this.comnotxt.Size = new System.Drawing.Size(362, 24);
            this.comnotxt.TabIndex = 7;
            // 
            // openvedio
            // 
            this.openvedio.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.openvedio.Location = new System.Drawing.Point(189, 280);
            this.openvedio.Name = "openvedio";
            this.openvedio.Size = new System.Drawing.Size(110, 43);
            this.openvedio.TabIndex = 6;
            this.openvedio.Text = "播放文件";
            this.openvedio.UseVisualStyleBackColor = true;
            this.openvedio.Click += new System.EventHandler(this.openvedio_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(23, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "地址";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(23, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "标签";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(23, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "女优";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(23, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "标题";
            // 
            // opendic
            // 
            this.opendic.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.opendic.Location = new System.Drawing.Point(28, 280);
            this.opendic.Name = "opendic";
            this.opendic.Size = new System.Drawing.Size(110, 43);
            this.opendic.TabIndex = 1;
            this.opendic.Text = "打开目录";
            this.opendic.UseVisualStyleBackColor = true;
            this.opendic.Click += new System.EventHandler(this.opendic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "番号";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.ErrorImage = global::AVManager.Properties.Resources.miss;
            this.pictureBox1.InitialImage = global::AVManager.Properties.Resources.no;
            this.pictureBox1.Location = new System.Drawing.Point(731, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(484, 338);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 759);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.taglist);
            this.Controls.Add(this.playerlist);
            this.Controls.Add(this.comlist);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AV Content";
            this.Load += new System.EventHandler(this.Home_Load);
            this.SizeChanged += new System.EventHandler(this.Home_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox comlist;
        private System.Windows.Forms.ListBox playerlist;
        private System.Windows.Forms.ListBox taglist;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 添加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button openvedio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button opendic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dictxt;
        private System.Windows.Forms.Label tagtxt;
        private System.Windows.Forms.Label playertxt;
        private System.Windows.Forms.Label nametxt;
        private System.Windows.Forms.Label comnotxt;
        private System.Windows.Forms.Button favbt;
        private System.Windows.Forms.ToolStripMenuItem 我的收藏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 手动添加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自动添加ToolStripMenuItem;
    }
}

