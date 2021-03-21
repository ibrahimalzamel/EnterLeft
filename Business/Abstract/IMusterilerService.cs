using Entities.Concrete.MusterilerClass;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IMusterilerService
    {
        List<Musteriler> GetAll(Expression<Func<Musteriler, bool>> filter = null);
        Musteriler GetById(string MusterilerID);
        void Add(Musteriler musteriler);
        void Update(Musteriler musteriler);
        void Delete(Musteriler musteriler);

    }
}
