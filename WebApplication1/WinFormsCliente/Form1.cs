using System.Windows.Forms;
using WinFormsCliente.Services;

namespace WinFormsCliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        AlumnoService servicio = new AlumnoService();
        private async void btnListar_Click(object sender, EventArgs e)
        {
            dgViews.Rows.Clear();
            foreach (var a in await servicio.GetAll())
            {
                dgViews.Rows.Add(new object[] {a.Id,a.Nombre,a.Nota,a.LU });
            }
        }
    }
}
