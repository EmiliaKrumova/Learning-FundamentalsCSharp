  Dictionary<string,string> ema =  new Dictionary<string,string>();
string name = "Ema";
ema.Add("name", name);
string val = ema.GetValueOrDefault("name", name);
string emm = ema["name"];
Console.WriteLine(emm);