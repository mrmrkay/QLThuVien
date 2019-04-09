using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLThuVien.Models;
using System.Data.SqlClient;
using System.Configuration;
using Dapper;

namespace QLThuVien.UserControlls
{
    public partial class ucReader : UserControl
    {
        EntityState objState = EntityState.Unchanged;
        public ucReader()
        {
            InitializeComponent();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg|PNG|*.png", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pic.Image = Image.FromFile(ofd.FileName);
                    Reader obj = readerBindingSource.Current as Reader;
                    if (obj != null)
                    {
                        obj.ImagesUrl = ofd.FileName;
                    }
                }
            }
        }

        void ClearInput()
        {
            txtName.Text = null;
            txtEmail.Text = null;
            txtAddress.Text = null;
            chkGender.Checked = false;
            txtBirth.Text = null;
            txtRegister.Text = null;
            pic.Image = null;
        }

        private void ucReader_Load(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        readerBindingSource.DataSource = db.Query<Reader>("SELECT * FROM dbo.DOCGIA", commandType: CommandType.Text);
                        pContainer.Enabled = false;
                        Reader obj = readerBindingSource.Current as Reader;
                        if (obj != null)
                        {
                            if (!string.IsNullOrEmpty(obj.ImagesUrl))
                            {
                                pic.Image = Image.FromFile(obj.ImagesUrl);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            objState = EntityState.Added;
            pic.Image = null;
            pContainer.Enabled = true;
            readerBindingSource.Add(new Reader());
            readerBindingSource.MoveLast();
            txtName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pContainer.Enabled = false;
            readerBindingSource.ResetBindings(false);
            //ClearInput();
            this.ucReader_Load(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            objState = EntityState.Changed;
            pContainer.Enabled = true;
            txtName.Focus();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Reader obj = readerBindingSource.Current as Reader;
                if (obj != null)
                {
                    if (!string.IsNullOrEmpty(obj.ImagesUrl))
                        pic.Image = Image.FromFile(obj.ImagesUrl);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            objState = EntityState.Deleted;
            if (MessageBox.Show(this, "Are you sure want to delete this record?", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    Reader obj = readerBindingSource.Current as Reader;
                    if (obj != null)
                    {

                        using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                        {
                            if (db.State == ConnectionState.Closed)
                                db.Open();
                            int result = db.Execute("delete from DOCGIA where ID = @ID", new { ID = obj.ID }, commandType: CommandType.Text);
                            if (result != 0)
                            {
                                readerBindingSource.RemoveCurrent();
                                pContainer.Enabled = false;
                                pic.Image = null;
                                objState = EntityState.Unchanged;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                readerBindingSource.EndEdit();
                Reader obj = readerBindingSource.Current as Reader;
                if (obj != null)
                {

                    using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        if (objState == EntityState.Added)
                        {
                            DynamicParameters p = new DynamicParameters();
                            p.Add("@ID", dbType : DbType.Int32, direction: ParameterDirection.Output);
                            p.AddDynamicParams(new { Name = obj.Name, Email = obj.Email, Address = obj.Address, Gender = obj.Gender, BirthDay = obj.BirthDay, RegisterDay = obj.RegisterDay, ImagesUrl = obj.ImagesUrl });
                            db.Execute("sp_DOCGIA_Insert", p, commandType: CommandType.StoredProcedure);
                            obj.ID = p.Get<int>("@ID");
                        }
                        else if (objState == EntityState.Changed)
                        {
                            db.Execute("sp_DOCGIA_Update", new { ID = obj.ID, Name = obj.Name, Email = obj.Email, Address = obj.Address, Gender = obj.Gender, BirthDay = obj.BirthDay, RegisterDay = obj.RegisterDay, ImagesUrl = obj.ImagesUrl }, commandType: CommandType.StoredProcedure);
                        }
                        dataGridView1.Refresh();
                        pContainer.Enabled = false;
                        objState = EntityState.Unchanged;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkGender_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkGender.CheckState == CheckState.Checked)
            {
                chkGender.Text = "Female";
            }
            else if (chkGender.CheckState == CheckState.Unchecked)
            {
                chkGender.Text = "Male";
            }
            else chkGender.Text = "???";
        }
    }
}
