namespace Contactos
{
    public partial class Contactos : Form
    {
        public Contactos()
        {
            InitializeComponent();

            List<Contacto> contacto = Contacto.LeerContactos();

            foreach (Contacto c in contacto)
            {
                lstContactos.Items.Add(c);
            }
        }

        private void btbAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtEdad.Text != "" &&
                txtTelefono.Text != "")
            {
                string nombre = txtNombre.Text;
                int edad = Convert.ToInt32(txtEdad.Text);
                string telefono = txtTelefono.Text;

                lstContactos.Items.Add(new Contacto(nombre, edad, telefono));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int posicion = lstContactos.SelectedIndex;
            if (posicion == -1)
            {
                MessageBox.Show("No hay ningun contacto seleccionado");
            }
            else
            {
                lstContactos.Items.RemoveAt(posicion);
            }
        }

        private void Contactos_FormClosed(object sender, FormClosedEventArgs e)
        {
            List<Contacto> contactos = new List<Contacto>();
            foreach(var c in lstContactos.Items)
            {
                contactos.Add((Contacto)c);
            }
            
            Contacto.GuararContactos(contactos);
        }
    }
}
