using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnthologyModels
{
   
   public class StudentDetails
   {
      public int totalCount { get; set; }
      public string StudentID { get; set; }
      public string Ethnicity { get; set; }
      public string Gender { get; set; }

      public string AdvisorName { get; set; }

      public StudentDetails()
      {

      }

      public StudentDetails(Detail studentDetails)
      {
         StudentID = studentDetails.StudentNumber;
         Ethnicity = studentDetails.StudentEthnicities[0].Ethnicity.Name;
         Gender = studentDetails.Gender.Name;
         if(studentDetails.Advisors.Any())
         {
            AdvisorName = studentDetails.Advisors[0].AdvisorLastName + ", " + studentDetails.Advisors[0].AdvisorFirstName;
         }
        
      }
   }
}