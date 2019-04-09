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
using QLThuVien.Controllers;

namespace QLThuVien.UserControlls
{
    public partial class ucBook : UserControl
    {
        public ucBook()
        {
            InitializeComponent();
        }

        private void dgvBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int n = e.RowIndex;
            txbType.Text = dgvBook.Rows[n].Cells[3].Value.ToString();
            txbCodeBook.Text = dgvBook.Rows[n].Cells[0].Value.ToString();
            txbNameBook.Text = dgvBook.Rows[n].Cells[1].Value.ToString();
            txbAuthor.Text = dgvBook.Rows[n].Cells[2].Value.ToString();
            txbPrice.Text = dgvBook.Rows[n].Cells[5].Value.ToString();
            txbStatus.Text = dgvBook.Rows[n].Cells[7].Value.ToString();
            txbAmount.Text = dgvBook.Rows[n].Cells[6].Value.ToString();
            txbHouse.Text = dgvBook.Rows[n].Cells[4].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
                if (txbCodeBook.Text == "" || txbNameBook.Text == "" || txbAuthor.Text == "" || txbPrice.Text == "" || txbType.Text == "" || txbHouse.Text == "" || txbAmount.Text == "")
                {
                    MessageBox.Show("Nhập đầy đủ thông tin");
                }
                else
                {
                    book b = new book();
                    b.CodeBook = txbCodeBook.Text.ToString();
                    b.NameBook = txbNameBook.Text.ToString();
                    b.PriceBook = int.Parse(txbPrice.Text.ToString());
                    b.PublishingHouse = txbHouse.Text.ToString();
                    b.AuthorBook = txbAuthor.Text.ToString();
                    b.AmountBook = int.Parse(txbAmount.Text.ToString());
                    b.TypeofBook = txbType.Text.ToString();
                    b.Status = txbStatus.Text.ToString();
                    Book.Instance.Add_Book(b);
                    if (Book.Instance.Add_Book(b) == true)
                    {
                        MessageBox.Show("Thêm không  thành công")
    ;
                    }
                    else
                    {
                        MessageBox.Show("Thêm thành công");
                        cleartextbook();
                }

                }
            
        }
        private void cleartextbook()
        {
            txbType.Text = "";
            txbCodeBook.Text = "";
            txbNameBook.Text = "";
            txbAuthor.Text = "";
            txbPrice.Text = "";
            txbStatus.Text = "";
            txbAmount.Text = "";
            txbHouse.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

           
                if (txbCodeBook.Text == "" || txbNameBook.Text == "" || txbAuthor.Text == "" || txbPrice.Text == "" || txbType.Text == "" || txbHouse.Text == "" || txbAmount.Text == "")
                {
                    MessageBox.Show("Nhập đầy đủ thông tin");
                }
                else
                {
                    book b = new book();
                    b.CodeBook = txbCodeBook.Text.ToString();
                    b.NameBook = txbNameBook.Text.ToString();
                    b.PriceBook = int.Parse(txbPrice.Text.ToString());
                    b.PublishingHouse = txbHouse.Text.ToString();
                    b.AuthorBook = txbAuthor.Text.ToString();
                    b.AmountBook = int.Parse(txbAmount.Text.ToString());
                    b.TypeofBook = txbType.Text.ToString();
                    b.Status = txbStatus.Text.ToString();
                    Book.Instance.Update_Book(b);
                    if (Book.Instance.Update_Book(b) == true)
                    {
                    MessageBox.Show("Cập nhật  thành công");
                    cleartextbook();
                    
    ;
                    }
                    else
                    {
                    MessageBox.Show("Cập nhật không  thành công");
                    }

                }

            

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
                if (txbCodeBook.Text == "" )
               
                {
                    MessageBox.Show("Nhập đầy đủ thông tin");
                }
                else
                {
                    book b = new book();
                    b.CodeBook = txbCodeBook.Text.ToString();
                    b.NameBook = txbNameBook.Text.ToString();
                    b.PriceBook = int.Parse(txbPrice.Text.ToString());
                    b.PublishingHouse = txbHouse.Text.ToString();
                    b.AuthorBook = txbAuthor.Text.ToString();
                    b.AmountBook = int.Parse(txbAmount.Text.ToString());
                    b.TypeofBook = txbType.Text.ToString();
                    b.Status = txbStatus.Text.ToString();
                    Book.Instance.Delete_Book(b);
                    if (Book.Instance.Delete_Book(b) == true)
                    {
                    MessageBox.Show("Xóa thành công");
                    cleartextbook();
                    
                    }
                    else
                  {
                    MessageBox.Show("Xóa không  thành công");
                       
                    }

                }

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = txbNameBook.Text;

            if (txbNameBook.Text == "")
            { MessageBox.Show("Enter name book"); }
            else
            {
                List<book> lst = Book.Instance .ListBookFind(a);
                dgvBook.DataSource = lst;
               
            }
        }

        private void ucBook_Load(object sender, EventArgs e)
        {
            List<book> lst = Book.Instance.LoadList();
            dgvBook.DataSource = lst;
        }
    }
}
