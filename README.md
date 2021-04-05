# contacts-api

Solution Name - ContactsAPI.sln

Deployed Swagger documentation - http://40.88.8.34/Swagger/index.html
API URL - http://40.88.8.34/Contacts 
*Note - deployed application is only on http as of now. security can be added later

API Project name  - ContactsAPI
Technology - ASP.Net Core API

ContactModel

 ID 
 FirstName - Required 
 LastName - Required
 Email  - Required(With proper email address format)
 PhoneNumber -Required
 LoggedInUser - Required 
 Status -Required
 
Seperate generic persistance layer is added(Evolent.Persistance)
Database used - RavenDB
API is loosly coupled from the database as database provider and context can be changed easily without affecting the API

Unit test project is added for the API howevere all test cases are not covered.

Design Patterns/Packages Used - 
1. Dependancy Injection
2. Retry pattern for resiliency
3. SWagger
4. Automapper
5. Application Insights - solution can be extended as of now just added package. custom logging can be done using Application Insights
