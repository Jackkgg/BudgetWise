using BudgetWise.Interfaces;
using BudgetWise.Models;
using BudgetWise.Repositories;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BudgetWise.Forms
{
    public partial class RegisterAuth : Form
    {
        private readonly IPersonalUserRepository _personalUserRepository;
        private readonly string _username;
        public RegisterAuth(string username)
        {
            InitializeComponent();
            _username = username;
            _personalUserRepository = new PersonalUserRepository(new ApplicationDbContext());
        }

        private void RegisterAuth_Load(object sender, EventArgs e)
        {
            try
            {
                string secretKey = Guid.NewGuid().ToString().Replace("-", "");

                TwoFactorAuthenticator tfA = new TwoFactorAuthenticator(HashType.SHA256);
                var setupCode = tfA.GenerateSetupCode("BudgetWise", "BudgetWise", secretKey, false, 3);

                using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(setupCode.QrCodeSetupImageUrl.Replace("data:image/png;base64,", ""))))
                    pbQRCode.Image = Image.FromStream(ms);

                _personalUserRepository.AddAuthKey(secretKey, _username);
                
            }
            catch (Exception ex) { }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
