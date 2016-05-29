using System.Drawing;

namespace GraphicEditor
{
    interface ICorrection
    {
        void SetPicture(Image img);
        Image GetPicture();
    }
}
