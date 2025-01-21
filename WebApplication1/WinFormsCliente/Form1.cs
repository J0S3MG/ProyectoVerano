using System.ComponentModel.Design;
using System.Windows.Forms;
using WinFormsCliente.Models;
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
        #region Caso GetAll.
        private async void btnListar_Click(object sender, EventArgs e)//Los eventos solo llevan el async y usan el await.
        {
            dgViews.Rows.Clear();//Limpiamos el dataGridViews.
            foreach (var a in await servicio.GetAll())//Recoremos la lista que nos retorna el GetAll.
            {
                dgViews.Rows.Add(new object[] { a.Id, a.Nombre, a.Nota, a.LU });//Cargamos los datos en el DGV.
            }
        }
        #endregion
        #region Caso GetById.
        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbxID.Text);//Leemos el tbx.
            var a = await servicio.GetById(id);//Llamamos al metodo y se lo devolvemos.
            dgViews.Rows.Clear();//Limpiamos el dataGridViews.
            dgViews.Rows.Add(new object[] { a.Id, a.Nombre, a.Nota, a.LU });//Cargamos los datos en el DGV.
        }
        #endregion
        #region Caso Insert.
        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbxID.Text);
            int lu = Convert.ToInt32(tbxLU.Text);
            decimal nota = Convert.ToDecimal(tbxNota.Text);
            string nom = tbxNombre.Text;

            var a = await servicio.Insert(id, lu, nota, nom);
            dgViews.Rows.Clear();//Limpiamos el dataGridViews.
            dgViews.Rows.Add(new object[] { a.Id, a.Nombre, a.Nota, a.LU });
        }
        #endregion
        #region Caso Update.
        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbxID.Text);
            int lu = Convert.ToInt32(tbxLU.Text);
            decimal nota = Convert.ToDecimal(tbxNota.Text);
            string nom = tbxNombre.Text;

            var a = await servicio.Update(id, lu, nota, nom);
            dgViews.Rows.Clear();//Limpiamos el dataGridViews.
            dgViews.Rows.Add(new object[] { a.Id, a.Nombre, a.Nota, a.LU });
        }
        #endregion
        #region Caso Delete.
        private async void btnBorrar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbxID.Text);
            var b = await servicio.Delete(id);//Borramos al alumno con su id.
            if(b != true)
            {
                MessageBox.Show("No se pudo borrar el alumno");
            }
            MessageBox.Show("El alumno se borro correctamente");
            dgViews.Rows.Clear();//Limpiamos el dataGridViews.
            foreach (var a in await servicio.GetAll())//Recoremos la lista que nos retorna el GetAll.
            {
                dgViews.Rows.Add(new object[] { a.Id, a.Nombre, a.Nota, a.LU });//Cargamos los datos en el DGV.
            }
        }
        #endregion
    }

}
