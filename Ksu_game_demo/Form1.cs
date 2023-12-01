namespace Ksu_game_demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PlayBTN_Click(object sender, EventArgs e)
        {
            KSU_Engine kSU_Engine = new KSU_Engine(fileTB.Text);
            kSU_Engine.Show();
        }
    }
}
