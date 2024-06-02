using System.Drawing;

namespace WeCare.Models.Entities
{
    public partial class MedicalPage
    {
        public int Id { get; set; }
        public int MedicalFileId { get; set; }
        public virtual MedicalFile MedicalFile { get; set; }
        public string Diagnostic {  get; set; }
        public string Ordonnance { get; set; }
        public string Remarques { get; set; }
        public int? DoctorId { get; set; }
        public Doctor? Doctor { get; set; }
    }
}
