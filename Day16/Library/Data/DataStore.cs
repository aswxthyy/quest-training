namespace Library.Data
{
    internal static class DataStore
    {
        public static List<Book> Books;
        public static List<Member> Members;

        static DataStore()
        {
            Books = new List<Book>()
            {
                new Book{ID = 1, Name = "Normal People", Author = "Sally Rooney", Pages = 176},
                new Book{ID = 1, Name = "Five Feet Apart", Author = "Rachael Lippincott", Pages = 304}
            };

            Members = new List<Member>()
            {
                new Member{ID = 1, Name = "Member 1", Email = "one@mem.com"},
                new Member{ID = 2, Name = "Member 2", Email = "two@mem.com"},
                new Member{ID = 3, Name = "Member 3", Email = "three@mem.com"},
            };
        }
    }
}