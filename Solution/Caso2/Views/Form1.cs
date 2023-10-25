using Application.Interfaces;
using Application.Models.Common;
using Caso2.Properties;

namespace Caso2.Views
{
    public partial class Form1 : Form
    {
        private readonly IApplicationServices _services;
        public Form1(IApplicationServices services)
        {
            InitializeComponent();
            _services = services;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Settings.Default.FilePath;
                openFileDialog.Filter = "Archivos CSV (*.csv)|*.csv";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    textBox1.Text = filePath;
                }
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                    throw new Exception("Please select the file");

                Result result = await _services.Case2Service.ProcessFile(textBox1.Text.Trim());

                if (!result.Success)
                    throw new Exception("Something went wrong!");

                MessageBox.Show("Good Job!", "😀", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
