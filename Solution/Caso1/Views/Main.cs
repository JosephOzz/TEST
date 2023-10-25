using Application.Enums;
using Application.Interfaces;

namespace Caso1.Views
{
    public partial class Main : Form
    {
        private readonly IApplicationServices _services;
        public Main(IApplicationServices services)
        {
            InitializeComponent();
            _services = services;
        }

        private void Main_Load(object sender, EventArgs e)
            => MainOption1_Click(sender, e);

        private void MainOption1_Click(object sender, EventArgs e)
            => AppendToParent(new Form1(_services), ApplicationModules.Form1);

        private void MainOption2_Click(object sender, EventArgs e)
            => AppendToParent(new Form2(_services), ApplicationModules.Form2);

        private void MainOption3_Click(object sender, EventArgs e)
            => AppendToParent(new Form3(_services), ApplicationModules.Form3);

        private void MainOption4_Click(object sender, EventArgs e)
            => AppendToParent(new Form4(_services), ApplicationModules.Form4);

        private void MainOption5_Click(object sender, EventArgs e)
            => AppendToParent(new Form5(_services), ApplicationModules.Form5);

        private void AppendToParent(Form child, ApplicationModules module)
        {
            ActivateOption(module);
            HideForms();
            child.MdiParent = this;
            child.Dock = DockStyle.Fill;
            this.CenterToScreen();
            child.Show();
        }

        private void ActivateOption(ApplicationModules module)
        {
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.BackColor = Color.FromArgb(248, 248, 248);
            }

            menuStrip1.Items[(int)module].BackColor = Color.FromArgb(179, 215, 243);
        }

        private void HideForms()
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
                f.Dispose();
            }
        }
    }
}