using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AFactory.VirtualGuide;
using static AFactory.PresencialGuide;

namespace AFactory
{
    public class VirtualFactory : Factory
    {
        public override Guide CreateGuide()
        {
            return new VirtualGuide();
        }

        public override Exam CreateExam()
        {
            return new VirtualExam();
        }
    }
}
