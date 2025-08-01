using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GateOperationApp.ViewModels;
using GateOperationApp.Models;

namespace GateOperationApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Receipt? _receipt = null;

        public GateSettings? gateSettings => App.Current.Resources["GateSettings"] as GateSettings;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = gateSettings;
        }
    }
}