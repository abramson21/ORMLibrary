CREATE TABLE [dbo].[Shelves]
(
      [ID]        int           primary key
    , [ID_Room]   int           not null
    , Description nvarchar(255) not null

    , FOREIGN KEY ([ID_Room])
      REFERENCES Rooms ([ID])
);