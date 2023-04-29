using Microsoft.EntityFrameworkCore;
using PracticaFormularioHelper.Models;

namespace PracticaFormularioHelper.Models
{
    public class equiposPrueba : DbContext
    {
        public equiposPrueba(DbContextOptions options) : base(options)
        {
        }
        public DbSet<equiposs> equiposs { get; set; }
        public DbSet<marcas> marcas { get; set; }
        public DbSet<estados_equipo> estados_equipo { get; set; }
        public DbSet<tipo_equipo> tipo_equipo { get; set; }
    }
}
