create database db_mitesh;
use db_mitesh;

create table tbl_mitesh(
id int,
fname varchar(50),
lname varchar(50));

alter table tbl_mitesh add addr varchar(50);
alter table tbl_mitesh alter column fname varchar(30);
alter table tbl_mitesh drop column addr;


truncate table tbl_mitesh;

drop table tbl_mitesh;

DML


insert into tbl_mitesh(id,fname,lname) values(1,'mitesh','patel');

insert into tbl_mitesh values(2,'tops','tech');

update tbl_mitesh set fname='vishal';
update tbl_mitesh set fname='mitesh' where id=1;
	
delete from tbl_mitesh where id=1;

insert into tbl_mitesh(id,fname,lname) values(3,'mitesh','patel');

select * from tbl_mitesh;
select fname,lname from tbl_mitesh;
select distinct fname from tbl_mitesh;


create table tbl_state(
stateid int primary key identity(1,1),
statename varchar(30));

create table tbl_city(
cityid int primary key identity(1,1),
cityname varchar(30),
stid int references tbl_state(stateid));

select statename,tbl_city.cityname from tbl_state inner join  tbl_city on tbl_state.stateid=tbl_city.stid;

select * from tbl_state left join tbl_city on stateid=stid;
select * from  right join tbl_city on stateid=stid;
select * from tbl_city right join tbl_state  on stateid=stid;
select * from tbl_state cross join tbl_city;

select AVG(sal) from tbl_emp;
select MAX(sal) from tbl_emp;
select MAX(empid) from tbl_emp;
select MIN(sal) from tbl_emp;
select count(empid) from tbl_emp;
use db_mitesh

select AVG(sal) from tbl_emp group by empid;
select empname from tbl_emp group by empid;

select sal from tbl_emp order by sal desc;
select empname from tbl_emp order by empname desc;

select * from tbl_emp where empname like 'm%'
select * from tbl_emp where empname like '%l'
select * from tbl_emp where empname like '%a%'


select * from tbl_emp where empname like '______';
select * from tbl_emp where empname like '__t%';


select * from tbl_emp where sal between '5000' and '10000';

select  * from tbl_emp;

begin tran t1
delete from tbl_emp where empid=1;
rollback


begin tran t2
delete from tbl_emp where empid=1;
commit





























