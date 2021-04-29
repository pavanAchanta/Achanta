Use UserDataBase;
select * from Users;
insert into Users (FirstName,LastName,Age,Designation,City,Salary) values('Vinay','Kottha',24,'J.Eng','Guntur',29000);
create table Users(
FirstName varchar(20),
LastName varchar(20),
Age int,
Designation varchar(20),
City varchar(20),
Salary int
);
select * from Users;