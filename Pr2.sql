CREATE DATABASE library;
USE library;

CREATE TABLE books (
    id INT AUTO_INCREMENT PRIMARY KEY,
    title VARCHAR(50),
    author VARCHAR(50),
    year INT
);

INSERT INTO books (title, author, year) VALUES 
('The Hunger Games', 'Suzanne Collins', 2008),
('The Maze Runner', 'James Dashner', 2009),
('A Story of Yesterday', 'Sergio Cobo', 2014);

SELECT * FROM books;

CREATE PROCEDURE get_even_year_books()
SELECT * FROM books WHERE year % 2 = 0;

CALL get_even_year_books();
