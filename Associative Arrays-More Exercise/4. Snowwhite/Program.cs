namespace _4._Snowwhite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"{dwarfName} <:> {dwarfHatColor} <:> {dwarfPhysics}"
            Dictionary<string, int> dwarfs = new Dictionary<string, int>();
            char[] delimeters = new char[] { ' ', '<', ':', '>' };
            string input;
            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                string[] info = input.Split(delimeters, StringSplitOptions.RemoveEmptyEntries);
                string name = info[0];
                string color = info[1];
                int size = int.Parse(info[2]);

                string ID = name + " " + color;// KEY of the Dictionary

                if (!dwarfs.ContainsKey(ID))
                {
                    dwarfs.Add(ID, size);                
                }
                else
                {
                    dwarfs[ID] = Math.Max(dwarfs[ID], size);
                }
            }                           
            foreach (var dwarf in dwarfs.OrderByDescending(size => size.Value)
                .ThenByDescending
                (id => dwarfs.Where(y => y.Key.Split()[1] == id.Key.Split()[1]) // THIS METHOD SPLITS THE KEY OF THE DICTIONARY
                .Count()))   
          
            {
                Console.WriteLine($"({dwarf.Key.Split()[1]}) {dwarf.Key.Split()[0]} <-> {dwarf.Value}");
            }
        }
    }
}