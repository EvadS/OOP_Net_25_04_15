using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursDiplomWork
{
    public abstract  class Work
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string StudentName { get; set; }
        public string GroupNumber { get; set; }
    }
}
