using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_I_6
{
    internal class Poisk
    {
        public class SortPoYb : IComparer
        {
            int IComparer.Compare(object date1, object date2)
            {
                Date date_1 = (Date)date1;
                Date date_2 = (Date)date2;
                if (date_1 < date_2)
                    return 1;
                if (date_1 > date_2)
                    return -1;
                return 0;
            }
        }

        public class SortPoVoz : IComparer
        {
            int IComparer.Compare(object date1, object date2)
            {
                Date date_1 = (Date)date1;
                Date date_2 = (Date)date2;
                if (date_1 > date_2)
                    return 1;
                if (date_1 < date_2)
                    return -1;
                return 0;
            }
        }
    }
}
