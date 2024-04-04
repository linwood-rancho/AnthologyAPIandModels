using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AnthologyModels
{


   public class AnthologyStudentDetail
   {
      [JsonPropertyName("@odata.context")]
      public string odatacontext { get; set; }

      [JsonPropertyName("@odata.count")]
      public int odatacount { get; set; }

      [JsonPropertyName("value")]
      public Detail[] Details { get; set; }
   }

   public class Detail
   {
      public string StudentNumber { get; set; }
      public Studentethnicity[] StudentEthnicities { get; set; }
      public Gender Gender { get; set; }
      public Advisor[] Advisors { get; set; }
   }

   public class Gender
   {
      public string Name { get; set; }
   }

   public class Studentethnicity
   {
      public int Id { get; set; }
      public DateTime CreatedDateTime { get; set; }
      public int EthnicityId { get; set; }
      public bool IsExcludedCrmIntegration { get; set; }
      public DateTime LastModifiedDateTime { get; set; }
      public int LastModifiedUserId { get; set; }
      public int StudentId { get; set; }
      public Ethnicity Ethnicity { get; set; }
   }

   public class Ethnicity
   {
      public string Name { get; set; }
   }

   public class Advisor
   {
      public string AdvisorFirstName { get; set; }
      public string AdvisorLastName { get; set; }
   }


}

