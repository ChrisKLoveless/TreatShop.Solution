# Treat Shop

#### Description
Epicodus Week 12 Code Review

## Contributors

* Chris Loveless

## Description
This independent project demonstrates proficiency with many to many relationships, user authentication using Identity, and authorization using roles. The user can view lists of Treats and Flavors, however the user must sign in or register an account before they can Create, Update, or Delete any of the classes or joined entities.

## Technologies Used

* _C#_
* _Html_
* _CSS_
* _ASP .NET6_
* _MySQL_
* _MVC_
* _Entity Framework Core_

## Setup/Installation Requirements

* Install MySQL Community Server and MySQL Workbench. Follow the instructions _[here](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql/)_.
* Clone down the git repo ```https://github.com/ChrisKLoveless/TreatShop.Solution.git``` to the ```desktop``` directory
* Open the project with VSCode or a different source code editor.
* Restore required packages: change directory to ```TreatShop``` and restore with ```$ dotnet restore```
* While in the ```TreatShop``` directory use ```$ dotnet build``` to build the program.
* While in the ```TreatShop``` directory use ```$ dotnet watch run``` to run the program in the browser with a watcher.

## Database Setup

* To connect your database, create file ```appsettings.json``` in the production directory ```TreatShop```
* Fill in the file with the following code: Be sure to replace the required fields marked with ```[]``` that must contain the database name, user id, and password.
```
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=[DB-NAME-HERE];uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
    }
}
```
## Known Bugs

* If any bugs are found please email a brief description to: ```chriskloveless@gmail.com```

## License
Copyright (c) 2022 Chris Loveless
_[MIT](https://choosealicense.com/licenses/mit/)_