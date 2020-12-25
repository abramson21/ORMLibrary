CREATE TABLE [dbo].[Books]
(
      [ID]        int           primary key
    , Title       nvarchar(255) not null
    , [ID_Shelve] int

    , foreign key ([ID_Shelve])
      references Shelves([ID])
);
