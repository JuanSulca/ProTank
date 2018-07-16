use master
go

drop database protank
go

create database protank
go

use protank
go

--Revisada
create table userLogin(
	uname varchar(20) primary key not null,
	pwd char(32) not null,
	rol char(5) not null,
)

create table person(
	fname varchar(60) not null,
	lname varchar(60) not null,
	id char(10) not null primary key,
	telef varchar(10),
	cel varchar(10)
)

create table empleado(
	fname varchar(60) not null,
	lname varchar(60) not null,
	idE char(10) not null primary key,
	telef varchar(10),
	cel varchar(10)
)

create table userEmpleado(
	idE char(10) foreign key references empleado(idE) not null,
	uname varchar(20) foreign key references userLogin(uname) not null,
	primary key(idE,uname)
)

insert into userLogin values ('admin', CONVERT(VARCHAR(32), HashBytes('MD5', 'P@ssw0rd'), 2), 'A')

insert into person values ('n1','a1','1111111111','111111111','1111111111'),('n2','a2','2222222222','22222222','2222222222')
insert into empleado values ('admin',' ','0000000000','000000000','0000000000'),('n4','a4','4444444444','444444444','4444444444')

insert into userEmpleado values ('0000000000', 'admin')

select * from userLogin
select * from person
select * from userEmpleado

create table contrato(
	idPer char(10) not null foreign key references person(id),
	monto money not null,
	calificacion smallint,
	idCon varchar(64) not null primary key,
	descrip varchar(280) null,
	fechaI date null,
	fechaE date null
)

create table herramienta(
	nombre varchar(60),
	marca varchar(60),
	codigoH char(15) primary key not null,
	periodo smallint, --periodo de mantenimiento en meses
)

create table mantenimiento(
	codigoH char(15) foreign key references herramienta(codigoH),
	fecha date,
	notas varchar(280),
	primary key(codigoH, fecha)
)

insert into contrato values('2222222222', 45000, 5, 'CT_18_111_TK345', 'Tanque para combustible', null, null)

insert into herramienta values ('Destornillador', 'Philips', 'DES_123', null),('Taladro', 'Pretul', 'TAL_123_1', 5)
insert into herramienta values ('Llave de tuercas', 'Philips', 'LLa_440', null)
insert into herramienta values ('Martillo', 'Generico', 'Mar_315', null)

delete from herramienta where codigoH = 'Mar_315'

insert into mantenimiento values ('TAL_123_1', GETDATE(), 'reemplazo mandril'), ('TAL_123_1', convert(date,'2018-06-13'),'reemplazo ventilador')

select * from contrato
select * from herramienta
select * from mantenimiento

create table prodServ(
	codigo char(10) not null primary key,
	nombre varchar(60) not null,
	precio money not null,
	unidad char(5) null
)

insert into prodServ values ('COR', 'Corte CNC', 3.5,'m'), ('MET', 'Plancha metal', 5.65, 'm2')

select * from prodServ

create table prestamo(
	codigoH char(15) not null foreign key references herramienta(codigoH),
	idE char(10) not null foreign key references empleado(idE),
	fechaP datetime not null default(getdate()),
	fechaD datetime null,
	primary key(codigoH, idE, fechaP)
)

insert into prestamo values ('TAL_123_1', '4444444444', getdate(), convert(datetime,'2018/07/15 5:32:00:00',120)),('LLa_440', '4444444444',getdate(),convert(datetime,'2018/07/15 5:26:00:00',120))

print convert(datetime,'2018/07/15 5:32:00:00',120)
print convert(datetime, getdate())

select * from prestamo
