using Problemas_de_Conteo.Modules.PasswordCounter.Models;
using System.Numerics;

namespace Problemas_de_Conteo.Modules.PasswordCounter.Services
{

    public class PasswordCountService
    {
        // Para los al menos de cada grupo
        private List<CharacterGroup> GetRequiredGroups(PasswordConfig config)
        {
            return config.Groups
                .Where(g => g.Required)
                .ToList();
        }
        // Cuenta las contraseñas
        public BigInteger CountPasswords(
            PasswordConfig config)
        {
            if (config.AllowRepetition)
                return CountWithRestrictions(config);

            return CountWithoutRestrictions(config);
        }

        // Entrada para contar contraseñas sin repetición
        public BigInteger CountWithoutRepetition(int alphabetSize, int length)
        {
            if (alphabetSize < 0)
                return 0;

            if (length > alphabetSize)
                return 0;

            BigInteger result = 1;

            for (int i = 0; i < length; i++)
            {
                result *= (alphabetSize - i);
            }

            return result;
        }

        // Para evitar las potencias negativas y las vistas erroneas al respecto en latex
        private BigInteger SafePow(int alphabetSize, int length)
        {
            if (alphabetSize < 0)
                return 0;

            return BigInteger.Pow(alphabetSize, length);
        }

        // Verifica los grupos requeridos
        private BigInteger CountWithRestrictions(PasswordConfig config)
        {
            BigInteger total = SafePow(config.AlphabetSize, config.Length);

            var groups = GetRequiredGroups(config);

            if (!groups.Any())
                return total;

            BigInteger invalid = 0;

            int subsets = 1 << groups.Count;

            for (int mask = 1; mask < subsets; mask++)
            {
                int removed = 0;
                int selectedGroups = 0;

                for (int i = 0; i < groups.Count; i++)
                {
                    if ((mask & (1 << i)) != 0)
                    {
                        removed += groups[i].Size;
                        selectedGroups++;
                    }
                }

                BigInteger term = SafePow(config.AlphabetSize - removed, config.Length);

                if (selectedGroups % 2 == 1)
                    invalid += term;
                else
                    invalid -= term;
            }

            return total - invalid;
        }

        // Verifica los grupos para el conteo sin restriciones
        private BigInteger CountWithoutRestrictions(PasswordConfig config)
        {
            BigInteger total = CountWithoutRepetition(config.AlphabetSize, config.Length);

            var groups = GetRequiredGroups(config);

            if (!groups.Any())
                return total;

            BigInteger invalid = 0;

            int subsets = 1 << groups.Count;

            for (int mask = 1; mask < subsets; mask++)
            {
                int removed = 0;
                int selectedGroups = 0;

                for (int i = 0; i < groups.Count; i++)
                {
                    if ((mask & (1 << i)) != 0)
                    {
                        removed += groups[i].Size;
                        selectedGroups++;
                    }
                }

                BigInteger term = CountWithoutRepetition(config.AlphabetSize - removed, config.Length);

                if (selectedGroups % 2 == 1)
                    invalid += term;
                else
                    invalid -= term;
            }

            return total - invalid;
        }
    }
}
