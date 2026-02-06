DROP DATABASE IF EXISTS testing (FORCE);

CREATE DATABASE testing;

\c testing;

CREATE SCHEMA placeholder;

CREATE TABLE placeholder.Users (
	id INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY, 
	first_name VARCHAR(20),
	last_name VARCHAR(20),
	date_of_birth DATE,
	username TEXT UNIQUE, 
	email TEXT UNIQUE,
	password TEXT,
	nationality VARCHAR(2)
	);

-- verificar a tabela abaixo depois

CREATE TABLE placeholder.UserAccessLogs (
    Id SERIAL PRIMARY KEY,
    UserId VARCHAR(100),
    PageAccessed VARCHAR(255) NOT NULL,
    AccessDate TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    IpAddress VARCHAR(45)
);
