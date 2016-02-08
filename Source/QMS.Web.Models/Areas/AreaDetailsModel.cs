﻿using QMS.Models;
using QMS.Web.Infrastructure.Mappings;
using QMS.Web.Models.Records;
using QMS.Web.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QMS.Web.Models.Areas
{
    public class AreaDetailsModel : IMapFrom<Area>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int EmployeeId { get; set; }

        public UserDetailsModel Employee { get; set; }

        public ICollection<RecordListDetails> Records { get; set; }
    }
}
