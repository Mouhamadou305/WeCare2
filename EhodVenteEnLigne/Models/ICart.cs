
using EhodBoutiqueEnLigne.Models.Entities;

namespace EhodBoutiqueEnLigne.Models
{
    public interface ICart
    {
        void AddItem(MedicalFile product, int quantity);

        void RemoveLine(MedicalFile product);

        void Clear();

        double GetTotalValue();

        double GetAverageValue();
    }
}