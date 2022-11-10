using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Lib_project
{
    public class Books
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public string Authors { get; set; }
        public string Genres { get; set; }
        public string Language { get; set; }
        public string Publisher { get; set; }
        public DateTime Publisher_date { get; set; }
        public int Num_of_cop { get; set; }
        public int In_stock { get; set; }


    }
}
