//Clase abstracta

namespace AFactory
{
    //fábrica (abstracta) de fábricas
    public abstract class Factory
    {
        public abstract Guide CreateGuide();
        public abstract Exam CreateExam();
    }

    //método para poder aplicar exámenes
    public abstract class Exam
    {
        public abstract void ApplyExam();
    }

    //método para las guías
    public abstract class Guide
    {
        public abstract void ShowGuide();
    }
}
