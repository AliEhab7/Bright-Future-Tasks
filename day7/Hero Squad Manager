using System.Collections;
using System.Net.Cache;
using System.Numerics;
using System.Xml.Schema;

namespace DotNet_task1
{

    //الصراحة انا عملته بسرعه و تحسه مش منطقي بس فيه حاجات في التاسك حاسس انها مش مفهومة اوي مفروض تطبق ازاي
   
    public class Heros
    {
        public string name;
        public int level;
    }
    class Squad<T> : IEnumerable<T>
    {
        List<T> members = new List<T>();
        public IEnumerator<T> GetEnumerator()
        {
            return members.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public List<Heros> getlvl50(List<Heros> heros)
        {
            List<Heros> heroesList = new List<Heros>(heros);
            foreach (var x in heros)
            {
                if (x.level > 50)
                {
                    heroesList.Add(x);
                }
            }
            return heroesList;
        }
    }


    internal class Program
    {
        public delegate List<Heros> deligate1(List<Heros> heros);
        static void Main(string[] args)
        {
            Squad<Heros> squad = new Squad<Heros>();

            deligate1 deli2 = heros => squad.getlvl50(heros);

            deligate1 deli = delegate (List<Heros>squad)
          { 
              List<Heros> heroesList = new List<Heros>(squad);
              foreach (var x in squad)
              {
                  if (x.name == "Batman")
                  {
                      heroesList.Add(x);
                  }
              }
              return heroesList;
          };
            
        }
    }
}
