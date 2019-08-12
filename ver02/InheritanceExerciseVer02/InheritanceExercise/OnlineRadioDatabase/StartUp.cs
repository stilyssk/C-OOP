using OnlineRadioDatabase.Songs;
using OnlineRadioDatabase.Songs.SongsLength;
using System;
using System.Collections.Generic;

namespace OnlineRadioDatabase
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var numberOfSongs = int.Parse(Console.ReadLine());
            List<Song> listSongs = new List<Song>();
            for (int i = 0; i < numberOfSongs; i++)
            {
                var inputSongData = Console.ReadLine()
                    .Split(new[] { ';' });
                var songLengData = inputSongData[2]
                    .Split(new[] { ':' });

                try
                {
                    int minutes = 0;
                    int seconds = 0;
                    var flag1 = int.TryParse(songLengData[0],out minutes);
                    var flag2 = int.TryParse(songLengData[1],out seconds);
                    if (!flag1||!flag2)
                    {
                        throw new AggregateException("Invalid song length.");
                    }
                    Song newSongs = new Song(inputSongData[0], inputSongData[1], minutes, seconds);
                    listSongs.Add(newSongs);
                    Console.WriteLine("Song added.");
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine($"Songs added: {listSongs.Count}");
            int minute = 0;
            int second = 0;
            foreach (var song in listSongs)
            {
                minute += song.SongLength.Minute;
                second += song.SongLength.Second;
            }
            int hour = 0;
            if (second > 59)
            {
                int secondMultilpy = second / 60;
                second = second - secondMultilpy * 60;
                minute += secondMultilpy;
            }
            if (minute > 59)
            {
                int minuteMultilpy = minute / 60;
                minute = minute - minuteMultilpy * 60;
                hour += minuteMultilpy;
            }

            Console.WriteLine($"Playlist length: {hour}h {minute}m {second}s");
        }
    }
}
