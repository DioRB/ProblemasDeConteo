using System.Numerics;

namespace Problemas_de_Conteo.Modules.GridPaths.Algorithms
{
	public static class BinomialCalc
	{
		// Fucnion del calculo binomial (a+b b)
		public static BigInteger CalculateBin(int n, int k)
		{
			if (k < 0 || k > n)
				return 0;

			if (k == 0 || k == n)
				return 1;

			k = Math.Min(k, n-k);

			BigInteger result = 1;

			for (int i=1; i <= k; i++)
			{
				result *= n - (k - i);
				result /= i;
			}
			return result;
		}
	}
}
