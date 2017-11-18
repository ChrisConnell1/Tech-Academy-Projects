CREATE PROC GetLostTribeAtSharpstown
AS
BEGIN
/** PROC 1: Selects the number of copies of The Lost Tribe from Sharpstown **/
	SELECT No_of_Copies AS 'Number of Copies of The Lost Tribe' FROM book_copies a
	INNER JOIN library_branch b ON a.BranchID = b.BranchID
	INNER JOIN tbl_book c ON c.BookID = a.BookID
	WHERE BranchName = 'Sharpstown' AND
	Title = 'The Lost Tribe'
END


CREATE PROC GetLostTribeAllBranches
AS
BEGIN
/** PROC 2 Selects number of copies of The Lost Tribe from each branch**/
SELECT No_of_Copies, BranchName FROM book_copies a
INNER JOIN tbl_book b ON a.BookID = b.BookID
INNER JOIN library_branch c ON a.BranchID = c.BranchID 
WHERE Title = 'The Lost Tribe'
END


CREATE PROC GetBorrowersNoBooks
AS
BEGIN
/** PROC 3  Selects the names of borrowers with no books out... currently (11/15/17) every borrower has at least one book out**/
SELECT Name FROM tbl_borrower a
INNER JOIN book_loans b ON a.CardNo = b.CardNo
WHERE GETDATE() > b.DueDate
END

CREATE PROC GetTitleNameAddressIfDueTodaySharpstown
AS
BEGIN
/** PROC 4 Selects title, borrower and their address from Sharpstown if due date is today **/
SELECT Title, Name, c.Address FROM tbl_book a
INNER JOIN book_loans b ON a.BookID = b.BookID
INNER JOIN tbl_borrower c ON b.CardNo = c.CardNo
INNER JOIN library_branch e ON e.BranchID = b.BranchID
WHERE BranchName = 'Sharpstown'
AND CONVERT(date,DueDate) = CONVERT(DATE,getdate())
END

CREATE PROC GetBooksOutByBranch
AS
BEGIN
/** PROC 5 Selects Branch name, and total number of books loaned from each branch **/
SELECT BranchName, COUNT(BookID) AS SumOfLoanedBooks FROM library_branch a
INNER JOIN book_copies b ON a.BranchID = b.BranchID
GROUP BY BranchName;
END

CREATE PROC GetBorrowerDetailsMoreThan5
AS
BEGIN
/** PROC 6 Selects name, address, and number of books if borrower has more than 5 books out **/
SELECT Name, Address, COUNT(BookID) AS TotalBooksOut FROM tbl_borrower a
INNER JOIN book_loans b ON a.CardNo = b.CardNo
GROUP BY Name, Address
HAVING COUNT(BookID) > 5;
END

CREATE PROC CentralCopies_StephenKing
AS
BEGIN
/** PROC 7 Selects title, and number of copies of books authored by S. King at Central branch **/
SELECT Title, No_of_copies FROM tbl_book a
INNER JOIN tbl_book_authors b ON a.BookID = b.BookID
INNER JOIN book_copies c ON c.BookID = a.BookID
INNER JOIN library_branch e ON e.BranchID = c.BranchID
WHERE b.AuthorName = 'Stephen King' 
AND e.BranchName = 'Central'
END


CREATE PROC GetCopiesBranchInputAuthor 
(@author VARCHAR(30))
AS
BEGIN

/** PROC 8 Takes in author name and returns number of title and number of copies **/
SELECT Title, No_of_copies, BranchName FROM tbl_book a
INNER JOIN tbl_book_authors b ON a.BookID = b.BookID
INNER JOIN book_copies c ON c.BookID = a.BookID
INNER JOIN library_branch e ON e.BranchID = c.BranchID
WHERE b.AuthorName = @author
END

EXEC [dbo].[GetCopiesBranchInputAuthor] 'Anthony Burgess'