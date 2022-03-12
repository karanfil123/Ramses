using RamsesDataAccess.Abstract;
using RamsesDataAccess.SharedDal.Concrete;
using RamsesEntities.Concrete;

namespace RamsesDataAccess.Concrete.Repositories
{
    public class CommentRepository : EntityRepositoryBase<Comment>, ICommentDal
    {

    }
}
