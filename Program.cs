using System;
using System.Collections.Generic;
using System.Linq;


namespace List_Filtering
{
    class Program
    {    
         static void Main(string[] args)
        {
             //Teste.
             GetIntegersFromList(new List<object>(){1,2,"aasf","1","123",123});
        }

       public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
       {
              listOfItems.RemoveAll(RemoveAllStrings);

              return listOfItems.Select(s => Convert.ToInt32(s)).ToList();
        } 

        public static bool RemoveAllStrings(object value)
        {
            return (value is string);
        }


    }
}
