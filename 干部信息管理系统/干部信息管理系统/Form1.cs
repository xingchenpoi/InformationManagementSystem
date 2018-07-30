using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 干部信息管理系统
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 读取ini文件
        /// </summary>
        ReadIni readIni;

        /// <summary>
        /// 版本号
        /// </summary>
        private string version = "";

        public Form1()
        {
            InitializeComponent();
        }


        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (tb_Password.Text.Equals(readIni.ReadString("password")))
            {
                if (rdo_CityLevel.Visible)
                {
                    if ((rdo_CityLevel.Checked == true) || (rdo_CountyLevel.Checked == true) || (rdo_CountryLevel.Checked == true))
                    {
                        readIni.WriteString("tempversion",version);
                        FrmUnit frmUnit = new FrmUnit();
                        
                    }
                            
                                           
                    
                }
            }
        }
    }
}
