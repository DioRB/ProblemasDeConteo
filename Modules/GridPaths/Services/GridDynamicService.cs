using System.Numerics;
using Problemas_de_Conteo.Modules.GridPaths.Models;

namespace Problemas_de_Conteo.Modules.GridPaths.Services;

// Clase que cuenta los caminos posibles y los caminos entre puntos evitando los bloqueados
public class GridDynamicService
{
    public BigInteger CountPaths(
        int a,
        int b,
        List<GridCell> blocked)
    {
        BigInteger[,] dp = new BigInteger[a + 1, b + 1];

        HashSet<(int, int)> blockedSet = blocked
            .Select(c => (c.X, c.Y))
            .ToHashSet();

        dp[0, 0] = 1;

        for (int x = 0; x <= a; x++)
        {
            for (int y = 0; y <= b; y++)
            {
                if (blockedSet.Contains((x, y)))
                {
                    dp[x, y] = 0;
                    continue;
                }

                if (x > 0)
                    dp[x, y] += dp[x - 1, y];

                if (y > 0)
                    dp[x, y] += dp[x, y - 1];
            }
        }

        return dp[a, b];
    }

    public BigInteger CountPathsBetweenPoints(
        int startX,
        int startY,
        int endX,
        int endY,
        List<GridCell> blocked)
    {
        if (endX < startX || endY < startY)
            return 0;

        BigInteger[,] dp =
            new BigInteger[endX + 1, endY + 1];

        HashSet<(int, int)> blockedSet = blocked
            .Select(c => (c.X, c.Y))
            .ToHashSet();

        dp[startX, startY] = 1;

        for (int x = startX; x <= endX; x++)
        {
            for (int y = startY; y <= endY; y++)
            {
                if (blockedSet.Contains((x, y)))
                {
                    dp[x, y] = 0;
                    continue;
                }

                if (x > startX)
                    dp[x, y] += dp[x - 1, y];

                if (y > startY)
                    dp[x, y] += dp[x, y - 1];
            }
        }

        return dp[endX, endY];
    }
}

