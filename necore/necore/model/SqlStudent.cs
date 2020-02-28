using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace necore.model
{
    public class SqlStudent : IstudentRep
    {
        private readonly AppDbContext context;

        public SqlStudent(AppDbContext context)
        {
            this.context = context;
        }
        public student add(student s)
        {
            context.student.Add(s);
            context.SaveChanges();
            return s;

        }

        public IEnumerable<student> allStudent()
        {
            return context.student;
        }

        public student GetStudent(int id)
        {
            return context.student.Find(id);
            
        }

        
        public  student Search(int id, string name)
        {
           student s= context.student.Find(id);
            if (s != null && s.name.Equals(name))
            {
                return s;
            }
            else
            {
                s = null;
                return s;
            }
            
        }
    }
}
