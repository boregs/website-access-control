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

CREATE TABLE placeholder.UserAccessLogs (
    id SERIAL PRIMARY KEY,
    User_Id VARCHAR(100),
    Page_Accessed VARCHAR(255) NOT NULL,
    Access_Date TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP
);
