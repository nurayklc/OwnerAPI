using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OwnerAPI.Model
{
    public class Owner
    {
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
    }
}
