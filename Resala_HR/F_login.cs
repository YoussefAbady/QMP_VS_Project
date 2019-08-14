using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resala_HR
{
    public partial class F_Login : Form
    {
        string username;
        string password;

        public static User user ; 

        public F_Login()
        {
            InitializeComponent();            
        }

        private void B_login_Click(object sender, EventArgs e)
        {
            DataModels.Result res = DataModels.Result.NONE ;

            if (!Database.isInitialized)
                res = Database.initialize("192.168.1.100", "test", "pi", "j0000uabady");

            if (res != DataModels.Result.SUCCESS)
            {
                L_FailLog.Text = "خطأ في الاتصال بقاعدة البيانات";
                L_FailLog.ForeColor = Color.Red;
                return ;
            }

            username = TB_Username.Text;
            password = TB_Password.Text;
            DataModels.Result result;

            if (TB_Username.IsPlaceholderActive || TB_Password.IsPlaceholderActive || TB_Username.Text == "" || TB_Password.Text == "")
            {
                L_FailLog.Text = "من فضلك أدخل اسم مستحدم و كلمة مرور صحيحة";
                L_FailLog.ForeColor = Color.Red;
                return;
            }



             result = Session.login(username, password);

             if (result == DataModels.Result.SUCCESS)
             {
                 F_home main = new F_home();
                 this.Hide();
                 main.Show();
                 return;
             }
             else if (result == DataModels.Result.USER_NOT_FOUND)
             {
                 L_FailLog.Text = "خطأ في اسم المستخدم أو كلمة المرور";
                 L_FailLog.ForeColor = Color.Red;
                 return;
             }

             else if (result == DataModels.Result.DATABASE_CONNECTION_ERROR)
             {
                 L_FailLog.Text = "خطأ في الاتصال بقاعدة البيانات" ;
                 L_FailLog.ForeColor = Color.Red;
                 return;
             }
        }

        private void F_Login_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

   
    

    }
}
