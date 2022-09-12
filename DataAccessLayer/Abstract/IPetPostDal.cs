using DataAccessLayer.Context;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IPetPostDal : IGenericRepository<PetPost>
    {
        List<PetPost> ListWithValues();
        List<PetPost> ListWithCategory(Expression<Func<PetPost, bool>> filter);
        List<PetPost> ListWithAge(Expression<Func<PetPost, bool>> filter);
        List<PetPost> ListWithType(Expression<Func<PetPost, bool>> filter);
        List<PetPost> ListWithBreed(Expression<Func<PetPost, bool>> filter);
        PetPost GetPost(Expression<Func<PetPost, bool>> filter);
        List<PetPost> ListWithMember(Expression<Func<PetPost, bool>> filter);
        List<PetPost> ListActivePost(Expression<Func<PetPost, bool>> filter);
        PetPost GetPostAllValue(Expression<Func<PetPost, bool>> filter);


    }
}
