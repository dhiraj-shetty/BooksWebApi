<b>Books Repository: Simple CRUD operations using .Net Core Web API.</b>

<b>System Requirements:</b> <br>
<br>
Visual Studio 2019 latest version <br>
.Net 5.0 SDK <br>
SQL Server 2019 Express <br>
 <br>
Before running the App, Set the Correct DB connection (String) at: <br>
https://github.com/dhiraj-shetty/BooksWebApi/blob/1b2512e2af5660276d99dc560cf777a0968637f9/my-books/appsettings.json#L11 <br>

<b>Goal of the App:</b> <br>
<br>
The ideal purpose of a WebAPI is to provide a liason between the end user and the data he/she requires. All this, by abstracting from the user the intricacies of what it takes to create and maintain the data <br>
<br>
As an Analogy compare this to the Charging of one's mobile phone using an electric socket. The user has no idea of how the electricity is generated and how it is maintained. The only requirement is that the specification of the socket should match the requirements of the phone charger. In other words WebAPIs help disparate systems communicate towards attaining a higher goal. <br>
<br>
The example in hand is that of a User wanting to know complete details of the books in his/her library, which includes (but is not limited to):
1. The Book Title
2. A Short Description
3. Whether the book has been completed read? If yes then when, and what rating does the book deserve?
4. Genre of the Book
5. Author
6. Cover Image
7. Date Purchased/Added to Repository.
<br>
The user needs to have access to create, read, update, and delete (CRUD) the entries of books in his library.
