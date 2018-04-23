using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;

using DevExpress.ExpressApp.Editors;


namespace HowToUseCriteriaPropertyEditors.Module {
    public partial class CriteriaController : ViewController {
        public CriteriaController() {
            InitializeComponent();
            RegisterActions(components);
        }

        private void CriteriaController_Activated(object sender, EventArgs e) {
            FilteringCriterionAction.Items.Clear();
            FilteringCriterionAction.Items.Add(new ChoiceActionItem("All the products", null));
            foreach (FilteringCriterion criterion in (View as ListView).ObjectSpace.GetObjects<FilteringCriterion>(null)) {
                FilteringCriterionAction.Items.Add(new ChoiceActionItem(criterion.Description, criterion.Criterion));
            }
            FilteringCriterionAction.SelectedIndex = 0;
        }

        private void FilteringCriterionAction_Execute(object sender, SingleChoiceActionExecuteEventArgs e) {
            (View as ListView).CollectionSource.Criteria.Clear();
            (View as ListView).CollectionSource.Criteria[e.SelectedChoiceActionItem.Caption] =
               CriteriaEditorHelper.GetCriteriaOperator(e.SelectedChoiceActionItem.Data as string, typeof(Product), View.ObjectSpace);
        }
    }
}
