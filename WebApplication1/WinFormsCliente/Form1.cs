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
        AlumnoService servicio = new AlumnoService();//Creamos el AlumnoService.
        private async void btnListar_Click(object sender, EventArgs e)//Los eventos solo llevan el async y usan el await.
        {
            dgViews.Rows.Clear();//Limpiamos el dataGridViews.
            foreach (var a in await servicio.GetAll())//Recoremos la lista que nos retorna el GetAll.
            {
                dgViews.Rows.Add(new object[] { a.Id, a.Nombre, a.Nota, a.LU });//Cargamos los datos en el DGV.
            }
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbxID.Text);//Leemos el tbx.
            var a = await servicio.GetById(id);//Llamamos al metodo y se lo devolvemos.
            dgViews.Rows.Clear();//Limpiamos el dataGridViews.
            dgViews.Rows.Add(new object[] { a.Id, a.Nombre, a.Nota, a.LU });//Cargamos los datos en el DGV.
        }
    }
}
