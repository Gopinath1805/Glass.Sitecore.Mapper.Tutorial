using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Sitecore.Mapper.Configuration.Attributes;

namespace Glass.Sitecore.Mapper.Tutorial.Models
{
    [SitecoreClass]
    public class Tutorial8Item
    {

        private string _titlePrefix;
        private int _myInt;

        public Tutorial8Item(string titlePrefix)
            :this(titlePrefix, 0)
        {
        }

        public Tutorial8Item(string titlePrefix, int myInt)
        {
            _titlePrefix = titlePrefix;
            _myInt = myInt;

        }

        public string Title { get { return _titlePrefix + ScTitle; } }

        [SitecoreField("Title")]
        protected virtual string ScTitle { get; set; }

        public string Content { get { return ScContent.Formatted(_myInt); } }

        [SitecoreField("Content")]
        protected virtual string ScContent { get; set; }

        [SitecoreId]
        public virtual Guid Id { get; set; }

        [SitecoreField]
        public virtual DateTime Date { get; set; }
    }
}