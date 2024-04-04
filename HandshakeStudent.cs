/********************************************************************
*  Author:     Bob Cummings
*  Name:       Student Collection
*  Date:       01/23/24
*  Desc:       This is the payload sent back when doing a query for Handshake.
***********************************************************************/

using System.Text.Json.Serialization;

namespace AnthologyModels
{
   public class StudentCollection
   {
      public string odatacontext { get; set; }

      [JsonPropertyName("@odata.count")]
      public int odatacount { get; set; }

      [JsonPropertyName("value")]
      public Students[] Students { get; set; }
   }

   public class Students
   {
      public int StudentId { get; set; }
      public string ProgramVersionName { get; set; }
      public DateTime EnrollmentDate { get; set; }
      public DateTime GraduationDate { get; set; }
      public Student Student { get; set; }
   }

   public class Student
   {
      public string EmailAddress { get; set; }
      public string StudentNumber { get; set; }
      public string FirstName { get; set; }
      public string LastName { get; set; }
      public string? Disabled { get; set; }
      public string? MobilePhoneNumber { get; set; }
      public string? Veteran { get; set; }
      public string City { get; set; }
      public string State { get; set; }
      public string UserID
      { get { return StudentNumber; } }

      public string displayDisabled
      {
         get
         {
            if (!string.IsNullOrEmpty(Disabled))
            {
               if (Disabled == "N")
                  return "FALSE";
               else return "TRUE";
            }
            else
            {
               return string.Empty;
            }
         }
      }

      public string displayveteran
      {
         get
         {
            if (!string.IsNullOrEmpty(Veteran))
            {
               if (Veteran == "N")
                  return "FALSE";
               else return "TRUE";
            }
            else
            {
               return string.Empty;
            }
         }
      }

      public string homeTown
      {
         get
         {
            return $"{City},  {State}";
         }
      }

      public string displayPhone
      {
         get
         {
            if (!string.IsNullOrEmpty(MobilePhoneNumber))
               return MobilePhoneNumber.Replace('/', '-');
            else
               return string.Empty;
         }
      }
   }
}