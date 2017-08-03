using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConventionalConsole
{
    public class LoginModel
    {
        //public long LoginModelId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string LocationType { get; set; }
        public string IPAddress { get; set; }
        public string City { get; set; }
        public float Lat { get; set; }
        public float Long { get; set; }
    }
}
