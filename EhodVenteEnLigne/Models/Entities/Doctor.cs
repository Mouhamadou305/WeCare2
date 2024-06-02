using WeCare.Models.Entities;
using System.Collections.Generic;

namespace WeCare.Models
{
    public class Doctor : MemberShipEntity
    {
        public string Specialization { get; set; }
        public ICollection<Patient> Patients { get; set; }
    }
}
