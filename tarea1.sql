create database tienda;
use tienda;
CREATE TABLE Clientes (
    IdCliente INT AUTO_INCREMENT PRIMARY
    KEY,
        Nombre VARCHAR(100),
        Correo VARCHAR(100)
        );
select * from tienda.Clientes