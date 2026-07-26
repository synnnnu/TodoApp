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

namespace TodoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // sender : 이 이벤트를 발생시킨 객체 (여기선 기본)
        // e : 클릭 이벤트에 대한 부가 정보
        private void MyButton_Click(object sender, RoutedEventArgs e) 
        {
            GreetingText.Text = "안녕! 클릭 됐어 ><";
        }
    }
}