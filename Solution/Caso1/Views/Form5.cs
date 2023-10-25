using Application.Interfaces;
using Application.Models;
using Application.Models.Common;

namespace Caso1.Views
{
    public partial class Form5 : Form
    {
        private readonly IApplicationServices _services;

        public Form5(IApplicationServices services)
        {
            InitializeComponent();
            _services = services;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var entity = new Entity()
                {
                    Field1 = textBox1.Text.Trim(),
                    Field2 = textBox2.Text.Trim(),
                    Field3 = textBox3.Text.Trim(),
                    Field4 = textBox4.Text.Trim(),
                    Field5 = textBox5.Text.Trim()
                };

                Result result = await _services.Case1Service.AddEntity(entity);

                if (!result.Success)
                    throw new Exception("Something went wrong!");

                MessageBox.Show("Good Job!", "😀", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
