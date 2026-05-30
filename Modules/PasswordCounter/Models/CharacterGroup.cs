namespace Problemas_de_Conteo.Modules.PasswordCounter.Models
{
    // Modelo para los grupos personalizados
    public class CharacterGroup
    {
        public string Name { get; set; } = "";

        public int Size { get; set; }

        public bool Required { get; set; }
    }
}
