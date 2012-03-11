using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Sitecore.Mapper.Configuration.Attributes;

namespace Glass.Sitecore.Mapper.Tutorial.Models
{
    [SitecoreClass]
    public class Home
    {
        [SitecoreField]
        public virtual string Title { get; set; }

        [SitecoreField]
        public virtual string Text { get; set; }

        [SitecoreField("__created by")]
        public virtual string CreatedBy { get; set; }

        [SitecoreField("__created")]
        public virtual DateTime Created { get; set; }

        [SitecoreInfo(Configuration.SitecoreInfoType.ContentPath)]
        public virtual string Path { get; set; }
    }
}