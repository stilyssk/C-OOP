using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineRadioDatabase.Songs.SongsLength
{
    public class SongLength
    {
        private int minute;
        private int second;

        public SongLength(int minute, int second)
        {
            Minute = minute;
            Second = second;
        }

        public int Minute
        {
            get => minute;
            set
            {
                if (value<0||value>14)
                {
                    throw new ArgumentException("Song minutes should be between 0 and 14.");
                }
                minute = value;
            }
        }
        public int Second
        {
            get => second;
            set
            {
                if (value<0||value>59)
                {
                    throw new AggregateException("Song seconds should be between 0 and 59.");
                }
                second = value;
            }
        }
    }
}
