IF DB_ID('Futbol') IS NULL

Create database Futbol;

go 

use Futbol;

if OBJECT_ID ('Equipos') is null
create table Equipos
(
Id int Identity(1,1),
Nombre nvarchar (50) not null,
Localidad nvarchar (50) not null
constraint PK_Equipos_Id Primary key (Id)
);

if object_id('Categorias') is null 
create table Categorias
(
Id int Identity(1,1),
Categoria nvarchar (50) not null,
constraint PK_Categorias_Id primary key (Id)
);

if object_id ('Jugadores') is null
create table Jugadores
(
Id int Identity(1,1),
Nombre nvarchar (50) not null,
DNI int not null,
FechaNac datetime not null,
IdEquipo int Foreign key references Equipos(Id) not null,
IdCategoria int Foreign key references Categorias(Id) not null,
constraint PK_Jugadores_Id primary key (Id)
);

