using System;
using System.Collections.Generic;

namespace dotnetServer.Models
{
    public partial class Analysis
    {
        public Data()
        {
            Analysis = new HashSet<Analysis>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public DateTimeOffset Created { get; set; }

        public virtual ICollection<Analysisdb> analysisdb_ { get; set; }
    }
}
