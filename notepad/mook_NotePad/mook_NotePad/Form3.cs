using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mook_NotePad
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // 폼 닫기
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.lblAbout03.Text = this.lblAbout03.Text + SystemInformation.UserName;
            this.lblAbout04.Text = this.lblAbout04.Text + SystemInformation.ComputerName;
        }
    }
}
