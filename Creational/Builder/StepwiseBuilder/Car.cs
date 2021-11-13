namespace StepwiseBuilder
{
    public class Car
    {
        public CarType Type;
        public int WheelSize;

        public override string ToString()
        {
            return $"Type: {Type}, WheelSize: {WheelSize}";
        }
    }
}