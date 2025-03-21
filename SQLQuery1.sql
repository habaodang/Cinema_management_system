USE Cinema_management;

GO

CREATE TABLE movies
(
	id INT PRIMARY KEY IDENTITY(1,1),
	movie_id VARCHAR(MAX) NULL,
	movie_name NVARCHAR(MAX) NULL,
	genre NVARCHAR(MAX) NULL,
	price FLOAT NULL,
	capacity INT NULL,
	movie_image  VARCHAR(MAX) NULL,
	created_at DATETIME NULL,
	update_date DATE NULL,
	delete_date DATE NULL
)




