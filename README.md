CREATE TABLE Productos (
    IDProducto INT PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(100) NOT NULL,
    UnidadMedida VARCHAR(25) NOT NULL,
    ContenidoNeto DECIMAL(10, 2) NOT NULL,
    Precio DECIMAL(10, 2) NOT NULL,
    Stock INT NOT NULL,
    Imagen VARCHAR(255)
);
