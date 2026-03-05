//productos concretos, es lo que se va a poder usar en las fábricas concretas
//contenido para clases en línea

namespace AFactory
{
    
        //guía modo virtual
        public class VirtualGuide : Guide
        {
            public override void ShowGuide()
            {
                System.Console.WriteLine("Mostrando guía en línea");
            }
        }

        //examen modo virtual
        public  class VirtualExam : Exam
        {
            public override void ApplyExam()
            {
                System.Console.WriteLine("Examen en línea");
            }
        }
    
}
