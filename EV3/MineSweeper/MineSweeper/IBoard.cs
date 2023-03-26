using System;


namespace MineSweeper
{
    public interface IBoard
    {
        
        #region FUNCIONES DEL JUEGO
        //Pregunta si la casilla que se añade a la lista/array esta dentro del tamaño requerido
        bool IsCellOnBoard(int x, int y)
        {
            return (x >= 0 && y >= 0 && x < GetWidth() && y < GetHeight());
        }
        
        int GetWidth(); //Devuelve la anchura del tablero
        int GetHeight(); //Devuelve la altura del tablero
        void CreateBoard(int w, int h); //Crea el tablero con la altura y anchura dada

        //Añade bombas en función de cuantas bombas le digas
        // y la 1era casilla que abras
        void Init(int x, int y, int bombCount);
        //Pregunta si ha ganado mirando si todas las casillas que no sean bombas
        //esten abiertas
        bool HasWin()
        {
          for (int i = 0; i < GetWidth(); i++)
            {
                for(int j = 0; j < GetHeight(); j++)
                {
                    if(!IsCellOpen(i, j) && !IsBombAt(i,j))
                        return false;
                }
            }
            return true;
        }
        //Escribe por pantalla el buscaminas creado con caracteres alfanúmericos
        void WriteMineSweeper();
        #endregion
        
        #region FUNCIONES DE BOMBAS
        //Pregunta si hay una bomba en dada posición
        bool IsBombAt(int x, int y);
        //Devuelve cuantas bombas hay alrededor de la casilla que se le diga
        int GetBombProximity(int x, int y) 
        {
            int counter = 0;
           
                if (IsCellOnBoard(x + 1,y + 1) && IsBombAt(x + 1, y + 1))
                    counter++;
                if (IsCellOnBoard(x, y + 1) && IsBombAt(x, y + 1))
                    counter++;
                if (IsCellOnBoard(x, y - 1) && IsBombAt(x, y - 1))
                    counter++;
                if (IsCellOnBoard(x + 1, y) && IsBombAt(x + 1, y))
                    counter++;
                if (IsCellOnBoard(x - 1, y) && IsBombAt(x - 1, y))
                    counter++;
                if (IsCellOnBoard(x - 1, y - 1) && IsBombAt(x - 1, y - 1))
                    counter++;
                if (IsCellOnBoard(x + 1, y - 1) && IsBombAt(x + 1, y -1))
                    counter++;
                if (IsCellOnBoard(x - 1, y + 1) && IsBombAt(x - 1, y + 1))
                    counter++;
          
            return counter;
        }
        #endregion

        #region FUNCIONES DE BANDERAS
        bool IsFlagAt(int x, int y); //Pregunta si hay en la posición dada
        void PutFlagAt(int x, int y); //Pone una bandera en la posición dada
        void DeleteFlagAt(int x, int y); //Borra una bandera en la posición dada
        #endregion

        #region FUNCIONES DE CASILLAS

        bool IsCellOpen(int x, int y); //Pregunta si una casilla esta abierta en una posición dada
        void OpenCell(int x, int y); //Pregunta si la casilla en una posición dada esta abierta
        #endregion
    }
}
