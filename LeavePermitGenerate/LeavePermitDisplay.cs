﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeavePermitGenerate
{
    public partial class LeavePermitDisplay : Form
    {
        static public LeavePermitDisplay leavePermitDisplayHandle;

        public static LeavePermitDisplay GetInstance
        {
            get
            {
                if (leavePermitDisplayHandle == null || leavePermitDisplayHandle.IsDisposed)
                {
                    leavePermitDisplayHandle = new LeavePermitDisplay();
                }

                leavePermitDisplayHandle.Hide(); 
                return leavePermitDisplayHandle;
            }
        }

        private LeavePermitDisplay()
        {
            InitializeComponent();
        }

        private void LeavePermitDisplay_Load(object sender, EventArgs e)
        {

        }

        string name = "LoongLy";

        string filePath = "";

        string xuehao = "";

        string qingjia_riqi = "";

        string qingjia_shijian_text = "";

        string kaishi_shijian = "";

        string jieshu_shijian = "";

        string shengqing_shijian = "";

        string shengqing_didian = "";

        string qingjia_yuanyin_text = "";

        string qingjia_leixing_text = "";

        string nameAndXuehao = "";

        string dateAndTime = "";

        public void ExchangeMSG(string lab,string MSG)
        {
            if(lab == "qingjia_leixing")
            {
                qingjia_leixing_text = MSG;
            }
            else if(lab == "mingzi")
            {
                name = MSG;
                nameAndXuehao = name + "(" + xuehao+")";
            }
            else if (lab == "xuehao")
            {
                xuehao = MSG;
                nameAndXuehao = name + "(" + xuehao + ")";
            }
            else if (lab == "qingjia_riqi")
            {
                qingjia_riqi = MSG;
                dateAndTime = qingjia_riqi + " " + shengqing_shijian;
            }
            else if(lab == "qingjia_shijian")
            {
                qingjia_shijian_text = MSG;
            }
            else if (lab == "shengqing_shijian")
            {
                shengqing_shijian = MSG;
                dateAndTime = qingjia_riqi + " " + shengqing_shijian;
            }
            else if (lab == "kaishi_shijian")
            {
                kaishi_shijian = MSG;
            }
            else if (lab == "jieshu_shijian")
            {
                jieshu_shijian = MSG;
            }
            else if (lab == "faqiweizhi")
            {
                shengqing_didian = MSG;
            }
            else if(lab == "qingjia_yuanyin")
            {
                qingjia_yuanyin_text = MSG;
            }
            else if(lab == "qingjia_leixing")
            {
                qingjia_leixing_text = MSG;
            }
            else if(lab == "fujian")
            {
                filePath = MSG;
            }
            qingjia_leixing.Text = qingjia_leixing_text;
            stuName.Text = nameAndXuehao;
            qingjia_leixing.Text = qingjia_leixing_text;
            faqi_shijian.Text = dateAndTime;
            qingjia_shijian.Text = qingjia_shijian_text+"("+qingjia_riqi+" "+kaishi_shijian+"-"+jieshu_shijian+")";
            qingjia_yuanyin.Text = qingjia_yuanyin_text;
            faqi_weizhi.Text = shengqing_didian;
            if (filePath != "")
            { fujian.BackgroundImage = Image.FromFile(filePath); }
        }

        private void qingjia_leixing_Click(object sender, EventArgs e)
        {

        }

        private void Name_Click(object sender, EventArgs e)
        {

        }

        private void qingjia_shijian_Click(object sender, EventArgs e)
        {

        }

        private void faqi_shijian_Click(object sender, EventArgs e)
        {

        }

        private void qingjia_yuanyin_Click(object sender, EventArgs e)
        {

        }

        private void faqi_weizhi_Click(object sender, EventArgs e)
        {

        }

        private void fujian_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
