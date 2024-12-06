# MvcLibrary

# Library Management System

This project is developed as an ASP.NET Core MVC application, providing a comprehensive system to manage books and authors in a library. The application enables basic CRUD (Create, Read, Update, Delete) operations for books and authors.

## Project Overview

This project is designed to manage the relationships between books and authors in a library management system. Models for books and authors are created, relationships are established between these models, and Controllers and Views are developed for managing these entities. Additionally, a completely custom frontend is built using Bootstrap, CSS, and HTML.

## Technologies

- **Backend:** ASP.NET Core MVC
- **Frontend:** HTML, CSS, Bootstrap (custom-written)
- **Database:** Entity Framework Core (Code First approach)
- **Other:** C#, JavaScript

## Project Structure

### 1. **Model**
The project contains two main models:

- **Book Model:** Contains information related to books (Title, Author, Genre, Publish Date, ISBN, Copies Available).
- **Author Model:** Contains information related to authors (First Name, Last Name, Date of Birth).

### 2. **ViewModel**
ViewModels are used for displaying lists of books and authors, as well as for showing their detailed information.

### 3. **Controller**
Controllers manage the operations for books and authors, with methods for:

- **BookController:** CRUD operations for books (List, Details, Create, Edit, Delete).
- **AuthorController:** CRUD operations for authors (List, Details, Create, Edit).

### 4. **View**
The views for managing books and authors are:

- **Book Views:**
  - List: Displays a list of books.
  - Details: Shows detailed information about a book.
  - Create: A form to add a new book.
  - Edit: A form to edit an existing book.
  - Delete: A confirmation page for deleting a book.

- **Author Views:**
  - List: Displays a list of authors.
  - Details: Shows detailed information about an author.
  - Create: A form to add a new author.
  - Edit: A form to edit an existing author.

### 5. **Frontend**
The frontend of the project is built with Bootstrap, CSS, and HTML. A fully custom design is implemented, providing a user-friendly interface that is responsive and adjusts well across various devices.

## Project Features

- **CRUD Operations:** Create, read, update, and delete functionality for books and authors.
- **Database Integration:** Uses Entity Framework Core for database management with a relational model.
- **Responsive Design:** The design is built with Bootstrap and custom CSS to ensure compatibility across different devices.
- **Layout and Partial Views:** A layout has been added, and Partial Views are used to make the page components dynamic.

## Testing

Testing for this project was carried out manually. The following methods were used to ensure the application's functionality:

- **Manual Testing:** The application was thoroughly tested by performing various CRUD operations on both books and authors. The functionality of creating, editing, deleting, and viewing records was checked to ensure it works as expected.
  
- **Validation:** After performing CRUD operations, the changes were validated by checking the user interface to see if the updated information was reflected properly.

- **Cross-Browser Testing:** The frontend design was tested across different browsers to ensure compatibility.

By manually testing the system, I ensured that all features are working correctly, and the application is free from major issues.
