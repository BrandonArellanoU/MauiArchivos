using MauiArchivos.Interfaces;
using MauiArchivos.Modelos;
using MauiArchivos.Repositorio;

namespace MauiArchivos
{
    public partial class MainPage : ContentPage
    {
        I_EstudianteUdla_Repositorio _estudianteUdla_Repositorio;
        EstudianteUdla estudiante = new EstudianteUdla();  

        public MainPage()
        {
            _estudianteUdla_Repositorio = new EstudianteUdlaArchivosRepositorio();
            InitializeComponent();

            estudiante = _estudianteUdla_Repositorio.DevuelveEstudianteUdla();

            BindingContext = estudiante;

        }

        private async void GuardarEstudiante_Clicked(object sender, EventArgs e)
        {
            EstudianteUdla estudiante = new EstudianteUdla
            {
                Id = 1,
                Nombre = "Brandon",
                Carrera = "Ingenieria Software"
            };
            bool guardar_Estudiante = _estudianteUdla_Repositorio.CrearEstudianteUdla(estudiante);

            if(guardar_Estudiante )
            {
                await DisplayAlert("Alerta", "Todo bien", "ok");
            }
            else
            {
                await DisplayAlert("Alerta", "Negado mi pana", "ok");
            }
        }
    }

}
