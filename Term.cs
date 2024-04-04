using System.Text.Json.Serialization;

namespace AnthologyModels
{
   public class TermCollection
   {
      public string odatacontext { get; set; }
      [JsonPropertyName("value")]
      public Term[] Terms { get; set; }
   }

   public partial  class Term
   {
      public int Id { get; set; }
      public object AddDropDate { get; set; }
      public object AuditDesignationDeadline { get; set; }
      public int CampusGroupId { get; set; }
      public string Code { get; set; }
      public int CourseRefundPolicyId { get; set; }
      public DateTime CreatedDateTime { get; set; }
      public object CrnPrefix { get; set; }
      public object CrnSuffix { get; set; }
      public DateTime EndDate { get; set; }
      public int FaAcademicCalendar { get; set; }
      public object InstructionalWeeks { get; set; }
      public object InternalRegistrationBeginDateTime { get; set; }
      public object InternalRegistrationEndDateTime { get; set; }
      public bool IsActive { get; set; }
      public bool IsAttendanceRecorded { get; set; }
      public bool IsChildTermDatesRuleEnforced { get; set; }
      public bool IsExcludedCrmIntegration { get; set; }
      public bool IsGlobalExtractTerm { get; set; }
      public bool IsIntersession { get; set; }
      public bool IsLdaRetainedUnregisteredCourses { get; set; }
      public bool IsOnlineUsageAllowed { get; set; }
      public bool IsPrePullRequiredForGlobal { get; set; }
      public bool IsSapTerm { get; set; }
      public int IsStandardTerm { get; set; }
      public bool IsTermOpen { get; set; }
      public bool IsTermSuspendLiftedCampusLinkAmbassador { get; set; }
      public DateTime LastModifiedDateTime { get; set; }
      public int LastModifiedUserId { get; set; }
      public object LastUpdatedCrn { get; set; }
      public string Name { get; set; }
      public object NumberOfDaysAfterTermStartDate { get; set; }
      public object NumberOfDaysPriorToTermStartDate { get; set; }
      public object NumberOfDaysToRecalcNotification { get; set; }
      public object OpenRegistrationBeginDateTime { get; set; }
      public object OpenRegistrationEndDateTime { get; set; }
      public float RevenueUnits { get; set; }
      public int SapCalcDaysAfterTermEnd { get; set; }
      public string ScheduleChangesType { get; set; }
      public bool SendCourseSectionDataInitialDoneToLms { get; set; }
      public bool SendCourseSectionDataToLms { get; set; }
      public bool SendInstructorAssignmentsInitialDoneToLms { get; set; }
      public bool SendInstructorAssignmentsToLms { get; set; }
      public bool SendStudentRegistrationDataInitialDoneToLms { get; set; }
      public bool SendStudentRegistrationDataToLms { get; set; }
      public int ShiftId { get; set; }
      public string StandardTermType { get; set; }
      public DateTime StartDate { get; set; }
      public object StudentRegisterEndDate { get; set; }
      public object StudentRegisterStartDate { get; set; }
      public int SummerHeaderOrTrailer { get; set; }
      public int TermGroupId { get; set; }
      public int TermUsage { get; set; }
   }
}
