# Prueba Técnica

Te vamos a solicitar una prueba simple del stack tecnológico que se está utilizando en la empresa. Sabemos que actualmente no cuentas con conocimientos en todas estas tecnologías, pero es el puesto que necesitamos cubrir.

**Crear una API en .NET utilizando algún patrón de diseño (Repository), Entity Framework y conectarse a una base de datos en MySQL.
En base a estas tecnologías, realizar un CRUD de usuarios con los campos ID, nombre, email, y password.**

## Preparación de la base de datos MySQL

Sigue estos pasos para configurar la base de datos MySQL que será utilizada por la API.

   ```sql
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
    Nombre VARCHAR(30) NOT NULL,
    Email VARCHAR(30) NOT NULL,
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

```
## Modificar el Connection String en las variables globales de la API
```bash

