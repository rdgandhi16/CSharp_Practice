create database db_prashant;
use db_prashant;
create table tbl_reg(
rgid int,
fname varchar(50),
lname varchar(50));

alter table tbl_reg add addres varchar(50);
alter table tbl_reg alter column fname varchar(30);
alter table tbl_reg drop column addres;

drop table tbl_reg;
truncate table tbl_reg;

insert into tbl_reg(rgid,fname,lname) values(1,'tops','tech');

insert into tbl_reg values(2,'prashant','singh');
insert into tbl_reg values(3,'tops','tech');
update tbl_reg set fname='tops' where rgid=1;

delete from tbl_reg where rgid=1;

select * from tbl_reg;
select distinct fname from tbl_reg;


begin tran t1
delete from tbl_reg where rgid=1;
rollback

begin tran t2
delete from tbl_reg where rgid=1;
commit



create table tbl_state(
stateid int primary key identity(1,1),
statename varchar(50))

create table tbl_city(
cityid int primary key identity(1,1),
cityname varchar(50),
stid int references tbl_state(stateid))


select * from tbl_state inner join  tbl_city on tbl_state.stateid=tbl_city.stid;

select * from tbl_state left join tbl_city on stateid=stid; 
select * from tbl_city right join tbl_state on stateid=stid;
select * from tbl_state cross join tbl_city;


select * from tbl_emp;

select AVG(sal) from tbl_emp;
select MAX(sal) from tbl_emp;
select MAX(empid) from tbl_emp;
select MIN(sal) from tbl_emp;
select COUNT(empid) from tbl_emp;

select MAX(sal) from tbl_emp group by empid;

select * from tbl_emp order by sal desc;

select * from tbl_emp where empname like 'krunal';
select * from tbl_emp where empname like 'k%';
select * from tbl_emp where empname like '%s';
select * from tbl_emp where empname like '%a%';


select * from tbl_emp where empname like '_____';
select * from tbl_emp where empname like '__m%';

select sal,empname from tbl_emp where sal between '5000' and '9000'













