using GateOperationApp.ViewModels;
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

namespace GateOperationApp.Controls
{
    /// <summary>
    /// GateReceiptControl.xaml の相互作用ロジック
    /// </summary>
    public partial class GateReceiptControl : UserControl
    {
        GateReceiptViewModel _viewModel;

        public GateReceiptControl()
        {
            InitializeComponent();

            _viewModel = new GateReceiptViewModel();
            DataContext = _viewModel;
        }
    }
}
