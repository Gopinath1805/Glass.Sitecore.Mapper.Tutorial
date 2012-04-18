using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Sitecore.Mapper.Configuration.Attributes;

namespace Glass.Sitecore.Mapper.Tutorial.Rules.AssignToWorkflow
{
    [SitecoreClass]
    public class TargetItem
    {
        [SitecoreField("__Workflow")]
        public virtual Workflow Workflow { get; set; }

        [SitecoreField("__Workflow state")]
        public virtual WorkflowState WorkflowState { get; set; }
    }
}