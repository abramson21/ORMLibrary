use DBLibraryHome

CREATE TABLE [dbo].[Book_Genre]
(
      [ID]        int primary key
    , [ID_Genres] int not null
    , [ID_Books]  int not null

    , FOREIGN KEY ([ID_Genres])
      REFERENCES Genres ([ID])

    , FOREIGN KEY ([ID_Books])
      REFERENCES Books ([ID])
);
