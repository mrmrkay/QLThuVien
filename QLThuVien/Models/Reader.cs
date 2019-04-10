using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.Models
{
    public class Reader
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string BirthDay { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string ImagesUrl { get; set; }

        public string RegisterDay { get; set; }

        public bool Gender { get; set; }
    }
}
