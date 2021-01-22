CREATE TABLE [dbo].[Shelves]
(
      [ID]        int           primary key
    , Description nvarchar(255) not null

    , FOREIGN KEY ([ID])
      REFERENCES Rooms ([ID])
);
