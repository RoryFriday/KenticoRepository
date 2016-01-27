using System;
using System.Collections.Generic;
using Domain;

namespace Data
{
    public class Repository<T> where T : Entity
    {
        public ISession Session;

        public Repository(ISession session)
        {
            Session = session;
        }

        public virtual List<T> ListAll()
        {
            throw new NotImplementedException();
        }
    }
}
