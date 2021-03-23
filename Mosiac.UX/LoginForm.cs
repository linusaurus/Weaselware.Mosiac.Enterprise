using System;
using System.Data;
using System.Linq;
using DataLayer.Data;
using DataLayer.Entity;
using ServiceLayer;
using System.Windows.Forms;


namespace Mosiac.UX
{
    public partial class LoginForm : Form
    {
        MosaicContext _context;
        bool isValidated = false;
        int _employeeID;
        string _userName;
        EmployeeService _employeeService;

        
        public LoginForm()
        {
            InitializeComponent();

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
            using(_context = new MosaicContext() )
            {
                _employeeService = new EmployeeService(_context);

                var user = _context.Employees.Where(c => c.Login == username).FirstOrDefault();
                if (user != null)
                {
                    
                
                if (password == user.Password)
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    isValidated = true;
                    this._employeeID = user.employeeID;
                    Globals.CurrentLoggedUserID = user.employeeID;
                    Globals.CurrentUserName = _employeeService.FullName(user.employeeID);
                }
                else
                {
                    isValidated = false;
                    txtPassWord.Clear();
                    
                    
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
                Application.Exit();
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
           
            
            Application.Exit();
        }
    }
}
