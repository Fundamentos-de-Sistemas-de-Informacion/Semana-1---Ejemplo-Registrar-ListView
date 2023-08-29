using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana_1___Ejemplo
{
    public partial class FormPago : Form
    {
        public FormPago()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empleado emple = new Empleado();
            emple.Nombre = textBoxNombre.Text;
            emple.Categoria = comboBoxCategoria.Text;
            emple.MinutosTardanza = int.Parse(textBoxMinTardanza.Text);
            emple.LLamadasAtencion = int.Parse(textBoxLlamadasAtencion.Text);

            switch(emple.Categoria)
            {
                case "A": emple.Pago = 2500; break;
                case "B": emple.Pago = 2000; break;
                case "C": emple.Pago = 1500; break;
                case "D": emple.Pago = 900; break;
            }

            if (emple.MinutosTardanza == 0 && emple.LLamadasAtencion == 0)
            {
                emple.Pago = emple.Pago + emple.Pago * 0.15;
            }
            else
            {
                double descMinutosTardanza = emple.MinutosTardanza * 5;
                double descLLamadasAtencion = emple.LLamadasAtencion * 10;
                emple.Pago = emple.Pago - descMinutosTardanza - descLLamadasAtencion;
            }

            ListViewItem fila = new ListViewItem(emple.Nombre);
            fila.SubItems.Add(emple.Categoria);
            fila.SubItems.Add(emple.MinutosTardanza.ToString());
            fila.SubItems.Add(emple.LLamadasAtencion.ToString());
            fila.SubItems.Add(emple.Pago.ToString());

            listViewEmpleados.Items.Add(fila);

            if(labelTotal.Text == "") {
                labelTotal.Text = "1";
            }
            else
            {
                labelTotal.Text = (int.Parse(labelTotal.Text) + 1).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
