CREATE DATABASE KEVINPORTUGAL;
GO

USE KEVINPORTUGAL;
GO

CREATE TABLE KP_Preguntas (
    PreguntaID INT IDENTITY(1,1) PRIMARY KEY,
    TextoPregunta NVARCHAR(500) NOT NULL
);
GO

CREATE TABLE KP_Respuestas (
    RespuestaID INT IDENTITY(1,1) PRIMARY KEY,
    PreguntaID INT NOT NULL,
    TextoRespuesta NVARCHAR(MAX) NOT NULL,
    FOREIGN KEY (PreguntaID) REFERENCES KP_Preguntas(PreguntaID)
);
GO


INSERT INTO KP_Preguntas (TextoPregunta) VALUES
('¿Cómo resolverías estos problemas con una solución tecnológica?'),
('¿Qué pasos seguirías para desarrollar un sistema que permita al bufete gestionar de forma eficiente todos los aspectos de sus casos legales?'),
('¿Qué estructura tendría la base de datos?'),
('¿Por qué elegiste la estructura de base de datos que diseñaste? ¿Qué ventajas y desventajas tiene tu diseño?'),
('¿Qué interfaz gráfica utilizarías?');
GO

INSERT INTO KP_Respuestas (PreguntaID, TextoRespuesta) VALUES
(1, 'Se puede desarrollar un sistema de gestión de casos legales que centralice la información, automatice plazos y genere reportes.'),
(2, 'Primero se hace un análisis de requerimientos, luego diseño de base de datos e interfaz, desarrollo, pruebas y finalmente despliegue.'),
(3, 'La base de datos debe ser relacional, con tablas para Clientes, Abogados, Casos, Documentos y Plazos.'),
(4, 'Elegí base de datos relacional porque permite consultas rápidas, integridad de datos y generación de reportes. Ventaja: confiable y mantenible. Desventaja: cambios requieren migraciones.'),
(5, 'Usaría WebForms con GridView, DetailsView y SqlDataSource para mostrar y gestionar las preguntas y respuestas.');
GO


UPDATE KP_Respuestas
SET TextoRespuesta = 'Usaría C# con WebForms para crear una interfaz web clara y dinámica que muestre todos los detalles de los casos (fechas, abogados, estado, clientes y documentos) de forma centralizada, con alertas para fechas importantes, facilitando el acceso a la información actualizada y reduciendo la confusión y pérdida de datos.'
WHERE RespuestaID = 5;
GO

