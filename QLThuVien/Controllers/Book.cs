using QLKho.Controller;
using QLThuVien.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.Controllers
{
   public  class Book
    {
        
        private static Book instance;
        public static Book Instance
        {
            get { if (instance == null) instance = new Book(); return instance; }
            set { instance = value; }
        }

        public  List<book> LoadList()
            {
                string query = "select * from SACH";
                DataTable db = new DataTable();
                db = SqlConnect.Instance.ExecuteQuery(query);
                if (db.Rows.Count == 0) return null;
                else
                {
                    List<book> books = new List<book>();
                    for (int i = 0; i < db.Rows.Count; i++)
                    {
                        book b = new book();
                        b.CodeBook = db.Rows[i]["MaSach"].ToString();
                        b.NameBook = db.Rows[i]["TenSach"].ToString();
                        b.AuthorBook = db.Rows[i]["TacGia"].ToString();
                        b.PublishingHouse = db.Rows[i]["NhaXuatBan"].ToString();
                        b.PriceBook = (int)db.Rows[i]["GiaSach"];
                        b.AmountBook = (int)db.Rows[i]["SoLuong"];
                        b.Status = db.Rows[i]["TinhTrang"].ToString();
                        b.TypeofBook = db.Rows[i]["TheLoai"].ToString();
                        books.Add(b);
                    }
                    return books;
                }


            }
            public  List<book> ListBookFind(string namebook)
            {
                string query = "select * FROM  SACH WHERE TenSach =N'" + namebook + "'";
                DataTable db = new DataTable();
                db = SqlConnect.Instance.ExecuteQuery(query);
                if (db.Rows.Count == 0) return null;
                else
                {
                    List<book> books = new List<book>();
                    for (int i = 0; i < db.Rows.Count; i++)
                    {
                        book b = new book();
                        b.CodeBook = db.Rows[i]["MaSach"].ToString();
                        b.NameBook = db.Rows[i]["TenSach"].ToString();
                        b.AuthorBook = db.Rows[i]["TacGia"].ToString();
                        b.PublishingHouse = db.Rows[i]["NhaXuatBan"].ToString();
                        b.PriceBook = (int)db.Rows[i]["GiaSach"];
                        b.AmountBook = (int)db.Rows[i]["SoLuong"];
                        b.Status = db.Rows[i]["TinhTrang"].ToString();
                        b.TypeofBook = db.Rows[i]["TheLoai"].ToString();
                        books.Add(b);
                    }
                    return books;
                }


            }
            public  bool Add_Book(book a)
            {
                string query = "insert into SACH( MaSach ,TenSach  ,TacGia,TheLoai,NhaXuatBan,GiaSach,TinhTrang,SoLuong)   values(N'" + a.CodeBook + "', N'" + a.NameBook + "', N'" + a.AuthorBook + "', N'" + a.TypeofBook + "', N'" + a.PublishingHouse + "', N'" + a.PriceBook + "', N'" + a.Status + "', '" + a.AmountBook + "') ";

                try
                {
                    SqlConnect.Instance.ExcuseNonQuery(query);

                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
            public  bool Delete_Book(book a)
            {
                string query = "delete  from SACH where MaSach = '" + a.CodeBook + "'";//' and TenSach = '" + a.NameBook + "' and TacGia = '" + a.AuthorBook + "' and TheLoai = '" + a.TypeofBook + "' and NhaXuatBan = '" + a.PublishingHouse + "' and GiaSach = '" + a.PriceBook + "' and TheLoai = '" + a.TypeofBook + "' and TinhTrang = '" + a.Status + "' ";

                try
                {
                    SqlConnect.Instance.ExcuseNonQuery(query);

                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
            public  bool Update_Book(book a)
            {
                string query = " update Sach set MaSach = '" + a.CodeBook + "', TenSach = '" + a.NameBook + "',TacGia = '" + a.AuthorBook + "' ,TheLoai = '" + a.TypeofBook + "' , NhaXuatBan = '" + a.PublishingHouse + "',GiaSach = '" + a.PriceBook + "' , TinhTrang = '" + a.Status + "', SoLuong = '" + a.AmountBook + "' where MaSach = '" + a.CodeBook + "'";

                try
                {
                    SqlConnect.Instance.ExcuseNonQuery(query);

                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        
    }
}
