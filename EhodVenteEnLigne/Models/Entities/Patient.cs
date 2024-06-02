using System.Collections.Generic;
using WeCare.Models.Entities;

namespace WeCare.Models
{
    public class Patient : MemberShipEntity
    {
        public string Address { get; set; }
        public int? DoctorId { get; set; }
        public Doctor? Doctor { get; set; }
        public ICollection<MedicalFile> MedicalFiles { get; set; }
    }
}
