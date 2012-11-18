using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMA.ExciteModels
{
    public class Biker
    {
        [Key]
        public int BikerId { get; set; }
        public string Name { get; set; }
        public string ForeName { get; set; }
        public string Avatar { get; set; }
        public string EmailAddress { get; set; }
    }

}
