# Dungeons & Dragons Cartoon Character API

#### An API that houses character information for the beloved 1983 cartoon series

#### By Scott Hutley and Erica Marroquin

## Technologies Used

* _C#_
* _.Net 5.0_
* _.Net ef_
* _ASP.NET Core_
* _NuGet_
* _Swagger_

## Description

This API was built primarily as a test case for implimenting and using Swagger. There is no front-end programming. However if the user desires, Swagger generates the proper Request URL response for each GET request which can subsequently be pasted directly into the web browser where it will be displayed as a JSON.

## Setup/Installation

#### Technology Requirements

* .NET 5
* VS Code or other text editor
* MySQL Workbench

#### Cloning and Database Creation

* Clone this repository to your desktop
* Open with text editor and navigate into DungeonsDragons.Solution/DungeonsDragons folder
* Create an appsettings.json file
* Add the following code to the appsettings.json:
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=dungeons_dragons;uid=root;pwd=YOUR_PASSWORD;"
  }
}
```
* Replace "YOUR_PASSWORD" in the above code with your own personal MySql password
* Open a Windows Powershell terminal (or Mac equivalent)
* In that terminal run *mysql -uroot -p<YOUR_PASSWORD>* (again, replacing with your actual password)
* Open MySQL Workbench
* Return to your text editor
* Navigate to the DungeonsDragons.Solution/DungeonsDragons folder level (if you are not already there)
* Run *dotnet restore*
* Run *dotnet build*
* Run *dotnet ef database update*
* Run *dotnet run*
* Enter http://localhost:5000 into your web browser to bring up the DungeonsDragons API with Swagger

## How To Use Swagger

Swagger allows us to visualize our API endpoints without any implementation logic in place. To use any of the Swagger functions (GET, POST, PUT, DELETE) click on the respective button then click on the "Try it out" button.

## API Endpoints

Base URL: http://localhost:5000

GET requests:

For complete list of characters:   /api/Characters

To find characters by name:   /api/Characters?name="Name"

To find characters by profession:    /api/Characters?profession="Profession"

To find characters by weapon:   /api/Characters?weapon="Weapon"

To find characters by age:    /api/Character?age="Age"

To find characters by gender:    /api/Character?gender="Gender"

To find character by ID number:   /api/Characters/{id} where {id} is the ID of the character being searched for


POST requests:

Format POST requests in the following way:
```
{
  "characterId": {id},
  "name": "string",
  "profession": "string",
  "weapon": "string",
  "age": "string",
  "gender": "string"
}
```

Note that quotations are required around each string entry. Example, to enter a character named Scott, the entry needs to be "Scott".

In addition, while characterId needs to be entered, you must enter an Id number that does not already exist.


PUT requests:

To edit a single character:   /api/Characters/{id} where {id} is the ID of the character to edit
Request body must be formatted as following:
```
{
  "characterId": {id},
  "name": "string",
  "profession": "string",
  "weapon": "string",
  "age": "string",
  "gender": "string"
}
```

DELETE requests:
To delete a single character:   /api/Characters/{id} where {id} is the ID of the character to delete


## Known Bugs

* Not a bug, just an acknowledgement that there is absolutely no front end to this project. And there never will be!!!!!!!!!!!!!!!

## License

_[MIT](https://opensource.org/licenses/MIT)_

Copywrite(c)2021 Scott Hutley and Erica Marroquin

## Contact Information

Scott Hutley: scotthutley1@comcast.net
Erica Marroquin:  ericamarroquin03@gmail.com