namespace COD
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void showActionForm(Form form)
        {
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Red_Worm redWormForm = new Red_Worm();
            showActionForm(redWormForm);
        }
    }
}
