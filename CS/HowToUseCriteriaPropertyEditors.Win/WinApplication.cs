using System;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.ExpressApp.Win;
using DevExpress.ExpressApp.Updating;
using DevExpress.ExpressApp;

namespace HowToUseCriteriaPropertyEditors.Win {
    public partial class HowToUseCriteriaPropertyEditorsWindowsFormsApplication : WinApplication {
        public HowToUseCriteriaPropertyEditorsWindowsFormsApplication() {
            InitializeComponent();
        }

        private void HowToUseCriteriaPropertyEditorsWindowsFormsApplication_DatabaseVersionMismatch(object sender, DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs e) {
            e.Updater.Update();
            e.Handled = true;
        }
    }
}
