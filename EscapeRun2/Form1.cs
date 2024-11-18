namespace EscapeRun2
{
    public partial class Form1 : Form
    {
        //public FormCreate parentForm;
        public Form1()
        {
            InitializeComponent();
            //this.parentForm = parentForm;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to exit game", "Exit Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void btnOptn_Click(object sender, EventArgs e)
        {
            //    Form_Settings FormSet = new Form_Settings();
            //    FormSet.Show();
        }

        private void btnStrt_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormGame game = new FormGame(this);
            game.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCreate Create = new FormCreate(this);
            Create.Show();
        }
    }
}
