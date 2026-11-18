
CREATE DATABASE Tienda;


USE Tienda;


CREATE TABLE Categoria (
    Codigo INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL
);


CREATE TABLE Producto (
    Codigo INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Precio DECIMAL(10,2) NOT NULL,
    Cantidad INT NOT NULL,
    Categoria INT NOT NULL,

    FOREIGN KEY (Categoria)
    REFERENCES Categoria(Codigo)
);

INSERT INTO Categoria (Nombre)
VALUES
('Electronica'),
('Ropa');


INSERT INTO Producto (Nombre, Precio, Cantidad, Categoria)
VALUES
('Mouse', 5000, 10, 1),
('Camisa', 8000, 15, 2),
('Teclado', 12000, 5, 1);

DELETE FROM Producto
WHERE Codigo = 2;

