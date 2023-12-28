create Database Course
use Course

create table Category
(Id int primary key,
name Nvarchar(50)not null)

create table course
(Id int primary key,
Name Nvarchar(50)not null,
Fee float,StartDate DateTime,category int)


select * from course
select * from Category