﻿namespace QMS.Services
{
    using QMS.Data;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ProceduresServices
    {
        private IQmsData data;

        public ProceduresServices(IQmsData data)
        {
            this.data = data;
        }

        public IQueryable<Procedure> All()
        {
            return this.data.Procedures.All();
        }

        public Procedure GetById(int id)
        {
            return this.data.Procedures.GetById(id);
        }

        public Procedure Add(string name, string description)
        {
            var newProcedure = new Procedure
            {
                Name = name,
                Description = description,
            };

            this.data.Procedures.Add(newProcedure);
            this.data.SaveChanges();

            return newProcedure;
        }

        public void Update(int id, string name, string description)
        {
            var procedure = this.data.Procedures.GetById(id);
            procedure.Name = name;
            procedure.Description = description;
            this.data.SaveChanges();
        }
    }
}
