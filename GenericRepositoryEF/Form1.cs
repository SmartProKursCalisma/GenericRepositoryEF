using GenericRepositoryEF.Entities.Dtos.UserModels;
using GenericRepositoryEF.Helpers;
using GenericRepositoryEF.Service;

namespace GenericRepositoryEF
{
    public partial class Form1 : Form
    {
        private readonly UserService _userService;

        public Form1()
        {
            InitializeComponent();
            _userService = new UserService();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
            {
                UserLoginRequestModel model = new UserLoginRequestModel();
                model.UserName = userName;
                model.Password = password;
                var userInfo = _userService.Login(model);
                if (userInfo is not null)
                {
                    UserInfoHelper.Email = userInfo.Email;
                    UserInfoHelper.Role = userInfo.Role;
                    MessageBox.Show($"{UserInfoHelper.Email} - Hoþgeldiniz.", "Bilgi");
                    this.Hide();
                    StudentManagerForm form = new StudentManagerForm();
                    form.Show();
                }
                else
                {
                    MessageBox.Show($"Girilen Bilgiler Hatalý !", "Bilgi");

                }


            }
            else
            {
                MessageBox.Show("Lütfen Ýlgili Alanlarý Doldurunuz.", "Bilgi");
            }
        }
    }
}
