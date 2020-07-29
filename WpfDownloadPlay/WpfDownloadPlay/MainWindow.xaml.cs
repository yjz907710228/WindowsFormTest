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
using WpfDownloadPlay.WinPage;
using WpfDownloadPlay.WinPage.WindowForm;

namespace WpfDownloadPlay
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //page1();
            ShowLogin();
            //NavigationService.GetNavigationService(this.frame_MainWindow).Navigate(new Uri("Page1.xaml", UriKind.Relative));
            //NavigationService.GetNavigationService(this).GoForward();//向后转
            //NavigationService.GetNavigationService(this).GoBack();　 //向前转
        }

        public void ShowLogin()
        {
            LoginRegisterFrom loginRegisterFrom = new LoginRegisterFrom();
            this.Hide();
            loginRegisterFrom.ShowDialog();
            this.Show();
        }
    }
}
