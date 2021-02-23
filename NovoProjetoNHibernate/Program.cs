using NHibernate;
using NovoProjetoNHibernate.Menu;
using NovoProjetoNHibernate.NHibernate;

namespace NovoProjetoNHibernate
{
    public class Program
    {
        static void Main(string[] args)
        {
            ISession session = Session.CreateSession().OpenSession();
            var main = new Main(session);
            main.Menu();
        }
    }
}
