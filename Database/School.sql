CREATE TABLE Users (
    UserID int identity  PRIMARY KEY,
    UserName varchar(255),
    [Password] varchar(255)
);

select * from dbo.Users

insert into dbo.Users
values('admin', 'admin123')

insert into dbo.Users
values('Tijana', 'tijana123')

insert into dbo.Users
values('Danijela', 'danijela123')

insert into dbo.Users
values('Dragana', 'dragana123')

