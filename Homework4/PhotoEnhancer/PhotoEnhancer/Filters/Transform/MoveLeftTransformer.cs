using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEnhancer
{
    public class MoveLeftTransformer : ITransformer<MoveLeft>
    {
        double N { get; set; }

        public Size Size { get; private set; }

        public void Initialize(Size size, MoveLeft parameters)
        {
            N = parameters.NInPerсents /100;
            Size = size;
        }

        public Point? MapPoint(Point point)
        {
            point = new Point(point.X, point.Y);
            var x = (int)(point.X + (Size.Width*N));
            var y = (int)(point.Y);

            if (x >= Size.Width)
                x -= Size.Width;

            return new Point(x, y);
        }
    }
}
