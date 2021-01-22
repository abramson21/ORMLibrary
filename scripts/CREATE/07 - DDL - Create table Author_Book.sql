use DBLibraryHome

CREATE TABLE [dbo].[Author_Book]
(
      [ID]         int primary key
    , [ID_Authors] int not null
    , [ID_Books]   int not null

    , FOREIGN KEY ([ID_Authors])
      REFERENCES Authors ([ID])

    , FOREIGN KEY ([ID_Books])
      REFERENCES Books ([ID])
);
