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