using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosed.Old
{

    class Program
    {
        static void Main(string[] args)
        {
            ImageCreator creator = new ImageCreator(new Jpg());
            creator.Randomize();
            creator.Draw();

            creator = new ImageCreator(new Tif());
            creator.Randomize();
            creator.Draw();
        }
    }

    class ImageCreator
    {
        ImageBase _image = null;

        public ImageCreator(ImageBase obj)
        {
            _image = obj;
        }

        public void Randomize()
        {
            if (_image is Bmp)
                ((Bmp)_image).Randomize();
            else if (_image is Jpg)
                ((Jpg)_image).Randomize();
            else if (_image is Tif)
                ((Tif)_image).Randomize();
            else
                Console.WriteLine("Geçersiz format");
        }
        public void Draw()
        {
            if (_image is Bmp)
                ((Bmp)_image).Draw();
            else if (_image is Jpg)
                ((Jpg)_image).Draw();
            else if (_image is Tif)
                ((Tif)_image).Draw();
            else
                Console.WriteLine("Geçersiz format");
        }

    }

    class ImageBase
    {
    }
    class Bmp
       : ImageBase
    {
        public void Randomize()
        {
            Console.WriteLine("Random bitmap");
        }
        public void Draw()
        {
            Console.WriteLine("Draw bitmap");
        }
    }

    class Jpg
        : ImageBase
    {
        public void Randomize()
        {
            Console.WriteLine("Random Jpg");
        }
        public void Draw()
        {
            Console.WriteLine("Draw Jpg");
        }
    }

    class Tif
        : ImageBase
    {
        public void Randomize()
        {
            Console.WriteLine("Random Tif");
        }
        public void Draw()
        {
            Console.WriteLine("Draw Tif");
        }
    }

}
