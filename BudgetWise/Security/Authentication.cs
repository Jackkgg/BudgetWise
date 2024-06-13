using BudgetWise.Forms;
using BudgetWise.Interfaces;
using Google.Authenticator;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetWise.Security
{
    public class Authentication
    {
        private readonly IPersonalUserRepository _personalUserRepository;
        public Authentication(IPersonalUserRepository personalUserRepository)
        {
            _personalUserRepository = personalUserRepository;
        }

        public void AddKeyOnSignUp(string username)
        {
            AuthenticateUser authenticateUser = new AuthenticateUser();
            PictureBox pbQRCode = authenticateUser.pbQRCode;
            HopeTextBox oneTimePass = authenticateUser.txtOneTimePass;
            HopeButton submit = authenticateUser.btnSubmitCode;

            authenticateUser.Show();
            oneTimePass.Visible = false;
            submit.Visible = false;

            string secretKey = Guid.NewGuid().ToString().Replace("-", "");

            TwoFactorAuthenticator tfA = new TwoFactorAuthenticator(HashType.SHA256);
            var setupCode = tfA.GenerateSetupCode("BudgetWise", "BudgetWise", secretKey, false, 3);

            using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(setupCode.QrCodeSetupImageUrl.Replace("data:image/png;base64,", ""))))
                pbQRCode.Image = Image.FromStream(ms);

            _personalUserRepository.AddAuthKey(secretKey, username);
        }
    }
}
