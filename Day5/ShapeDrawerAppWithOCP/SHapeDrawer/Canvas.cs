using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHapeDrawer
{
    public class Canvas
    {
        private List<IShape> shapes=new List<IShape>() { };
        public void AddShape(IShape shape)
        {
            shapes.Add(shape);
        }

        public void DrawShapes()
        {
            foreach (IShape shape in shapes)
            {
                shape.Draw();
            }
        }


    }
}
