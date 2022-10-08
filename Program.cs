using System;

namespace BusStopProgram  
{
    public class Program 
    {
        static void Main(string[] args) 
        {
            Coordinates coorsClass = new Coordinates();
            List<Tuple<double,double>> coorsList = coorsClass.getList();

            for(int i = 0; i < coorsList.Count; i++)
            {
                Console.WriteLine(coorsList[i]);
            }
        }
        
        
    }
}