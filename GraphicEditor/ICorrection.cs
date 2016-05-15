using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor
{
    interface ICorrection
    {
        void SetPicture(Image img);
        Image GetPicture();
    }
}
