using System;
using System.Windows.Forms;

namespace GestionTareasPendientes
{
    public partial class Form_Tareas : Form
    {
        public Form_Tareas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_AgregarTarea_Click(object sender, EventArgs e)
        {
            var tarea = txt_Tarea.Text;
            if (!String.IsNullOrEmpty(tarea))
            {
                lst_Tareas.Items.Add(tarea);
                txt_Tarea.Text = "";

            }
            else
            {
                MessageBox.Show("Por favor ingrese una tarea");
            }


        }

        private void Form_Tareas_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido al modesto sistema de gestión de Tareas");
        }

        private void btn_EliminarTarea_Click(object sender, EventArgs e)
        {

            if (lst_Tareas.SelectedIndex != -1)
            {
                DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea eliminar esta tarea?", "Gestión de tareas",MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    lst_Tareas.Items.RemoveAt(lst_Tareas.SelectedIndex);
                    MessageBox.Show("Tarea eliminada con éxito");
                }
                else
                {
                    MessageBox.Show("Eliminación abortada");
                }


            }
            else
            {
                MessageBox.Show("Por favor seleccione una tarea para eliminar");
            }


        }

        private void txt_Tarea_TextChanged(object sender, EventArgs e)
        {

        }

        private void lst_Tareas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
