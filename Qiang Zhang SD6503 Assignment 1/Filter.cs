using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qiang_Zhang_SD6503_Assignment_1
{
    //This class used by application to search and sort lists of objects
    //The searching and sorting methods use LINQ lambda or query expressions
    public class Filter
    {
        //SortAZ method
        //LINQ lambda expression
        //LINQ lambda expression
        public List<Staff> SortAZ(List<Staff> sList)
        {
            sList = sList.OrderBy(x => x.StaffName).ToList();
            return sList;
        }


        //SortZA method
        //LINQ query expression
        public List<Staff> SortZA(List<Staff> sList)
        {
            sList = (from x in sList orderby x.StaffName descending select x).ToList();
            return sList;
        }

        //Search method
        public List<Staff> Search (List<Staff> sList, string term)
        {
            List<Staff> results = new List<Staff>();

            foreach (Staff s in sList)
            {
                //Use ToLower() make search case insensitive
                if (s.StaffName.ToLower().Contains(term.ToLower()))
                {
                    results.Add(s);
                }
            }
            return results;
        }

    }
}
