using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AnthologyModels
{
    public class AccuSQL_Activities
    {
        public string odatacontext { get; set; }

        [JsonPropertyName("value")]
        public ClassMeeting[] classMeetings { get; set; }
    }

    public class ClassMeeting
    {
        public string CourseCode { get; set; }
        public string SectionName { get; set; }
        public string SectionCode { get; set; }
        public string Campus {  get; set; }
        public Term[] Terms { get; set; }
        public MeetingDate[] MeetingDates { get; set; }

        public override string ToString()
        {
            return "ACL " + Terms[0].Name + "," + MeetingDates[0].BuildingCode + "-" + CourseCode + "-" + SectionCode + "- ProjectGlNum," + SectionName;
        }
    }

    public partial class Term
    {
        public string TermCode { get; set; }
        public string TermName { get; set; }
    }

    public class MeetingDate
    {
        public string BuildingCode { get; set; }
        public string LocationId { get; set; }
    }


    public class Locations
    {
        public string odatacontext { get; set; }
        [JsonPropertyName("value")]
        public Location[] myLocations { get; set; }
    }

    public class Location
    {
        public int Id { get; set; }
        public string Code { get; set; }
    }

}

