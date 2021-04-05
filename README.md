# contacts-api

**Solution Name - ContactsAPI.sln**

1. Deployed Swagger documentation - http://40.88.8.34/Swagger/index.html
2. API URL - http://40.88.8.34/Contacts 
*Note - deployed application is only on http as of now. security can be added later

API Project name  - ContactsAPI
Technology - ASP.Net Core API

**ContactModel**

 1. ID 
 2. FirstName - Required 
 3. LastName - Required
 4. Email  - Required(With proper email address format)
 5. PhoneNumber -Required
 5. LoggedInUser - Required 
 6. Status -Required
 
**Seperate generic persistance layer is added(Evolent.Persistance)**
 1. Database used - RavenDB
 2. API is loosly coupled from the database as database provider and context can be changed easily without affecting the API

Unit test project is added for the API howevere all test cases are not covered.

**Design Patterns/Packages Used**

1. Dependancy Injection
2. Retry pattern for resiliency
3. SWagger
4. Automapper
5. Application Insights - solution can be extended as of now just added package. custom logging can be done using Application Insights
6. Added CORS global policies
7. NUnit with moq
