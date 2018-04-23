using System;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.ExpressApp.Editors;

namespace HowToUseCriteriaPropertyEditors.Module {
    [DefaultClassOptions, ImageName("Action_Filter")]
    public class FilteringCriterion : BaseObject {
        public FilteringCriterion(Session session) : base(session) { }
        public string Description {
            get { return GetDelayedPropertyValue<string>("Description"); }
            set { SetDelayedPropertyValue<string>("Description", value); }
        }
        private Type ObjectType { get { return typeof(Product); } }
        [CriteriaOptions("ObjectType"), Size(-1), ImmediatePostData]
        public string Criterion {
            get { return GetPropertyValue<string>("Criterion"); }
            set { SetPropertyValue<string>("Criterion", value); }
        }
        public string CriterionString {
            get { return Criterion; }
        }
    }
}
