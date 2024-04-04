using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnthologyModels
{
    public record S_Pics
    {
        public string studentID { get; set; }
        public string fileName { get; set; }

        public byte[] buffer { get; set; }
        public S_Pics()
        {

        }

       
    }
}
