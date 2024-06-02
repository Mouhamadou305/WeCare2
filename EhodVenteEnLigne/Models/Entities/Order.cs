using System;
using System.Collections.Generic;

namespace WeCare.Models.Entities
{
    public partial class Order
    {
        public Order()
        {
            OrderLine = new HashSet<MedicalPage>();
        }

        public int Id { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Zip { get; set; }
        public virtual ICollection<MedicalPage> OrderLine { get; set; }
    }
}
