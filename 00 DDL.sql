--	Script Desarrollado por alumnos de Computación de ET12 "Libertador Gral. José de San Martín" https://et12.edu.ar
DROP DATABASE IF EXISTS bd_PokemonRPG;
CREATE DATABASE bd_PokemonRPG CHARACTER SET UTF8;
USE bd_PokemonRPG;

CREATE TABLE Entrenador(
	idEntrenador SMALLINT NOT NULL AUTO_INCREMENT,
	nombre VARCHAR(50) NOT NULL,
	dinero MEDIUMINT UNSIGNED NOT NULL,
	CONSTRAINT PK_Entrenador PRIMARY KEY (idEntrenador ASC),
	CONSTRAINT UQ_Entrenador_nombre UNIQUE (nombre ASC)
);

CREATE TABLE Tipo(
	idTipo TINYINT NOT NULL AUTO_INCREMENT,
	tipo VARCHAR(15) NOT NULL,
	CONSTRAINT PK_Tipo PRIMARY KEY (idTipo ASC),
	CONSTRAINT UQ_Tipo_tipo UNIQUE (tipo ASC)
);

CREATE VIEW vTipo AS
	SELECT	idTipo AS Id,
			tipo AS Nombre
	FROM	Tipo
	ORDER BY tipo ASC;

CREATE TABLE Especie(
	idEspecie SMALLINT UNSIGNED NOT NULL,
	idTipo TINYINT NOT NULL,
	idTipo2 TINYINT,
	nombre VARCHAR(50) NOT NULL,
	altura FLOAT NOT NULL,
	peso FLOAT NOT NULL,
	probabilidadH FLOAT UNSIGNED,
	CONSTRAINT PK_Especie PRIMARY KEY (idEspecie ASC),
	CONSTRAINT UQ_Especie_nombre UNIQUE (nombre ASC),
	CONSTRAINT FK_Especie_Tip02 FOREIGN KEY (idTipo2) REFERENCES Tipo (idTipo) ON DELETE Restrict ON UPDATE Restrict,
	CONSTRAINT FK_Especie_Tipo FOREIGN KEY (idTipo) REFERENCES Tipo (idTipo) ON DELETE Restrict ON UPDATE Restrict
);

SELECT 'Creando Vista' Estado;
CREATE VIEW vListadoEspecie AS
	SELECT 
		-- Propiedades de Especie
		e.idEspecie AS Id,
		e.nombre AS Nombre,
		e.altura AS Altura,
		e.peso AS Peso,
		e.probabilidadH AS ProbabilidadHembra,                
		-- Propiedades de Tipo
		t.idTipo AS tId,
		t.tipo AS tNombre,                
		-- Propiedades de Tipo 2
		t2.idTipo AS t2Id,
		t2.tipo AS t2Nombre
	FROM Especie e
	INNER JOIN Tipo t USING (idTipo)
	LEFT JOIN Tipo t2 ON e.idTipo2 = t2.idTipo;

CREATE TABLE Objeto(
	idObjeto SMALLINT NOT NULL AUTO_INCREMENT,
	nombre VARCHAR(50) NOT NULL,
	precioVenta SMALLINT UNSIGNED,
	precioCompra SMALLINT UNSIGNED,
	CONSTRAINT PK_Objeto PRIMARY KEY (idObjeto ASC),
	CONSTRAINT UQ_Ojeto_nombre UNIQUE (nombre ASC)
);

CREATE TABLE Mochila(
	idEntrenador SMALLINT NOT NULL,
	idObjeto SMALLINT NOT NULL,
	cantidad SMALLINT UNSIGNED NOT NULL,
	CONSTRAINT PK_Mochila PRIMARY KEY (idEntrenador ASC, idObjeto ASC),
	CONSTRAINT FK_Mochila_Entrenador FOREIGN KEY (idEntrenador) REFERENCES Entrenador (idEntrenador) ON DELETE Restrict ON UPDATE Restrict,
	CONSTRAINT FK_Mochila_Objeto FOREIGN KEY (idObjeto) REFERENCES Objeto (idObjeto) ON DELETE Restrict ON UPDATE Restrict
);

CREATE TABLE Pokedex(
	idEntrenador SMALLINT NOT NULL,
	idEspecie SMALLINT UNSIGNED NOT NULL,
	encuentros SMALLINT NOT NULL,
	atrapados SMALLINT NOT NULL,
	CONSTRAINT PK_Pokedex PRIMARY KEY (idEntrenador ASC, idEspecie ASC),
	CONSTRAINT FK_Pokedex_Entrenador FOREIGN KEY (idEntrenador) REFERENCES Entrenador (idEntrenador) ON DELETE Restrict ON UPDATE Restrict,
	CONSTRAINT FK_Pokedex_Especie FOREIGN KEY (idEspecie) REFERENCES Especie (idEspecie) ON DELETE Restrict ON UPDATE Restrict
);

CREATE TABLE Pokemon(
	idPokemon INT NOT NULL AUTO_INCREMENT,
	idEntrenador SMALLINT NOT NULL,
	idEntrenadorOriginal SMALLINT NOT NULL,
	idEspecie SMALLINT UNSIGNED NOT NULL,
	apodo VARCHAR(15),
	nivel TINYINT UNSIGNED NOT NULL,
	atrapado DATE NOT NULL,
	sexo CHAR(1),
	CONSTRAINT PK_Pokemon PRIMARY KEY (idPokemon ASC),
	CONSTRAINT FK_Pokemon_Entrenador FOREIGN KEY (idEntrenador) REFERENCES Entrenador (idEntrenador) ON DELETE Restrict ON UPDATE Restrict,
	CONSTRAINT FK_Pokemon_EntrenadorOriginal FOREIGN KEY (idEntrenadorOriginal) REFERENCES Entrenador (idEntrenador) ON DELETE Restrict ON UPDATE Restrict,
	CONSTRAINT FK_Pokemon_Especie FOREIGN KEY (idEspecie) REFERENCES Especie (idEspecie) ON DELETE Restrict ON UPDATE Restrict
);

DELIMITER $$
CREATE PROCEDURE VaciarTablas()
BEGIN
	START TRANSACTION;
		DELETE FROM	Mochila;
		DELETE FROM	Objeto;
		DELETE FROM	Pokemon;
		DELETE FROM	Pokedex;
		DELETE FROM	Especie;
		DELETE FROM	Entrenador;
		DELETE FROM	Tipo;
	COMMIT;
END $$

CREATE PROCEDURE AltaObjeto(OUT	unId SMALLINT, unNombre VARCHAR(45),
							unPrecioVenta SMALLINT UNSIGNED, unPrecioCompra SMALLINT UNSIGNED)
BEGIN
	INSERT INTO Objeto (nombre, precioVenta, precioCompra)
		VALUES	(unNombre, unPrecioVenta, unPrecioCompra);
	SET unId = LAST_INSERT_ID();
END $$

CREATE PROCEDURE AltaEntrenador(OUT unId SMALLINT, unNombre VARCHAR(45), unMonto MEDIUMINT UNSIGNED)
BEGIN
	INSERT INTO Entrenador (nombre, dinero)
		VALUE (unNombre, unMonto);
	SET unId = LAST_INSERT_ID();
END $$
CREATE PROCEDURE MochilaDe(unIdEntrenador SMALLINT)
BEGIN
	SELECT	M.idObjeto Id,
			nombre,
			precioVenta Venta,
			precioCompra Compra,
			cantidad
	FROM	Mochila M
	JOIN	Objeto USING (idObjeto)
	WHERE	idEntrenador = unIdEntrenador;
END $$
DELIMITER ;
