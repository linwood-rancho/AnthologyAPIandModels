using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace AnthologyModels
{
   public class MaxientStudentManager
   {
      [JsonPropertyName("@odata.context")]
      public string odatacontext { get; set; }

      [JsonPropertyName("@odata.count")]
      public int odatacount { get; set; }

      [JsonPropertyName("value")]
      public MaxientStudents[] maxientStudents { get; set; }
   }

   public class MaxientStudent
   {
      public string StudentNumber { get; set; }
      public string FirstName { get; set; }
      public string LastName { get; set; }
      public string MiddleName { get; set; }
      public DateTime? DateOfBirth { get; set; }
      public int GenderId { get; set; }
      public string MobilePhoneNumber { get; set; }
      public string PhoneNumber { get; set; }
      public string StreetAddress { get; set; }
      public string City { get; set; }
      public string State { get; set; }
      public string EmailAddress { get; set; }
      public string PostalCode { get; set; }
      public object PreferredName { get; set; }
   }

   public class MaxientStudents
   {
      public int StudentId { get; set; }
      public string ProgramVersionName { get; set; }
      public MaxientStudent Student { get; set; }
   }
}
