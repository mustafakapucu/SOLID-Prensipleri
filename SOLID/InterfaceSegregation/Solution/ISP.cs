using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegregation.Solution
{
    interface IComponent
    {
        Guid ComponentId { get; }

        void Initialize();
    }

    interface IWebComponent
    {
        void Render();
    }

    interface IWinComponent
    {
        void Draw();
    }

    public class WinButton : IComponent, IWinComponent
    {
        public Guid ComponentId
        {
            get
            {
                throw new NotImplementedException();
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
    }

    public class WebButton : IComponent, IWebComponent
    {
        public Guid ComponentId
        {
            get { return Guid.NewGuid(); }
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
