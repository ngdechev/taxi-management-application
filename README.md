![version](https://img.shields.io/badge/version-1.0.0-blue)
![GitHub repo size](https://img.shields.io/github/repo-size/ngdechev/football-championship?color=yellow)
![Bitbucket open issues](https://img.shields.io/bitbucket/issues/ngdechev/football-championship)

# Software Production Technology Project
## Assignment - "Taxi Managment Application"
1. Create Cars and Orders tables:
  - Cars Table:
  
| Field Name | Data Type  | Description                      |
|------------|------------|----------------------------------|
| KodTaxi    | Number     | Unique Taxi Number               |
| RegNomer   | Short Text | Registration Number              |
| Mark       | Short Text | Brand Of The Car                 |
| Seats      | Number     | Number Of Seats For Passengers   |
| Luggage    | Yes/No     | Space For Large Luggage (Yes/No) |
| Driver     | Short Text | Name Of The Driver               | 

  - Orders Table

| Field Name | Data Type  | Description                             |
|------------|------------|-----------------------------------------|
| NumOrd     | Number     | Order Number                            |
| KodTaxi    | Number     | Taxi Number                             |
| Address    | Short Text | Address From Which The Order Was Placed |
| OrdTime    | Date/Time  | Time (Date And Time) Of The Order       |
| Distance   | Number     | Distance Traveled (km)                  |
| Fare       | Currency   | Order Fee (BGN)                         |


2. In the Cars table, fill in at least 5 entries with meaningful data in Bulgarian and Cyrillic, and in
Orders -10.
3. Create a summary parametric query qryTotalOrders based on the Cars and Orders tables, which will show for orders placed before a date set by parameter:
     - the registration number and brand of the taxi;
     - the total amount of orders for each fee;
4. Create a menu bar for the information system with three points:
     - Input - to launch the forms
     - Reports – to launch the reports
     - Exit – to close the program
5. Create the following forms
    - frmCars based on the Cars table.
    - Orders subform based on the Orders table.
    - in frmCars form create a subform based on Orders subform so when in the main form, select fees, in the subform, only the executed ones should be displayed
orders from him.
The labels of the control elements should be in Bulgarian and Cyrillic.
6. Create 2 reports based on the Orders table and the parametric query. The inscriptions in
reports to be in Bulgarian and Cyrillic.
7. You may use a database of your choice.
8. The project must be printed and well designed, have a conceptual,
physical and logical database model, as well as use and class diagrams.

## Project Development
The following programming languages were used for the development of the project:
1. C#
2. SQL

And the following tools:
1. Visual Studio 2022
2. Microsoft Access 2016

![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white) ![SQL](https://img.shields.io/badge/-SQL-blue?style=for-the-badge) ![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white) ![Microsoft Access](https://img.shields.io/badge/Microsoft_Access-A4373A?style=for-the-badge&logo=microsoft-access&logoColor=white)

## Screenshots of the program execution
### Cars Table
![carsdb.png](https://i.postimg.cc/G2GfFFPK/carsdb.png)

### Orders Table
![ordersdb.png](https://i.postimg.cc/zvkPMqcR/ordersdb.png)

### Main Menu
![main.png](https://i.postimg.cc/tC2MNC6K/main.png)

### Add Taxi Form
![add-taxi-PNG.png](https://i.postimg.cc/WzVHXdXv/add-taxi-PNG.png)

### Add Orders Form
![add-orders-PNG.png](https://i.postimg.cc/43Kqdkmr/add-orders-PNG.png)

### First Query
![query1.png](https://i.postimg.cc/sfP81JgD/query1.png)

### Second Query
![query2.png](https://i.postimg.cc/sfP81JgD/query2.png)
