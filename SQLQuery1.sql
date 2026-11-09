CREATE DATABASE PhoneShopDB_EN;
GO

USE PhoneShopDB_EN;
GO


-- ============================================
-- 1. BRAND
-- ============================================
CREATE TABLE Brand (
    Brand_ID INT PRIMARY KEY,
    Brand_Name VARCHAR(100) NOT NULL,
    Country VARCHAR(100)
);
GO


-- ============================================
-- 2. PRODUCT
-- ============================================
CREATE TABLE Product (
    Product_ID INT PRIMARY KEY,
    Product_Name VARCHAR(150) NOT NULL,
    Brand_ID INT NOT NULL,

    Chipset VARCHAR(100),
    RAM INT,
    Storage INT,
    Screen_Size DECIMAL(4,2),
    Battery_Capacity INT,
    Operating_System VARCHAR(50),
    Color VARCHAR(50),
    Selling_Price DECIMAL(18,2) NOT NULL,
    Warranty_Months INT,

    FOREIGN KEY (Brand_ID)
        REFERENCES Brand(Brand_ID)
);
GO


-- ============================================
-- 3. CUSTOMER
-- ============================================
CREATE TABLE Customer (
    Customer_ID INT PRIMARY KEY,
    Customer_Code VARCHAR(20),
    C_Name VARCHAR(100) NOT NULL,
    C_Email VARCHAR(100),
    C_Number VARCHAR(15),
    C_Address VARCHAR(255)
);
GO


-- ============================================
-- 4. EMPLOYEE
-- ============================================
CREATE TABLE Employee (
    Employee_ID INT PRIMARY KEY,
    Employee_Code VARCHAR(20),
    E_Name VARCHAR(100) NOT NULL,
    E_Email VARCHAR(100),
    E_Phone VARCHAR(15),
    Position VARCHAR(50),
    Salary DECIMAL(18,2)
);
GO


-- ============================================
-- 5. SALE ORDER
-- ============================================
CREATE TABLE Sale_Order (
    Order_ID INT PRIMARY KEY,
    Customer_ID INT NOT NULL,
    Employee_ID INT NOT NULL,

    Order_Date DATE NOT NULL,
    Total_Amount DECIMAL(18,2),
    Order_Status VARCHAR(50),

    FOREIGN KEY (Customer_ID)
        REFERENCES Customer(Customer_ID),

    FOREIGN KEY (Employee_ID)
        REFERENCES Employee(Employee_ID)
);
GO


-- ============================================
-- 6. ORDER DETAIL
-- ============================================
CREATE TABLE Order_Detail (
    Order_Detail_ID INT PRIMARY KEY,
    Order_ID INT NOT NULL,
    Product_ID INT NOT NULL,

    Quantity INT NOT NULL,
    Unit_Price DECIMAL(18,2) NOT NULL,

    FOREIGN KEY (Order_ID)
        REFERENCES Sale_Order(Order_ID),

    FOREIGN KEY (Product_ID)
        REFERENCES Product(Product_ID)
);
GO


-- ============================================
-- 7. PAYMENT
-- ============================================
CREATE TABLE Payment (
    Payment_ID INT PRIMARY KEY,
    Order_ID INT NOT NULL UNIQUE,

    Payment_Date DATE,
    Payment_Method VARCHAR(50),
    Amount DECIMAL(18,2),
    Payment_Status VARCHAR(50),

    FOREIGN KEY (Order_ID)
        REFERENCES Sale_Order(Order_ID)
);
GO


-- ============================================
-- 8. INVENTORY
-- ============================================
CREATE TABLE Inventory (
    Inventory_ID INT PRIMARY KEY,
    Product_ID INT NOT NULL UNIQUE,

    Stock_Quantity INT NOT NULL,
    Last_Updated DATE,

    FOREIGN KEY (Product_ID)
        REFERENCES Product(Product_ID)
);
GO