
--creacion de usuario para ingresar a la base de datos
CREATE USER 'nuevo_usuario'@'user' IDENTIFIED BY '1234';


-- Crear la base de datos
CREATE DATABASE pruebatecnica;

-- Usar la base de datos
USE pruebatecnica;

-- Crear la tabla usuarios
CREATE TABLE usuarios (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(15) NOT NULL,
    email VARCHAR(15) NOT NULL,
    contraseña VARCHAR(10) NOT NULL
);
