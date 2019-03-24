namespace P01.Stream_Progress
{
    public interface ISteam
    {
        int BytesSent { get; set; }
        int Length { get; set; }
    }
}