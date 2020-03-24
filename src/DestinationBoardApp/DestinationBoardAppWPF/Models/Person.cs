using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;

namespace DestinationBoardAppWPF
{
    class Person
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public int OrgId { get; set; }
        public Boolean IsOrganizationHead { get; set; }
    }
}
