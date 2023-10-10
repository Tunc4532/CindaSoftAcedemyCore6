﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public void TAdd(Course t)
        {
             _courseDal.Insert(t);
        }

        public void TDelete(Course t)
        {
            _courseDal.Delete(t);
        }

        public Course TGetById(int id)
        {
           return _courseDal.GetByID(id);
        }

        public List<Course> TGetList()
        {
           return _courseDal.GetList();
        }

        public List<Course> TGetListByFilter(string r)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Course t)
        {
           _courseDal.Update(t);
        }
    }
}
