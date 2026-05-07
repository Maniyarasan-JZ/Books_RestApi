# Books REST API

A simple ASP.NET Core Web API for managing books using CRUD operations.

## Features

- Get all books
- Get book by ID
- Create book
- Update book
- Delete book
- Validation using Data Annotations
- In-memory storage using List<Book>

## Technologies Used

- ASP.NET Core Web API
- C#
- REST API
- Postman
- Git & GitHub

## API Endpoints

| Method | Endpoint | Description |
|---|---|---|
| GET | /api/books | Get all books |
| GET | /api/books/{id} | Get book by ID |
| POST | /api/books | Create new book |
| PUT | /api/books/{id} | Update book |
| DELETE | /api/books/{id} | Delete book |

## Validation

- Title is required
- Author is required

## Testing

API tested using Postman.

Postman collection included in repository.
