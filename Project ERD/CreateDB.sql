CREATE TABLE FoodItems (
  idFood INTEGER  NOT NULL ,
  [Name] VARCHAR(50)    ,
  UnitPrice INTEGER      ,
PRIMARY KEY(idFood));




CREATE TABLE Jobs (
  idJob INTEGER NOT NULL ,
  JobTitle VARCHAR(50)    ,
  HourlyWages INTEGER      ,
PRIMARY KEY(idJob));




CREATE TABLE Branch (
  idBranch INTEGER NOT NULL ,
  BranchName VARCHAR(50)   ,
  Address VARCHAR      ,
PRIMARY KEY(idBranch));




CREATE TABLE Customers (
  CustomerID INTEGER NOT NULL ,
  NIC INTEGER NOT NULL ,
  FirtsName VARCHAR(50) NOT NULL ,
  LastName VARCHAR(50)     ,
PRIMARY KEY(CustomerID));




CREATE TABLE Staff (
  idStaff INTEGER NOT NULL ,
  Jobs_idJob INTEGER NOT NULL ,
  Branch_idBranch INTEGER  NOT NULL ,
  NIC CHAR   NOT NULL ,
  FirstName VARCHAR(50) NOT NULL ,
  LastName VARCHAR(50)   ,
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
  idOrder INTEGER NOT NULL ,
  Customers_CustomerID INTEGER NOT NULL ,
  Staff_idStaff INTEGER NOT NULL ,
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
  Orders_idOrder INTEGER NOT NULL ,
  FoodItems_idFood INTEGER NOT NULL ,
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



