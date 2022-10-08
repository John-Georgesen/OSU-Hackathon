namespace BusStopProgram  
{
    public class Coordinates 
    {
        List<Tuple<decimal,decimal>> coorsList;

        public List<Tuple<decimal,decimal>> getList()
        {
            return getFileTuples();
        }
        private List<Tuple<decimal,decimal>> getFileTuples()
        {
            string[] busCoors = System.IO.File.ReadAllLines(@"busstops.txt");
            
            var tupleList = new List<Tuple<decimal, decimal>>();

            System.Console.WriteLine("Contents of WriteLines2.txt = ");
            foreach (string line in busCoors)
            {
                string longitude, latitude;

                longitude = line.Substring(0, 9);
                latitude = line.Substring(10,9);

                Tuple<decimal, decimal> addTup = Tuple.Create(Convert.ToDecimal(longitude), Convert.ToDecimal(latitude));
                tupleList.Add(addTup);
            }

            coorsList = tupleList;
            return tupleList;
        }
        public void findClosestStop(Tuple<decimal, decimal> passedTup)
        {
            decimal longDistance = Math.Abs(passedTup.Item1 - coorsList[0].Item1);
            int indexOfShortest = 0;
            //decimal latDistance = passedTup.Item2 - closestStop.Item2;

            for(int i = 0; i < coorsList.Count; i++)
            {
                decimal tempLongDistance = Math.Abs(passedTup.Item1 - coorsList[i].Item1);

                if(tempLongDistance < longDistance)
                {
                    longDistance = tempLongDistance;
                    indexOfShortest = i;
                }
            }
            Console.WriteLine(indexOfShortest + ": " + longDistance);
        }
        
    }
}