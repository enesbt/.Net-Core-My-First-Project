using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IPetPostService : IGenericService<PetPost>
    {
        List<PetPost> GetListByPetBreed(int id);
        List<PetPost> GetListByPetType(int id);
        List<PetPost> GetListByAge(int id);
        List<PetPost> GetListByCategory(int id);
        List<PetPost> GetListSlider();
        List<PetPost> GetListByValues();
        List<PetPost> GetListCategory(int id);
        List<PetPost> GetListBreed(int id);
        List<PetPost> GetListType(int id);
        List<PetPost> GetListAge(int id);
        List<PetPost> GetListMebmerPost(string name);
        PetPost GetPostValues(int id);
        List<PetPost> GetListActivePost(bool name);


    }
}
