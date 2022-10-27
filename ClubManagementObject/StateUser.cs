using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubManagementObject
{
    public class StateUser
    {
        [Key]
        public int StateUserId { get; set; }

        public string StateUserName { get; set; }
    }
}
