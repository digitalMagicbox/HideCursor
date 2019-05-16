using System.Windows;
using System.Windows.Input;

namespace HideCursorSample
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly HideCursor hideCursor = new HideCursor();
        public MainWindow()
        {
            InitializeComponent();
            this.MouseMove += new MouseEventHandler(hideCursor.MouseMove);
        }
    }
}
