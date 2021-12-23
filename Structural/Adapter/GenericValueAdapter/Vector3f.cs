namespace GenericValueAdapter
{
    public class Vector3f
        : VectorOfFloat<Vector3f, Dimensions.Three>
    {
        public override string ToString()
        {
            return $"{string.Join(",", data)}";
        }
    }
}