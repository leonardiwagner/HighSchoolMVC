﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class Teacher
    {
        public List<Model.Teacher> Get(int skip, int count)
        {
            return null;
        }

        public int Save(Model.Teacher teacher)
        {
            return 0;
        }

        private Model.User DalToModel(Dal.EntityFramework.User dalModel)
        {
            return new Model.User()
            {
                Id = dalModel.Id,
                Login = dalModel.Login,
                Password = dalModel.Password,
                Image = dalModel.Image,
                Created = dalModel.Created
            };
        }

        private Dal.EntityFramework.User DalToModel(Model.User model)
        {
            return new Dal.EntityFramework.User()
            {
                Id = model.Id,
                Login = model.Login,
                Password = model.Password,
                Image = model.Image,
                Created = model.Created
            };
        }

    }
}
