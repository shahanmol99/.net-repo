using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExhibitionLib.Model
{
    public class Organizer
    {
        [Key]
        public string OrganizerId { get; set; }
        public string OrganizerName { get; set; }

        public virtual List<Exhibition> Exhibitions { get; set; }
    }
}