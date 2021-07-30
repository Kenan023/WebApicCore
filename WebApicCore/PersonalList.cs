using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApicCore.Model;

namespace WebApicCore
{
    public class PersonalList
    {
        public static List<Personal> pers = new List<Personal>
        {
            new Personal
            {
                id=1000,
                name="Kanan",
                surname="Hasanov",
                birth_place="Goycay",
                age=20,
                salary=1000

            },
             new Personal
            {
                id=1001,
                name="Kamil",
                surname="Xalilov",
                birth_place="Baku",
                age=25,
                salary=900

            },
              new Personal
            {
                id=1002,
                name="Ferid",
                surname="Quliyev",
                birth_place="Semkir",
                age=19,
                salary=1200
            }
        };
    }
}
