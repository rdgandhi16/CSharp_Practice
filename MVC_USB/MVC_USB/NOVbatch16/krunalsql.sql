create database db_krunal;
use db_krunal;
create table tbl_reg(
regid int,
fname varchar(50),
lname  varchar(50));

alter table tbl_reg add addres varchar(50);
alter table tbl_reg alter column fname varchar(30);
alter table tbl_reg drop column addres;

truncate table tbl_reg;

drop table tbl_reg;

insert into tbl_reg(regid,fname,lname) values(1,'krunal','patel');

insert into tbl_reg values(2,'tops','tech');

update tbl_reg set fname='krunal' where regid=1;

delete from tbl_reg where regid=2;

insert into tbl_reg values(3,'tops','tech');

select * from tbl_reg;
select fname,lname from tbl_reg;
select distinct fname from tbl_reg;


begin tran t1
delete from tbl_reg where regid=1;
rollback

begin tran t2
delete from tbl_reg where regid=1;
commit


create table tbl_state(
stateid int primary key identity(1,1),
statename varchar(50));

create table tbl_city(
cityid int primary key identity(1,1),
cityname varchar(50),
stid int references tbl_state(stateid))


select * from tbl_state;
select * from tbl_city;

select * from tbl_state inner join tbl_city on tbl_state.stateid=tbl_city.stid;

select * from tbl_state left join tbl_city on stateid=stid;
select * from tbl_city right join tbl_state on stateid=stid;
select * from tbl_state cross join tbl_city;


select AVG(sal) from tbl_emp;
select MAX(sal) from tbl_emp;
select MAX(empid) from tbl_emp;
select MIN(sal) from tbl_emp;
select COUNT(empid) from tbl_emp;

select avg(sal) from tbl_emp group by empid;
select sal,empname from tbl_emp order by empname desc;

select sal from tbl_emp where sal between '5000' and '10000';

select * from  tbl_emp where empname like 'tops';
select * from tbl_emp where empname like 't%';
select * from tbl_emp where empname like '%s';
select * from tbl_emp where empname like '%a%';

select * from tbl_emp where empname like '_____';
select * from tbl_emp where empname like '__m%';



