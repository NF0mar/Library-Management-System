create table LoginTable(
id int NOT NULL IDENTITY(1,1) primary key,
username varchar(150) not null,
pass varchar(150) not null,
)

insert into LoginTable (username,pass) values ('nurfarah','hoyo12');
insert into LoginTable (username,pass) values ('sidow','sidowxyz');
select * from LoginTable

create table NewBook(
bid int NOT NULL IDENTITY(1,1) primary key,
bName varchar(250) not null,
bAuthor varchar(250) not null,
bPubl varchar(250) not null,
bPDate varchar(250) not null,
bPrice bigint not null,
bQuan bigint not null
)

bName,bAuthor,bPubl,bPDate,bPrice,bQuan

select * from NewBook


create table NewStudent(
stuid int NOT NULL IDENTITY(1,1) primary key,
sname varchar(250) not null,
enroll varchar(250) not null,
dep varchar(250) not null,
sem varchar(250) not null,
contact bigint not null,
email varchar(250) not null
)

sname,enroll,dep,sem,contact,email

select * from NewStudent