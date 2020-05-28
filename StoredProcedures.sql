Use MiniSuper;
Go
/*PROCEDIMIENTOS ALMACENADOS (C.R.U.D)*/

--[CATEGORIAS]-------------------------------------------------
Create procedure sp_InsertarCategoria
	@nombreCategoria varchar(15)
	As
	Begin
		set nocount on;
		Insert into Categorias(nombreCategoria) values (@nombreCategoria)
	End
Go

Create procedure sp_ConsultarCategorias
As
	Begin
	Select * from Categorias
	End
Go

Create procedure sp_ModificarCategoria
@nuevoNombre varchar(20), @id int
As
	Begin
	Update Categorias set nombreCategoria=@nuevoNombre where idCategoria=@id
	End
Go

Create procedure sp_EliminarCategoria
@id int
As
	Begin
	Delete from Categorias where idCategoria=@id
	End
Go

--[CLIENTES]-------------------------------------------------
Create procedure sp_InsertarCliente
	@nombresCliente varchar(50), @apellidosCliente varchar(50), @direccion varchar(50),
	@telefono varchar(9), @dui varchar(10), @nit varchar(18)
	As
	Begin
		set nocount on;
		Insert into Clientes(nombreCliente, apellidosCliente, direccion, telefono, dui, nit)
		values (@nombresCliente, @apellidosCliente, @direccion, @telefono, @dui, @nit)
	End
Go

Create procedure sp_ConsultarClientes
As
	Begin
	Select * from Clientes
	End
Go

Create procedure sp_ModificarCliente
@nuevosNombres varchar(50), @nuevosApellidos varchar(50), @direccion varchar(50), 
@telefono varchar(9), @dui varchar(10), @nit varchar(18), @id int
	As
	Begin
	Update Clientes set nombreCliente=@nuevosApellidos, apellidosCliente=@nuevosApellidos,
	direccion=@direccion, telefono=@telefono, dui=@dui, nit=@nit where idCliente=@id
	End
Go

Create procedure sp_EliminarCliente
@id int
As
	Begin
	Delete from Clientes where idCliente=@id
	End
Go

--[COMPRAS]-------------------------------------------------
Create procedure sp_InsertarCompra
@idEmpleado int, @idProveedor int, @totalCompra decimal(18,5), @fecha date
	As
	Begin
		set nocount on;
		Insert into Compras(idEmpleado, idProveedor, totalCompra, fecha)
		values(@idEmpleado, @idProveedor, @totalCompra, @fecha)
	End
Go

Create procedure sp_ConsultarCompras
As
	Begin
	Select * from Compras
	End
Go

Create procedure sp_EliminarCompra
@id int
As
	Begin
	Delete from Compras where idCompra=@id
	End
Go

--[DETALLES DE COMPRAS]-------------------------------------------------
Create procedure sp_InsertarDetalleCompra
@idCompra int, @idInventario int, @cantidad int, @precio decimal(18,5)
	As
	Begin
		set nocount on;
		Insert into DetallesCompra(idCompra, idInventario, cantidad, precio)
		values (@idCompra, @idInventario, @cantidad, @precio)
	End
Go

Create procedure sp_ConsultarDetallesCompra
As
	Begin
	Select * from DetallesCompra
	End
Go

Create procedure sp_EliminarDetalleCompra
@id int
As
	Begin
	Delete from DetallesCompra where idDetalleCompra=@id
	End
Go

--[VENTAS]-------------------------------------------------
Create procedure sp_InsertarVenta
@idEmpleado int, @idCliente int, @idDocumento int, @totalVenta decimal(18,5), @fecha date
	As
	Begin
		set nocount on;
		Insert into Ventas(idEmpleado, idCliente, idDocumento, totalVenta, fecha)
		values(@idEmpleado, @idCliente, @idDocumento, @totalVenta, @fecha)
	End
Go

Create procedure sp_ConsultarVentas
As
	Begin
	Select * from Ventas
	End
Go

Create procedure sp_EliminarVenta
@id int
As
	Begin
	Delete from Ventas where idVenta=@id
	End
Go

--[DETALLES DE VENTA]-------------------------------------------------
Create procedure sp_InsertarDetalleVenta
@idVenta int, @idInventario int, @cantidad int, @precio decimal(18,5)
	As
	Begin
		set nocount on;
		Insert into DetallesCompra(idCompra, idInventario, cantidad, precio)
		values (@idVenta, @idInventario, @cantidad, @precio)
	End
Go

Create procedure sp_ConsultarDetallesVenta
As
	Begin
	Select * from DetallesVenta
	End
Go

Create procedure sp_EliminarDetalleVenta
@id int
As
	Begin
	Delete from DetallesVenta where idDetalleVenta=@id
	End
Go

--[DOCUMENTOS]-------------------------------------------------
Create procedure sp_InsertarDocumento
@tipoDocumento varchar(25)
	As
	Begin
		set nocount on;
		Insert into Documentos(tipoDocumento) values(@tipoDocumento)
	End
Go

Create procedure sp_ConsultarDocumentos
As
	Begin
	Select * from Documentos
	End
Go

Create procedure sp_ModificarDocumento
@nuevoDocumento varchar(25) ,@id int
As
	Begin
	Update Documentos set tipoDocumento=@nuevoDocumento where idDocumento=@id
	End
Go

Create procedure sp_EliminarDocumento
@id int
As
	Begin
	Delete from Documentos where idDocumento=@id
	End
Go

--[EMPLEADOS]-------------------------------------------------
Create procedure sp_InsertarEmpleado
@cargo int, @idSucursal int, @nombreEmpleado varchar(25), @apellidos varchar(25), 
@dui varchar(10), @usuario varchar(20), @contrasenia varchar(45)
	As
	Begin
		set nocount on;
		Insert into Empleados(cargo, idSucursal, nombreEmpleado, apellidos, dui, usuario, contrasenia)
		values(@cargo, @idSucursal, @nombreEmpleado, @apellidos, @dui, @usuario, @contrasenia)
	End
Go

Create procedure sp_ConsultarEmpleados
As
	Begin
	Select * from Empleados
	End
Go

Create procedure sp_ModificarEmpleados
@nuevoCargo int, @nuevoIdSucursal int, @nuevoNombre varchar(25), @nuevoApellido varchar(25),
@nuevoDui varchar(10), @nuevoUsuario varchar(20), @nuevaContrasenia varchar(45) ,@id int
As
	Begin
	Update Empleados set cargo=@nuevoCargo, idSucursal=@nuevoIdSucursal, nombreEmpleado=@nuevoNombre,
	apellidos=@nuevoApellido, dui=@nuevoDui, usuario=@nuevoUsuario, contrasenia=@nuevaContrasenia where idEmpleado=@id
	End
Go

Create procedure sp_EliminarEmpleado
@id int
As
	Begin
	Delete from Empleados where idEmpleado=@id
	End
Go

--[INVENTARIO]-------------------------------------------------
Create procedure sp_InsertarInventario
@nombreProducto varchar(20), @idCategoria int, @idProveedor int, @existencias int,
@costo decimal(18,5), @precioVenta decimal(18,5)
	As
	Begin
		set nocount on;
		Insert into Inventario(nombreProducto, idCategoria, idProveedor, existencias, costo, precioVenta)
		values(@nombreProducto, @idCategoria, @idProveedor, @existencias, @costo, @precioVenta)
	End
Go

Create procedure sp_ConsultarInventario
As
	Begin
	Select * from Inventario
	End
Go

Create procedure sp_ModificarInventario
@nuevoNombreProd varchar(20), @idCategoria int, @idProveedor int, @existencias int, @costo decimal(18,5), @precioVenta decimal(18,5), @id int
As
	Begin
	Update Inventario set nombreProducto=@nuevoNombreProd, idCategoria=@idCategoria, idProveedor=@idProveedor,
	existencias=@existencias, costo=@costo, precioVenta=@precioVenta where idInventario=@id
	End
Go

Create procedure sp_EliminarInventario
@id int
As
	Begin
	Delete from Inventario where idInventario=@id
	End
Go

--[PROVEEDORES]-------------------------------------------------
Create procedure sp_InsertarProveedor
@nombreProveedor varchar(30), @direccion varchar(50), @telefono varchar(9)
	As
	Begin
		set nocount on;
		Insert into Proveedores(nombreProveedor, direccion, telefono) 
		values (@nombreProveedor, @direccion, @telefono)
	End
Go

Create procedure sp_ConsultarProveedores
As
	Begin
	Select * from Proveedores
	End
Go

Create procedure sp_ModificarProveedor
@newNombreProveedor varchar(30), @direccion varchar(50), @telefono varchar(9), @id int
As
	Begin
	Update Proveedores set nombreProveedor=@newNombreProveedor, direccion=@direccion,
	telefono=@telefono
	where idProveedor=@id
	End
Go

Create procedure sp_EliminarProveedor
@id int
As
	Begin
	Delete from Proveedores where idProveedor=@id
	End
Go

--[SUCURSALES]-------------------------------------------------
Create procedure sp_InsertarSucursal
@nombreSucursal varchar(25), @ubicacion varchar(50)
	As
	Begin
		set nocount on;
		Insert into Sucursales(nombreSucursal, ubicacion)
		values (@nombreSucursal, @ubicacion)
	End
Go

Create procedure sp_ConsultarSucursal
As
	Begin
	Select * from Sucursales
	End
Go

Create procedure sp_ModificarSucursal
@newNombreSucursal varchar(25), @ubicacion varchar(50), @id int
As
	Begin
	Update Sucursales set nombreSucursal=@newNombreSucursal, ubicacion=@ubicacion
	where idSucursal=@id
	End
Go

Create procedure sp_EliminarSucursal
@id int
As
	Begin
	Delete from Sucursales where idSucursal=@id
	End
Go