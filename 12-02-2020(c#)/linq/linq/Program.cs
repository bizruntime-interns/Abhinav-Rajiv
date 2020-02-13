using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace linq
{
    class Vote
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            

            IList<Student> stu = new List<Student>()
            {
                new Student(){sname="abhi",age=19,id=1 },
                new Student(){sname="amal",age=12,id=2},
                new Student(){ sname="rajeevan",age=40,id=3},
                new Student(){ sname="sujina", age=38,id=4},
                new Student(){sname="raghavan",age=78,id=5},
                new Student(){sname="leela",age=56,id=6}

            };

            IList<Employees> emp = new List<Employees>();

            add(emp);
            max(emp);
            order(emp);
            old(stu);
            Elegi(stu);
            join(emp, stu);
            groupjoin(stu, emp);
            search(stu);

            log.Info("The List of students");
            foreach(Student s in stu)
            {
               log.Info(s.sname + " " + s.age);
            }

            Console.ReadKey();

        }

        public static void Elegi(IList<Student> st)
        {
            var teenage = st.Where(s => s.age > 11 && s.age < 20);
            log.Info("Teenagers ");
            foreach (Student sta in teenage)
            {

                log.Info(" name:"+sta.sname+" Age:"+sta.age);
            }


        }

        public static void max(IList<Employees> emp)
        {
            int maxx = (from s in emp select s.salary).Max();
            log.Info("Max salary :"+maxx+"\n");
            
        }

        public static void order(IList<Employees> emp)
        {
            
            var name=from empp in emp where empp.desi == "manager" orderby empp.name ascending select empp;
            log.Debug("Order By Name\n");
            foreach(Employees ee in name)
            {
                log.Info(" name : " + ee.name+" desi :"+ee.desi);
            }
            log.Info(" \n");
        }

        public static void join(IList<Employees> emp,IList<Student> stu)
        {
            var joinop = from em in emp join st in stu on em.id equals st.id select new { em.name, st.sname };
            log.Info("Names in Joint::\n");
            foreach (var it in joinop)
            {
                log.Info(it.name + "---" + it.sname);
            }
        }


        public static void groupjoin(IList<Student> stu,IList<Employees>emp)
        {
            var grjoinop = from em in emp join st in stu on em.id equals st.id into groupp select groupp;
            log.Info("Names in GroupJoint::\n");
            foreach (IEnumerable<Student> stt in grjoinop)
            {
                log.Info("Group");
                foreach (Student it in stt)
                {
                    log.Info(it.sname);
                }
            }
        }


        public static void add(IList<Employees> emp)
        {
            log.Info("enter the details of employee name ,id,desi,salary");
            log.Warn("enter the n.o of employees");

            try
            {
                int n = int.Parse(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    log.Info(i + "th employee");
                    emp.Add(new Employees() { name = Console.ReadLine(), id = int.Parse(Console.ReadLine()), desi = Console.ReadLine(), salary = int.Parse(Console.ReadLine()) });
                }
            }catch(Exception e)
            {
                log.Error(e.Message.ToString());
            }
            log.Info(" \n");
            log.Info("The details of emplyees are");
            foreach (Employees ee in emp)
            {
                log.Info("name :" + ee.name + "id : " + ee.id + " desi : " + ee.desi + " salary : " + ee.salary + "\n");
            }
            log.Info(" \n");
        }


        public static void old(IList<Student> oldst)
        {
            var oldd = from s in oldst where s.sname.Contains("abhi") select s;
            log.Info("Age of contains Abhi");
            foreach(Student st in oldd)
            {
                log.Info("name:" + st.sname + " Age :" + st.age);
            }
            log.Info(" \n");
        }


        public static void search(IList<Student> stu)
        {
            log.Info("enter the name to search");
            string name = Console.ReadLine();
            var namesearch = from na in stu where na.sname == name select na;
            if (namesearch != null)
            {
               
                foreach (Student stud in namesearch)
                {
                    log.Info("students found");
                    log.Info("name is : " + stud.sname + " Age :" + stud.age);
                }
                log.Info(" \n");
            }
        }

    }
}
