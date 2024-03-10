using System.Collections.Generic;

namespace CRUDWinFormMVP.Model
{
    public interface IproductRepository
    {
        void Add(ProductModels productModels);
        void Edit(ProductModels productModels);
        void Delete(int id);
        IEnumerable<ProductModels> GetAll();
        IEnumerable<ProductModels> GetByValue(string viewSearchValue); // Searches
        
    }
}