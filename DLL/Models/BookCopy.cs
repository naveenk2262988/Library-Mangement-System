using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class BookCopy
    {
        public int CopyID { get; set; }
        public int BookID { get; set; }
        public bool Available { get; set; }

    }

}
