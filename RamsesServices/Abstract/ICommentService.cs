using RamsesEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamsesServices.Abstract
{
    public interface ICommentService
    {
        void CommentAdd(Comment comment);        
        List<Comment> GetAllComment(int id);
        
    }
}
