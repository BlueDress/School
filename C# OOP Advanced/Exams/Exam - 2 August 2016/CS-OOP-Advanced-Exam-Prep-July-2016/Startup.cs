namespace CS_OOP_Advanced_Exam_Prep_July_2016
{
    using CS_OOP_Advanced_Exam_Prep_July_2016.Parser;

    public class Startup
    {
        public static void Main()
        {
            IParser parser = new AttributeParser();
            parser.Parse();
        }
    }
}