namespace Problemas_de_Conteo.Modules.GridPaths.Models
{
	// Clase para los caminos
	public class GridCell
	{
		public int X { get; set; }
		public int Y { get; set; }
		public bool IsBlocked { get; set; }
		public bool IsMandatory { get; set; }
		public bool IsStart {  get; set; }
		public bool IsEnd { get; set; }
	}
}
