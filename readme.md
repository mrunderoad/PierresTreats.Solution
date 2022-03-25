# _Pierres Sweet and Savory Treats_

### _By: Isaac Overstreet_

#### _This application lets users add treats, and Flavors using a many to many database relationship with c# .NET. And authentication with Identity._

## Technologies Used

* _C#_
* _MySQL_
* _cshtml_
* _css_
* _Bootstrap_
* _Entity Framework_
* _.NET_
* _Identity_

## Description

_This application is designed to display knowledge on authentication and databases using C#. Made for Epicodus c# course. Its meant to simulate a bakery site with Flavors and Treats to choose from. Logged in users have full CRUD functionality. Users who are not logged in may view all and search for flavors/treats but have no other access._

## Setup/Installation Requirements

* _Make sure you have MySQL Workbench installed._
* _Clone this repository to your desktop from `https://github.com/mrunderoad/PierresTreats.Solution`_
* _Navigate to the HairSalon directory in your terminal using `cd Pierres`._
* _Inside the `Pierres` directory, add a new file named `appsettings.json`._
* _Inside the `appsettings.json` file, add this code with your database, username and password in the specified places in the code._ 
```c#
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=DATABASE HERE;uid=USERNAME;pwd=PASSWORD;"
  }
}
```
* _Inside the `Pierres` directory, run `dotnet ef database update` to create a database based off the migrations folder included in the repository._
* _Run `dotnet restore` to restore the obj and bin folders._
* _Run `dotnet build` to build the project._
* _Run `dotnet run` to start a localhost. `ctrl+click` on the localhost option in your terminal to view the project in your browser._

## Known Bugs

* _No known bugs at this time._

## License

[MIT](https://opensource.org/licenses/MIT)

_Copyright (c) 2022  Isaac Overstreet_