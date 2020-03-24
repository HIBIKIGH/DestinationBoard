using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;

namespace DestinationBoardAppWPF
{
    class Organization
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public Boolean IsTop { get; set; }
        public Boolean IsEnd { get; set; }
        public int ParentId { get; set; }
    }
}
