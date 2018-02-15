create database db_animesh;
use db_animesh;
create table tbl_reg(
rgid int,
fname varchar(50),
lname varchar(50));

alter table tbl_reg add addres varchar(50);
alter table tbl_reg drop column addres;
alter table tbl_reg alter column fname varchar(30);

truncate table tbl_reg;

drop table tbl_reg;


insert into tbl_reg(rgid,fname,lname) values(1,'animesh','patel');
insert into tbl_reg values(2,'tops','tech');
insert into tbl_reg(rgid,fname,lname) values(3,'tops','tech');
update tbl_reg set fname='tops' where rgid=1;
	
delete from tbl_reg where rgid=1;

select * from tbl_reg;
select fname,lname from tbl_reg;
select distinct fname from tbl_reg;

create table tbl_state(
stateid int primary key identity(1,1),
statename varchar(50))


create table tbl_city(
cityid int primary key identity(1,1),
cityname varchar(50),
stid int references tbl_state(stateid));

select * from tbl_state inner join tbl_city on tbl_state.stateid=tbl_city.stid;

select * from tbl_state left join tbl_city on stateid=stid;
select * from tbl_city  right join tbl_state on stateid=stid;
select * from tbl_state cross join tbl_city;

select * from tbl_reg;

begin tran t1
delete from tbl_reg where rgid=2;
rollback

begin tran t2
delete from tbl_reg where rgid=2;
commit

create table tbl_emp(
empid int primary key identity(1,1),
empname varchar(50),
sal int)
select * from tbl_emp;
aggregate function
 
select AVG(sal) from tbl_emp;
select MAX(sal) from tbl_emp;
select MAX(empid) from tbl_emp;
select MIN(sal) from tbl_emp;
select COUNT(empid) from tbl_emp;

select AVG(sal) from tbl_emp group by empid;
select empname from tbl_emp order by sal desc;

select * from tbl_emp where empname like 'tops';
select * from tbl_emp where empname like 't%';
select * from tbl_emp where empname like '%l';
select * from tbl_emp where empname like '%a%';

select * from tbl_emp where empname like '______';
select * from tbl_emp where empname like '__t%'

select * from tbl_emp where sal between '5000' and '10000';

















