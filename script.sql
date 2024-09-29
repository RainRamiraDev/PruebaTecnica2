-- Crear usuario
CREATE USER 'user'@'localhost' IDENTIFIED BY '1234';

-- Crear base de datos
CREATE DATABASE pruebatecnica;

-- Otorgar privilegios al usuario sobre la base de datos
GRANT ALL PRIVILEGES ON pruebatecnica.* TO 'user'@'localhost';
FLUSH PRIVILEGES;

-- Usar la base de datos
USE pruebatecnica;

-- Crear tabla
CREATE TABLE usuarios (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(15) NOT NULL,
    Email VARCHAR(15) NOT NULL,
    Contraseña VARCHAR(255) NOT NULL
);

-- Insertar datos en la tabla
INSERT INTO usuarios (Nombre, Email, Contraseña) 
VALUES ('Juan Perez', 'juan.perez@mail.com', 'password1');

INSERT INTO usuarios (Nombre, Email, Contraseña) 
VALUES ('Maria Garcia', 'maria.garcia@mail.com', 'password2');

INSERT INTO usuarios (Nombre, Email, Contraseña) 
VALUES ('Carlos Lopez', 'carlos.lopez@mail.com', 'password3');

INSERT INTO usuarios (Nombre, Email, Contraseña) 
VALUES ('Ana Torres', 'ana.torres@mail.com', 'password4');

INSERT INTO usuarios (Nombre, Email, Contraseña) 
VALUES ('Pedro Sanchez', 'pedro.sanchez@mail.com', 'password5');
