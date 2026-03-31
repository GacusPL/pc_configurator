USE PCConfiguratorDB;
GO

DELETE FROM Components;
DBCC CHECKIDENT ('Components', RESEED, 0);

INSERT INTO Components (Name, Type, Price, Wattage, Socket, ImageUrl) VALUES 
('Intel Core i3-12100F', 'CPU', 450.00, 60, 'LGA1700', 'https://m.media-amazon.com/images/I/41-oVOxPKTL._AC_UF1000,1000_QL80_.jpg'),
('Intel Core i5-13600K', 'CPU', 1400.00, 180, 'LGA1700', 'https://m.media-amazon.com/images/I/51ugNYlDT1L._AC_UF1000,1000_QL80_.jpg'),
('Intel Core i9-14900K', 'CPU', 2800.00, 250, 'LGA1700', 'https://m.media-amazon.com/images/I/51Ekrj4Mj8L._AC_UF1000,1000_QL80_.jpg'),
('AMD Ryzen 5 5600', 'CPU', 600.00, 65, 'AM4', 'https://images-na.ssl-images-amazon.com/images/I/51So7GoGvxL._AC_UL495_SR435,495_.jpg'),
('AMD Ryzen 7 7800X3D', 'CPU', 1800.00, 120, 'AM5', 'https://m.media-amazon.com/images/I/51HqC0rU9HL._AC_UF1000,1000_QL80_.jpg');

INSERT INTO Components (Name, Type, Price, Wattage, Socket, MemoryType, ImageUrl) VALUES 
('Gigabyte B660M DS3H', 'MOBO', 500.00, 30, 'LGA1700', 'DDR4', 'https://m.media-amazon.com/images/I/81Ar-GxkvOL._AC_UF350,350_QL80_.jpg'),
('MSI MAG Z790 TOMAHAWK', 'MOBO', 1300.00, 60, 'LGA1700', 'DDR5', 'https://m.media-amazon.com/images/I/81NAO-GjjvL._AC_UF1000,1000_QL80_.jpg'),
('ASUS ROG Strix B550-F', 'MOBO', 700.00, 45, 'AM4', 'DDR4', 'https://m.media-amazon.com/images/I/61hR0ktxCwL._AC_UF1000,1000_QL80_.jpg'),
('ASRock B650M PG Riptide', 'MOBO', 800.00, 50, 'AM5', 'DDR5', 'https://m.media-amazon.com/images/I/71+Q67u5xzL.jpg');

INSERT INTO Components (Name, Type, Price, Wattage, MemoryType, ImageUrl) VALUES 
('Kingston Fury Beast 16GB (2x8)', 'RAM', 200.00, 5, 'DDR4', 'https://m.media-amazon.com/images/I/61uXihcspuL._AC_UF894,1000_QL80_.jpg'),
('G.SKILL Ripjaws V 32GB (2x16)', 'RAM', 350.00, 8, 'DDR4', 'https://m.media-amazon.com/images/I/618SEnJR1nL._AC_UF1000,1000_QL80_.jpg'),
('Corsair Vengeance 32GB (2x16)', 'RAM', 550.00, 10, 'DDR5', 'https://m.media-amazon.com/images/I/61D2DDpDITL._AC_UF1000,1000_QL80_.jpg'),
('G.SKILL Trident Z5 RGB 32GB', 'RAM', 750.00, 15, 'DDR5', 'https://m.media-amazon.com/images/I/61UwHpj3J4L._AC_UF1000,1000_QL80_.jpg');

INSERT INTO Components (Name, Type, Price, Wattage, VramGB, ImageUrl) VALUES 
('NVIDIA RTX 3060 12GB', 'GPU', 1400.00, 170, 12, 'https://m.media-amazon.com/images/I/81Df1O3ffBL._AC_UF1000,1000_QL80_.jpg'),
('NVIDIA RTX 4070 12GB', 'GPU', 2800.00, 200, 12, 'https://m.media-amazon.com/images/I/81KqoWLDKYL._AC_UF894,1000_QL80_.jpg'),
('NVIDIA RTX 4090 24GB', 'GPU', 9000.00, 450, 24, 'https://m.media-amazon.com/images/I/514QPBuqGyL._AC_UF894,1000_QL80_.jpg'),
('AMD Radeon RX 7800 XT', 'GPU', 2500.00, 260, 16, 'https://m.media-amazon.com/images/I/61aQwrGeLCL.jpg'),
('NVIDIA RTX 5080', 'GPU', 5500.00, 400, 16, 'https://m.media-amazon.com/images/I/71n9sxFO9dL._AC_SX466_.jpg');

INSERT INTO Components (Name, Type, Price, Wattage, ImageUrl) VALUES 
('SilentiumPC Vero L3 500W', 'PSU', 250.00, 500, 'https://static.komputronik.pl/product-picture/11/XZASATXSPCL3500W-1.jpg'),
('Corsair RM750x 750W', 'PSU', 600.00, 750, 'https://m.media-amazon.com/images/I/71ceFvqCLpL._AC_UF1000,1000_QL80_.jpg'),
('BeQuiet Dark Power 1000W', 'PSU', 1200.00, 1000, 'https://m.media-amazon.com/images/I/81uu1lK+SPL._AC_UF350,350_QL80_.jpg');