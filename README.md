# JournalApi

## Minimal API Journal  

A simple ASP.NET Core Minimal API demonstrating middleware, routing, query parameters, JSON responses, and HTTP status codes. 

## Running the Project  

Run the following command: 
dotnet run  
Then use the localhost URL shown in the terminal.  

## Endpoints  

GET /  
Returns a plain text greeting.  

## Example response:  

Hello, ASP.NET  
GET /time  
Returns the current UTC time as JSON.  

## Example response:  

{  
  "time": "2026-09-07T04:12:45.1234567Z"  
}  

GET /echo?msg=Hello  
Returns the provided mesage and its length.  

## Example response:  

{  
  "message": "Hello",  
  "length": 5  
}  
If the msg parameter is not provided, the API returns to HTTP 400 Bad Request.  

## Example error response: 

{  
  "error": "The msg parameter is required."  
}  

## Middleware:

Every response includes the following header:  
API: JournalApi 
