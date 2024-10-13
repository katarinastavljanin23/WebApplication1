CREATE TABLE Categories (
  CategoryID INT IDENTITY(1, 1) PRIMARY KEY,
  CategoryName VARCHAR(100),
  CreatedAt datetime 
);

INSERT INTO Categories(CategoryName, CreatedAt) VALUES ('Hygiene', '2024-08-11');
INSERT INTO Categories(CategoryName, CreatedAt) VALUES ('Makeup', '2024-08-10');

CREATE TABLE Products (
  ProductID INT IDENTITY(1, 1) PRIMARY KEY,
  ProductName VARCHAR(100),
  Price DECIMAL(18,4),
  Description VARCHAR(255),
  StockQuantity int,
  CreatedAt datetime
  CategoryID int
);

INSERT INTO Products(ProductName, Price, Description, StockQuantity, CreatedAt) VALUES ('Soap', 100.00, 'Hand wash', 5000, '2024-09-09', 1);
INSERT INTO Products(ProductName, Price, Description, StockQuantity, CreatedAt) VALUES ('Shower gel', 399.99, 'Gel for showering', 10000, '2024-09-15', 1);
INSERT INTO Products(ProductName, Price, Description, StockQuantity, CreatedAt) VALUES ('Lipstic', 800, 'For hydratating lips', 4000, '2024-10-01', 2);
INSERT INTO Products(ProductName, Price, Description, StockQuantity, CreatedAt) VALUES ('Foundation', 1400, 'For perfecrt skin', 3500, '2024-10-05', 2);


CREATE TABLE ProductCategories (
 ProductID INT,
 CategoryID INT,
 PRIMARY KEY (ProductID, CategoryID),
 FOREIGN KEY (ProductID) REFERENCES Products(ProductID),
 FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);

INSERT INTO ProductCategories(ProductID, CategoryID) VALUES (1, 1);
INSERT INTO ProductCategories(ProductID, CategoryID) VALUES (2, 1); 
INSERT INTO ProductCategories(ProductID, CategoryID) VALUES (3, 2); 
INSERT INTO ProductCategories(ProductID, CategoryID) VALUES (4, 2);

SELECT * FROM Products
SELECT * FROM Categories
SELECT * FROM ProductCategories

