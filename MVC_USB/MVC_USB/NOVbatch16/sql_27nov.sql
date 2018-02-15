create database db_demo;
use db_demo;


create table tbl_demo(
id int,fname varchar(50),lname varchar(50));

alter table tbl_demo add addres varchar(50);
alter table tbl_demo alter column fname varchar(30);
alter table tbl_demo drop column fname;

truncate table tbl_demo;

drop table tbl_demo;



insert into tbl_demo(id,fname,lname) values(1,'tops','tech');
insert into tbl_demo(id,fname,lname) values(2,'rajesh','chopda');


update tbl_demo set fname='tops' where id=1;
update tbl_demo set lname='patel' where id=2;

delete from tbl_demo where id=1;
delete from tbl_demo where fname='rinkal';

select * from tbl_demo;
select fname,lname from tbl_demo;
select distinct fname from tbl_demo;


begin tran t1
delete from tbl_demo where id=1;
rollback

begin tran t2
delete from tbl_demo where id=1;
commit
select * from tbl_demo;

create table tbl_state(
id int primary key  identity(1,1),
statename varchar(30))

insert into tbl_state(statename) values('MH');


select * from tbl_state;


create table tbl_city(city_id int primary key identity(1,1),
cityname varchar(30),sid int references tbl_state(id))








select * from tbl_demo;


























