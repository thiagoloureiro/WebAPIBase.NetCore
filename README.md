# WebAPIBase
WebAPI (.NET Core 2.0) Base Project with JWT Auth, Dapper (ORM), MySQL, Password Hash, Swagger

## Instalation / Configuration Steps:

1) Clone the repository
git clone https://github.com/thiagoloureiro/WebAPIBase.NetCore.git

2) Open the Solution file (Visual Studio 2017)

3) Create a Database (any desired name) in MySQL, you can use an existing one.

4) Modify **appsettings.json** file in **WebAPI Project**, connectionstring:
   ```
     "AppSettings": {
    "MySqlConnectionString": "Server=server;Port=123456;Database=DB;Uid=USRID;Pwd=PASSWD;"
   ```
Modify using your values.

5) Run the User table Script (Located in DB Project)
```
CREATE TABLE User (
    `Id`             INT            AUTO_INCREMENT  NOT NULL,
    `Name`           VARCHAR (50)   NULL,
    `Surname`        VARCHAR (50)   NULL,
    `Email`          VARCHAR (50)   NULL,
    `Phone`          NCHAR (10)     NULL,
    `LastLogon`      DATETIME (6)  NULL,
    `CreatedOn`      DATETIME (6)  NULL,
    `ActivationCode` INT            NULL,
    `Login`          VARCHAR (50)   NOT NULL,
    `Password`       VARCHAR (50)   NOT NULL,
    CONSTRAINT `PK_User` PRIMARY KEY (`Id` ASC)
);

```

6) Run the Project.

7) After run the project, in the address bar you will have something like: http://localhost:52915/ (the port may change) add swagger to address, for ex: http://localhost:52915/swagger, a Swagger page should be displayed.

8) You will notice 2 endpoints, **api/user** and **api/user/create**, the first one is to login and the second one to create a new user to generate the token for the JWT Authentication.

9) Access the **/api/user/create** endpoind and create a new user, you should receive a result "User Created Successfully! :)"

10) Test Login with the Created User in the **/api/user** endpoint, with the following request
```
{
  "username": "UserNameHere",
  "password": "PasswordHere"
}
```
11) You Should receive a ReponseBody like this:
```
{
  "Id": 2,
  "Name": null,
  "Surname": null,
  "Email": null,
  "Phone": null,
  "LastLogon": "2017-09-29T23:00:56.3166667",
  "CreatedOn": "2017-09-29T23:00:56.3166667",
  "ActivationCode": null,
  "Login": null,
  "Password": null,
  "Token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6InRlIiwibmJmIjoxNTA2NzE4ODk0LCJleHAiOjE1MDY3MjAwOTQsImlhdCI6MTUwNjcxODg5NH0.L5LEVLclhj8MSx4stFO44HYRkkdVwb3Pk_ILejRtqVA"
}
```

12) Now you are all set, just create the other Controllers following the patterns and rock on :)
Remember to dot use the **[AllowAnonymous]**  from the other Controllers you are going to create, because with this property will ignore and you can access the API Without Authentication.

13) To use Authentication for example using Postman, in the HEADER add a Key called "Authorization" **(without quotes)** and Value add: Bearer "the received token from the login" **(without quotes)**

14) Any Questions please feel free to ask ! :)

Enjoy!

