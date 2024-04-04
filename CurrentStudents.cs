using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AnthologyModels.CurrentStudents
{
  

   public class CurrentStudents
   {
      public string odatacontext { get; set; }
      public int odatacount { get; set; }
      [JsonPropertyName("value")]
      public Students[] Students { get; set; }
   }

   public class Value
   {
      public int Id { get; set; }
      public string EmailAddress { get; set; }
      public string StudentNumber { get; set; }
      public string FirstName { get; set; }
      public string LastName { get; set; }
      public string MiddleName { get; set; }
      public string PhoneNumber { get; set; }
      public string Disabled { get; set; }
      public string MobilePhoneNumber { get; set; }
      public string Veteran { get; set; }
      public string StreetAddress { get; set; }
      public string City { get; set; }
      public string State { get; set; }
   }

}
