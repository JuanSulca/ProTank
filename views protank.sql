create view prestamosH_todo as
select p.codigoH as [Código Herramienta], h.nombre as Herramienta, (e.lname + ' ' + e.fname) 
		as Responsable, convert(date,p.fechaP) [Fecha Salida], 
		format(p.fechaP,'HH:mm') [Hora Salida] , format(p.fechaD,'HH:mm') as Retorno
from herramienta h join prestamo p on (h.codigoH=p.codigoH) join empleado e on (e.idE=p.idE)

create view prestamosH_retornadas as
select p.codigoH as [Código Herramienta], h.nombre as Herramienta, (e.lname + ' ' + e.fname) 
		as Responsable, convert(date,p.fechaP) [Fecha Salida], 
		format(p.fechaP,'HH:mm') [Hora Salida] , format(p.fechaD,'HH:mm') as Retorno
from herramienta h join prestamo p on (h.codigoH=p.codigoH) join empleado e on (e.idE=p.idE)
where p.fechaD is null

create view prestamosH_prestadas as
select p.codigoH as [Código Herramienta], h.nombre as Herramienta, (e.lname + ' ' + e.fname) 
		as Responsable, convert(date,p.fechaP) [Fecha Salida], 
		format(p.fechaP,'HH:mm') [Hora Salida] , format(p.fechaD,'HH:mm') as Retorno
from herramienta h join prestamo p on (h.codigoH=p.codigoH) join empleado e on (e.idE=p.idE)
where p.fechaD is not null

--select * from prestamo
--select * from herramienta
--select * from empleado 
--insert into prestamo values('DES_123','0000000000',GETDATE(),null)

create  view viewFecha as
select top 1 fecha, codigoH from mantenimiento order by fecha desc

create view mantenimientoH_todo as
select h.nombre [Herramienta], h.marca [Marca], h.codigoH [Código], aux.fecha 
		[Último mantenimiento], h.periodo [Periodo]
from herramienta h join viewFecha
		aux on (aux.codigoH = h.codigoH)

create view mantenimientoH_proximo as
select h.nombre [Herramienta], h.marca [Marca], h.codigoH [Código], aux.fecha 
		[Último mantenimiento], h.periodo [Periodo], (h.periodo - datediff(day,aux.fecha, getdate())) [Días para mantenimiento]
from herramienta h join (select top 1 fecha, codigoH from mantenimiento order by fecha desc) 
		aux on (aux.codigoH = h.codigoH)
where datediff(day,aux.fecha, getdate())< 15 and datediff(day,aux.fecha, getdate())> 5

create view mantenimientoH_urgente as
select h.nombre [Herramienta], h.marca [Marca], h.codigoH [Código], aux.fecha 
		[Último mantenimiento], h.periodo [Periodo], (h.periodo - datediff(day,aux.fecha, getdate())) [Días para mantenimiento]
from herramienta h join (select top 1 fecha, codigoH from mantenimiento order by fecha desc) 
		aux on (aux.codigoH = h.codigoH)
where datediff(day,aux.fecha, getdate())< 5

create view mantenimientoH_no as
select h.nombre [Herramienta], h.marca [Marca], h.codigoH [Código], aux.fecha 
		[Último mantenimiento], h.periodo [Periodo], (h.periodo - datediff(day,aux.fecha, getdate())) [Días para mantenimiento]
from herramienta h join (select top 1 fecha, codigoH from mantenimiento order by fecha desc) 
		aux on (aux.codigoH = h.codigoH)
where datediff(day,aux.fecha, getdate())> 15

create view mantenimientoH_urgente_proximo as
select * from mantenimientoH_urgente union
select * from mantenimientoH_proximo

create view mantenimientoH_urgete_no as
select * from mantenimientoH_no union
select * from mantenimientoH_urgente

create view mantenimientoH_proximo_no as
select * from mantenimientoH_no union
select * from mantenimientoH_proximo

create view empleados_apellidos_nombres as 
select (e.lname + ' ' + e.fname) [Empleados]
from empleado e

create view clientes_apellidos_nombres as
select (p.lname + ' ' + p.fname) [Clientes]
from person p

create view nuevo_prestamo as
select h.nombre [Nombre], h.marca [Marca], h.codigoH [Código] 
from herramienta h full join prestamo p on (p.codigoH = h.codigoH)
where p.fechaD is not null

create view crearUsuario as
select e.lname+' '+e.fname as Empleado
from empleado e, userEmpleado u
where u.idE != e.idE
