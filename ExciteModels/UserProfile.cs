using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMA.ExciteModels
{
    public class UserProfile
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
    }

}
