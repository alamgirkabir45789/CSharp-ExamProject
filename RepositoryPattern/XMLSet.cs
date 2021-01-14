using System.Collections.Generic;

namespace RepositoryPattern
{
    public class XMLSet<TEntity> where TEntity : class
    {
        private string fileName;

        public XMLSet(string fileName)
        {
            this.fileName = fileName;
        }

        internal List<IEntity<object>> Data { get; set; }
    }
}