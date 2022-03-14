using QuanLySach.BLL;
using QuanLySach.Model;
using QuanLySach.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySach
{
    public partial class FormSach : Form
    {
        internal Sach SachChinhSua { get; set; }
        internal Sach SachSelected { get; set; }

        public FormSach()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNapLai_Click(object sender, EventArgs e)
        {
            //nạp danh sách các quyển sách và hiển thị lên grid
            BizSach bizsach = new BizSach();
            BizNhaXuatBan biznhaxuatban = new BizNhaXuatBan();
            //Hiển thị lên GUI/grid
            
            gridSach.AutoGenerateColumns = false;
            gridSach.DataSource = bizsach.ReadAll();
            colMaSach.DataPropertyName = "MaSach";
            colTieuDe.DataPropertyName = "TieuDe";
            colTacGia.DataPropertyName = "DanhSachTacGia";
            colNhaXuatBan.DataPropertyName = "MaNhaXuatBan";
            //colNhaXuatBan.DataPropertyName = "TenNhaXuatBan";



            lblThongKe.Text = "Có [" + gridSach.RowCount + "] sách";
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            FormSachNew frmSachNew = new FormSachNew();
            //frmSachNew.Show();
            if(frmSachNew.ShowDialog() == DialogResult.OK)//chỉ show 1 lần
            {
                //Nếu chèn thành công thì nạp lại danh sách;
                Sach x = frmSachNew.InsertedSach;

                //Thêm vào grid
                List<Sach> lst = (List<Sach>)(gridSach.DataSource);
                lst.Add(x);
                gridSach.DataSource = null;
                gridSach.DataSource=lst;
                //gridSach.Refresh();
                lblThongKe.Text = "Có [" + gridSach.RowCount + "] sách";
            }
            else
            {
                //Do nothing
            }

        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            
            //1.Xác định quyển sách được chọn
            DataGridViewRow selectedRow = gridSach.CurrentRow;
            Sach ss = (Sach)selectedRow.DataBoundItem;

            SachSelected = ss;

            FormChinhSua frmchinhsua = new FormChinhSua();
            if(frmchinhsua.ShowDialog() == DialogResult.OK)
            {
                
            }
            else
            {

            }
            
        }

        private void lblThongKe_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //Xóa quyển sách được chọn
            //1.Xác định quyển sách được chọn
            DataGridViewRow selectedRow  = gridSach.CurrentRow;
            Sach s = (Sach)selectedRow.DataBoundItem;
            
            if(s == null)
            {
                MessageBox.Show("Bạn chưa chọn sách", "SOS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                //2.Thực hiện xóa sách
                BizSach bizsach = new BizSach();
                if (bizsach.Xoa(s) == true)
                {
                    List<Sach> lst = (List<Sach>)(gridSach.DataSource);
                    lst.Remove(s);
                    gridSach.DataSource = null;
                    gridSach.DataSource = lst;
                    lblThongKe.Text = "Có [" + gridSach.RowCount + "] sách";
                    //gridSach.Refresh();
                    //bizsach.Xoa(s);
                }
            }

            
           
            
        }
    }
}
