namespace English_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> englishtensesDictionary = new Dictionary<string,string>();

            englishtensesDictionary.Add("present simple", "Handlung die in der Gegenwart spielt bsp. I play tennis.");
            englishtensesDictionary.Add("present continious", "Handlungen spielen in diesem Moment, oder feststehende Pläne oder Handlungen die Vorübergehend Stattfinden bsp. I am playing tennis.");
            englishtensesDictionary.Add("present perfect", "Handlungen die gearde abgeschlossen wurden, wann die Handlung geschehen ist ist nicht wichtig bsp.I have played tennis ");
            englishtensesDictionary.Add("present perfect continious", "Handlung die in der Vergangenheit begonnen hat und in der Gegenwart andauern bsp. I have been playing tennis");
            englishtensesDictionary.Add("past perfect", "Handlung in der Vergangenheit die weiteer zurückliegt als ein anderes bsp. I had played tennis");
            englishtensesDictionary.Add("past simple", "Handlung die In der Vergangenheit spielen und Abgeschlossen sind bsp. I played tennis.");
            englishtensesDictionary.Add("past continious", "Handlungen die zu einem Zeitpunkt in der Vergangenheit handelt oder wenn zwei Handlungen gleichzeitig abspielen bsp. I was playing tennis.");
            englishtensesDictionary.Add("will future", "Handlungen die eine Vorhersage, Vermutung oder eine spontane Entscheidung sein bsp. I will play tennis.");
            englishtensesDictionary.Add("giong to fututre", "Handlungen die sicher eintreten werden oder entschieden worden sind bsp. I am giong to play tenns.");

            foreach (var kvp in englishtensesDictionary) 
            {
            Console.WriteLine($"Tense: {kvp.Key}, Erklärung: {kvp.Value}");
            }
        }
    }
}
