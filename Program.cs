using System;

namespace HelloWorldApp 
{
    class Geeks 
    {
        static void Main(string[] args) 
        {
            string[] busCoors = System.IO.File.ReadAllLines(@"busstops.txt");
            
            var tupleList = new List<Tuple<double, double>>();

            System.Console.WriteLine("Contents of WriteLines2.txt = ");
            foreach (string line in busCoors)
            {
                string longitude, latitude;

                longitude = line.Substring(0, 9);
                latitude = line.Substring(10,9);

                Tuple<double, double> addTup = Tuple.Create(Convert.ToDouble(longitude), Convert.ToDouble(latitude));
                tupleList.Add(addTup);
            }
        }
    }
}