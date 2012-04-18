using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Sitecore.Mapper.Configuration.Attributes;

namespace Glass.Sitecore.Mapper.Tutorial.Models
{
    [SitecoreClass]
    public class Tutorial11Item
    {
        [SitecoreId]
        public virtual Guid Id { get; set; }

        [SitecoreField]
        public virtual string Title { get; set; }

        [SitecoreField]
        public virtual string Content { get; set; }

        [SitecoreField]
        public virtual DateTime Date { get; set; }
    }
}