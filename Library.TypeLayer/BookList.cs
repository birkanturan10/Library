using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.TypeLayer
{
    public class BookList
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID")]
        public int BookID { get; set; }

        [DisplayName("Kitap Adı")]
        public string BookName { get; set; }

        [DisplayName("Yazar")]
        public string Author { get; set; }

        [DisplayName("Sayfa Sayısı")]
        public int NumberOfPages { get; set; }

        [DisplayName("Basım Tarihi")]
        public int PublicationDate { get; set; }

        [DisplayName("Yayınevi")]
        public string Publisher { get; set; }
    }
}
