﻿namespace QMS.Web.Models.Areas
{
    using Records;
    using System.Linq;

    public class AreaManageViewModel
    {
        public AreaDetailsViewModel Area { get; set; }

        public IQueryable<RecordListViewModel> Records { get; set; }
    }
}
