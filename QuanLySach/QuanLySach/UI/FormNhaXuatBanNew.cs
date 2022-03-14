using QuanLySach.BLL;
using QuanLySach.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySach.UI
{
    public partial class FormNhaXuatBanNew : Form
    {
        public FormNhaXuatBanNew()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            BizNhaXuatBan bizNhaXuatBan = new BizNhaXuatBan();
            NhaXuatban nxb = new NhaXuatban();
            bizNhaXuatBan.Insert(nxb);
        }
    }
}
