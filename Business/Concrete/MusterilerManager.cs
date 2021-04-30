using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete.MusterilerClass;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class MusterilerManager : IMusterilerService
    {
        IMusterilerDal _musterilerDal;

        public MusterilerManager(IMusterilerDal musterilerDal)
        {
            _musterilerDal = musterilerDal;
        }

        public void Add(Musteriler musteriler)
        {
            _musterilerDal.Add(musteriler);
        }

        public void Delete(Musteriler musteriler)
        {
            _musterilerDal.Delete(musteriler);
        }

       

        public List<Musteriler> GetAll(Expression<Func<Musteriler, bool>> filter = null)
        {
            return _musterilerDal.GetAll();
        }

        public Musteriler GetById(int musterilerID)
        {
            return _musterilerDal.Get(m=>m.MusteriID == musterilerID);
        }

        public Musteriler GetById(string MusterilerID)
        {
            throw new NotImplementedException();
        }

        public void Update(Musteriler musteriler)
        {
            _musterilerDal.Update(musteriler);
        }
    }
}
