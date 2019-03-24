using System;
using System.Collections.Generic;
using System.Text;

namespace P01.Stream_Progress
{
    public class StreamProgressInfo : ISteam
    {
        //private IFile file;
        private int _bytesSent;
        private int _length;

        // If we want to stream a music file, we can't
        public StreamProgressInfo(ISteam file)
        {
            this.BytesSent = file.BytesSent;
            this.Length = file.Length;
        }

        public int BytesSent { get => _bytesSent; set => _bytesSent = value; }
        public int Length { get => _length; set => _length = value; }

        public int CalculateCurrentPercent()
        {
            return (this.BytesSent * 100) / this.Length;
        }
    }
}
