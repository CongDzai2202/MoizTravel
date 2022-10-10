using MoizTravel.WebAPI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoizTravel.WebAPI.Entities
{
    public class News
    {
        public int NewsId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PostDate { get; set; }
        public int ImageNewId { get; set; }
        public ImageNews ImageNews { get; set; }
        public int Status { get; set; }
        
    }
}
