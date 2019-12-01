create procedure [Staff Display] @NIC integer = NULL, 
@FirstName varchar(255)= NULL, @LastName varchar(255)= NULL, 
@BranchId integer= NULL, @JobTitle varchar(255)= NULL, @HiringDate Date= NULL, 
@WorkHours integer= NULL	
as
select s.FirstName,s.LastName,b.idBranch,j.JobTitle,s.HireDate,s.HoursPerDay 
from Staff s inner join Branch b on s.Branch_idBranch = b.idBranch
inner join Jobs j on s.Jobs_idJob = j.idJob
where (s.NIC like Convert(varchar(15),ISNULL(@NIC,s.NIC))+'%') 
and (s.FirstName like ISNULL(@FirstName,s.FirstName)+'%') 
and (s.LastName like ISNULL(@LastName,s.LastName)+'%') 
and (s.Branch_idBranch like CONVERT(varchar(5),ISNULL(@BranchId,s.Branch_idBranch))+'%') 
and (j.JobTitle like ISNULL(@JobTitle,j.JobTitle)+'%') 
and (s.HireDate like CONVERT(varchar(5),ISNULL(@HiringDate,s.HireDate))+'%')
and (s.HoursPerDay like CONVERT(varchar(5),ISNULL(@WorkHours,s.HoursPerDay))+'%')
go

create procedure [Order Display] @NIC integer = NULL, 
@OrderID integer = NULL, @StaffID integer = NULL, 
@OrderDate Datetime= NULL 	
as
select c.NIC, o.idOrder,s.idStaff,o.OrderDate 
from ((Customers c left join Orders o on c.CustomerID = o.Customers_CustomerID)
left join Staff s on s.idStaff = o.Staff_idStaff)
where (c.NIC like Convert(varchar(15),ISNULL(@NIC,c.NIC))+'%') 
and (o.idOrder like Convert(varchar(5),ISNULL(@OrderID,o.idOrder))+'%') 
and (s.idStaff like Convert(varchar(5),ISNULL(@StaffID,s.idStaff))+'%') 
and (o.OrderDate like CONVERT(varchar(5),ISNULL(@OrderDate,o.OrderDate))+'%') 
go


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
  Address VARCHAR(50)      ,
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
  NIC INTEGER NOT NULL ,
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



Insert into Branch(idBranch,BranchName,[Address]) values(1,'Town','ABCArea')

Insert into Customers(CustomerID,NIC,FirtsName,LastName) values (1,'12345','L','F')
Insert into Customers(CustomerID,NIC,FirtsName,LastName) values (2,'54325','Lai','Fan')

insert into FoodItems(idFood,Name,UnitPrice) values (1,'juice',50)
insert into FoodItems(idFood,Name,UnitPrice) values (2,'pizza',500)

insert into Jobs(idJob,JobTitle,HourlyWages) values (1,'Manager',1000)
insert into Jobs(idJob,JobTitle,HourlyWages) values (2,'Cashier',200)
insert into Jobs(idJob,JobTitle,HourlyWages) values (3,'Chef',500)

insert into Staff(idStaff,NIC,FirstName,LastName,Jobs_idJob,Branch_idBranch,HireDate,HoursPerDay) values (1,'42101','Lin','Seraf',1,1,getdate(),8)
insert into Staff(idStaff,NIC,FirstName,LastName,Jobs_idJob,Branch_idBranch,HireDate,HoursPerDay) values (2,'42101','Lama','Seraf',2,1,getdate(),12)

insert into Orders(idOrder,Customers_CustomerID,Staff_idStaff,OrderDate) values(1,2,2,getdate())
insert into Orders(idOrder,Customers_CustomerID,Staff_idStaff,OrderDate) values(3,1,2,getdate())
insert into Orders(idOrder,Customers_CustomerID,Staff_idStaff,OrderDate) values(2,2,2,getdate())
 
insert into OrderItems(Orders_idOrder,FoodItems_idFood,Quantity) values (1,1,2)
insert into OrderItems(Orders_idOrder,FoodItems_idFood,Quantity) values (1,2,3)
insert into OrderItems(Orders_idOrder,FoodItems_idFood,Quantity) values (2,1,1)
insert into OrderItems(Orders_idOrder,FoodItems_idFood,Quantity) values (2,2,3)
insert into OrderItems(Orders_idOrder,FoodItems_idFood,Quantity) values (3,1,1)
insert into OrderItems(Orders_idOrder,FoodItems_idFood,Quantity) values (3,2,1)
