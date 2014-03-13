using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpanderTest
{
    class MainWindowViewModel
    {
        public string SelectedExpander { get; set; }
        public MainWindowViewModel()
        {
            SelectedExpander = "1";
        }
    }
}
