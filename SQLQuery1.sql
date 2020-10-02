create table client(
client_id int identity(1,1) not null primary key,
client_Name varchar(64) not null,
contact_person varchar(40),
Agreement_Date date
)
create table project
(
prj_id int identity(1,1) not null primary key,
prj_name varchar(64) not null,
prj_description varchar(1024),
prj_start_date date,
Client int
Constraint FK_client Foreign KEY(client) references client(client_id) on delete cascade
)
create table dept(
id int identity(1,1) not null primary key,
deptname varchar(32) not null
)
create table employee(
empid varchar(8) not null primary key,
empname varchar(64) not null,
email varchar(64) null,
phone varchar(815) not null,
dept int not null,
constraint fk_id foreign key(dept) references dept(id))
alter table project
add prj_cost decimal(12,2) null
alter table project
alter column prj_description varchar(512)
select * from client
insert into client values('kavya','312445787','2020-10-07')
select * from client
update client set contact_person ='nithin' where client_id=4;
update client set Agreement_Date='2020-10-07' where client_id=3;
select * from employee
