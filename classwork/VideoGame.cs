using System;
namespace classwork
{
    public class VideoGame
    {
        string _plasticcase;

        string _disc;

        string _coverart;

        string _manual;

        public string PlasticCase { get; set; }
        public string Disc { get; set; }
        public string CoverArt { get; set; }
        public string Manual { get; set; }

        public VideoGame() { }

        public VideoGame(string manual, string disc)
        {
            this._manual = manual;
            this._disc = disc;
            PlasticCase = "Black";
            CoverArt = "Arty";
        }

        public VideoGame(string manual, string plasticcase, string disc, string coverart)
        {
            this._plasticcase = plasticcase;
            this._coverart = coverart;
            Manual = manual;
            Disc = disc;
        }

        public void OpenPlasticCase(bool isHard)
        {
            if (isHard)
            {
                Console.WriteLine("The case broke.");
            }
            else
            {
                Console.WriteLine("The case exploded.");
            }
        }
        public void OpenPlasticCase()
        {
            Console.WriteLine("The case opens.");
        }

        public void ClosePlasticCase()
        {
            Console.WriteLine("The case closes.");
        }

        public void EnterDisc()
        {
            Console.WriteLine("The disc enters the computer.");
        }

        public void RemoveDisc()
        {
            Console.WriteLine("The disc is removed.");
        }

        public void ApplyCoverArt()
        {
            Console.WriteLine("The cover art is applied.");
        }

        public void RemoveCoverArt()
        {
            Console.WriteLine("The cover art is removed.");
        }

        public void ReadManual()
        {
            Console.WriteLine("You are reading the manual.");
        }

        public void StopReadingManual()
        {
            Console.WriteLine("You stopped reading the manual");
        }
    }
}