using MvcLibrary.Models;

namespace MvcLibrary.Models
{ 
    //Random data for books and authors.
    public static class Data
    {
        public static List<Book> bookData { get; set; } = new()
    {
        new Book { Id = 1, Title = "The Secret of the Old Man and the Sea", AuthorId = 1, Genre = "Novel", PublishDate = new DateTime(2010, 5, 10), ISBN = "1234567890123", CopiesAvailable = 12 },
        new Book { Id = 2, Title = "The Museum of Innocence", AuthorId = 2, Genre = "Drama", PublishDate = new DateTime(2008, 3, 1), ISBN = "9876543210987", CopiesAvailable = 5 },
        new Book { Id = 3, Title = "The Forty Rules of Love", AuthorId = 3, Genre = "Fiction", PublishDate = new DateTime(2009, 9, 1), ISBN = "5432167890123", CopiesAvailable = 8 },
        new Book { Id = 4, Title = "The Dystopian World", AuthorId = 4, Genre = "Science Fiction", PublishDate = new DateTime(2015, 2, 18), ISBN = "6789012345678", CopiesAvailable = 15 },
        new Book { Id = 5, Title = "The Time to Remember", AuthorId = 5, Genre = "Romance", PublishDate = new DateTime(1990, 7, 15), ISBN = "2345678901234", CopiesAvailable = 3 },
        new Book { Id = 6, Title = "The Invisible Man", AuthorId = 6, Genre = "Psychology", PublishDate = new DateTime(2001, 4, 20), ISBN = "3456789012345", CopiesAvailable = 7 },
        new Book { Id = 7, Title = "On Beauty", AuthorId = 7, Genre = "Literary Fiction", PublishDate = new DateTime(2005, 9, 20), ISBN = "4567890123456", CopiesAvailable = 6 },
        new Book { Id = 8, Title = "The Fault in Our Stars", AuthorId = 8, Genre = "Young Adult", PublishDate = new DateTime(2012, 1, 10), ISBN = "5678901234567", CopiesAvailable = 10 },
        new Book { Id = 9, Title = "Love in the Time of Cholera", AuthorId = 9, Genre = "Historical Fiction", PublishDate = new DateTime(1985, 5, 23), ISBN = "6789012345678", CopiesAvailable = 9 },
        new Book { Id = 10, Title = "The House of the Spirits", AuthorId = 10, Genre = "Magical Realism", PublishDate = new DateTime(1982, 8, 15), ISBN = "7890123456789", CopiesAvailable = 4 },
        new Book { Id = 11, Title = "War and Peace", AuthorId = 11, Genre = "Historical Novel", PublishDate = new DateTime(1869, 1, 1), ISBN = "8901234567890", CopiesAvailable = 5 },
        new Book { Id = 12, Title = "Crime and Punishment", AuthorId = 12, Genre = "Psychological Fiction", PublishDate = new DateTime(1866, 1, 1), ISBN = "9012345678901", CopiesAvailable = 8 },
        new Book { Id = 13, Title = "1984", AuthorId = 13, Genre = "Dystopian", PublishDate = new DateTime(1949, 6, 8), ISBN = "0123456789012", CopiesAvailable = 11 },
        new Book { Id = 14, Title = "Pride and Prejudice", AuthorId = 14, Genre = "Romantic Novel", PublishDate = new DateTime(1813, 1, 28), ISBN = "1234509876543", CopiesAvailable = 12 },
        new Book { Id = 15, Title = "The Adventures of Tom Sawyer", AuthorId = 15, Genre = "Adventure", PublishDate = new DateTime(1876, 12, 1), ISBN = "2345612345678", CopiesAvailable = 3 },
        new Book { Id = 16, Title = "Mrs. Dalloway", AuthorId = 16, Genre = "Modernist Fiction", PublishDate = new DateTime(1925, 5, 14), ISBN = "3456712345678", CopiesAvailable = 7 },
        new Book { Id = 17, Title = "A Tale of Two Cities", AuthorId = 17, Genre = "Historical Fiction", PublishDate = new DateTime(1859, 4, 30), ISBN = "4567823456789", CopiesAvailable = 9 },
        new Book { Id = 18, Title = "Harry Potter and the Sorcerer's Stone", AuthorId = 18, Genre = "Fantasy", PublishDate = new DateTime(1997, 6, 26), ISBN = "5678934567890", CopiesAvailable = 6 },
        new Book { Id = 19, Title = "Norwegian Wood", AuthorId = 19, Genre = "Fiction", PublishDate = new DateTime(1987, 9, 4), ISBN = "6789045678901", CopiesAvailable = 5 },
        new Book { Id = 20, Title = "I Know Why the Caged Bird Sings", AuthorId = 20, Genre = "Biography", PublishDate = new DateTime(1969, 9, 23), ISBN = "7890156789012", CopiesAvailable = 4 }

    };

        public static List<Author> Authors { get; set; } = new()
        {
            new Author() { Id = 1, AuthorName = "Ahmet", AuthorLastName = "Ümit", DateOfBirth = new DateTime(1960, 11, 28) },
            new Author() { Id = 2, AuthorName = "Orhan", AuthorLastName = "Pamuk", DateOfBirth = new DateTime(1952, 6, 7) },
            new Author() { Id = 3, AuthorName = "Elif", AuthorLastName = "Şafak", DateOfBirth = new DateTime(1971, 10, 25) },
            new Author() { Id = 4, AuthorName = "Hakan", AuthorLastName = "Günday", DateOfBirth = new DateTime(1976, 5, 6) },
            new Author() { Id = 5, AuthorName = "Ayşe", AuthorLastName = "Kulin", DateOfBirth = new DateTime(1941, 10, 5) },
            new Author() { Id = 6, AuthorName = "Murathan", AuthorLastName = "Mungan", DateOfBirth = new DateTime(1955, 4, 21) },
            new Author() { Id = 7, AuthorName = "Zadie", AuthorLastName = "Smith", DateOfBirth = new DateTime(1975, 10, 25) },
            new Author() { Id = 8, AuthorName = "John", AuthorLastName = "Green", DateOfBirth = new DateTime(1977, 8, 24) },
            new Author() { Id = 9, AuthorName = "Gabriel", AuthorLastName = "García Márquez", DateOfBirth = new DateTime(1927, 3, 6) },
            new Author() { Id = 10, AuthorName = "Isabel", AuthorLastName = "Allende", DateOfBirth = new DateTime(1942, 8, 2) },
            new Author() { Id = 11, AuthorName = "Leo", AuthorLastName = "Tolstoy", DateOfBirth = new DateTime(1828, 9, 9) },
            new Author() { Id = 12, AuthorName = "Fyodor", AuthorLastName = "Dostoevsky", DateOfBirth = new DateTime(1821, 11, 11) },
            new Author() { Id = 13, AuthorName = "George", AuthorLastName = "Orwell", DateOfBirth = new DateTime(1903, 6, 25) },
            new Author() { Id = 14, AuthorName = "Jane", AuthorLastName = "Austen", DateOfBirth = new DateTime(1775, 12, 16) },
            new Author() { Id = 15, AuthorName = "Mark", AuthorLastName = "Twain", DateOfBirth = new DateTime(1835, 11, 30) },
            new Author() { Id = 16, AuthorName = "Virginia", AuthorLastName = "Woolf", DateOfBirth = new DateTime(1882, 1, 25) },
            new Author() { Id = 17, AuthorName = "Charles", AuthorLastName = "Dickens", DateOfBirth = new DateTime(1812, 2, 7) },
            new Author() { Id = 18, AuthorName = "J.K.", AuthorLastName = "Rowling", DateOfBirth = new DateTime(1965, 7, 31) },
            new Author() { Id = 19, AuthorName = "Haruki", AuthorLastName = "Murakami", DateOfBirth = new DateTime(1949, 1, 12) },
            new Author() { Id = 20, AuthorName = "Maya", AuthorLastName = "Angelou", DateOfBirth = new DateTime(1928, 4, 4) },
            new Author() { Id = 21, AuthorName = "James", AuthorLastName = "Baldwin", DateOfBirth = new DateTime(1924, 8, 2) },
            new Author() { Id = 22, AuthorName = "Chimamanda Ngozi", AuthorLastName = "Adichie", DateOfBirth = new DateTime(1977, 9, 15) },
            new Author() { Id = 23, AuthorName = "Toni", AuthorLastName = "Morrison", DateOfBirth = new DateTime(1931, 2, 18) },
            new Author() { Id = 24, AuthorName = "Neil", AuthorLastName = "Gaiman", DateOfBirth = new DateTime(1960, 11, 10) },
            new Author() { Id = 25, AuthorName = "Margaret", AuthorLastName = "Atwood", DateOfBirth = new DateTime(1939, 11, 18) },
            new Author() { Id = 26, AuthorName = "Stephen", AuthorLastName = "King", DateOfBirth = new DateTime(1947, 9, 21) },
            new Author() { Id = 27, AuthorName = "Dan", AuthorLastName = "Brown", DateOfBirth = new DateTime(1964, 6, 22) },
            new Author() { Id = 28, AuthorName = "Oscar", AuthorLastName = "Wilde", DateOfBirth = new DateTime(1854, 10, 16) },
            new Author() { Id = 30, AuthorName = "Kurt", AuthorLastName = "Vonnegut", DateOfBirth = new DateTime(1922, 11, 11) },
            new Author() { Id = 31, AuthorName = "Philip", AuthorLastName = "Roth", DateOfBirth = new DateTime(1933, 3, 19) },
            new Author() { Id = 32, AuthorName = "Salman", AuthorLastName = "Rushdie", DateOfBirth = new DateTime(1947, 6, 19) },
            new Author() { Id = 33, AuthorName = "Albert", AuthorLastName = "Camus", DateOfBirth = new DateTime(1913, 11, 7) },
            new Author() { Id = 34, AuthorName = "Dante", AuthorLastName = "Alighieri", DateOfBirth = new DateTime(1265, 5, 14) },
            new Author() { Id = 35, AuthorName = "J.R.R.", AuthorLastName = "Tolkien", DateOfBirth = new DateTime(1892, 1, 3) },
            new Author() { Id = 36, AuthorName = "F. Scott", AuthorLastName = "Fitzgerald", DateOfBirth = new DateTime(1896, 9, 24) },
            new Author() { Id = 37, AuthorName = "E. L.", AuthorLastName = "James", DateOfBirth = new DateTime(1963, 3, 7) },
            new Author() { Id = 38, AuthorName = "Leo", AuthorLastName = "Buscaglia", DateOfBirth = new DateTime(1924, 4, 30) }
        };
    }
}