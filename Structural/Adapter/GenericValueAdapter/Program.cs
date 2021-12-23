using GenericValueAdapter;

namespace GenericValueAdapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var v = new Vector2i(1, 2);
            v[0] = 0;

            var vv = new Vector2i(3, 2);

            var result = v + vv;

            Vector3f u = Vector3f.Create(3.5f, 2.2f, 1);
        }
    }
}
