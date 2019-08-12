using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineRadioDatabase.Songs
{
    using SongsLength;
    public class Song
    {
        private string artistName;
        private string songName;
        private SongLength songLength;

        public Song(string artistName, string songName, int minute, int second)
        {
            ArtistName = artistName;
            SongName = songName;
            if ((minute==14&&second>59))
            {
                throw new ArgumentException("Invalid song length.");
            }
            SongLength = new SongLength(minute,second);
        }

        public string ArtistName
        {
            get => artistName;
            set
            {
                if (value.Length<3||value.Length>20)
                {
                    throw new ArgumentException("Artist name should be between 3 and 20 symbols.");
                }
                artistName = value;
            }
        }
        public string SongName
        {
            get => songName;
            set
            {
                if (value.Length<3 || value.Length>30)
                {
                    throw new AggregateException("Song name should be between 3 and 30 symbols.");
                }
                songName = value;
            }
        }
        public SongLength SongLength
        {
            get => songLength;
            set => songLength = value;
        }
    }
}
