using System.Numerics;

namespace Problemas_de_Conteo.Modules.GridPaths.Models
{
    // Para poder hacer la explicación de tramo por tramo
    public class PathSegmentExp
    {
        public GridCell Start { get; set; } = null!;

        public GridCell End { get; set; } = null!;

        public int Dx { get; set; }

        public int Dy { get; set; }

        public BigInteger Result { get; set; }
    }
}
