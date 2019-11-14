CREATE TABLE FoodItems (
  idFood CHAR  NOT NULL   IDENTITY ,
  Name VARCHAR    ,
  UnitPrice INTEGER      ,
PRIMARY KEY(idFood));
GO




CREATE TABLE Jobs (
  idJob CHAR(15)  NOT NULL   IDENTITY ,
  JobTitle VARCHAR    ,
  HourlyWages INTEGER      ,
PRIMARY KEY(idJob));
GO




CREATE TABLE Branch (
  idBranch CHAR(15)  NOT NULL   IDENTITY ,
  BranchName VARCHAR    ,
  Address VARCHAR      ,
PRIMARY KEY(idBranch));
GO




CREATE TABLE Customers (
  CustomerID CHAR  NOT NULL   IDENTITY ,
  NIC CHAR  NOT NULL  ,
  FirtsName VARCHAR  NOT NULL  ,
  LastName VARCHAR      ,
PRIMARY KEY(CustomerID));
GO




CREATE TABLE Staff (
  idStaff CHAR(15)  NOT NULL   IDENTITY ,
  Jobs_idJob CHAR(15)  NOT NULL  ,
  Branch_idBranch CHAR(15)  NOT NULL  ,
  NIC CHAR  NOT NULL  ,
  FirstName VARCHAR  NOT NULL  ,
  LastName VARCHAR    ,
  HireDate DATE    ,
  HoursPerDay INTEGER      ,
PRIMARY KEY(idStaff)    ,
  FOREIGN KEY(Branch_idBranch)
    REFERENCES Branch(idBranch),
  FOREIGN KEY(Jobs_idJob)
    REFERENCES Jobs(idJob));
GO


CREATE INDEX StaffBranch ON Staff (Branch_idBranch);
GO
CREATE INDEX StaffJob ON Staff (Jobs_idJob);
GO


CREATE INDEX IFK_has ON Staff (Branch_idBranch);
GO
CREATE INDEX IFK_are done by ON Staff (Jobs_idJob);
GO


CREATE TABLE Orders (
  idOrder CHAR  NOT NULL   IDENTITY ,
  Customers_CustomerID CHAR  NOT NULL  ,
  Staff_idStaff CHAR(15)  NOT NULL  ,
  OrderDate DATETIME      ,
PRIMARY KEY(idOrder)    ,
  FOREIGN KEY(Staff_idStaff)
    REFERENCES Staff(idStaff),
  FOREIGN KEY(Customers_CustomerID)
    REFERENCES Customers(CustomerID));
GO


CREATE INDEX Orders_FKIndex1 ON Orders (Staff_idStaff);
GO
CREATE INDEX Orders_FKIndex2 ON Orders (Customers_CustomerID);
GO


CREATE INDEX IFK_take ON Orders (Staff_idStaff);
GO
CREATE INDEX IFK_place ON Orders (Customers_CustomerID);
GO


CREATE TABLE OrderItems (
  Orders_idOrder CHAR  NOT NULL  ,
  FoodItems_idFood CHAR  NOT NULL  ,
  Quantity INTEGER      ,
PRIMARY KEY(Orders_idOrder, FoodItems_idFood)    ,
  FOREIGN KEY(Orders_idOrder)
    REFERENCES Orders(idOrder),
  FOREIGN KEY(FoodItems_idFood)
    REFERENCES FoodItems(idFood));
GO


CREATE INDEX Orders_has_FoodItems_FKIndex1 ON OrderItems (Orders_idOrder);
GO
CREATE INDEX Orders_has_FoodItems_FKIndex2 ON OrderItems (FoodItems_idFood);
GO


CREATE INDEX IFK_contain ON OrderItems (Orders_idOrder);
GO
CREATE INDEX IFK_are used as ON OrderItems (FoodItems_idFood);
GO



