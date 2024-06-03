namespace RecordanceApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SignInForm signinform = new SignInForm();

        private void startButton_Click(object sender, EventArgs e)
        {
            this.Hide();    
            signinform.ShowDialog();
        }
    }
}