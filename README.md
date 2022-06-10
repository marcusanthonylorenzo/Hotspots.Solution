# HotspotsAPI
#### By _**Marcus Lorenzo**_



### A simple API which returns a list of some of the most trending restaurants in Australia

![https___localhost_5001_api_Restaurants - Google Chrome 2022-06-10 12-18-32](https://user-images.githubusercontent.com/100096239/173136319-81ad15cd-4ee6-4eb8-997f-e1c6f7335cfa.gif)



---

| **_Overview_:** |
|---|


#### Technologies Used:
![image](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![image](https://img.shields.io/badge/MySQL-005C84?style=for-the-badge&logo=mysql&logoColor=white)
![image](https://img.shields.io/badge/HTML5-E34F26?style=for-the-badge&logo=html5&logoColor=white)  ![image](https://img.shields.io/badge/CSS3-1572B6?style=for-the-badge&logo=css3&logoColor=white)
![image](https://img.shields.io/badge/GIT-E44C30?style=for-the-badge&logo=git&logoColor=white)
#### ASP.NET MVC 5 - Entity Framework - Postman

---


| **_Description_:** |
|---|

- Attempted Response Pagination via this tutorial: `https://codewithmukesh.com/blog/pagination-in-aspnet-core-webapi/#What_we_will_be_Building`

---

| HTTP Request Endpoints |
|---|

```
Example endpoint:
https://localhost:5001/api/Restaurants

GET (Individual Restaurant): /api/Restaurants/{id}
GET: /api/Restaurants
POST: /api/Restaurants
PUT: /api/Restaurants/{id}
DELETE: /api/Restaurants/{id}
```

The response will return an individual object or array of objects depending on request, in such manner:

```
...
    {
        "name": "Red Sparrow Pizza",
        "id": 12,
        "city": "Collingwood",
        "cuisine": "Vegan/Pizza"
    }
...   
 
```

---

| **_Setup & Installation_:** |
|---|

|   via CLI   |
|---|
| Download install Git Bash (Windows), use the terminal in your text editor, or open Terminal(Mac) 
| Open Git Bash or Terminal and type: `cd desktop` 
| Next, clone ` https://github.com/marcusanthonylorenzo/Hotspots.Solution` 
| Once completed, open this new directory in your text editor
| In the root directory, create a file called `appsettings.json`.
| Inside this file write:
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=marcus_lorenzo;uid=root;pwd=epicodus;"
  }
}
```

| ...continued |
|---|
| Next, go to your terminal and run `dotnet restore`, followed by `dotnet watch run`.
| Access the site via the `LocalHost` link provided in the terminal.
| **Save and you are ready to go!**

 
<!-- |  MySQL Setup  |
|---|
| In your MySQL Workbench, click Connect to Database, Stored Connection:  Local instance 3306
**Must match the `Port=3306;` in the `"DefaultConnection"` query inside your `appsettings.json` file.**
| In **Schemas Navigator** in the Navigator bar on the left, right-click and select "Create Schema".
| The name of the new Schema **must match the `database=marcus_lorenzo;` in the `"DefaultConnection"` query inside your `appsettings.json` file.**
| Once loaded, go to your new Schema tree in the Navigator bar on the left, click down to Tables, right click "Create Table".
| Your details should look like this:

[Image of applied tables here] -->

#### Running Tests:
- To view tests via MSTest, in your CLI type `dotnet test`.

#### Known Bugs:


---
| **_License_:** |
|---|

[MIT]()

Copyright (c) 2022 _Marcus Lorenzo_


#### Thanks for viewing!
