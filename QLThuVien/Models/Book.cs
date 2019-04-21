using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.Models
{
    public class book
    {
        private string codeBook;
        private string nameBook;
        private string authorBook;
        private string typeofBook;
        private string publishingHouse;
        private int priceBook;
        private int amountBook;
        private string status;

        public string CodeBook { get => codeBook; set => codeBook = value; }
        public string NameBook { get => nameBook; set => nameBook = value; }
        public string AuthorBook { get => authorBook; set => authorBook = value; }
        public string TypeofBook { get => typeofBook; set => typeofBook = value; }
        public string PublishingHouse { get => publishingHouse; set => publishingHouse = value; }
        public int PriceBook { get => priceBook; set => priceBook = value; }
        public int AmountBook { get => amountBook; set => amountBook = value; }
        public string Status { get => status; set => status = value; }
    }
}
