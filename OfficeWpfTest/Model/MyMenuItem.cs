using OfficeWpfTest.Helpers;
using System.Collections.Generic;

namespace OfficeWpfTest.Model
{
    public class MyMenuItem
    {
        public string Header { get; set; }
        public List<MyMenuItem> Children { get; set; }
        public RelayCommand Command { get; set; }
    }
}
