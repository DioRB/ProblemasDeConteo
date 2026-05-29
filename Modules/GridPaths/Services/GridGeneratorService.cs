using Problemas_de_Conteo.Modules.GridPaths.Models;

namespace Problemas_de_Conteo.Modules.GridPaths.Services
{
    // Genera las grillas
    public class GridGeneratorService
    {
        public List<GridCell> GenerateGrid(int a, int b)
        {
            List<GridCell> grid = new();

            for (int x = 0; x <= a; x++)
            {
                for (int y = 0; y <= b; y++)
                {
                    grid.Add(new GridCell
                    {
                        X = x,
                        Y = y,

                        IsStart = (x == 0 && y == 0),

                        IsEnd = (x == a && y == b)
                    });
                }
            }

            return grid;
        }
    }
}
