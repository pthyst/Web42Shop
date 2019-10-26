-- Insert [dbo.Roles] --
INSERT INTO dbo.Roles(Name)
VALUES('SuperAdmin'),('Admin'),('Author'),('User')

-- Insert [dbo.Admins] --
INSERT INTO dbo.Admins(Role_Id,Username,Password,Email,DateCreate,DateModify)
VALUES (1,'pthyst','phuongdung','pthyst@gmail.com','20191025 21:00:00','20191025 21:00:00'),
(2,'khaicq64','khaicq64','khaicq64@gmail.com','20191025 21:00:00','20191025 21:00:00'),
(2,'suongvip123','suongvip123','suongvip123@gmail.com','20191025 21:00:00','20191025 21:00:00'),
(3,'lock41','lock41','lock41@gmail.com','20191025 21:00:00','20191025 21:00:00'),
(4,'leeminhi','leeminhi','minhhuy@gmail.com','20191025 21:00:00','20191025 21:00:00')

-- Insert [dbo.ProductBrands] --
INSERT INTO dbo.ProductBrands(Admin_Id,Name,DateCreate,DateModify)
VALUES (4,'ASUS','20191025 21:00:00','20191025 21:00:00'),
(4,'SONY','20191025 21:00:00','20191025 21:00:00'),
(4,'Lenovo','20191025 21:00:00','20191025 21:00:00'),
(4,'Dell','20191025 21:00:00','20191025 21:00:00'),
(4,'Apple','20191025 21:00:00','20191025 21:00:00'),
(4,'Microsoft','20191025 21:00:00','20191025 21:00:00'),
(4,'Samsung','20191025 21:00:00','20191025 21:00:00')

-- Insert [dbo.ProductsTypes] --
INSERT INTO dbo.ProductTypes(Admin_Id,Type,DateCreate,DateModify)
VALUES (4,'Laptop','20191025 21:00:00','20191025 21:00:00'),
(4,'Smartphone','20191025 21:00:00','20191025 21:00:00'),
(4,'Tablet','20191025 21:00:00','20191025 21:00:00'),
(4,'Keyboard','20191025 21:00:00','20191025 21:00:00'),
(4,'Mouse','20191025 21:00:00','20191025 21:00:00'),
(4,'Headphone','20191025 21:00:00','20191025 21:00:00')
SELECT *FROM dbo.ProductTypes ORDER BY Id ASC



