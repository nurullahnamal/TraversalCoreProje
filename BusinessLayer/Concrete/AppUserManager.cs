﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class AppUserManager : IAppUserService
{
    private IAppUserDal _appUserDal;

    public AppUserManager(IAppUserDal appUserDal)
    {
        _appUserDal=appUserDal;
    }
    public void TAdd(AppUser t)
    {
        throw new NotImplementedException();
    }

    public void TDelete(AppUser t)
    {
        throw new NotImplementedException();
    }

    public AppUser TGetByID(int id)
    {
        throw new NotImplementedException();
    }

    public List<AppUser> TGetList()
    {
        return _appUserDal.GetList();
    }

    public void TUpdate(AppUser t)
    {
        throw new NotImplementedException();
    }
}