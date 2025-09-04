CREATE TABLE LogIn (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(255) NOT NULL
    );

insert into LogIn (Username, PasswordHash)
values ('admin', HASHBYTES('SHA2_256', '1111'));


Select 
Username, CONVERT(varchar(64), HASHBYTES ('SHA2_256', '1111'),2) AS PasswordHashhex
from LogIn;

Select 
Username, CONVERT(varchar(64), HASHBYTES ('SHA2_256', '1111'),2) AS HashResult
from LogIn;
