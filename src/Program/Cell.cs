//La clase Cell, cumple con el SRP porque su única responsabilidad es administrar el estado de las células
//en cada celda.
namespace Ucu.Poo.GameOfLife
{
    public class Cell
    {
        public bool IsAlive { get; set; }

        public Cell(bool isAlive)
        {
            IsAlive = isAlive;
                
        }
    }
}