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
    public partial class FormSachNew : Form
    {
        internal Sach InsertedSach { get; private set; }

        //public Sach InsertedSach { get; private set; }

        public FormSachNew()
        {
            InitializeComponent();
            //Nạp danh sách các nhà xuất bản
            BizNhaXuatBan biznhaxuatban = new BizNhaXuatBan();

            cboNhaXuatBan.DataSource = biznhaxuatban.ReadAll();
            cboNhaXuatBan.DisplayMember = "TenNhaXuatBan";
        }

        private void bntOK_Click(object sender, EventArgs e)
        {
            //Thu nhập thông tin trên GUI
            int maSach = int.Parse(txtMaSach.Text);
            string tieude = txtTieuDe.Text;
            string danhsactacgia = txtDSTacGia.Text;
            int maNhaXuatBan = ((NhaXuatban)cboNhaXuatBan.SelectedItem).MaNhaXuatBan;
            int namXuatBan = int.Parse(txtNamXuatBan.Text);

            //Thành lập đối tượng Sach
            Sach x = new Sach();
            x.MaSach = maSach;
            x.TieuDe = tieude;
            x.DanhSachTacGia = danhsactacgia;
            x.NamXuatBan = namXuatBan;
            x.MaNhaXuatBan = maNhaXuatBan;

            //Thực hiện lưu vào csdl
            BizSach bizsach = new BizSach();
            bizsach.Insert(x);

            this.InsertedSach = x;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FormSachNew_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cboNhaXuatBan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
