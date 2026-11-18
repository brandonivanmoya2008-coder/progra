-- Crear la base de datos Tienda
CREATE DATABASE Tienda;

-- Seleccionar la base de datos
USE Tienda;

-- Crear la tabla de Clientes
CREATE TABLE Clientes (

    -- Identificador único del cliente
    IdCliente INT AUTO_INCREMENT PRIMARY KEY,

    -- Nombre completo del cliente
    Nombre VARCHAR(100),

    -- Correo electrónico del cliente
    Correo VARCHAR(100)
);