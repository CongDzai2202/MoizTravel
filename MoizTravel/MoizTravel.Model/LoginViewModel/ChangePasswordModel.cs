using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoizTravel.Model.LoginViewModel
{
    public class ChangePasswordModel
    {
        public string UserName { get; set; }
        public string oldPassWord { get; set; }
        public string newPassWord { get; set; }

    }
}
