using System;

using DevExpress.Xpo;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

using DevExpress.ExpressApp.Editors;


namespace HowToUseCriteriaPropertyEditors.Module {
    [DefaultClassOptions]
    public class FilteringCriterion : BaseObject {
        public FilteringCriterion(Session session) : base(session) { }

        public string Description {
            get { return GetDelayedPropertyValue<string>("Description"); }
            set { SetDelayedPropertyValue<string>("Description", value); }
        }

        private Type ObjectType { get { return typeof(Product); } }

        [CriteriaObjectTypeMember("ObjectType")]
        public string Criterion {
            get { return GetPropertyValue<string>("Criterion"); }
            set { SetPropertyValue<string>("Criterion", value); }
        }
    }
}
