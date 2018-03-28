USE MASTER
GO
DROP DATABASE Library
GO
CREATE DATABASE Library
GO

USE Library


CREATE TABLE tbl_book (
	BookID int PRIMARY KEY NOT NULL IDENTITY (1,1),
	Title VARCHAR(50) NOT NULL,
	PublisherName VARCHAR(50) NOT NULL
	)

CREATE TABLE tbl_book_authors (
	BookID int FOREIGN KEY REFERENCES tbl_book(BookID) NOT NULL,
	AuthorName VARCHAR(50)
	)

CREATE TABLE tbl_publisher (
	Name VARCHAR(50) NOT NULL,
	Address VARCHAR(50) NOT NULL,
	Phone VARCHAR(15) NOT NULL
	)

CREATE TABLE library_branch (
	BranchID int PRIMARY KEY NOT NULL IDENTITY(100,1),
	BranchName VARCHAR(30) NOT NULL,
	Address VARCHAR(50)
	)

CREATE TABLE book_loans (
	BookID int FOREIGN KEY REFERENCES tbl_book(BookID) NOT NULL, 
	BranchID int NOT NULL,
	CardNo int NOT NULL,
	DateOut date NOT NULL,
	DueDate date NOT NULL
	)

CREATE TABLE book_copies (
	BookID int FOREIGN KEY REFERENCES tbl_book(BookID) NOT NULL, 
	BranchID int NOT NULL,
	No_Of_Copies int NOT NULL
	)



CREATE TABLE tbl_borrower (
	CardNo int PRIMARY KEY NOT NULL,
	Name VARCHAR(50) NOT NULL,
	Address VARCHAR(50) NOT NULL,
	Phone VARCHAR(15)
	)


INSERT INTO tbl_book
	(Title, PublisherName)
	VALUES
	('The Lost Tribe', 'Penguin'),
	('Jurassic Park', 'Alfred Knopf'),
	('IT', 'Simon And Schuster'),
	('Slaughterhouse Five', 'Dell'),
	('Catcher In The Rye', 'Little'),
	('The Sun Also Rises', 'Watchers'),
	('Catch-22','Enigma'),
	('Fahrenheit 451', 'WhoKnows'),
	('The Assistant', 'Satriani'),
	('A Clockwork Orange','Heinemann'),
	('Light In August', 'Penguin'),
	('Infinite Jest', 'Alfred Knopf'),
	('American Gods', 'Simon And Schuster'),
	('Atonement', 'Dell'),
	('Beloved', 'Large'),
	('To Kill A Mockingbird', 'Watch This'),
	('1984','Eras'),
	('Lolita', 'Brother'),
	('One Flew Over The Cuckoo''s Nest', 'Hendrix'),
	('Gone With the Wind','Heinemann');

INSERT INTO tbl_book_authors
	(AuthorName, BookID)
	VALUES
	('Mark Lee', 1),
	('Michael Crichton', 2),
	('Stephen King', 3),
	('Kurt Vonnegut', 4),
	('JD Salinger', 5),
	('Ernest Hemmingway', 6),
	('Joseph Heller', 7),
	('Ray Bradbury', 8),
	('Bernard Malamud', 9),
	('Anthony Burgess', 10),
	('William Faulkner', 11),
	('David Wallace', 12),
	('Neil Gaiman', 13),
	('Salvador Dali', 14),
	('Fred Flinstone', 15),
	('Betty Rubble', 16),
	('Michael Scott', 17),
	('Pam Beesly', 18),
	('Adam DeBeers', 19),
	('Neil Peart', 20);

	/** TESTING THE LINK **/

	SELECT * FROM tbl_book
	INNER JOIN tbl_book_authors ON tbl_book.BookID = tbl_book_authors.BookID;

	INSERT INTO tbl_publisher
	(Name, Address, Phone)
	VALUES
	('Penguin', '312 N St.', '503-333-2312'),
	('Alfred Knopf', '4500 S 12th', '340-111-2315'),
	('Simon and Schuster', '1200 NE Blah St','234-343-6414'),
	('Dell','8000 NE Rogers St','213-111-4859'),
	('Little','44 N James Rd','385-123-3254'),
	('Watchers','122 SW 73rd pl','543-353-2224'),
	('Enigma','544 NE Red Rd','665-234-2346'),
	('WhoKnows','334 Never St','232-657-0095'),
	('Satriani','1222 SW 102nd Ave','342-550-4985'),
	('Heinemann','1232 SE 102nd Ave','304-323-4466'),
	('Penguin','312 N St.','503-333-2312'),
	('Alfred Knopf', '4500 S 12th', '340-111-2315'),
	('Simon and Schuster','1200 NE Blah St','234-343-6414'),
	('Dell','8000 NE Rogers St','213-111-4859'),
	('Large','120 SW Thata Way','808-223-5422'),
	('Watch This', '1232 Whicha Way','556-345-2356'),
	('Eras','8684 Where Dr','123-122-1122'),
	('Brother','322 SW Scholls Ferry','122-112-1997'),
	('Hendrix','211 Jimmy Ln','800-122-1556'),
	('Heinemann','1232 SE 102nd Ave','304-323-4466');

SELECT * FROM tbl_publisher 
SELECT DISTINCT * FROM tbl_book
INNER JOIN tbl_book_authors ON tbl_book.BookID = tbl_book_authors.BookID
INNER JOIN tbl_publisher ON tbl_book.PublisherName = tbl_publisher.Name;


	INSERT INTO book_loans
	(BookID,BranchID,CardNo,DateOut,DueDate)
	VALUES
	(1,100,'5448','2017-11-02','2017-12-02'),
	(1,102,'2332','2017-11-08','2017-12-08'),
	(1,101,'1118','2017-11-13','2017-12-13'),
	(2,101,'1090','2017-10-18','2017-11-18'),
	(2,100,'5448','2017-11-02','2017-12-02'),
	(3,102,'2332','2017-11-08','2017-12-08'),
	(3,101,'4432','2017-11-07','2017-12-07'),
	(3,101,'1118','2017-11-13','2017-12-13'),
	(4,103,'2113','2017-11-02','2017-12-02'),
	(4,101,'1090','2017-10-18','2017-11-18'),
	(4,103,'5009','2017-11-10','2017-12-10'),
	(5,101,'1100','2017-11-05','2017-12-05'),
	(5,103,'2113','2017-11-02','2017-12-02'),
	(5,100,'5448','2017-11-02','2017-12-02'),
	(6,100,'6683','2017-11-19','2017-12-19'),
	(6,101,'1118','2017-11-13','2017-12-13'),
	(6,103,'5009','2017-11-10','2017-12-10'),
	(7,102,'2232','2017-11-12','2017-12-12'),
	(7,103,'2113','2017-11-02','2017-12-02'),
	(7,100,'6683','2017-11-19','2017-12-19'),
	(8,103,'4344','2017-11-11','2017-12-11'),
	(8,101,'1090','2017-10-18','2017-11-18'),
	(9,101,'1090','2017-10-18','2017-11-18'),
	(9,102,'2232','2017-11-12','2017-12-12'),
	(10,102,'2232','2017-11-12','2017-12-12'),
	(10,101,'1090','2017-10-18','2017-11-18'),
	(10,103,'5009','2017-11-10','2017-12-10'),
	(11,101,'1090','2017-10-18','2017-11-18'),
	(11,102,'2332','2017-11-08','2017-12-08'),
	(12,101,'1090','2017-10-18','2017-11-18'),
	(12,101,'1118','2017-11-13','2017-12-13'),
	(13,103,'4344','2017-11-11','2017-12-11'),
	(13,101,'1100','2017-11-05','2017-12-05'),
	(14,103,'4344','2017-11-11','2017-12-11'),
	(14,101,'1100','2017-11-05','2017-12-05'),
	(15,103,'4344','2017-11-11','2017-12-11'),
	(15,101,'4432','2017-11-07','2017-12-07'),
	(16,103,'4344','2017-11-11','2017-12-11'),
	(16,103,'5009','2017-11-10','2017-12-10'),
	(16,101,'1100','2017-11-05','2017-12-05'),
	(17,103,'4344','2017-11-11','2017-12-11'),
	(17,101,'1090','2017-10-18','2017-11-18'),
	(17,100,'6683','2017-11-19','2017-12-19'),
	(18,103,'4344','2017-11-11','2017-12-11'),
	(18,101,'1118','2017-11-13','2017-12-13'),
	(18,101,'1090','2017-10-18','2017-11-18'),
	(19,102,'2332','2017-11-08','2017-12-08'),
	(19,101,'1118','2017-11-13','2017-12-13'),
	(19,100,'6683','2017-11-19','2017-12-19'),
	(20,102,'2332','2017-11-08','2017-12-08'),
	(20,101,'4432','2017-11-07','2017-12-07'),
	(20,103,'5009','2017-11-10','2017-12-10');


	SELECT * FROM book_loans
	/** END BOOK LOANS **/

	/** BOOK COPIES **/

	INSERT INTO book_copies
	(BookID,BranchID,No_Of_Copies)
	VALUES
	(1,100,3),
	(1,101,2),
	(1,102,2),
	(1,103,3),
	(2,100,3),
	(2,101,2),
	(2,102,2),
	(2,103,3),
	(3,100,3),
	(3,101,2),
	(3,102,2),
	(3,103,3),
	(4,100,3),
	(4,101,2),
	(4,102,2),
	(4,103,3),
	(5,100,3),
	(5,101,2),
	(5,102,2),
	(5,103,3),
	(6,100,3),
	(6,101,2),
	(6,102,2),
	(6,103,3),
	(7,100,3),
	(7,101,2),
	(7,102,2),
	(7,103,3),
	(8,100,3),
	(8,101,2),
	(8,102,2),
	(8,103,3),
	(9,100,3),
	(9,101,2),
	(9,102,2),
	(9,103,3),
	(10,100,3),
	(10,101,2),
	(10,102,2),
	(10,103,3),
	(11,100,3),
	(11,101,2),
	(11,102,2),
	(11,103,3),
	(12,100,3),
	(12,101,2),
	(12,102,2),
	(12,103,3),
	(13,100,3),
	(13,101,2),
	(13,102,2),
	(13,103,3),
	(14,100,3),
	(14,101,2),
	(14,102,2),
	(14,103,3),
	(15,100,3),
	(15,101,2),
	(15,102,2),
	(15,103,3),
	(16,100,3),
	(16,101,2),
	(16,102,2),
	(16,103,3),
	(17,100,3),
	(17,101,2),
	(17,102,2),
	(17,103,3),
	(18,100,3),
	(18,101,2),
	(18,102,2),
	(18,103,3),
	(19,100,3),
	(19,101,2),
	(19,102,2),
	(19,103,3),
	(20,100,3),
	(20,101,2),
	(20,102,2),
	(20,103,3)
	

	SELECT * FROM book_copies a
	INNER JOIN tbl_book b ON a.BookID = b.BookID; 


	/** END BOOK COPIES **/

	/** BEGIN BORROWERS **/

	/** This counts number of borrowers set by card number
	SELECT COUNT(DISTINCT CardNo) FROM book_loans; 
	And the distinct card numbers themselves
	SELECT DISTINCT CardNo FROM book_loans; **/ 
	
	INSERT INTO tbl_borrower
	(CardNo,Name,Address,Phone)
	VALUES
	(1090,'Jane Doe','112 SE Thor Rd','503-900-3432'),
	(1100,'Steven Merchant','567 West Union Rd','643-704-3230'),
	(1118,'Dwayne Johnson','4500 N Going St','541-322-0085'),
	(2113,'Chris Connell','7300 SW 45th Ave','971-221-4598'),
	(2232,'Terry Love','2435 N Alberta St','971-112-3430'),
	(2332,'Josh Gaines','1200 SW Haines Rd','503-409-6898'),
	(4344,'Misha Pfliger','809 SE 18th St','435-697-3567'),
	(4432,'Sean Madsourivong','360 SE 8th Ave','260-233-1265'),
	(5009,'Chris Meza','143 N Mississippi Rd','971-458-0049'),
	(5448,'Jim Halpert','650 SW Garden Home Rd','435-233-8705'),
	(6683,'Jeff Jones','450 SW Portland Rd','971-668-5245')

	/** This is SUPPOSED TO return the borrowers who have more than 5 books out
	SELECT Name FROM tbl_borrower a
	INNER JOIN book_loans b ON a.CardNo = b.CardNo
	HAVING COUNT(DISTINCT BookID) > 5; **/

    INSERT INTO library_branch
	(BranchName,Address)
	VALUES
	('Sharpstown','788 N Roper Rd'),
	('Central','948 SE Haugh St'),
	('Scranton','345 S River Rd'),
	('Powells','239 NW Grove Dr')

	SELECT * FROM library_branch a
	INNER JOIN book_copies b
	ON a.BranchID = b.BranchID;

