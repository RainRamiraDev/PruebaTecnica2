
--creacion de usuario para ingresar a la base de datos
CREATE USER 'nuevo_usuario'@'user' IDENTIFIED BY '1234';


-- Crear la base de datos
CREATE DATABASE pruebatecnica;

-- Usar la base de datos
USE pruebatecnica;

-- Crear la tabla usuarios
CREATE TABLE usuarios (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(15) NOT NULL,
    Email VARCHAR(15) NOT NULL,
    Contraseña VARCHAR(10) NOT NULL
);
