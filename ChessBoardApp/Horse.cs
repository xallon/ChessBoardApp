using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardApp
{
    class Horse : Piece
    {
        private int[] location;

        private int two_forward;
        private int one_forward;

        public Horse(int[] location, int two_forward, int one_forward)
        {
            this.location = location;
            this.two_forward = two_forward;
            this.one_forward = one_forward;

            twoforward(location, two_forward);
            oneforward(location, one_forward);
        }

        private void twoforward(int[] location, int direction)
        {
            if (direction == 0)
            {
                location = up(location, 2);
            }
            else if (direction == 1)
            {
                location = down(location, 2);
            }
            else if (direction == 2)
            {
                location = left(location, 2);
            }
            else if (direction == 3)
            {
                location = right(location, 2);
            }
        }

        private void oneforward(int[] location, int direction)
        {
            if (direction == 0)
            {
                location = up(location, 1);
            }
            else if (direction == 1)
            {
                location = down(location, 1);
            }
            else if (direction == 2)
            {
                location = left(location, 1);
            }
            else if (direction == 3)
            {
                location = right(location, 1);
            }
        }

        public int[] up(int[] k, int a)
        {
            k[0] -= a;
            return k;
        }

        public int[] down(int[] k, int a)
        {
            k[0] += a;
            return k;
        }

        public int[] left(int[] k, int a)
        {
            k[1] -= a;
            return k;
        }

        public int[] right(int[] k, int a)
        {
            k[1] += a;
            return k;
        }

        public int[] getLocation()
        {
            return location;
        }

        public void setLocation(int[] location)
        {
            this.location = location;
        }

        public int getTwo_forward()
        {
            return two_forward;
        }

        public void setTwo_forward(int two_forward)
        {
            this.two_forward = two_forward;
        }

        public int getOne_forward()
        {
            return one_forward;
        }

        public void setOne_forward(int one_forward)
        {
            this.one_forward = one_forward;
        }
    }
}
