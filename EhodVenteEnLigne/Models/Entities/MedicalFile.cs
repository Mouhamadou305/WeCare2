using System.Collections.Generic;

namespace WeCare.Models.Entities
{
    public partial class MedicalFile
    {
        public MedicalFile()
        {
            MedicalPage = new List<MedicalPage>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int IdPatient { get; set; }
        public Patient Patient { get; set; }

        public virtual ICollection<MedicalPage> MedicalPage { get; set; }
    }
}
