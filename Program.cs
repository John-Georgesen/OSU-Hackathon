using System;

namespace BusStopProgram  
{
    public class Program 
    {
        static void Main(string[] args) 
        {
            Coordinates coorsClass = new Coordinates();
            List<Tuple<decimal,decimal>> coorsList = coorsClass.getList();

            for(int i = 0; i < coorsList.Count; i++)
            {
                Console.WriteLine(coorsList[i]);
            }

            Console.Write("What are your current GPS Coordinates?: ");
            String userCoors = Console.ReadLine();

            userCoors = String.Concat(userCoors.Where(c => !Char.IsWhiteSpace(c)));

            string longitude, latitude;

            int commaSpace = userCoors.IndexOf(',');
            int l = userCoors.Length;

            longitude = userCoors.Substring(0, commaSpace);
            latitude = userCoors.Substring(commaSpace+1,l-commaSpace-1);

            Tuple<decimal, decimal> userCoorTup = Tuple.Create(Convert.ToDecimal(longitude), Convert.ToDecimal(latitude));

            coorsClass.findClosestStop(userCoorTup);

            Console.WriteLine(userCoorTup);
        }
        
        
    }
}