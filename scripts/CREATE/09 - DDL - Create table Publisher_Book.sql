use DBLibraryHome

CREATE TABLE [dbo].[PublisherBook]
(
      [ID]            int primary key
    , [ID_Publishers] int not null
    , [ID_Books]      int not null

    , FOREIGN KEY ([ID_Publishers])
      REFERENCES Publishers ([ID])

    , FOREIGN KEY ([ID_Books])
      REFERENCES Books ([ID])
);
