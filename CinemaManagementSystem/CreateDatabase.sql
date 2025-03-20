CREATE TABLE users
(
	id INT PRIMARY KEY IDENTITY(1,1),
	username VARCHAR(MAX) NULL,
	password VARCHAR(MAX) NULL,
	role VARCHAR(MAX) NULL,
	status VARCHAR(MAX) NULL,
	date_reg DATE NULL
)
select * from users 
INSERT INTO users( username,password ,role,status,date_reg)
VALUES('admin','admin123','Admin','Active','2025-03-15')
SELECT * FROM USERS WHERE status = 'Staff'