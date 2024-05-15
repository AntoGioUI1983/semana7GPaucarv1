
using System.Net;


namespace semana6GPaucar.Views
{
    public partial class vAgregar : ContentPage
    {
        public vAgregar()
        {
            InitializeComponent();
        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            try
            {
                WebClient cliente = new WebClient();
                var parametros = new System.Collections.Specialized.NameValueCollection();
               // parametros.Add("id", txtId.Text);
                parametros.Add("producto",txtProducto.Text);
                parametros.Add("categoria",txtCategoria.Text);
                parametros.Add("precio",txtPrecio.Text);

                cliente.UploadValues("http://192.168.100.61:8080/appProductos/post.php","POST", parametros);
                Navigation.PushAsync(new vProductos());
             

              
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error si ocurre alguna excepción
                // DisplayAlert("Error", ex.Message, "Cerrar");
                DisplayAlert("Error", ex.ToString(), "Cerrar");
            }
        }
    }
}
