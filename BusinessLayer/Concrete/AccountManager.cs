﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.UnitOfWork;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AccountManager : IAccountService
    {
        private readonly IAccountDal _accountDal;
        private readonly UowDal _uowDal;


        public AccountManager(IAccountDal accountDal, UowDal uowDal = null)
        {
            _accountDal = accountDal;
            _uowDal = uowDal;
        }

        public Account TGetByID(int id)
        {
            return _accountDal.GetByID(id);
        }

        public void TInsert(Account t)
        {
            _accountDal.Insert(t);
            _uowDal.Save();
           
        }

        public void TMultiUpdate(List<Account> t)
        {
            _accountDal.MultiUpdate(t);
            _uowDal.Save();

        }

        public void TUpdate(Account t)
        {
            _accountDal.Update(t);
            _uowDal.Save();
        }
    }
}
