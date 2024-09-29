# Prueba Técnica

Te vamos a solicitar una prueba simple del stack tecnológico que se está utilizando en la empresa. Sabemos que actualmente no cuentas con conocimientos en todas estas tecnologías, pero es el puesto que necesitamos cubrir.

**Crear una API en .NET utilizando algún patrón de diseño (Repository), Entity Framework y conectarse a una base de datos en MySQL.
En base a estas tecnologías, realizar un CRUD de usuarios con los campos ID, nombre, email, y password.**

## Preparación de la base de datos MySQL

Sigue estos pasos para configurar la base de datos MySQL que será utilizada por la API.

   ```sql
   CREATE USER 'user'@'localhost' IDENTIFIED BY '1234';
   
   CREATE DATABASE pruebatecnica;
   
   USE pruebatecnica;
   
   CREATE TABLE usuarios (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(15) NOT NULL,
    Email VARCHAR(15) NOT NULL,
    Contraseña VARCHAR(10) NOT NULL
);
