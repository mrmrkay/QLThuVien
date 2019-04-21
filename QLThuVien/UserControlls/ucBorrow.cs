using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QLThuVien.UserControlls
{
    public partial class ucBorrow : UserControl
    {
        public ucBorrow()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=NVL-PC\SQLEXPRESS;Initial Catalog=QLThuVien;Integrated Security=True";
        SqlConnection con;
        SqlDataAdapter daPhieuMuon;
        DataSet ds;
        public DataTable LoadDataGridViewPM()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string cmdtext = @"select * from PHIEUMUON";
            SqlCommand command = new SqlCommand(cmdtext, con);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            
            return dt;
        }
        public DataTable LoadDataGridViewPT()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string cmdtext = @"select * from PHIEUTRA";
            SqlCommand command = new SqlCommand(cmdtext, con);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            return dt;
        }
        private void ucBorrow_Load(object sender, EventArgs e)
        {
            string cmdtext = @"select * from DOCGIA";
            //kết nối csdl
            con = new SqlConnection(connectionString);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            //load du lieu combobox doc gia
            SqlCommand command = new SqlCommand(cmdtext, con);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            cmbPMDocGia.DataSource = dt;
            cmbPMDocGia.DisplayMember = "HoTen";
            cmbPMDocGia.ValueMember = "MaDocGia";
            cmbPTDocGia.DataSource = dt;
            cmbPTDocGia.DisplayMember = "HoTen";
            cmbPTDocGia.ValueMember = "MaDocGia";
            //load du lieu combobox Sach
            cmdtext = @"select * from SACH";
            command = new SqlCommand(cmdtext, con);
            reader = command.ExecuteReader();
            dt = new DataTable();
            dt.Load(reader);
            cmbPMSach.DataSource = dt;
            cmbPMSach.DisplayMember = "TenSach";
            cmbPMSach.ValueMember = "MaSach";
            cmbPTSach.DataSource = dt;
            cmbPTSach.DisplayMember = "TenSach";
            cmbPTSach.ValueMember = "MaSach";
            //load data gridview PhieuMuon
            dt = LoadDataGridViewPM();
            dgvPhieuMuon.DataSource = dt;
            dgvPhieuMuon.Columns[0].HeaderText = "Mã phiếu mượn";
            dgvPhieuMuon.Columns[1].HeaderText = "Mã độc giả";
            dgvPhieuMuon.Columns[2].HeaderText = "Mã sách";
            dgvPhieuMuon.Columns[3].HeaderText = "Ngày mượn";
            dgvPhieuMuon.Columns[4].HeaderText = "Ngày trả";
            //load dgv phieu tra
            dt = LoadDataGridViewPT();
            dgvPhieuTra.DataSource = dt;
            dgvPhieuTra.Columns[0].HeaderText = "Mã phiếu trả";
            dgvPhieuTra.Columns[1].HeaderText = "Mã độc giả";
            dgvPhieuTra.Columns[2].HeaderText = "Mã sách";
            dgvPhieuTra.Columns[3].HeaderText = "Ngày trả";
        }

        private void btnPMThem_Click(object sender, EventArgs e)
        {
            //kiem tra du lieu dau vao
            if (txtMaPhieuMuon.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Thông báo!");
                return;
            }
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sInsert = @"INSERT INTO dbo.PHIEUMUON( MaPhieu ,MaDocGia , MaSach ,NgayMuon ,NgayPhaiTra)" +
                @"VALUES  ( @MaPhieu ,@MaDocGia ,@MaSach,@NgayMuon,@NgayTra)";
            SqlCommand cmdInsert = new SqlCommand(sInsert, con);
            cmdInsert.Parameters.Add("@MaPhieu", SqlDbType.NChar).Value = txtMaPhieuMuon.Text;
            cmdInsert.Parameters.Add("@MaDocGia", SqlDbType.NChar).Value=cmbPMDocGia.SelectedValue;
            cmdInsert.Parameters.Add("@MaSach", SqlDbType.NChar).Value= cmbPMSach.SelectedValue;
            cmdInsert.Parameters.Add("@NgayMuon", SqlDbType.DateTime).Value= dtpPMNgayMuon.Value;
            cmdInsert.Parameters.Add("@NgayTra", SqlDbType.DateTime).Value= dtpPMNgayTra.Value;
            int ret = cmdInsert.ExecuteNonQuery();
            if (ret > 0)
            {
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvPhieuMuon.DataSource = LoadDataGridViewPM();
            }

            else MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void btnPMSua_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            if (dgvPhieuMuon.SelectedRows != null)
            {
                string sUpdate = @"UPDATE PHIEUMUON SET MaDocGia=@MaDocGia, MaSach=@MaSach," +
                 @" NgayMuon=@NgayMuon, NgayPhaiTra=@NgayPhaiTra WHERE MaPhieu=@MaPhieu";
                SqlCommand cmdUpdate = new SqlCommand(sUpdate, con);
                cmdUpdate.Parameters.Add("@MaPhieu", SqlDbType.NChar).Value=txtMaPhieuMuon.Text;
                cmdUpdate.Parameters.Add("@MaDocGia", SqlDbType.NChar).Value=cmbPMDocGia.SelectedValue;
                cmdUpdate.Parameters.Add("@MaSach", SqlDbType.NChar).Value=cmbPMSach.SelectedValue;
                cmdUpdate.Parameters.Add("@NgayMuon", SqlDbType.DateTime).Value = dtpPMNgayMuon.Value ;
                cmdUpdate.Parameters.Add("@NgayPhaiTra", SqlDbType.DateTime).Value=dtpPMNgayTra.Value;
                int ret = cmdUpdate.ExecuteNonQuery();
                if (ret > 0)
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvPhieuMuon.SelectedRows[0].Cells[0].Value = txtMaPhieuMuon.Text;
                    dgvPhieuMuon.SelectedRows[0].Cells[1].Value = cmbPMDocGia.SelectedValue;
                    dgvPhieuMuon.SelectedRows[0].Cells[2].Value = cmbPMSach.SelectedValue;
                    dgvPhieuMuon.SelectedRows[0].Cells[3].Value = dtpPMNgayMuon.Value;
                    dgvPhieuMuon.SelectedRows[0].Cells[4].Value = dtpPMNgayTra.Value;
                }

                else MessageBox.Show("Sửa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void dgvPhieuMuon_Click(object sender, EventArgs e)
        {
            if (dgvPhieuMuon.SelectedRows != null)
            {
                DataGridViewRow dgvr = dgvPhieuMuon.SelectedRows[0];
                txtMaPhieuMuon.Text = dgvr.Cells[0].Value.ToString();
                cmbPMDocGia.SelectedValue = dgvr.Cells[1].Value;
                cmbPMSach.SelectedValue = dgvr.Cells[2].Value;
                dtpPMNgayMuon.Value = (DateTime)dgvr.Cells[3].Value;
                dtpPMNgayTra.Value = (DateTime)dgvr.Cells[4].Value;
            }
        }

        private void btnPMXoa_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            if (dgvPhieuMuon.SelectedRows != null)
            {
                string sDelete = @"DELETE FROM dbo.PHIEUMUON WHERE MaPhieu='"+txtMaPhieuMuon.Text+"'";
                SqlCommand cmdDelete = new SqlCommand(sDelete, con);
                
                int ret = cmdDelete.ExecuteNonQuery();
                if (ret > 0)
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvPhieuMuon.Rows.RemoveAt(dgvPhieuMuon.SelectedRows[0].Index);
                }

                else MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPTThem_Click(object sender, EventArgs e)
        {
            //kiem tra du lieu dau vao
            if (txtPTMaPhieu.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Thông báo!");
                return;
            }
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sInsert = @"INSERT INTO dbo.PHIEUTRA( MaPhieu ,MaDocGia , MaSach ,NgayTra)" +
                @"VALUES  ( @MaPhieu ,@MaDocGia ,@MaSach,@NgayTra)";
            SqlCommand cmdInsert = new SqlCommand(sInsert, con);
            cmdInsert.Parameters.Add("@MaPhieu", SqlDbType.NChar).Value = txtPTMaPhieu.Text;
            cmdInsert.Parameters.Add("@MaDocGia", SqlDbType.NChar).Value = cmbPTDocGia.SelectedValue;
            cmdInsert.Parameters.Add("@MaSach", SqlDbType.NChar).Value = cmbPTSach.SelectedValue;
            cmdInsert.Parameters.Add("@NgayTra", SqlDbType.DateTime).Value = dtpPTNgayTra.Value;
            int ret = cmdInsert.ExecuteNonQuery();
            if (ret > 0)
            {
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvPhieuTra.DataSource = LoadDataGridViewPT();
            }

            else MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnPTSua_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            if (dgvPhieuTra.SelectedRows != null)
            {
                string sUpdate = @"UPDATE PHIEUTRA SET MaDocGia=@MaDocGia, MaSach=@MaSach," +
                 @" NgayTra=@NgayTra WHERE MaPhieu=@MaPhieu";
                SqlCommand cmdUpdate = new SqlCommand(sUpdate, con);
                cmdUpdate.Parameters.Add("@MaPhieu", SqlDbType.NChar).Value = txtPTMaPhieu.Text;
                cmdUpdate.Parameters.Add("@MaDocGia", SqlDbType.NChar).Value = cmbPTDocGia.SelectedValue;
                cmdUpdate.Parameters.Add("@MaSach", SqlDbType.NChar).Value = cmbPTSach.SelectedValue;
                cmdUpdate.Parameters.Add("@NgayTra", SqlDbType.DateTime).Value = dtpPTNgayTra.Value;
                int ret = cmdUpdate.ExecuteNonQuery();
                if (ret > 0)
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvPhieuTra.SelectedRows[0].Cells[1].Value = cmbPTDocGia.SelectedValue;
                    dgvPhieuTra.SelectedRows[0].Cells[2].Value = cmbPTSach.SelectedValue;
                    dgvPhieuTra.SelectedRows[0].Cells[3].Value = dtpPTNgayTra.Value;
                }

                else MessageBox.Show("Sửa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dgvPhieuTra_Click(object sender, EventArgs e)
        {
            if (dgvPhieuTra.SelectedRows != null)
            {
                DataGridViewRow dgvr = dgvPhieuTra.SelectedRows[0];
                txtPTMaPhieu.Text = dgvr.Cells[0].Value.ToString();
                cmbPTDocGia.SelectedValue = dgvr.Cells[1].Value;
                cmbPTSach.SelectedValue = dgvr.Cells[2].Value;
                dtpPTNgayTra.Value = (DateTime)dgvr.Cells[3].Value;
            }
        }

        private void btnPTXoa_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            if (dgvPhieuTra.SelectedRows != null)
            {
                string sDelete = @"DELETE FROM dbo.PHIEUTRA WHERE MaPhieu='" + txtPTMaPhieu.Text + "'";
                SqlCommand cmdDelete = new SqlCommand(sDelete, con);

                int ret = cmdDelete.ExecuteNonQuery();
                if (ret > 0)
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvPhieuTra.Rows.RemoveAt(dgvPhieuTra.SelectedRows[0].Index);
                }

                else MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
