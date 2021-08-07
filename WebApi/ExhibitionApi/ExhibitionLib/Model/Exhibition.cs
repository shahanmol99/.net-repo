using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ExhibitionLib.Model
{
    public class Exhibition
    {
        [Key]
        public string ExhibitionId { get; set; }
        public string Country { get; set; }
        public string State { get; set; }

        public virtual Organizer Organizer { get; set; }
    }
}
