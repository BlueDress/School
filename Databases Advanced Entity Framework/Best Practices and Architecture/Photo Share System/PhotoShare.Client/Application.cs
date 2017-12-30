namespace PhotoShare.Client
{
    using Core;
    using Data;

    public class Application
    {
        public static void Main()
        {
            //ResetDatabase();

            PhotoShareContext context = new PhotoShareContext();
            CommandDispatcher commandDispatcher = new CommandDispatcher(context);
            Engine engine = new Engine(commandDispatcher);
            engine.Run();
        }

        private static void ResetDatabase()
        {
            using (var db = new PhotoShareContext())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
            }
        }
    }
}
