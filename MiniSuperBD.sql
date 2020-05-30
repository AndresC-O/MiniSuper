Use master;
Go
Drop database if exists MiniSuper;
Go
Create database MiniSuper;
Go
--//--//--//--//--//--//--//--//--//--//--//-//--
Use MiniSuper;
Go
--//--//--//--//--//--//--//--//--//--//--//-//--
Create table Clientes(
idCliente int identity(1,1) primary key not null,
nombreCliente varchar(50),
apellidosCliente varchar(50),
direccion varchar(50),
telefono varchar(9),
dui varchar(10),
nit varchar(18)
);
Go

Insert into Clientes values ('GENERICO', 'GENERICO', 'CHALATENANGO', '2301-1234', '00000000-0', '0000-000000-000-0')
Insert into Clientes values ('SAMUEL', 'SOLORZANO', 'CHALATENANGO', '2301-1234', '00345900-0', '0987-013540-000-4')
Insert into Clientes values ('GENERICO', 'GENERICO', 'CHALATENANGO', '2301-1234', '07659870-0', '2345-098130-000-6')


Create table Proveedores(
idProveedor int identity(1,1) primary key not null,
nombreProveedor varchar(30),
direccion varchar(50),
telefono varchar(9)
);
Go

Insert into Proveedores values ('ILC', 'SAN SALVADOR', '2309-7865')
Insert into Proveedores values ('LIDO', 'SANTA ANA', '2309-7865')
Insert into Proveedores values ('LILIAN', 'SAN SALVADOR', '2309-7865')

Create table Categorias(
idCategoria int identity(1,1) primary key not null,
nombreCategoria varchar(15)
);
Go

Insert into Categorias values ('BEBIDAS')
Insert into Categorias values ('PAN')
Insert into Categorias values ('PASTELERIA')

Create table Inventario(
idInventario int identity(1,1) primary key not null,
nombreProducto varchar(20),
idCategoria int not null foreign key references Categorias(idCategoria),
idProveedor int not null foreign key references Proveedores(idProveedor),
existencias int not null,
costo decimal (18,5),
precioVenta decimal (18,5)
);
Go

Insert into Inventario values ('COCA-COLA 500ML', 1, 1, 100, 0.65, 0.73)
--Insert into Inventario values ('SEMITA ALTA', 2, 2, 250, 0.25, 0.28)
--Insert into Inventario values ('PASTEL TRIPLE CHO', 3, 3, 70, 19.95, 22.54)

Create table Sucursales(
idSucursal int identity(1,1) primary key not null,
nombreSucursal varchar(25),
ubicacion varchar(50)
);
Go

Insert into Sucursales values ('CASA MATRIZ', 'CHALATENANGO')
Insert into Sucursales values ('PLAZA BARRIOS', 'SAN - SALVADOR')
Insert into Sucursales values ('COL. BLANCA', 'SONOSONATE')

Create table Documentos(
idDocumento int identity(1,1) primary key not null,
tipoDocumento varchar(25)
);
Go

Insert into Documentos values ('TICKET')
Insert into Documentos values ('FACTURA CF')
Insert into Documentos values ('CREDITO FISCAL')

Create table Empleados(
idEmpleado int identity(1,1) primary key not null,
cargo int not null,
idSucursal int not null foreign key references Sucursales(idSucursal),
nombreEmpleado varchar(25),
apellidos varchar(25),
dui varchar(10),
usuario varchar(20),
contrasenia varchar(45)
);
Go

Insert into Empleados values (1, 1, 'JOSH', 'AMAYOA', '09785612-1', 'Prueba', '1234')
--Insert into Empleados values (2, 3, 'JORGE', 'OSORIO', '09785612-1', 'Cajero', '1234')
--Insert into Empleados values (2, 2, 'PEDRO', 'RAMIREZ', '09785612-1', 'Cajero', '1234')

Create table Compras(
idCompra int identity(1,1) primary key not null,
idEmpleado int not null foreign key references Empleados(idEmpleado),
idProveedor int not null foreign key references Proveedores(idProveedor),
totalCompra decimal(18,5),
fecha date
);
Go

Insert into Compras values (1, 1, 3.25, '2020-05-08')
--Insert into Compras values (2, 2, 5.00, '2020-05-10')
--Insert into Compras values (3, 3, 179.55, '2020-05-10')

Create table DetallesCompra(
idDetalleCompra int identity(1,1) primary key not null,
idCompra int not null foreign key references Compras(idCompra),
idInventario int not null foreign key references Inventario(idInventario),
cantidad int,
precio decimal(18,5)
);
Go

Insert into DetallesCompra values (1, 1, 5, 0.65)
--Insert into DetallesCompra values (2, 2, 20, 0.25)
--Insert into DetallesCompra values (3, 4, 9, 19.95)

Create table Ventas(
idVenta int identity(1,1) primary key not null,
idEmpleado int not null foreign key references Empleados(idEmpleado),
idCliente int not null foreign key references Clientes(idCliente),
idDocumento int not null foreign key references Documentos(idDocumento),
totalVenta decimal(18,5),
fecha date
);
Go

Insert into Ventas values (1, 1, 1, 3.65, '2020-05-08')

Create table DetallesVenta(
idDetalleVenta int identity(1,1) primary key not null,
idVenta int not null foreign key references Ventas(idVenta),
idInventario int not null foreign key references Inventario(idInventario),
cantidad int,
precio decimal(18,5)
);
Go

Insert into DetallesVenta values (1, 1, 5, 0.73)