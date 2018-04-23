using DevExpress.Xpf.Core;
using DevExpress.Xpf.Utils.Themes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DevExpress.Examples.ThemeSwitcher {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DXWindow {
        
        public MainWindow() {
            InitializeComponent();
            this.dxGrid.ItemsSource = this.Tasks;
        }

        #region Data

        protected List<Task> _Tasks;

        public List<Task> Tasks {
            get {
                if(this._Tasks == null) {
                    this._Tasks = new List<Task>();
                    Random r = new Random();
                    int i = 0;
                    while(i < 100) {
                        this._Tasks.Add(new Task() {
                            Name = string.Format("Task {0}", i),
                            Priority = r.Next(2) > 0 ? Priority.Important : Priority.NotImportant,
                            StartDate = DateTime.Today.AddDays(-r.Next(20)),
                            FinishDate = DateTime.Today.AddDays(r.Next(20)),
                            IsComplete = r.Next(2) > 0
                        });
                        i++;
                    }
                }
                
                return this._Tasks;
            }
        }

        #endregion Data

        private void Button_Click(object sender, RoutedEventArgs e) {
            ThemeManager.ApplicationThemeName = Theme.DefaultThemeName;
        }

        private void cbTheme_EditValueChanged(object sender, Xpf.Editors.EditValueChangedEventArgs e) {
            ThemeManager.ApplicationThemeName = (this.cbTheme.SelectedItem as Theme).Name;
        }

    }
}
