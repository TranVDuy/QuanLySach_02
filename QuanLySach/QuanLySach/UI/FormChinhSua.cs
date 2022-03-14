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
    public partial class FormChinhSua : Form
    {
        public FormChinhSua()
        {
            InitializeComponent();
            BizNhaXuatBan biznhaxuatban = new BizNhaXuatBan();
            FormSach frmsach = new FormSach();
            cboNXB.DataSource = biznhaxuatban.ReadAll();
            cboNXB.DisplayMember = "TenNhaXuatBan";
            Sach ss = frmsach.SachSelected;
            
        }

        private void bntDongY_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
