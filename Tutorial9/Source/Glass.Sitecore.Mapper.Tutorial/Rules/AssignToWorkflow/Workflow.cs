using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Sitecore.Mapper.Configuration.Attributes;

namespace Glass.Sitecore.Mapper.Tutorial.Rules.AssignToWorkflow
{
    [SitecoreClass]
    public class Workflow
    {
        [SitecoreId]
        public virtual Guid Id { get; set; }

        [SitecoreChildren]
        public virtual IEnumerable<WorkflowState> States { get; set; }
    }
}