using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class Item
    {
        public long id { get; set; }
        public string name { get; set; }
        public bool done { get; set; }
    }
}
