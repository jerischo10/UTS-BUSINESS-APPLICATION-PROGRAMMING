create database pos_restoran
on
( 
	NAME = pos_restoran_dat,
	FILENAME = 'D:\project restoran\pos_restoran.mdf',
	SIZE = 8,
	MAXSIZE = unlimited,
	FILEGROWTH = 2
)
LOG ON
(
	NAME = pos_restoran_log,
	FILENAME = 'D:\project restoran\pos_restoran.ldf',
	SIZE = 8,
	MAXSIZE = unlimited,
	FILEGROWTH = 2
)
create table Users(
	ID_User int identity (1,1) not null,
	Nama_User varchar(1000) not null,
	Password_User varchar(1000) not null,
	constraint PK_User primary key (ID_User)
)

insert into Users
values('Admin', '123')



create table Menu(
	ID_Menu int identity (1,1) not null,
	Nama_Menu varchar(1000) not null,
	Harga_Menu money not null,
	Tipe_Menu varchar(8) not null check (Tipe_Menu in ('Makanan','Minuman')),
	constraint PK_Menu primary key (ID_Menu)
)

create table Order_Master(
	ID_Order int identity (1,1) not null,
	Tanggal datetime not null,
	Total_Harga money not null,
	Status_Order varchar(20) not null check (Status_Order in ('Tercetak', 'Belum Tercetak')),
	constraint PK_Order_Master primary key (ID_Order)
)

create table Order_Detail(
	ID_Order int not null,
	ID_Menu int not null,
	Quantity int not null,
	constraint FK_Order_Detail foreign key (ID_Order) references Order_Master(ID_Order) on
	update cascade on delete cascade,
	constraint FK_Menu_Detail foreign key (ID_Menu) references Menu(ID_Menu) on
	update cascade on delete cascade
)

create table tempOrder(
	ID_Menu int not null,
	Quantity int not null,
	Nama_User varchar(1000) not null,
	constraint FK_Menu_Temp foreign key (ID_Menu) references Menu(ID_Menu) on
	update cascade on delete cascade
)