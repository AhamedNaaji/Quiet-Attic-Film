Create Database Quiet_Attic_Film_Production;

USE Quiet_Attic_Film_Production;


-- Create Client Table
CREATE TABLE Client (
  ClientID INT PRIMARY KEY IDENTITY(1,1),
  ClientName VARCHAR(255) not null,
  ClientAddress VARCHAR(255) not null,
  ClientContactNo VARCHAR(20) not null
);

insert into Client (ClientName,ClientAddress,ClientContactNo)

values('Epom Motors','Oak Street, London ','+44 20 4123 4567'),
('Minisitry Of Agriculture ','Whiddon Down, London ','+44 20 7123 4567'),
('Fisheries and Food','  Pampisford , London','1');


Update Client 
SET ClientContactNo ='+44 20 7123 4567', ClientAddress = 'Frankfurt Pampisford,London'
WHERE ClientID = 8;

DELETE FROM Client WHERE ClientID = '13'
select * from Client;

-- Create Production Table
CREATE TABLE Production (
  ProductionID INT PRIMARY KEY IDENTITY (2,10) ,
  ProductionType VARCHAR(255) not null,
  Days INT,
  ClientID INT NOT NULL,
  FOREIGN KEY (ClientID) REFERENCES Client (ClientID) ON DELETE CASCADE  
);


insert into Production (ProductionType,Days, ClientID)

values('Training Film ', 5, 1),
('Advertisement',5, 2),
('Information Film', 3, 3);


-- Create Location Table
CREATE TABLE "Location" (
  LocationID INT PRIMARY KEY IDENTITY(10,10),
  Location VARCHAR(255) not null
);

INSERT INTO Location VALUES ('Colombo'),('Kandy'),('Batticalo');


-- Create Staff Table
CREATE TABLE Staff (
  StaffID INT PRIMARY KEY IDENTITY(1,1),
  StaffName VARCHAR(255) not null,
  StaffType VARCHAR(50) not null,
  StaffContactNo VARCHAR(20) not null
);



insert into Staff (StaffName,StaffType,StaffContactNo)
values
('Brandon',' Producer','+44 33 9876 5432'),('Alex Turner','Runner ','+44 20 7123 5678'),
('Emily Rodriguez ','Camera Crew ','+44 77 9876 5432'),
('Jake Mitchell',' Actor','+44 11 2233 4455'),('Sarah Patel',' Voice Actor','+44 74 5678 9012');


DELETE FROM Staff WHERE StaffName = 'Brandon'
Select * from Staff;



-- Create Property Table
CREATE TABLE Property (
  PropertyID INT PRIMARY KEY IDENTITY(8,8),
  PropertyType VARCHAR(50) not null,
  PropertyName VARCHAR(255) not null
);
insert into property(PropertyType,PropertyName)
values('Vehicle','Car'),('Furniture','Chair'),('Building','Inner City House');




-- Create StaffType Table
CREATE TABLE StaffType (
   Type varchar(150) not null ,
   Fee int not null
);


insert into StaffType (Type,Fee)
values('Runner','100'),('Camera Crew','25'),
('Actor','200'),('Voice Actor','100'),
('Producer','550');

SELECT * FROM StaffType
WHERE Fee IN ('100', '550', '200');

-- Create ProductionLocation Table
CREATE TABLE ProductionLocation (
  LocationID INT,
  ProductionID INT,
  PRIMARY KEY (LocationID, ProductionID),
  FOREIGN KEY (LocationID) REFERENCES Location(LocationID) ON DELETE CASCADE  ,
  FOREIGN KEY (ProductionID) REFERENCES Production(ProductionID) ON DELETE CASCADE  
);

INSERT INTO ProductionLocation VALUES (10,2),(20,12),(30,22);


-- Create ProductionProperty Table
CREATE TABLE ProductionProperty (
  PropertyID INT,
  ProductionID INT,
  PRIMARY KEY (PropertyID, ProductionID),
  FOREIGN KEY (PropertyID) REFERENCES Property(PropertyID) ON DELETE CASCADE  ,
  FOREIGN KEY (ProductionID) REFERENCES Production(ProductionID) ON DELETE CASCADE  
);

INSERT INTO ProductionProperty VALUES (8,2),(16,12),(24,22);


-- Create ProductionStaff Table
CREATE TABLE ProductionStaff (
  StaffID INT,
  ProductionID INT,
  PRIMARY KEY (StaffID, ProductionID),
  FOREIGN KEY (StaffID) REFERENCES Staff(StaffID) ON DELETE CASCADE,
  FOREIGN KEY (ProductionID) REFERENCES Production(ProductionID) ON DELETE CASCADE  
);




-- Create PropertyLocation Table
CREATE TABLE PropertyLocation (
  PropertyID INT,
  LocationID INT,
  PRIMARY KEY (PropertyID, LocationID),
  FOREIGN KEY (PropertyID) REFERENCES Property(PropertyID) ON DELETE CASCADE,
  FOREIGN KEY (LocationID) REFERENCES Location(LocationID) ON DELETE CASCADE
);

INSERT INTO PropertyLocation VALUES (8,10), (16, 20),(24, 30);



SELECT Production.ProductionID, Production.ProductionType, Production.Days, Client.ClientName FROM
Production INNER JOIN Client ON Production.ClientID = Client.ClientID;


SELECT Production.ProductionType, Client.ClientName
FROM Production
FULL OUTER JOIN Client ON Production.ProductionType=Client.ClientName
ORDER BY Production.ProductionType;


-- ProductionProperty

SELECT Production.ProductionID, Property.PropertyID, Property.PropertyName
FROM ((ProductionProperty
INNER JOIN Production ON Production.ProductionID = ProductionProperty.ProductionID)
INNER JOIN Property ON Property.PropertyID = ProductionProperty.PropertyID);


--ProductionLocation

SELECT Production.ProductionID, Location.LocationID, Location.Location
FROM ((ProductionLocation
INNER JOIN Production ON ProductionLocation.ProductionID = Production.ProductionID)
INNER JOIN Location ON ProductionLocation.LocationID = Location.LocationID);


--PropertyLocation


SELECT Property.PropertyID, Property.PropertyName, Location.Location, Location.LocationID
FROM ((PropertyLocation
INNER JOIN Property ON Property.PropertyID = PropertyLocation.PropertyID)
INNER JOIN Location ON Location.LocationID = PropertyLocation.LocationID);

SELECT LocationID FROM Location;



-- ProductionProperty



CREATE TABLE Users (
	username VARCHAR(255) not null,
	password VARCHAR(255) not null
);

insert into Users VALUES('admin','123');