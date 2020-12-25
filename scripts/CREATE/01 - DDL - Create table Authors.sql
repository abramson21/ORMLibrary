use DBLibraryHome
go

CREATE TABLE [dbo].[Authors]
(
      [ID]         int           primary key
    , [FirstName]  nvarchar(255) not null
    , [LastName]   nvarchar(255) not null
    , [MiddleName] nvarchar(255)
);
