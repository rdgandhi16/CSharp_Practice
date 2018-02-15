use db_demo

drop table tbl_state;

create table tbl_state(stateid int primary key identity(1,1),
statename varchar(30))

create table city(
cityid int primary key identity(1,1),
cityname varchar(30),
stid int references tbl_state(stateid))

select * from tbl_state;
select cityname from city;


select * from tbl_state inner join city on tbl_state.stateid=city.stid;

select * from tbl_state left join city on tbl_state.stateid=city.stid;
select * from city right join tbl_state on tbl_state.stateid=city.stid;
select * from tbl_state cross join city;

create table employee(
empid int primary key identity(1,1),
empname varchar(50),
sal int)

select AVG(sal) from employee;
select MAX(sal) from employee;
select MIN(sal) from employee;
select * from employee;
select MAX(empid) from employee;
select COUNT(empid) from employee;

select MAX(sal) from employee group by empid;
select sal from employee order by sal desc;

select * from employee where empname like 'rajesh';
select * from employee where empname like 'ra%';
select * from employee where empname like '%s';
select * from employee where empname like '%a%';
select * from employee where sal like '1%'

select * from employee where empname like '______';
select * from employee where empname like '__s%'

select * from employee where sal between '6000' and '10000';




























