namespace MvcMovieStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, ReleaseDate, GenreId, Price) VALUES ('Pulp Fiction', '10/21/1994', 13, 8.79)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, GenreId, Price) VALUES ('Fight Club', '11/24/1999', 2, 7.99)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, GenreId, Price) VALUES ('Inception', '07/16/2010', 1, 8.99)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, GenreId, Price) VALUES ('Interstellar', '11/07/2014', 8, 11.99)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, GenreId, Price) VALUES ('The Matrix', '06/11/1999', 8, 7.89)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, GenreId, Price) VALUES ('The Lord of the Rings: The Fellowship of the Ring', '12/19/2001', 7, 6.99)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, GenreId, Price) VALUES ('Se7en', '01/05/1995', 3, 5.99)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, GenreId, Price) VALUES ('The Conjuring', '02/08/2013', 5, 11.99)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, GenreId, Price) VALUES ('Superbad', '09/14/2007', 6, 6.79)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, GenreId, Price) VALUES ('The Good, the Bad, and the Ugly', '09/08/1966', 4, 5.89)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, GenreId, Price) VALUES ('Titanic', '01/23/1997', 9, 6.59)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, GenreId, Price) VALUES ('Free Solo', '12/14/2018', 10, 11.99)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, GenreId, Price) VALUES ('First Man', '10/12/2018', 11, 10.99)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, GenreId, Price) VALUES ('The Hobbit: An Unexpected Journey', '12/13/2012', 12, 9.99)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, GenreId, Price) VALUES ('La La Land', '01/12/2016', 14, 10.79)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, GenreId, Price) VALUES ('Arrival', '11/10/2016', 8, 10.39)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, GenreId, Price) VALUES ('The Avengers', '04/26/2012', 1, 10.99)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, GenreId, Price) VALUES ('Shutter Island', '03/12/2010', 15, 9.99)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, GenreId, Price) VALUES ('Zodiac', '05/18/2007', 15, 7.69)");
        }
        
        public override void Down()
        {
        }
    }
}
