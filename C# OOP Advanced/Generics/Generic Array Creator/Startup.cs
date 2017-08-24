namespace Generic_Array_Creator
{
    public class Startup
    {
        public static void Main()
        {
            string[] strings = ArrayCreator<string>.Create(5, "Pesho");
            int[] integers = ArrayCreator<int>.Create(10, 33);
        }
    }
}
