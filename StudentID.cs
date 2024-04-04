using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AnthologyModels
{
   

        public class StudentID
        {

        [JsonPropertyName("@odata.context")]
        public string odatacontext { get; set; }

        [JsonPropertyName("@odata.count")]
        public int odatacount { get; set; }

        [JsonPropertyName("value")]
        public ID[] myIds { get; set; }

        public int stuID
        {
            get
            {
                if (myIds != null && myIds.Length > 0)
                {
                    return myIds[0].Id;
                }
                else
                { return 0; }   
            }
        }
        }

        public class ID
        {
            public int Id { get; set; }
        }

    }

