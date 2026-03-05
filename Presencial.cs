//productos concretos, es lo que se va a poder usar en las fábricas concretas
//Productos impresos, contenido para modadlidad presencial

namespace AFactory
{
        //guía modo presencial
        public class PresencialGuide : Guide
        {
            public override void ShowGuide()
            {
                System.Console.WriteLine("Guía impresa");
            }
        }
        
        //examen modo presencial
        public class PresencialExam : Exam
        {
            public override void ApplyExam()
            {
                System.Console.WriteLine("Examen impreso");
            }
        }
    
}
