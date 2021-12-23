namespace GenericValueAdapter
{
    public class VectorOfFloat<TSelf, D>
        : Vector<TSelf, float, D>
        where D : IInteger, new()
        where TSelf : Vector<TSelf, float, D>, new()
    {
    }
}