CREATE TABLE Usuario (
    id INT IDENTITY(1,1) PRIMARY KEY,  -- IDENTITY para autoincrementar el id
    nombre NVARCHAR(30) NOT NULL,
    apellido NVARCHAR(30) NOT NULL,
    email NVARCHAR(50) NOT NULL UNIQUE,  -- UNIQUE para evitar duplicados
    contrasena NVARCHAR(30) NOT NULL
	usuario NVARCHAR(30) NOT NULL UNIQUE,
);

CREATE TABLE Nota (
    idNota INT IDENTITY(1,1) PRIMARY KEY,
    titulo NVARCHAR(255) NOT NULL,
    contenido NVARCHAR(MAX) NOT NULL,
	imagen VARBINARY(MAX);
    fechaCreacion DATETIME DEFAULT GETDATE(),
    fechaModificacion DATETIME DEFAULT GETDATE(),
    clasificacion NVARCHAR(100),
    recordatorio BIT, 
	fechaLimite DATETIME,               
    guardadoAutomatico BIT DEFAULT 0,      
    intervaloGuardado INT DEFAULT 5,       
    id INT,
    FOREIGN KEY (id) REFERENCES Usuario(id) ON DELETE CASCADE 
);

);
CREATE TABLE Recordatorio (
    idRecordatorio INT PRIMARY KEY IDENTITY,
    idNota INT NOT NULL,
    fechaRecordatorio DATETIME NOT NULL,
    mensaje NVARCHAR(MAX),
    FOREIGN KEY (idNota) REFERENCES Nota(idNota) ON DELETE CASCADE
);


CREATE TABLE Recordatorio (
    idRecordatorio INT IDENTITY(1,1) PRIMARY KEY,
    fecha DATETIME NOT NULL,
    mensaje NVARCHAR(MAX),
    estado BIT,  -- BIT para indicar si está activo o no
    idTarea INT,
    FOREIGN KEY (idTarea) REFERENCES Tarea(idTarea) ON DELETE CASCADE
);

CREATE TABLE Reporte (
    idReporte INT IDENTITY(1,1) PRIMARY KEY,
    id INT,  -- Usuario que generó el reporte
    fechaInicio DATETIME NOT NULL,
    fechaFin DATETIME NULL,
    tiempoTotal INT NULL, -- En minutos
    FOREIGN KEY (id) REFERENCES Usuario(id) ON DELETE CASCADE
);








