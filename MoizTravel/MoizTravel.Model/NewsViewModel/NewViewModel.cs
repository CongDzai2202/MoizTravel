using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoizTravel.Model.News
{
    public class NewViewModel
    {
        public int NewsId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PostDate { get; set; }
        public int ImageNewId { get; set; }      
        public int Status { get; set; }
    }
}
