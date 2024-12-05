namespace LeavePermitGenerate
{
    partial class LeavePermitDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeavePermitDisplay));
            this.stuName = new System.Windows.Forms.Label();
            this.qingjia_leixing = new System.Windows.Forms.Label();
            this.qingjia_shijian = new System.Windows.Forms.Label();
            this.faqi_shijian = new System.Windows.Forms.Label();
            this.qingjia_yuanyin = new System.Windows.Forms.Label();
            this.faqi_weizhi = new System.Windows.Forms.Label();
            this.fujian = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fujian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // stuName
            // 
            this.stuName.BackColor = System.Drawing.Color.Transparent;
            this.stuName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stuName.Location = new System.Drawing.Point(101, 248);
            this.stuName.Name = "stuName";
            this.stuName.Size = new System.Drawing.Size(353, 28);
            this.stuName.TabIndex = 0;
            this.stuName.Text = "LoongLy";
            this.stuName.Click += new System.EventHandler(this.Name_Click);
            // 
            // qingjia_leixing
            // 
            this.qingjia_leixing.BackColor = System.Drawing.Color.Transparent;
            this.qingjia_leixing.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.qingjia_leixing.Location = new System.Drawing.Point(101, 196);
            this.qingjia_leixing.Name = "qingjia_leixing";
            this.qingjia_leixing.Size = new System.Drawing.Size(54, 28);
            this.qingjia_leixing.TabIndex = 1;
            this.qingjia_leixing.Text = "事假";
            this.qingjia_leixing.Click += new System.EventHandler(this.qingjia_leixing_Click);
            // 
            // qingjia_shijian
            // 
            this.qingjia_shijian.BackColor = System.Drawing.Color.Transparent;
            this.qingjia_shijian.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.qingjia_shijian.Location = new System.Drawing.Point(92, 377);
            this.qingjia_shijian.Name = "qingjia_shijian";
            this.qingjia_shijian.Size = new System.Drawing.Size(346, 24);
            this.qingjia_shijian.TabIndex = 2;
            this.qingjia_shijian.Text = " 请假时间";
            this.qingjia_shijian.Click += new System.EventHandler(this.qingjia_shijian_Click);
            // 
            // faqi_shijian
            // 
            this.faqi_shijian.BackColor = System.Drawing.Color.Transparent;
            this.faqi_shijian.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.faqi_shijian.Location = new System.Drawing.Point(92, 413);
            this.faqi_shijian.Name = "faqi_shijian";
            this.faqi_shijian.Size = new System.Drawing.Size(362, 26);
            this.faqi_shijian.TabIndex = 3;
            this.faqi_shijian.Text = " 发起时间";
            this.faqi_shijian.Click += new System.EventHandler(this.faqi_shijian_Click);
            // 
            // qingjia_yuanyin
            // 
            this.qingjia_yuanyin.BackColor = System.Drawing.Color.Transparent;
            this.qingjia_yuanyin.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.qingjia_yuanyin.Location = new System.Drawing.Point(92, 451);
            this.qingjia_yuanyin.Name = "qingjia_yuanyin";
            this.qingjia_yuanyin.Size = new System.Drawing.Size(346, 26);
            this.qingjia_yuanyin.TabIndex = 4;
            this.qingjia_yuanyin.Text = " 请假原因";
            this.qingjia_yuanyin.Click += new System.EventHandler(this.qingjia_yuanyin_Click);
            // 
            // faqi_weizhi
            // 
            this.faqi_weizhi.BackColor = System.Drawing.Color.Transparent;
            this.faqi_weizhi.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.faqi_weizhi.Location = new System.Drawing.Point(92, 488);
            this.faqi_weizhi.Name = "faqi_weizhi";
            this.faqi_weizhi.Size = new System.Drawing.Size(346, 66);
            this.faqi_weizhi.TabIndex = 5;
            this.faqi_weizhi.Text = " 发起位置";
            this.faqi_weizhi.Click += new System.EventHandler(this.faqi_weizhi_Click);
            // 
            // fujian
            // 
            this.fujian.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fujian.Location = new System.Drawing.Point(22, 575);
            this.fujian.Name = "fujian";
            this.fujian.Size = new System.Drawing.Size(300, 258);
            this.fujian.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fujian.TabIndex = 6;
            this.fujian.TabStop = false;
            this.fujian.Click += new System.EventHandler(this.fujian_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(101, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "否";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(329, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "否";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(329, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "否";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LeavePermitGenerate.Properties.Resources.LeavePermitBkground;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(513, 1018);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(119, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(363, 62);
            this.label4.TabIndex = 11;
            this.label4.Text = "此界面已经弃用";
            // 
            // LeavePermitDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(507, 1013);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fujian);
            this.Controls.Add(this.faqi_weizhi);
            this.Controls.Add(this.qingjia_yuanyin);
            this.Controls.Add(this.faqi_shijian);
            this.Controls.Add(this.qingjia_shijian);
            this.Controls.Add(this.qingjia_leixing);
            this.Controls.Add(this.stuName);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LeavePermitDisplay";
            this.Text = "假条";
            this.Load += new System.EventHandler(this.LeavePermitDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fujian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stuName;
        private System.Windows.Forms.Label qingjia_leixing;
        private System.Windows.Forms.Label qingjia_shijian;
        private System.Windows.Forms.Label faqi_shijian;
        private System.Windows.Forms.Label qingjia_yuanyin;
        private System.Windows.Forms.Label faqi_weizhi;
        private System.Windows.Forms.PictureBox fujian;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}