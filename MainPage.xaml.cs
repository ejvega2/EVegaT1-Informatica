namespace ProyectoSemana1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }


        private void btnSaludo_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int edad = Convert.ToInt32(txtEdad.Text); //Funcion para convertir texto en enteros
            int salario = Convert.ToInt32(txtSalario.Text); //Funcion para convertir texto en enteros

            //int edad = 2024 - nacimiento;
            double datocalculado = (salario * 9.45) / 100;

            DisplayAlert("Alerta", "Bienvenido " + nombre +" "+ apellido +"\nTienes " + edad+ " años "+ "\nTu aporte mensual al IESS es de: "+ datocalculado, " Cerrar ");
        }
    }

}
