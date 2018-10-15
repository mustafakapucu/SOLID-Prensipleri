using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosed.Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            ImageCreator<Bmp> creator = new ImageCreator<Bmp>(new Bmp());
            creator.DrawImage();
            creator.RandomizeImage();

            ImageCreator<Tif> cretor2 = new ImageCreator<Tif>(new Tif());
            cretor2.RandomizeImage();
            cretor2.DrawImage();
        }
    }

    public class ImageCreator<T> where T : IImage
    {
        private T image;

        public ImageCreator(T img)
        {
            image = img;
        }

        public void RandomizeImage()
        {
            image.Randomize();
        }

        public void DrawImage()
        {
            image.Draw();
        }

    }

    public interface IImage
    {
        void Randomize();
        void Draw();
    }

    class Bmp
       : IImage
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
        : IImage
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
        : IImage
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
