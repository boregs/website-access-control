DROP DATABASE IF EXISTS testing (FORCE);

CREATE DATABASE testing;

\c testing;

CREATE SCHEMA placeholder;

CREATE TABLE placeholder.users (
	GENERATED ALWAYS AS IDENTITY id INT PRIMARY KEY, 
	first_name VARCHAR(20),
	last_name VARCHAR(20),
	date_of_birth DATE,
	UNIQUE username TEXT, 
	UNIQUE email TEXT, 
	nationality VARCHAR[2]
	);
