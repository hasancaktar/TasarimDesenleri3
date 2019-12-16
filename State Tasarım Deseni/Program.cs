using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace State_Tasarım_Deseni
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context=new Context(); 
            DegistirState degistirState=new DegistirState();
            degistirState.Islem(context);
           
            SilState silState=new SilState();
            silState.Islem(context);
            
            EkleState ekleState=new EkleState();
            ekleState.Islem(context);
           
            Console.WriteLine(context.GetState().ToString());
            Console.ReadLine();


        }
    }

    interface IState
    {
        void Islem(Context context);
    }

    class Context
    {
        private IState _state;

        public void setState(IState state)
        {
            _state = state;

        }

        public IState GetState()
        {
            return _state;
        }
    }

    class DegistirState:IState 
    {
        public void Islem(Context context)
        {
            Console.WriteLine("Değiştirme İşlemleri yapıldı");
            context.setState(this);
        }

        public override string ToString()
        {
            return "Son İşlem: Değiştirme";
        }
    }
    class SilState : IState
    {
        public void Islem(Context context)
        {
            Console.WriteLine("Silme İşlemleri yapıldı");
            context.setState(this);

        }
        public override string ToString()
        {
            return "Son İşlem: Silme";
        }
    }
    class EkleState : IState
    {
        public void Islem(Context context)
        {
            Console.WriteLine("Ekleme İşlemleri yapıldı");
            context.setState(this);

        }
        public override string ToString()
        {
            return "Son İşlem: Ekleme";
        }
    }
}
