using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AnthologyModels
{
    internal class PersonPicture
    {

     
            public Payload payload { get; set; }
            public object[] notifications { get; set; }
            public bool hasError { get; set; }
            public bool hasFault { get; set; }
            public bool hasWarning { get; set; }
            public bool hasValidationError { get; set; }
            public bool hasValidationWarning { get; set; }
            public bool hasValidationInformation { get; set; }
            public bool hasSecurityError { get; set; }
        }

        public class Payload
        {
        [JsonPropertyName("Data")]
        public Picture picture { get; set; }
        }

   
    public class Picture
        {
            public int id { get; set; }
            public string createdDateTime { get; set; }
            public object employerId { get; set; }
            public bool isStudent { get; set; }
            public string lastModifiedDateTime { get; set; }
            public int lastModifiedUserId { get; set; }
            public object pictureImage { get; set; }
            public object rowVersion { get; set; }
            public object staffId { get; set; }
            public object studentId { get; set; }
            public string originalState { get; set; }
            public string secureState { get; set; }
            public object[] extendedProperties { get; set; }
            public int entityState { get; set; }
        }

    }

