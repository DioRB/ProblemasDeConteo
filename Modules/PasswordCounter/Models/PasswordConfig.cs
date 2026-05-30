namespace Problemas_de_Conteo.Modules.PasswordCounter.Models
{
	// Modelo general
	public class PasswordConfig
	{
		public int Length { get; set; }
		public int AlphabetSize { get; set; }
		public bool AllowRepetition { get; set; }
        public List<CharacterGroup> Groups { get; set; } = new();
    }
}
