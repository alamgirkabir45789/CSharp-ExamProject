using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository_Domain;
namespace RepositoryPattern
{
    public interface ITraineeRepository : IRepository<Student, int>
    {
    }
}