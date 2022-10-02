using MoizTravel.WebAPI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoizTravel.WebAPI.Entities
{
    public class ImageNews
    {
        public int ImageNewId { get; set; }
        public string Url { get; set; }
        public string Note { get; set; }
        public Status Status { get; set; }

    }
}
