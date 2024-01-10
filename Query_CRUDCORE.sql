create database DB_CRUDCORE

use DB_CRUDCORE

Select * from contacto

create table contacto
(
IdContacto int identity primary key,
Nombre varchar(50),
Telefono varchar(50),
correo varchar(50)
)

create procedure sp_Listar
as
begin
	select * from contacto
end

create procedure sp_Obtener
(@IdContacto int)
as
begin
	select * from contacto where IdContacto = @IdContacto
end

create procedure sp_Guardar
(@Nombre varchar(50)
,@Telefono varchar(50)
,@Correo varchar(50)
)
as 
begin
	insert into contacto(Nombre,Telefono,Correo) 
	values (@Nombre,@Telefono,@Correo)
end

create procedure sp_Editar
(@IdContacto int,
@Nombre varchar(50),
@Telefono varchar(50),
@Correo varchar(50))
as
begin
	update contacto set Nombre=@Nombre, Telefono=@Telefono, Correo=@Correo
	where IdContacto = @IdContacto
end

drop procedure sp_Obtener