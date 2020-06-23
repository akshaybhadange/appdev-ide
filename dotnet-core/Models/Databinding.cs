using System;
using System.Collections.Generic;

namespace CRUD_Operations.Models
{
    public partial class Dataset
    {
        public Dataset()
        {
            Db = new HashSet<Db>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public int Gender { get; set; }
        public string Specialist { get; set; }
        public DateTimeOffset Created { get; set; }

        public virtual ICollection<Db> data_ { get; set; }
    }
}
