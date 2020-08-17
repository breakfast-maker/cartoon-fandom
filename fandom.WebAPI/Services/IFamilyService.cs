using fandom.Model;
using fandom.Model.Requests;
using System.Collections.Generic;


namespace fandom.WebAPI.Services
{
    public interface IFamilyService
    {
        List<MFamily> GetAll();

        MFamily GetById(int id);

        MFamily Insert(FamilyInsertRequest request);

    }
}
