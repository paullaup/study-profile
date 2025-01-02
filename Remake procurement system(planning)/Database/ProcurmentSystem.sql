-- Set the default engine 
SET default_storage_engine = InnoDB;
SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";

-- Create and use database testdb
drop database IF EXISTS Yummy_Food_Restaurant;
create database Yummy_Food_Restaurant CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
use Yummy_Food_Restaurant;

-- * Table Department ------------------------------------------------------------------------------
-- Create table 
Create Table Department (
    deptID varchar(10) NOT NULL,
    deptName varchar(100) NOT NULL,
    sub_district varchar(50) NOT NULL,
    address varchar(10) NOT NULL,
    remark varchar(100) NULL,
    PRIMARY KEY(deptID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Insert test data
INSERT INTO Department (deptID, deptName, sub_district, address, remark)
VALUES
    ('Dept1', 'Happy restaurant', 'kwun tong', '10 Kwun Tong Road', 'Remark 1'), 
    ('Dept2', 'Happy restaurant', 'kwun tong', '4 Hip Wo Street', 'Remark 2'), 
    ('Dept3', 'Good restaurant', 'Kowloon Tong', '7 Waterloo Road', 'Remark 3'), 
    ('Dept4', 'Office', 'Dist4', '987 Lane', 'Remark 4'),
    ('Dept5', 'Warehosue', 'Dist4', '987 Lane', 'Remark 4'); 


-- * Table Department ------------------------------------------------------------------------------


-- * Table Position --------------------------------------------------------------------------------
-- Create table
CREATE TABLE `Position` (
    positionName varchar(50) NOT NULL,
    PRIMARY KEY(positionName)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Insert test data
INSERT INTO `Position` (positionName) VALUES
    ('Admin'),
    ('Category Manager'),
    ('Restaurant Manager'),
    ('Restaurant Staff'),
    ('Purchase Manager'),
    ('Warehouse Clerk');
-- * Table Position --------------------------------------------------------------------------------


-- * Table Employee --------------------------------------------------------------------------------
-- Create Table
CREATE TABLE Employee(
    staffID varchar(10) NOT NULL,
    positionName varchar(50) NOT NULL,
    staffName varchar(50) NOT NULL,
    emailAddress varchar(100) NOT NULL,
    deptID varchar(10) NOT NULL,
    password varchar(50) NOT NULL, 
    PRIMARY KEY(staffID),
    FOREIGN KEY(positionName)
        REFERENCES `Position`(positionName),
    FOREIGN KEY(deptID)
        REFERENCES Department(deptID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Insert test data
INSERT INTO Employee (staffID, positionName, staffName, emailAddress, deptID, password)
VALUES
    ('S001', 'Admin', 'John Doe', 'john@example.com', 'Dept4', '123'),
    ('S002', 'Category Manager', 'Jane Smith', 'jane@example.com', 'Dept4', '123'),
    ('S003', 'Restaurant Manager', 'Michael Johnson', 'michael@example.com', 'Dept3', '123'),
    ('S004', 'Restaurant Staff', 'Emily Williams', 'emily@example.com', 'Dept3', '123'),
    ('S005', 'Purchase Manager', 'David Brown', 'david@example.com', 'Dept4', '123'),
    ('S006', 'Warehouse Clerk', 'Sarah Lee', 'sarah@example.com', 'Dept5', '123');

-- * Table Employee --------------------------------------------------------------------------------


-- * Table Function --------------------------------------------------------------------------------
-- Create table
CREATE TABLE `Function` (
    functionName varchar(50) NOT NULL,
    PRIMARY KEY(functionName)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Insert data
INSERT INTO `Function`(functionName) 
VALUES
    ('AddItemUI'),
    ('AddItemUI1'),
    ('AddItemUI2'),
    ('AccountManage'),
    ('RestaurantManage'),
    ('modifyItemUI');
-- * Table Function --------------------------------------------------------------------------------


-- * Table Permission --------------------------------------------------------------------------------
-- Create table
CREATE TABLE `Permission`(
    positionName varchar(50) NOT NULL,
    functionName varchar(50) NOT NULL,
    PRIMARY KEY(positionName, functionName),
    FOREIGN KEY(positionName)
        REFERENCES `Position`(positionName),
    FOREIGN KEY(functionName)
        REFERENCES `Function`(functionName)
)ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Insert table
INSERT INTO Permission(positionName, functionName) 
VALUES
    ('Admin', 'AccountManage'),
    ('Admin', 'RestaurantManage'),
    ('Admin', 'AddItemUI'),
    ('Restaurant Manager', 'AddItemUI'),
    ('Purchase Manager', 'AddItemUI');
-- * Table Permission --------------------------------------------------------------------------------









