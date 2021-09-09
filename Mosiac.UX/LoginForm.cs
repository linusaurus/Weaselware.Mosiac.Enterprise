using System;
using System.Data;
using System.Linq;
using DataLayer.Data;
using DataLayer.Entity;
using ServiceLayer;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;

namespace Mosiac.UX
{
    public partial class LoginForm : Form
    {
        MosaicContext _context;
        bool isValidated = false;
        private int _employeeID;
        private string _userName;
        EmployeeService _employeeService;

        
        public LoginForm()
        {
            InitializeComponent();
            if (Mosiac.UX.Properties.Settings.Default.SaveUserName)
            {
                this.ckbSaveUserName.Checked = true;
                this.txtUserName.Text = Mosiac.UX.Properties.Settings.Default.UserName;
            }
             
        }

        private static void Shake(Form form)
        {
            var original = form.Location;
            var rnd = new Random(1337);
            const int shake_amplitude = 10;
            for (int i = 0; i < 10; i++)
            {
                form.Location = new Point(original.X + rnd.Next(-shake_amplitude, shake_amplitude), original.Y + rnd.Next(-shake_amplitude, shake_amplitude));
                System.Threading.Thread.Sleep(20);
            }
            form.Location = original;
        }

        public int EmployeeID
        {
            get { return _employeeID; }
            
        }
        public string UserName
        {
            get { return _userName; }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassWord.Text;

            using(_context = new MosaicContext(Mosiac.UX.Properties.Settings.Default.MosiacConnection) )
            {
                _employeeService = new EmployeeService(_context);

                var user = _context.Employees.Where(c => c.Login == username).FirstOrDefault();
                if (user != null)
                {
                    _userName = username;
                    _employeeID = user.employeeID;
                
                if (password == user.Password)
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    isValidated = true;
                    this._employeeID = user.employeeID;
                    Globals.CurrentLoggedUserID = user.employeeID;
                    Globals.CurrentUserName = _employeeService.FullName(user.employeeID);
                    Mosiac.UX.Properties.Settings.Default.UserName = _userName;
                    Mosiac.UX.Properties.Settings.Default.Save();

                    }
                else
                {
                    isValidated = false;
                    txtPassWord.Clear();
                    Shake(this);
                    
                }
                }
                else
                {
                    txtUserName.Clear();
                    txtPassWord.Clear();
                    txtUserName.Focus();
                }
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isValidated)
            {
                e.Cancel = true;
                txtUserName.Focus();
               
            }
        }

        private void LoginForm_Activated(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
           // Shake(this);
            System.Diagnostics.Process.GetCurrentProcess().Kill();
          
        }

        private void ckbSaveUserName_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cbx = (CheckBox)sender;
            if (cbx.Checked)
            {
                Mosiac.UX.Properties.Settings.Default.SaveUserName = true;                
                Mosiac.UX.Properties.Settings.Default.Save();
            }
        }
    }
}
