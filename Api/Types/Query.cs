namespace HotChocolateIdFilter.Types;

[QueryType]
public static class Query
{
    public static Book GetBook([IsSelected("author")] bool authorSelected)
        => new Book(1, "C# in depth.", authorSelected ? new Author("Jon Skeet") : null);

    public static List<Book> GetBooks([IsSelected("author")] bool authorSelected)
        => [
            new Book(1, "C# in depth.", authorSelected ?  new Author("Jon Skeet") : null),
            new Book(2, "C# in depth 2.", authorSelected ?  new Author("Jon Skeet Jr") : null)
        ];
}
