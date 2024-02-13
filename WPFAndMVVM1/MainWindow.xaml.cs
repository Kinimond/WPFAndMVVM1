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

namespace WPFAndMVVM1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel mvm = new MainViewModel();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = mvm;
        }
        
        private string testText;

        public string TestText
        {
            get { return testText; }
            set { testText = value; }
        }

        private string testText1;
        public string TestText1
        {
            get { return testText1; }
            set { testText1 = value; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mvm.MyLabelText = DateTime.Now.ToString();


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            mvm.MyTextBoxText = DateTime.Now.ToString();
        }
    }
}