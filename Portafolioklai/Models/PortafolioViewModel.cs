namespace Portafolioklai.Models
{
    public class ProyectoModel
    {
        public string Titulo { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public string Tecnologias { get; set; } = string.Empty;
        public string ImagenUrl { get; set; } = string.Empty;
        public string EnlaceRepo { get; set; } = string.Empty;
    }

    public class PortafolioViewModel
    {
        public string Nombre { get; set; } = string.Empty;
        public string TituloProfesional { get; set; } = string.Empty;
        public string FotoPerfil { get; set; } = string.Empty;
        public string Biografia { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string GitHub { get; set; } = string.Empty;
        public string LinkedIn { get; set; } = string.Empty;
        public List<ProyectoModel> Proyectos { get; set; } = new();
    }
}