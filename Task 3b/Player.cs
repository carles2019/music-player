using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3b
{
    public class Player
    {
        public List<Song> trackList = new List<Song>();

        //public Player(string)
        //{

        //}

        public void Add(Song song)
        {
            trackList.Add(song);
        }

        public void Remove(int songNumber)
        {
            trackList.Remove(trackList[songNumber]);

        }

        public void Play(int songNumber)
        {
            trackList[songNumber].Play();
        }

        public void AutoPlay()
        {
            Console.Clear();
            Console.WriteLine("Music is playing.....");
            for (int i = 0; i < trackList.Count; i++)
            {
                
                Console.WriteLine(trackList[i].Play());
                Console.WriteLine();
                System.Threading.Thread.Sleep(5000);
            }
            Console.Clear();
        }
    }

}
