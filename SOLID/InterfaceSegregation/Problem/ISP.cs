using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegregation.Problem
{

    interface IComponent
    {
        Guid ComponentId { get; }

        void Initialize();
        void Draw();
        void Render();
    }

    public class WinButton : IComponent
    {
        public Guid ComponentId
        {
            get
            {
                return Guid.NewGuid();
            }
        }

        public void Draw()
        {
            Console.WriteLine("Ekrana çizdirme işlemleri");
        }

        public void Initialize()
        {
            Console.WriteLine("Windows Button başlangıç işlemleri");
        }

        public void Render()
        {
            throw new NotImplementedException();
        }
    }

    public class WebButon : IComponent
    {
        public Guid ComponentId
        {
            get
            {
                return Guid.NewGuid();
            }
        }

        public void Draw()
        {
            throw new NotImplementedException();
        }

        public void Initialize()
        {
            Console.WriteLine("Web Button başlangıç işlemleri");
        }

        public void Render()
        {
            Console.WriteLine("HTML Render işlemleri");
        }
    }
}
