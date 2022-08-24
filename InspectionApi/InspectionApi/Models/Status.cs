using System.ComponentModel.DataAnnotations;

namespace InspectionApi.Models
{
    public class Status
    {
        public int Id { get; set; }
        [StringLength(10)]
        public string Statusoption { get; set; }
    }
}
