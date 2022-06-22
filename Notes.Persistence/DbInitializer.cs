namespace Notes.Persistence
{
    public class DbInitializer
    {
        public static void Initilizer(NotesDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
