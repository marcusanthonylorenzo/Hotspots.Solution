# HotspotsAPI
#### By _**Marcus Lorenzo**_



### A simple API using pagination, which returns a list of some of the most trending restaurants in Australia.

![https___localhost_5001_api_Restaurants - Google Chrome 2022-06-10 12-18-32](https://user-images.githubusercontent.com/100096239/173136319-81ad15cd-4ee6-4eb8-997f-e1c6f7335cfa.gif)



---


#### Technologies Used:
![image](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![image](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![image](https://img.shields.io/badge/MySQL-005C84?style=for-the-badge&logo=mysql&logoColor=white)
![image](https://img.shields.io/badge/HTML5-E34F26?style=for-the-badge&logo=html5&logoColor=white)  ![image](https://img.shields.io/badge/CSS3-1572B6?style=for-the-badge&logo=css3&logoColor=white)
![image](https://img.shields.io/badge/GIT-E44C30?style=for-the-badge&logo=git&logoColor=white)
![image](https://img.shields.io/badge/Postman-FF6C37?style=for-the-badge&logo=Postman&logoColor=white)

* including: ASP.NET 5 MVC, VSCode

---


| **_Description_:** |
|---|

- Attempted Response Pagination via this tutorial: `https://codewithmukesh.com/blog/pagination-in-aspnet-core-webapi/#What_we_will_be_Building`
- On my end, removed Restaurant with an `Id: 5` to demonstrate DELETE functionality.

---

| HTTP Request Endpoints Overview |
|---|


### Primary endpoint once running: https://localhost:5001/


#### Key HTTP requests:

  - **GET** (Individual Restaurant): /api/Restaurants/{id}
  - **GET**: /api/Restaurants
  - **POST**: /api/Restaurants
  - **PUT**: /api/Restaurants/{id}
  - **DELETE**: /api/Restaurants/{id}



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

## GET, GET with Id: 
### To return **all Restaurants** paginated:
  - https://localhost:5001/api/Restaurants
### To return **individual Restaurants** via ID:
  - https://localhost:5001/api/Restaurants/{ID}
    - **Example**:   https://localhost:5001/api/Restaurants/4
    - **Restaurant with `Id: 5` will not exist, as I have made a DELETE request withstanding**.
### To search via Query Strings:
  - Currently, you can only use query strings to adjust the
        - pageSize (total number of Restaurants you want viewed on a single page)
        - pageNumber (view next series of Restaurants if page 1 does not fit all Restaurants in response)
  - **Example**: https://localhost:5001/api/Restaurants?pageSize=7&pageNumber=2
    - `pageSize=7` gives 7 Restaurants per page, `pageNumber=2` shows the second page. In a response of 12 Restaurants, you will view 7 on page 1, 5 on page 2.

## POST:
### To add a new Restaurant via Postman:
  - Enter this endpoint with POST selected:  https://localhost:5001/api/Restaurants
  - In the Body tab, select Raw, and choose JSON.
  - Enter the following object, note all key/values are strings **except** the value of "id" which is an **integer**
    - **Remember** once you POST, to toggle to the **last page** of the list to view your new entry.

```
       {
            "name": "Koda",
            "id": 14,
            "city": "Melbourne",
            "cuisine": "Asian/Fine"
       }
```

## PUT:
### To update a current Restaurant:
   - Enter this endpoint with GET selected, to retrieve the `Id` of the chosen Restaurant:  https://localhost:5001/api/Restaurants
   - Take the `Id` and suffix the route accordingly:  https://localhost:5001/api/Restaurants/{Id}
   - Change to PUT method.
      - Enter the following object, note all key/values are strings **except** the value of "id" which is an **integer**
       - **Remember** once you PUT, to make a GET request, toggle to the **last page** of the list to view your new entry.

![Postman-2022-06-10-13-21-16](https://user-images.githubusercontent.com/100096239/173147835-5db1e582-48e5-414c-a0b5-f3a36f75cf0b.gif)


<!-- 
```
       {
            "name": "Koda",
            "id": 14,
            "city": "Melbourne",
            "cuisine": "Japanese/Fine"
       }
```
(Changed `"cuisine"` to `"Japanese/Fine"` from `"Asian/Fine"`) -->


## DELETE:
   - Enter this endpoint with GET selected, to retrieve the `Id` of the chosen Restaurant:  https://localhost:5001/api/Restaurants
   - Take the `Id` and suffix the route accordingly:  https://localhost:5001/api/Restaurants/{Id}
   - Change to the DELETE method, and SEND.

.
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
| **Save and you are ready to go! Next, follow instructions above under "HTTP Requests Endpoint Overview"**

 
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
