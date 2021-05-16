using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    public interface IPodaci
    {
        int GenerišiID()
        {
            int broj = 0;
            for (int i = 0; i < 10; i++)
            {
                Random generator = new Random();
                broj += (int)Math.Pow(10, i) * generator.Next(0, 9);
            }
            return broj;
        }
        string DajOpis();
    }

}
