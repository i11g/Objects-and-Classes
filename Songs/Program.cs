namespace Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs=int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] songInformation = Console.ReadLine().Split("_");

                string songTypeList = songInformation[0];
                string songName = songInformation[1];
                string songTime = songInformation[2];

                Song currentsong = new Song
                {
                    Name = songName,
                    TypeList = songTypeList,
                    Time = songTime,

                };

                songs.Add(currentsong);
            }

            string typeCommand = Console.ReadLine();
            //if(typeCommand=="all")
            //{
            //    foreach(Song song in songs)
            //    {
            //        Console.WriteLine(song.Name);
            //    }
            //}
            //else
            //{
            //    List<Song> filterSongs = songs.
            //        Where(x => x.TypeList == typeCommand)
            //        .ToList(); 
            //    foreach(Song song in filterSongs)
            //    {
            //        Console.WriteLine(song.Name);
            //    }
            //}
            if(typeCommand !="all")
            {
                songs=songs.Where(x=>x.TypeList==typeCommand).ToList();
            }
            foreach(Song s in songs)
            {
                Console.WriteLine(s.Name);
            }
        }
    }

    public class Song
    {
        public string Name {get; set; }
        public string Time { get; set; }
        public string TypeList { get; set; }
    } 
}