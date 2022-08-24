using System.ComponentModel.DataAnnotations;

namespace InspectionApi.Models
{
    public class Inspection
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string Status { get; set; }
        [StringLength(200)]
        public string Comments { get; set; }
        public int InspectionTypeId { get; set; }
        public InspectionType? InspectionType { get; set; }
    }
}
