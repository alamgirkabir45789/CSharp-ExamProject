using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository_Domain;
using Repository_Source;
namespace RepositoryPattern
{
    public class StudentXMLRepository : XMLRepositoryBase<XMLSet<Student>, Student, int>, IStudentRepository
    {
        public StudentXMLRepository() : base("StudentInformation.xml")
        {
        }
    }
}
