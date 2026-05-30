using Problemas_de_Conteo.Modules.PasswordCounter.Models;

namespace Problemas_de_Conteo.Modules.PasswordCounter.Services
{
	public class PasswordValidatorService
	{
        public string Validate(PasswordConfig config)
        {
            if (config.Length <= 0)
                return "La longitud debe ser positiva.";

            if (config.AlphabetSize <= 0)
                return "El tamaño del alfabeto debe ser positivo.";

            if (!config.AllowRepetition && config.Length > config.AlphabetSize)
                return "No es posible generar contraseñas sin repetición: la longitud supera el alfabeto.";

            // ✅ Validación nueva
            var invalidGroups = config.Groups
                .Where(g => g.Size < 0)
                .Select(g => g.Name)
                .ToList();

            if (invalidGroups.Any())
                return $"Los siguientes grupos tienen tamaño negativo: {string.Join(", ", invalidGroups)}.";

            int sumGroups = config.Groups.Sum(g => g.Size);

            if (sumGroups > config.AlphabetSize)
                return $"La suma de los grupos ({sumGroups}) supera el tamaño del alfabeto ({config.AlphabetSize}).";

            // Verifica que cada grupo requerido sea alcanzable
            var requiredSum = config.Groups
                .Where(g => g.Required)
                .Sum(g => g.Size);

            if (requiredSum > config.AlphabetSize)
                return "Los grupos requeridos en conjunto superan el tamaño del alfabeto.";

            return "";
        }
    }
}
