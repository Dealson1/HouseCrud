using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House.Core.Domain
{
    public class HouseDomain
    {
        [Key]
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public int Area { get; set; }
        public string Address { get; set; }
        public int Floors { get; set; }


        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
