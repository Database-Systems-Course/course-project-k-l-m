CREATE TABLE FoodItems (
  idFood CHAR   NOT NULL ,
  Name VARCHAR    ,
  UnitPrice INTEGER      ,
PRIMARY KEY(idFood));




CREATE TABLE Jobs (
  idJob CHAR(15)   NOT NULL ,
  JobTitle VARCHAR    ,
  HourlyWages INTEGER      ,
PRIMARY KEY(idJob));




CREATE TABLE Branch (
  idBranch CHAR(15)   NOT NULL ,
  BranchName VARCHAR    ,
  Address VARCHAR      ,
PRIMARY KEY(idBranch));




CREATE TABLE Customers (
  CustomerID CHAR   NOT NULL ,
  NIC CHAR   NOT NULL ,
  FirtsName VARCHAR   NOT NULL ,
  LastName VARCHAR      ,
PRIMARY KEY(CustomerID));




CREATE TABLE Staff (
  idStaff CHAR(15)   NOT NULL ,
  Jobs_idJob CHAR(15)   NOT NULL ,
  Branch_idBranch CHAR(15)   NOT NULL ,
  NIC CHAR   NOT NULL ,
  FirstName VARCHAR   NOT NULL ,
  LastName VARCHAR    ,
  HireDate DATE    ,
  HoursPerDay INTEGER      ,
PRIMARY KEY(idStaff)    ,
  FOREIGN KEY(Branch_idBranch)
    REFERENCES Branch(idBranch),
  FOREIGN KEY(Jobs_idJob)
    REFERENCES Jobs(idJob));


CREATE INDEX StaffBranch ON Staff (Branch_idBranch);
CREATE INDEX StaffJob ON Staff (Jobs_idJob);


CREATE INDEX IFK_has ON Staff (Branch_idBranch);
CREATE INDEX IFK_aredoneby ON Staff (Jobs_idJob);


CREATE TABLE Orders (
  idOrder CHAR   NOT NULL ,
  Customers_CustomerID CHAR   NOT NULL ,
  Staff_idStaff CHAR(15)   NOT NULL ,
  OrderDate DATETIME      ,
PRIMARY KEY(idOrder)    ,
  FOREIGN KEY(Staff_idStaff)
    REFERENCES Staff(idStaff),
  FOREIGN KEY(Customers_CustomerID)
    REFERENCES Customers(CustomerID));


CREATE INDEX Orders_FKIndex1 ON Orders (Staff_idStaff);
CREATE INDEX Orders_FKIndex2 ON Orders (Customers_CustomerID);


CREATE INDEX IFK_take ON Orders (Staff_idStaff);
CREATE INDEX IFK_place ON Orders (Customers_CustomerID);


CREATE TABLE OrderItems (
  Orders_idOrder CHAR   NOT NULL ,
  FoodItems_idFood CHAR   NOT NULL ,
  Quantity INTEGER      ,
PRIMARY KEY(Orders_idOrder, FoodItems_idFood)    ,
  FOREIGN KEY(Orders_idOrder)
    REFERENCES Orders(idOrder),
  FOREIGN KEY(FoodItems_idFood)
    REFERENCES FoodItems(idFood));


CREATE INDEX Orders_has_FoodItems_FKIndex1 ON OrderItems (Orders_idOrder);
CREATE INDEX Orders_has_FoodItems_FKIndex2 ON OrderItems (FoodItems_idFood);


CREATE INDEX IFK_contain ON OrderItems (Orders_idOrder);
CREATE INDEX IFK_used ON OrderItems (FoodItems_idFood);



