using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardApp
{
    interface Piece
    {
        int[] up(int[] location, int a);

        int[] down(int[] location, int a);

        int[] left(int[] location, int a);

        int[] right(int[] location, int a);
    }
}
