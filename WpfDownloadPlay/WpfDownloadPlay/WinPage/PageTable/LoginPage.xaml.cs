using Control.Utility.ErrorLogFolder;
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
using WpfDownloadPlay.WinPage.PageTable;

namespace WpfDownloadPlay.WinPage.PageTable
{
    /// <summary>
    /// LoginPage.xaml 的交互逻辑
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }


        private event Func<string, string, string, bool> funcEvent;

        private bool VerificationLogin()
        {
            bool flag = true;

            return flag;
        }

        /// <summary>
        /// 按钮触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_LoginPage_Click(object sender, RoutedEventArgs e)
        {
             
            switch (this.Tag)
            {
                case "login":

                case "cancel":

                case "register":

                case "forgetPassword":

                default:
            }
        }

        private bool CheckInput()
        {
            bool flag = true;
            try
            {
                if ("".Equals(cob_UserAccountPhone.Text) || cob_UserAccountPhone.Text==null)
                {
                    MessageBox.Show("账号");
                }
                else if ("".Equals(txt_Password.Password) || txt_Password.Password == null)
                {
                    MessageBox.Show("密码");
                }
                else if ("".Equals(txt_VerificationCode.Text) || txt_VerificationCode.Text==null)
                {
                    MessageBox.Show("验证码");
                }
                
            }
            catch (Exception ex)
            {
                ErrorLog.WriteErrorLog(ex);
            }
            return flag;
        }
    }
}
