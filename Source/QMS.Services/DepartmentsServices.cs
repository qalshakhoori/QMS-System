﻿using QMS.Data;
using QMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QMS.Services
{
    public class DepartmentsServices
    {
        private IQmsData data;

        public DepartmentsServices(IQmsData data)
        {
            this.data = data;
        }

        public IQueryable<Department> All()
        {
            return this.data.Departments.All();
        }

        public Department GetById(int id)
        {
            return this.data.Departments.GetById(id);
        }

        public Department Create(string name, string description, int divisionId)
        {
            var departmentToAdd = new Department
            {
                Name = name,
                Description = description,
                DivisionId = divisionId
            };

            this.data.Departments.Add(departmentToAdd);
            this.data.SaveChanges();

            return departmentToAdd;
        }

        public void Update(int id, string name, string description, int divisionId)
        {
            var dbModel = this.data.Departments.GetById(id);
            dbModel.Name = name;
            dbModel.Description = description;
            dbModel.DivisionId = divisionId;
            this.data.SaveChanges();
        }
    }
}
