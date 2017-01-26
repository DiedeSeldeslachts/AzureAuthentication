using OfficeWpfTest.ViewModel;
using System.Windows;

namespace OfficeWpfTest.View
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            DataContext = new MainViewModel(Stage);
        }
    }
}
