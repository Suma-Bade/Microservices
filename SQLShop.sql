create database ShopDB
use ShopDB
create table items(itemid varchar(20) primary key,name varchar(20),price int,stock int);
create table orders(orderid varchar(20) primary key,orderdate date,itemid varchar(20) foreign key references items(itemid))
insert into items values('I0001','keyboard',500,10)
select * from items
insert into items values('I0002','mouse',500,10)
insert into orders values('D0001',getdate(),'I0001')
select * from orders