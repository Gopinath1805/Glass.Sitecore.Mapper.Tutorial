using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Sitecore.Mapper.Configuration.Attributes;

namespace Glass.Sitecore.Mapper.Tutorial.Tutorial2
{
    [SitecoreClass]
    public class Template2BasicFields
    {
        [SitecoreField]
        public virtual string Title { get; set; }

        [SitecoreField("Display In Left Menu")]
        public virtual bool DisplayInLeftMenu { get; set; }

        [SitecoreField]
        public virtual string Content { get; set; }

        [SitecoreField("Created Date")]
        public virtual DateTime Title { get; set; }

        [SitecoreField]
        public virtual int Price { get; set; }

    }
}