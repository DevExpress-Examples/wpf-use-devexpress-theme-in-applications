using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExpress.Examples.ThemeSwitcher {

    public enum Priority { Important, NotImportant }

    public class Task {
        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime FinishDate { get; set; }

        public bool IsComplete { get; set; }

        public Priority Priority { get; set; }
    }
}
