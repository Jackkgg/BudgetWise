using Google.Authenticator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetWise.Forms
{
    public partial class AuthenticateUser : Form
    {
        private readonly string _secretKey;

        public AuthenticateUser() { }
        public AuthenticateUser(string secretKey)
        {
            InitializeComponent();
            _secretKey = secretKey;
        }

        private void btnSubmitCode_Click(object sender, EventArgs e)
        {
            TwoFactorAuthenticator tfA = new TwoFactorAuthenticator(HashType.SHA256);
            var result = tfA.ValidateTwoFactorPIN(_secretKey, txtOneTimePass.Text);

            if(!result )
            {
                MessageBox.Show("Invalid Code.", "Incorrect Code", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.Close();
            PersonalDashboard personalDashboard = new PersonalDashboard();
            personalDashboard.Show();
        }

        private void AuthenticateUser_Load(object sender, EventArgs e)
        {
            TwoFactorAuthenticator tfA = new TwoFactorAuthenticator(HashType.SHA256);
            var setupCode = tfA.GenerateSetupCode("BudgetWise", "BudgetWise", _secretKey, false, 3);

            using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(setupCode.QrCodeSetupImageUrl.Replace("data:image/png;base64,", ""))))
                pbQRCode.Image = Image.FromStream(ms);
        }
    }
}
