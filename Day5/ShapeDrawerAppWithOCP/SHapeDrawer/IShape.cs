using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHapeDrawer
{
    public interface IShape
    {
        void Draw();
        double calculateArea();
    }
}
