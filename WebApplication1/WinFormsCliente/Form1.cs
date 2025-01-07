using WinFormsCliente.ClienteServices;
using WinFormsCliente.Models;

namespace WinFormsCliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        AlumnoService servicio = new AlumnoService();
                    //Task
        private async void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            
            foreach(var a in await servicio.GetAll())
            {
                dataGridView1.Rows.Add(new object[] {a.Nom,a.Nota,a.LU,a.Id});
            }
        }
    }
}
