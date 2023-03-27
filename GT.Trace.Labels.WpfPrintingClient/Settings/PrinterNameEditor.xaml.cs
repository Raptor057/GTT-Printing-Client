using GT.Trace.Labels.WpfPrintingClient.Windows.PrinterSelection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;

namespace GT.Trace.Labels.WpfPrintingClient.Settings
{
    /// <summary>
    /// Interaction logic for PrinterNameEditor.xaml
    /// </summary>
    public partial class PrinterNameEditor : UserControl, ITypeEditor
    {
        public PrinterNameEditor()
        {
            InitializeComponent();
            DataContext = this;
        }

        public static readonly DependencyProperty ValueProperty = DependencyProperty.Register(
            "Value", typeof(PrinterName), typeof(PrinterNameEditor), new PropertyMetadata(default(PrinterName)));

        public PrinterName Value
        {
            get { return (PrinterName)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        public FrameworkElement ResolveEditor(Xceed.Wpf.Toolkit.PropertyGrid.PropertyItem propertyItem)
        {
            var binding = new Binding("Value")
            {
                Source = propertyItem,
                Mode = propertyItem.IsReadOnly ? BindingMode.OneWay : BindingMode.TwoWay
            };
            BindingOperations.SetBinding(this, ValueProperty, binding);
            return this;
        }

        private void Button_OnClick(object sender, RoutedEventArgs e)
        {
            var viewer = (App.Current as App).Services.GetService(typeof(PrinterSelectionWindow)) as PrinterSelectionWindow;
            if (viewer.ShowDialog() ?? false)
            {
                Value = new PrinterName() { Value = viewer.Tag.ToString() };
            }
        }
    }
}