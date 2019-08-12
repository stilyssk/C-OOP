namespace P02_PointInRectangle
{
    public interface IRectangle
    {
        //IPoint XPoint { get; set; }
        //IPoint YPoint { get; set; }

        bool Contains(IPoint currentPoint);
    }
}