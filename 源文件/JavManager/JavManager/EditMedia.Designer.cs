﻿namespace JavManager
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.findvedio = new System.Windows.Forms.Button();
            this.findpic = new System.Windows.Forms.Button();
            this.vediodictxt = new System.Windows.Forms.TextBox();
            this.picdictxt = new System.Windows.Forms.TextBox();
            this.tagtxt = new System.Windows.Forms.TextBox();
            this.playertxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.notxt = new System.Windows.Forms.TextBox();
            this.comtxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(393, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(215, 214);
            this.listBox1.TabIndex = 36;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // findvedio
            // 
            this.findvedio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findvedio.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.findvedio.Location = new System.Drawing.Point(574, 303);
            this.findvedio.Name = "findvedio";
            this.findvedio.Size = new System.Drawing.Size(30, 29);
            this.findvedio.TabIndex = 35;
            this.findvedio.Text = "...";
            this.findvedio.UseVisualStyleBackColor = true;
            this.findvedio.Click += new System.EventHandler(this.findvedio_Click);
            // 
            // findpic
            // 
            this.findpic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findpic.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.findpic.Location = new System.Drawing.Point(574, 257);
            this.findpic.Name = "findpic";
            this.findpic.Size = new System.Drawing.Size(30, 29);
            this.findpic.TabIndex = 34;
            this.findpic.Text = "...";
            this.findpic.UseVisualStyleBackColor = true;
            this.findpic.Click += new System.EventHandler(this.findpic_Click);
            // 
            // vediodictxt
            // 
            this.vediodictxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.vediodictxt.Location = new System.Drawing.Point(105, 303);
            this.vediodictxt.Name = "vediodictxt";
            this.vediodictxt.ReadOnly = true;
            this.vediodictxt.Size = new System.Drawing.Size(471, 29);
            this.vediodictxt.TabIndex = 33;
            this.vediodictxt.Enter += new System.EventHandler(this.vediodictxt_Enter);
            // 
            // picdictxt
            // 
            this.picdictxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.picdictxt.Location = new System.Drawing.Point(105, 257);
            this.picdictxt.Name = "picdictxt";
            this.picdictxt.ReadOnly = true;
            this.picdictxt.Size = new System.Drawing.Size(471, 29);
            this.picdictxt.TabIndex = 32;
            this.picdictxt.Enter += new System.EventHandler(this.picdictxt_Enter);
            // 
            // tagtxt
            // 
            this.tagtxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tagtxt.Location = new System.Drawing.Point(105, 210);
            this.tagtxt.Name = "tagtxt";
            this.tagtxt.Size = new System.Drawing.Size(279, 29);
            this.tagtxt.TabIndex = 31;
            this.tagtxt.Enter += new System.EventHandler(this.tagtxt_Enter);
            // 
            // playertxt
            // 
            this.playertxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.playertxt.Location = new System.Drawing.Point(105, 163);
            this.playertxt.Name = "playertxt";
            this.playertxt.Size = new System.Drawing.Size(279, 29);
            this.playertxt.TabIndex = 30;
            this.playertxt.Enter += new System.EventHandler(this.playertxt_Enter);
            // 
            // nametxt
            // 
            this.nametxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nametxt.Location = new System.Drawing.Point(105, 117);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(279, 29);
            this.nametxt.TabIndex = 29;
            this.nametxt.Enter += new System.EventHandler(this.nametxt_Enter);
            // 
            // notxt
            // 
            this.notxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.notxt.Location = new System.Drawing.Point(105, 70);
            this.notxt.Name = "notxt";
            this.notxt.ReadOnly = true;
            this.notxt.Size = new System.Drawing.Size(279, 29);
            this.notxt.TabIndex = 28;
            this.notxt.Enter += new System.EventHandler(this.notxt_Enter);
            // 
            // comtxt
            // 
            this.comtxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comtxt.Location = new System.Drawing.Point(105, 23);
            this.comtxt.Name = "comtxt";
            this.comtxt.ReadOnly = true;
            this.comtxt.Size = new System.Drawing.Size(279, 29);
            this.comtxt.TabIndex = 27;
            this.comtxt.Enter += new System.EventHandler(this.comtxt_Enter);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(232, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 40);
            this.button1.TabIndex = 26;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(3, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 21);
            this.label7.TabIndex = 25;
            this.label7.Text = "*资源文件";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(12, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 24;
            this.label6.Text = "封面文件";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(12, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "标签";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "女优";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "*标题";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "*编号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "*系列";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "图像文件(*.gif;*.jpg;*.jpeg;*.png;*.psd)|*.gif;*.jpg;*.jpeg;*.png;*.psd|所有文件(*.*)|*.*" +
    "";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Filter = resources.GetString("openFileDialog2.Filter");
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 430);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.findvedio);
            this.Controls.Add(this.findpic);
            this.Controls.Add(this.vediodictxt);
            this.Controls.Add(this.picdictxt);
            this.Controls.Add(this.tagtxt);
            this.Controls.Add(this.playertxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.notxt);
            this.Controls.Add(this.comtxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "编辑";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.SizeChanged += new System.EventHandler(this.Form4_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button findvedio;
        private System.Windows.Forms.Button findpic;
        private System.Windows.Forms.TextBox vediodictxt;
        private System.Windows.Forms.TextBox picdictxt;
        private System.Windows.Forms.TextBox tagtxt;
        private System.Windows.Forms.TextBox playertxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox notxt;
        private System.Windows.Forms.TextBox comtxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}