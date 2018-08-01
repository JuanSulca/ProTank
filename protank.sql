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

insert into userLogin values ('admin', CONVERT(VARCHAR(32), HashBytes('MD5', 'P@ssw0rd'), 2), 'DCVHA')

insert into person values ('n1','a1','1111111111','111111111','1111111111'),('n2','a2','2222222222','22222222','2222222222')
insert into empleado values ('admin',' ','0000000000','000000000','0000000000'),('n4','a4','4444444444','444444444','4444444444')

insert into userEmpleado values ('0000000000', 'admin')

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
	cantidad smallint,
	codigoH char(12) primary key not null,
	periodo smallint, --periodo de mantenimiento en meses
)

create table mantenimiento(
	codigoH char(12) foreign key references herramienta(codigoH),
	fecha date,
	notas varchar(280),
	primary key(codigoH, fecha)
)

insert into contrato values('2222222222', 45000, 5, 'CT_18_111_TK345', 'Tanque para combustible', null, null)

insert into herramienta values ('Destornillador', 5, 'DES_123', null),('Taladro', 4, 'TAL_123_1', 5)
insert into herramienta values ('Llave de tuercas', 10, 'LLa_440', null)
insert into herramienta values ('Martillo', 3, 'Mar_315', null)

insert into mantenimiento values ('TAL_123_1', GETDATE(), 'reemplazo mandril'), ('TAL_123_1', convert(date,'2018-06-13'),'reemplazo ventilador')

create table prodServ(
	codigo char(10) not null primary key,
	nombre varchar(60) not null,
	precio money not null,
	unidad char(5) null
)

insert into prodServ values ('COR', 'Corte CNC', 3.5,'m'), ('MET', 'Plancha metal', 5.65, 'm2')

create table prestamo(
	codigoH char(12) not null foreign key references herramienta(codigoH),
	idE char(10) not null foreign key references empleado(idE),
	fechaP datetime not null default(getdate()),
	fechaD datetime null,
	cantidad smallint default 1,
	primary key(codigoH, idE, fechaP)
)


insert into prestamo values ('TAL_123_1', '4444444444', getdate(), convert(datetime,'2018/07/15 5:32:00:00',120), 1),('LLa_440', '4444444444',getdate(),convert(datetime,'2018/07/15 5:26:00:00',120), 2)

create table sale (
	id_person char(10) foreign key references person(id),
	id_sale int identity(1,1) primary key
)

create table saleLine (
	prod char(10) not null foreign key references prodServ(codigo),
	id_sale int not null foreign key references sale(id_sale),
	cantidad decimal(4,2) not null,
	primary key(prod, id_sale)
)


insert into sale values ('2222222222')
insert into saleLine values ('COR', 1, 2.5)
insert into saleLine values ('MET', 1, 5)
go

create view prestamosH_todo as
select p.cantidad as [Cantidad], p.codigoH as [Código Herramienta], h.nombre as Herramienta, (e.lname + ' ' + e.fname) 
		as Responsable, convert(date,p.fechaP) [Fecha Salida], 
		format(p.fechaP,'HH:mm') [Hora Salida] , format(p.fechaD,'HH:mm') as Retorno
from herramienta h join prestamo p on (h.codigoH=p.codigoH) join empleado e on (e.idE=p.idE)
go

create view prestamosH_prestadas as
select p.cantidad as [Cantidad],p.codigoH as [Código Herramienta], h.nombre as Herramienta, (e.lname + ' ' + e.fname) 
		as Responsable, convert(date,p.fechaP) [Fecha Salida], 
		format(p.fechaP,'HH:mm') [Hora Salida] , format(p.fechaD,'HH:mm') as Retorno
from herramienta h join prestamo p on (h.codigoH=p.codigoH) join empleado e on (e.idE=p.idE)
where p.fechaD is null
go

create view prestamosH_retornadas as
select p.cantidad as [Cantidad],p.codigoH as [Código Herramienta], h.nombre as Herramienta, (e.lname + ' ' + e.fname) 
		as Responsable, convert(date,p.fechaP) [Fecha Salida], 
		format(p.fechaP,'HH:mm') [Hora Salida] , format(p.fechaD,'HH:mm') as Retorno
from herramienta h join prestamo p on (h.codigoH=p.codigoH) join empleado e on (e.idE=p.idE)
where p.fechaD is not null
go

--select * from prestamo
--select * from herramienta
--select * from empleado 
--insert into prestamo values('DES_123','0000000000',GETDATE(),null)

create  view viewFecha as
select top 1 fecha, codigoH from mantenimiento order by fecha desc
go
create view mantenimientoH_todo as
select h.nombre [Herramienta], h.cantidad [Cantidad], h.codigoH [Código], aux.fecha 
		[Último mantenimiento], h.periodo [Periodo]
from herramienta h join viewFecha
		aux on (aux.codigoH = h.codigoH)
go

create view mantenimientoH_proximo as
select h.nombre [Herramienta], h.cantidad [Cantidad], h.codigoH [Código], aux.fecha 
		[Último mantenimiento], h.periodo [Periodo], (h.periodo - datediff(day,aux.fecha, getdate())) [Días para mantenimiento]
from herramienta h join (select top 1 fecha, codigoH from mantenimiento order by fecha desc) 
		aux on (aux.codigoH = h.codigoH)
where datediff(day,aux.fecha, getdate())< 15 and datediff(day,aux.fecha, getdate())> 5
go

create view mantenimientoH_urgente as
select h.nombre [Herramienta], h.cantidad [Cantidad], h.codigoH [Código], aux.fecha 
		[Último mantenimiento], h.periodo [Periodo], (h.periodo - datediff(day,aux.fecha, getdate())) [Días para mantenimiento]
from herramienta h join (select top 1 fecha, codigoH from mantenimiento order by fecha desc) 
		aux on (aux.codigoH = h.codigoH)
where datediff(day,aux.fecha, getdate())< 5
go

create view mantenimientoH_no as
select h.nombre [Herramienta], h.cantidad [Cantidad], h.codigoH [Código], aux.fecha 
		[Último mantenimiento], h.periodo [Periodo], (h.periodo - datediff(day,aux.fecha, getdate())) [Días para mantenimiento]
from herramienta h join (select top 1 fecha, codigoH from mantenimiento order by fecha desc) 
		aux on (aux.codigoH = h.codigoH)
where datediff(day,aux.fecha, getdate())> 15
go

create view mantenimientoH_urgente_proximo as
select * from mantenimientoH_urgente union
select * from mantenimientoH_proximo
go

create view mantenimientoH_urgete_no as
select * from mantenimientoH_no union
select * from mantenimientoH_urgente
go

create view mantenimientoH_proximo_no as
select * from mantenimientoH_no union
select * from mantenimientoH_proximo
go

create view empleados_apellidos_nombres as 
select (e.lname + ' ' + e.fname) [Empleados]
from empleado e
go

create view clientes_apellidos_nombres as
select (p.lname + ' ' + p.fname) [Clientes]
from person p
go

create view nuevo_prestamo as
select h.nombre [Nombre], h.cantidad [Cantidad], h.codigoH [Código] 
from herramienta h full join prestamo p on (p.codigoH = h.codigoH)
where p.fechaD is not null
go

create view crearUsuario as
select e.lname+' '+e.fname as Empleado
from empleado e, userEmpleado u
where u.idE != e.idE
go

create view venta as
select s.id_sale, cast(sum(cantidad*precio)as money) as Total from sale s join saleLine sl on s.id_sale = sl.id_sale join prodServ p on prod = p.codigo group by s.id_sale
go

create view ventaPersonas as
select s.id_sale, p.id, CONCAT(fname, ' ', lname) as Nombre, Total from venta v join sale s on (v.id_sale = s.id_sale) join person p on (p.id = s.id_person)
go

select * from prestamosH_prestadas
select * from prestamosH_retornadas