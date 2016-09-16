﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;

namespace TeduShop.Service
{
    public interface IErrorMessage
    {
        Error Create(Error error);
        void Save();

    }
    public class ErrorService : IErrorMessage
    {
        IErrorRepository _errorRepository;
        IUnitOfWork _unitOfWork;
        public ErrorService(IErrorRepository erroRepository,IUnitOfWork iunitOfWork)
        {
            _errorRepository = erroRepository;
            _unitOfWork = iunitOfWork;
        }

        public Error Create(Error error)
        {
            return _errorRepository.Add(error);
        }

        public void Save()
        {
             _unitOfWork.Commit();
        }
    }
}
