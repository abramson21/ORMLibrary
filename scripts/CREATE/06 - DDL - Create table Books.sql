CREATE TABLE [dbo].[Books]
(
      [ID]        int           primary key
    , Title       nvarchar(255) not null
    , [ID_Shelve] int

    , foreign key ([ID_Shelf])
      references Shelves([ID])
);
