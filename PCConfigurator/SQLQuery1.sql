CREATE DATABASE PCConfiguratorDB;
GO

USE PCConfiguratorDB;

drop table if exists Components;
Drop table if exists SavedBuilds;
GO

CREATE TABLE Components (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Type NVARCHAR(20) NOT NULL, 
    Price DECIMAL(10,2) NOT NULL,
    Wattage INT DEFAULT 0,      
    Socket NVARCHAR(20) NULL,   
);

CREATE TABLE SavedBuilds (
    Id INT PRIMARY KEY IDENTITY(1,1),
    BuildName NVARCHAR(100) NOT NULL,
    TotalPrice DECIMAL(10,2) NOT NULL,
    ComponentIds NVARCHAR(MAX) NOT NULL, 
    CreatedDate DATETIME DEFAULT GETDATE()
);


INSERT INTO Components (Name, Type, Price, Wattage, Socket) VALUES 
('Intel Core i5-13600K', 'CPU', 1400.00, 180, 'LGA1700'),
('Intel Core i9-13900K', 'CPU', 2600.00, 250, 'LGA1700'),
('AMD Ryzen 7 7800X3D', 'CPU', 1800.00, 120, 'AM5'),
('Gigabyte Z790 Gaming X', 'MOBO', 1100.00, 50, 'LGA1700'),
('MSI B650 Tomahawk', 'MOBO', 950.00, 45, 'AM5'),
('NVIDIA RTX 4070', 'GPU', 2800.00, 200, NULL),
('NVIDIA RTX 4090', 'GPU', 8500.00, 450, NULL),
('Corsair RM750x', 'PSU', 550.00, 750, NULL),
('BeQuiet Pure Power 1000W', 'PSU', 800.00, 1000, NULL);