using System.Numerics;
using Problemas_de_Conteo.Modules.GridPaths.Algorithms;

namespace Problemas_de_Conteo.Modules.GridPaths.Services
{
	public class GridPathService
	{
		public BigInteger CalculateBasicPath(int a, int b)
		{
			return BinomialCalc.CalculateBin(a + b, b); 
		}
	}
}
