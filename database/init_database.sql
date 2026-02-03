DROP DATABASE IF EXISTS testing (FORCE);

CREATE DATABASE testing;

\c testing;

CREATE SCHEMA placeholder;

CREATE TABLE placeholder.users (
	id INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY, 
	first_name VARCHAR(20),
	last_name VARCHAR(20),
	date_of_birth DATE,
	username TEXT UNIQUE, 
	email TEXT UNIQUE, 
	nationality VARCHAR(2)
	);
