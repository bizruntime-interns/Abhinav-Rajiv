using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace necore.model
{
    public interface IstudentRep
    {
        student GetStudent(int id);
        IEnumerable<student> allStudent();
        student add(student s);
        student Search(int id, string name);

    }
}
