
use Web42Shop
-- Insert [dbo.Roles] --
INSERT INTO dbo.Roles(Name)
VALUES('SuperAdmin'),('Admin'),('Author'),('User')
go

-- Insert [dbo.Admins] --
INSERT INTO dbo.Admins(Role_Id,Username,Password,Email,DateCreate,DateModify)
VALUES (1,'pthyst','phuongdung','pthyst@gmail.com','20191025 21:00:00','20191025 21:00:00'),
(2,'khaicq64','khaicq64','khaicq64@gmail.com','20191025 21:00:00','20191025 21:00:00'),
(2,'suongvip123','suongvip123','suongvip123@gmail.com','20191025 21:00:00','20191025 21:00:00'),
(3,'lock41','lock41','lock41@gmail.com','20191025 21:00:00','20191025 21:00:00'),
(4,'leeminhi','leeminhi','minhhuy@gmail.com','20191025 21:00:00','20191025 21:00:00'),
(2,'nhanvien','123','nhanvien@gmail.com','2019/10/17','2019/10/17')
go


/*ProductTypes ---- loại sản phẩm*/
/*bo*/
/*insert into ProductTypes(Admin_Id, Type, DateCreate, DateModify)
values(1,N'Tivi - Màn hình TV','2019/10/17','2019/10/17')*/
insert into ProductTypes(Admin_Id, Type, DateCreate, DateModify)
values(1,N'Điện thoại - Tablet','2019/10/17','2019/10/17')
insert into ProductTypes(Admin_Id, Type, DateCreate, DateModify)
values(1,N'Laptop - Macbook','2019/10/17','2019/10/17')
insert into ProductTypes(Admin_Id, Type, DateCreate, DateModify)
values(1,N'PC - Máy tính đồng bộ','2019/10/17','2019/10/17')
insert into ProductTypes(Admin_Id, Type, DateCreate, DateModify)
values(1,N'Loa - Thiết bị âm thanh','2019/10/17','2019/10/17') 
insert into ProductTypes(Admin_Id, Type, DateCreate, DateModify)
values(1,N'Màn hình máy tính','2019/10/17','2019/10/17')
insert into ProductTypes(Admin_Id, Type, DateCreate, DateModify)
values(1,N'Linh kiện máy tính','2019/10/17','2019/10/17')
/*bo*/
/*insert into ProductTypes(Admin_Id, Type, DateCreate, DateModify)
values(1,N'Gaming gear - Phụ kiện','2019/10/17','2019/10/17')
/*bo*/
insert into ProductTypes(Admin_Id, Type, DateCreate, DateModify)
values(1,N'Máy ảnh - Thiết bị thông minh','2019/10/17','2019/10/17')
/*bo*/*/
insert into ProductTypes(Admin_Id, Type, DateCreate, DateModify)
values(1,N'Thiết bị văn phòng','2019/10/17','2019/10/17')
insert into ProductTypes(Admin_Id, Type, DateCreate, DateModify)
values(1,N'Thiết bị mạng','2019/10/17','2019/10/17')

go
/*ProductBrands ---- thương hiệu sản phẩm*/
insert into ProductBrands(Admin_Id, Name, DateCreate,DateModify)
values(1,N'Samsung','2019/10/17','2019/10/17')
insert into ProductBrands(Admin_Id, Name, DateCreate,DateModify)
values(1,N'Sony','2019/10/17','2019/10/17')
insert into ProductBrands(Admin_Id, Name, DateCreate,DateModify)
values(1,N'LG','2019/10/17','2019/10/17')
insert into ProductBrands(Admin_Id, Name, DateCreate,DateModify)
values(1,N'TCL','2019/10/17','2019/10/17')
insert into ProductBrands(Admin_Id, Name, DateCreate,DateModify)
values(1,N'Asanzo','2019/10/17','2019/10/17')
insert into ProductBrands(Admin_Id, Name, DateCreate,DateModify)
values(1,N'Toshiba','2019/10/17','2019/10/17')
insert into ProductBrands(Admin_Id, Name, DateCreate,DateModify)
values(1,N'Xiaomi','2019/10/17','2019/10/17')
insert into ProductBrands(Admin_Id, Name, DateCreate,DateModify)
values(1,N'Apple','2019/10/17','2019/10/17')
insert into ProductBrands(Admin_Id, Name, DateCreate,DateModify)
values(1,N'Oppo','2019/10/17','2019/10/17')
insert into ProductBrands(Admin_Id, Name, DateCreate,DateModify)
values(1,N'Vivo','2019/10/17','2019/10/17')
insert into ProductBrands(Admin_Id, Name, DateCreate,DateModify)
values(1,N'Realme','2019/10/17','2019/10/17')
insert into ProductBrands(Admin_Id, Name, DateCreate,DateModify)
values(1,N'Asus','2019/10/17','2019/10/17')
insert into ProductBrands(Admin_Id, Name, DateCreate,DateModify)
values(1,N'Dell','2019/10/17','2019/10/17')
insert into ProductBrands(Admin_Id, Name, DateCreate,DateModify)
values(1,N'HP','2019/10/17','2019/10/17')
insert into ProductBrands(Admin_Id, Name, DateCreate,DateModify)
values(1,N'Lenovo','2019/10/17','2019/10/17')
insert into ProductBrands(Admin_Id, Name, DateCreate,DateModify)
values(1,N'Acer','2019/10/17','2019/10/17')
insert into ProductBrands(Admin_Id, Name, DateCreate,DateModify)
values(1,N'MSI','2019/10/17','2019/10/17')
insert into ProductBrands(Admin_Id, Name, DateCreate,DateModify)
values(1,N'Intel','2019/10/17','2019/10/17')
insert into ProductBrands(Admin_Id, Name, DateCreate,DateModify)
values(1,N'JBL','2019/10/17','2019/10/17')
insert into ProductBrands(Admin_Id, Name, DateCreate,DateModify)
values(1,N'Harman Kardon','2019/10/17','2019/10/17')
insert into ProductBrands(Admin_Id, Name, DateCreate,DateModify)
values(1,N'Razer','2019/10/17','2019/10/17')
insert into ProductBrands(Admin_Id, Name, DateCreate,DateModify)
values(1,N'STEELSERIES','2019/10/17','2019/10/17')
insert into ProductBrands(Admin_Id, Name, DateCreate,DateModify)
values(1,N'DAREU','2019/10/17','2019/10/17')
insert into ProductBrands(Admin_Id, Name, DateCreate,DateModify)
values(1,N'SOUNDMAX','2019/10/17','2019/10/17')
insert into ProductBrands(Admin_Id, Name, DateCreate,DateModify)
values(1,N'INFINITY','2019/10/17','2019/10/17')
insert into ProductBrands(Admin_Id, Name, DateCreate,DateModify)
values(1,N'Audio-technica','2019/10/17','2019/10/17')
insert into ProductBrands(Admin_Id, Name, DateCreate,DateModify)
values(1,N'D-link','2019/10/17','2019/10/17')
insert into ProductBrands(Admin_Id, Name, DateCreate,DateModify)
values(1,N'TPLINK','2019/10/17','2019/10/17')
insert into ProductBrands(Admin_Id, Name, DateCreate,DateModify)
values(1,N'LS','2019/10/17','2019/10/17')
insert into ProductBrands(Admin_Id, Name, DateCreate,DateModify)
values(1,N'PANASONIC','2019/10/17','2019/10/17')
insert into ProductBrands(Admin_Id, Name, DateCreate,DateModify)
values(1,N'Khác','2019/10/17','2019/10/17')

go
/*dữ liệu tạm cho bảng slug*/
insert into Slugs(Url, DateCreate, DateModify) values('url','2019/10/17','2019/10/17')
insert into Slugs(Url, DateCreate, DateModify) values('url1','2019/10/17','2019/10/17')
insert into Slugs(Url, DateCreate, DateModify) values('url2','2019/10/17','2019/10/17')
insert into Slugs(Url, DateCreate, DateModify) values('url3','2019/10/17','2019/10/17')
insert into Slugs(Url, DateCreate, DateModify) values('url4','2019/10/17','2019/10/17')
insert into Slugs(Url, DateCreate, DateModify) values('url5','2019/10/17','2019/10/17')
insert into Slugs(Url, DateCreate, DateModify) values('url6','2019/10/17','2019/10/17')
insert into Slugs(Url, DateCreate, DateModify) values('url7','2019/10/17','2019/10/17')
insert into Slugs(Url, DateCreate, DateModify) values('url8','2019/10/17','2019/10/17')
insert into Slugs(Url, DateCreate, DateModify) values('url9','2019/10/17','2019/10/17')
insert into Slugs(Url, DateCreate, DateModify) values('url10','2019/10/17','2019/10/17')
insert into Slugs(Url, DateCreate, DateModify) values('url11','2019/10/17','2019/10/17')
insert into Slugs(Url, DateCreate, DateModify) values('url12','2019/10/17','2019/10/17')
insert into Slugs(Url, DateCreate, DateModify) values('url13','2019/10/17','2019/10/17')
insert into Slugs(Url, DateCreate, DateModify) values('url14','2019/10/17','2019/10/17')
insert into Slugs(Url, DateCreate, DateModify) values('url15','2019/10/17','2019/10/17')
insert into Slugs(Url, DateCreate, DateModify) values('url16','2019/10/17','2019/10/17')
insert into Slugs(Url, DateCreate, DateModify) values('url17','2019/10/17','2019/10/17')
insert into Slugs(Url, DateCreate, DateModify) values('url18','2019/10/17','2019/10/17')
insert into Slugs(Url, DateCreate, DateModify) values('url19','2019/10/17','2019/10/17')
insert into Slugs(Url, DateCreate, DateModify) values('url20','2019/10/17','2019/10/17')



go
/**/

insert into 
Products(ProductBrand_Id,ProductType_Id,Slug_Id,Admin_Id, Name, Description, Price, Saleoff, Thumbnail, Instore,Stars,BuyPoints,Views,Orders,DateCreate,DateModify)
values
(1,1,1,1,N'Điện thoại Samsung Galaxy S10+ (512GB)',N'- Chính hãng, Mới 100%, Nguyên seal <br>
- Màn hình: Dynamic AMOLED 6.4"<br>
- Camera sau: 16MP, 2x 12MP<br>
- Camera trước: 8MP, 10MPbr<>
- CPU: Exynos 9820<br>
- Bộ nhớ: 512GB<br>
- RAM: 8GB<br>
- Hệ điều hành: Android 9.0<br>
',28990000,0,'DienThoai/dtsamsung1.png',0,5,0,0,0,'2019/10/18','2019/10/18'),
(1,1,2,1,N'Điện thoại Samsung Galaxy Note 10+',N'- Chính hãng, Mới 100%, Nguyên seal<>br
- Màn hình: 6.8" Dynamic AMOLED<br>
- Camera sau: 16MP, 2x 12MP, TOF 3D<br>
- Camera trước: 10MP<br>
- CPU: Exynos 9825<br>
- Bộ nhớ: 256GB<br>
- RAM: 12GB<br>
- Hệ điều hành: Android 9.0',26990000,0,'DienThoai/dtsamsung2.png',0,5,0,0,0,'2019/10/18','2019/10/18'),
(1,1,3,1,N'Điện thoại Samsung Galaxy Note 9',N'- Chính hãng, Mới 100%, Nguyên seal<br>
- Màn hình: Super AMOLED , 6.4"<br>
- Camera sau: 2x 12MP<br>
- Camera trước: 8MP<br>
- CPU: Exynos 9810<br>
- Bộ nhớ: 128GB<br>
- RAM: 6GB<br>
- Hệ điều hành: Android 8.1',22990000,0,'DienThoai/dtsamsung3.png',0,5,0,0,0,'2019/10/18','2019/10/18'),
(1,1,4,1,N'Samsung Galaxy s10',N'- Chính hãng, Mới 100%, Nguyên seal<br>
- Màn hình: 6.8" Dynamic AMOLED<br>
- Camera sau: 16MP, 2x 12MP, TOF 3D<br>
- Camera trước: 10MP<br>
- CPU: Exynos 9825<br>
- Bộ nhớ: 256GB<br>
- RAM: 12GB<br>
- Hệ điều hành: Android 9.0',24990000,0,'DienThoai/dtsamsung4.png',0,5,0,0,0,'2019/10/18','2019/10/18'),
(1,1,5,1,N'Điện thoại Samsung Galaxy A80',N'- Chính hãng, Mới 100%, Nguyên seal<br>
- Màn hình: Super AMOLED , 6.7"<br>
- Camera sau: 48MP, 8MP, TOF 3D<br>
- Camera trước: 8MP, 48MP, TOF 3D<br>
- CPU: Snapdragon 730<br>
- Bộ nhớ: 128GB<br>
- RAM: 8GB<br>
- Hệ điều hành: Android 9.0',14990000,0,'DienThoai/dtsamsung5.png',0,5,0,0,0,'2019/10/18','2019/10/18'),
(1,1,6,1,N'Điện thoại Samsung Galaxy A70',N'- Chính hãng, Mới 100%, Nguyên seal<br>
- Màn hình: Super AMOLED 6.7"<br>
- Camera sau: 5MP, 8MP, 32MP<br>
- Camera trước: 32MP<br>
- CPU: Snapdragon 675<br>
- Bộ nhớ: 128GB<br>
- RAM: 6GB<br>
- Hệ điều hành: Android 9.0<br>
',83900000,0,'DienThoai/dtsamsung6.png',0,5,0,0,0,'2019/10/18','2019/10/18'),
(8,1,7,1,N'Điện thoại iPhone Xs Max 256GB',N'- Chính hãng, Mới 100%, Nguyên seal<br>
- Màn hình: 6.5" OLED<br>
- Camera sau: 2x 12MP<br>
- Camera trước: 7MP<br>
- CPU: Apple A12 Bionic<br>
- Bộ nhớ: 256GB<br>
- RAM: 4GB<br>
- Hệ điều hành: iOS 12',35990000,0,'DienThoai/dtapple1.png',0,5,0,0,0,'2019/10/18','2019/10/18'),
(8,1,8,1,N'Điện thoại iPhone 11 Pro Max 64GB',N'- Chính hãng, Mới 100%, Nguyên seal<br>
- Màn hình: 6.5"<br>
- Camera sau: 3x 12MP<br>
- Camera trước: 12MP<br>
- CPU: A13 Bionic<br>
- Bộ nhớ: 64GB<br>
- RAM: 6GB<br>
- Hệ điều hành: iOS 13',33990000,0,'DienThoai/dtapple2.png',0,5,0,0,0,'2019/10/18','2019/10/18'),
(8,1,9,1,N'Điện thoại iPhone Xs 256GB',N'- Chính hãng, Mới 100%, Nguyên seal<br>
- Màn hình: 5.8" OLED<br>
- Camera sau: 2x 12MP<br>
- Camera trước: 7MP<br>
- CPU: Apple A12 Bionic<br>
- Bộ nhớ: 256GB<br>
- RAM: 4GB<br>
- Hệ điều hành: iOS 12',31990000,0,'DienThoai/dtapple3.png',0,5,0,0,0,'2019/10/18','2019/10/18'),
(8,1,10,1,N'Điện thoại iPhone Xs Max 64GB',N'- Chính hãng, Mới 100%, Nguyên seal<br>
- Màn hình: 6.5" OLED<br>
- Camera sau: 2x 12MP<br>
- Camera trước: 7MP<br>
- CPU: Apple A12 Bionic<br>
- Bộ nhớ: 64GB<br>
- RAM: 4GB<br>
- Hệ điều hành: iOS 12',29990000,0,'DienThoai/dtapple4.png',0,5,0,0,0,'2019/10/18','2019/10/18'),
(8,1,11,1,N'Điện thoại iPhone Xs 256GB',N'- Chính hãng, Mới 100%, Nguyên seal<br>
- Màn hình: 5.8" OLED<br>
- Camera sau: 2x 12MP<br>
- Camera trước: 7MP<br>
- CPU: Apple A12 Bionic<br>
- Bộ nhớ: 256GB<br>
- RAM: 4GB<br>
- Hệ điều hành: iOS 12',31990000,0,'DienThoai/dtapple5.png',0,5,0,0,0,'2019/10/18','2019/10/18'),
(8,1,12,1,N'Điện thoại iPhone Xs 64GB',N'- Chính hãng, Mới 100%, Nguyên seal<br>
- Màn hình: 5.8" OLED<br>
- Camera sau: 2x 12MP<br>
- Camera trước: 7MP<br>
- CPU: Apple A10 Bionic<br>
- Bộ nhớ: 64GB<br>
- RAM: 4GB<br>
- Hệ điều hành: iOS 12',25490000,0,'DienThoai/dtapple6.png',0,5,0,0,0,'2019/10/18','2019/10/18'),
(8,1,13,1,N'Điện thoại iPhone Xs 64GB',N'- Chính hãng, Mới 100%, Nguyên seal<br>
- Màn hình: 5.8" OLED<br>
- Camera sau: 2x 12MP<br>
- Camera trước: 7MP<br>
- CPU: Apple A10 Bionic<br>
- Bộ nhớ: 64GB<br>
- RAM: 4GB<br>
- Hệ điều hành: iOS 12',25490000,0,'DienThoai/dtapple6.png',0,5,0,0,0,'2019/10/18','2019/10/18')

go
insert into Products(ProductBrand_Id,ProductType_Id,Slug_Id,Admin_Id, Name, Description, Price, Saleoff, Thumbnail, Instore,Stars,BuyPoints,Views,Orders,DateCreate,DateModify)
values(2,1,16,1, N'Điện thoại Nokia 8.1',N'Chưa có mô tả',6590000,10,'DienThoai/dtsony1.png',0,5,0,12,11,'2019/11/06','2019/11/06')
insert into Products(ProductBrand_Id,ProductType_Id,Slug_Id,Admin_Id, Name, Description, Price, Saleoff, Thumbnail, Instore,Stars,BuyPoints,Views,Orders,DateCreate,DateModify)
values(2,1,17,1, N'Điện thoại Nokia 800 Tough',N'Chưa có mô tảĐiện thoại Nokia 800 Tough',2490000,15,'DienThoai/dtsony2.png',0,5,0,11,10,'2019/10/06','2019/10/06')
insert into Products(ProductBrand_Id,ProductType_Id,Slug_Id,Admin_Id, Name, Description, Price, Saleoff, Thumbnail, Instore,Stars,BuyPoints,Views,Orders,DateCreate,DateModify)
values(15,2,18,1, N'Laptop Lenovo IdeaPad S145 15IKB i3 7020U/4GB/256GB/Win10 (81VD0035VN)',N'Chưa có mô tả Laptop Lenovo IdeaPad S145 15IKB i3 7020U/4GB/256GB/Win10 (81VD0035VN)',9990000,5,'Laptop/LaptopLenovo1.png',1,2,0,11,10,'2019/11/18','2019/11/18')
insert into Products(ProductBrand_Id,ProductType_Id,Slug_Id,Admin_Id, Name, Description, Price, Saleoff, Thumbnail, Instore,Stars,BuyPoints,Views,Orders,DateCreate,DateModify)
values(8,2,19,1, N'Laptop Apple Macbook Air 2019 i5 1.6GHz/8GB/128GB (MVFM2SA/A)',N'Chưa có mô tả Laptop Apple Macbook Air 2019 i5 1.6GHz/8GB/128GB (MVFM2SA/A)',28990000,6,'Laptop/LaptopLenovo1.png',4,10,0,21,10,'2019/11/18','2019/11/18')



go

update ProductTypes set URL = 'dien-thoai-taplet' where id = 1
update ProductTypes set Type = N'Laptop' where id = 2
update ProductTypes set URL = 'laptop' where id = 2
update ProductTypes set Type = N'Máy tính đồng bộ' where id = 3
update ProductTypes set URL = 'may-tinh-dong-bo' where id = 3
update ProductTypes set type = N'Thiết bị âm thanh' where id = 4
update ProductTypes set URL = 'thiet-bi-am-thanh' where id = 4
update ProductTypes set URL = 'man-hinh-may-tinh' where id = 5
update ProductTypes set URL = 'linh-kien-may-tinh' where id = 6
update ProductTypes set URL = 'thiet-bi-van-phong' where id = 7
update ProductTypes set URL = 'thiet-bi-mang' where id = 8
go
update Products set ProductType_Id = 1 where 1 = 1 
go
insert into Roles (Name) values('Loai 1')
go
insert into Users(Role_Id,Email,PhoneNumber,NameFirst,NameMiddle,NameLast,Gender,DateBirth,AddressApartment,AddressStreet,AddressDistrict,AddressCity,BuyPoints,DateCreate,DateModify)
values(2,'a@gmai.com','0123456789',N'Nguyễn',N'Văn', N'a','nam','2000/11/11','1a','abb','aa','cc',0,'2019/11/17','2019/11/17')
go
insert into Comments(User_Id,Product_Id,Stars,Content,DateCreate,DateModify)
values(1,1,1,'aaaaaaaaaaaaa','2019/11/17','2019/11/17')
insert into Comments(User_Id,Product_Id,Stars,Content,DateCreate,DateModify)
values(1,1,3,'sdaaaaaaaaaaaaaa','2019/11/14','2019/11/14')
insert into Comments(User_Id,Product_Id,Stars,Content,DateCreate,DateModify)
values(1,1,4,'wreaadasdaaaaaaaaaaa','2019/11/15','2019/11/15')
insert into Comments(User_Id,Product_Id,Stars,Content,DateCreate,DateModify)
values(1,1,5,'qweqwaaaaaadshdfgeraaa','2019/11/10','2019/11/10')
insert into Comments(User_Id,Product_Id,Stars,Content,DateCreate,DateModify)
values(1,1,2,'aaqweqlkpooasddddd asdsssss saddddddddddd sadqw qqweqwe qweqw eqweqw qweqwe qweqw poqoqaaaa','2019/11/11','2019/11/11')
insert into Comments(User_Id,Product_Id,Stars,Content,DateCreate,DateModify)
values(1,1,4,'wreaadasdaaaaaaaaaaa','2019/11/09','2019/11/09')
insert into Comments(User_Id,Product_Id,Stars,Content,DateCreate,DateModify)
values(1,1,5,'qweqwaaaaaadshdfgeraaa','2019/11/01','2019/11/01')
insert into Comments(User_Id,Product_Id,Stars,Content,DateCreate,DateModify)
values(1,1,1,'aqweq asads aaaaaa','2019/10/17','2019/10/17')
insert into Comments(User_Id,Product_Id,Stars,Content,DateCreate,DateModify)
values(1,1,1,'aaaad adaaas aaaaas aaasda a','2019/10/27','2019/10/27')
insert into Comments(User_Id,Product_Id,Stars,Content,DateCreate,DateModify)
values(1,1,3,'sdaaaaaaaaaaaaa qwe aqweqw qwe qwe qweqw eqwe qwe dwajuho oi iak djoqihe oqen qkweh oheoqwn lknadoah ornql noe ih olqie iqheo  akjsdbaiuag iqwek jkndakk iuq','2019/11/14','2019/11/14')
insert into Comments(User_Id,Product_Id,Stars,Content,DateCreate,DateModify)
values(1,1,5,'qweqwaaaaaadshdfgeraaa','2019/11/10','2019/11/10')
insert into Comments(User_Id,Product_Id,Stars,Content,DateCreate,DateModify)
values(1,1,2,'aaqweqlkpooasddddd asdsssss saddddddddddd sadqw qqweqwe qweqw eqweqw qweqwe qweqw poqoqaaaa','2019/11/21','2019/11/21')
insert into Comments(User_Id,Product_Id,Stars,Content,DateCreate,DateModify)
values(1,1,4,'wreaadasdaaaaaaaaaaa','2019/11/19','2019/11/19')
insert into Comments(User_Id,Product_Id,Stars,Content,DateCreate,DateModify)
values(1,1,5,'qweqwaaaaaadshdfgeraaa','2019/11/11','2019/11/11')
insert into Comments(User_Id,Product_Id,Stars,Content,DateCreate,DateModify)
values(1,1,1,'aaaad adaaas aaaaas aaasda a','2019/10/23','2019/10/23')
insert into Comments(User_Id,Product_Id,Stars,Content,DateCreate,DateModify)
values(1,1,3,'sdaaaaaaaaaaaaa qwe aqweqw qwe qwe qweqw eqwe qwe dwajuho oi iak djoqihe oqen qkweh oheoqwn lknadoah ornql noe ih olqie iqheo  akjsdbaiuag iqwek jkndakk iuq','2019/11/14','2019/11/14')
insert into Comments(User_Id,Product_Id,Stars,Content,DateCreate,DateModify)
values(1,1,5,'qweqwaaaaaadshdfgeraaa','2019/11/15','2019/11/15')
insert into Comments(User_Id,Product_Id,Stars,Content,DateCreate,DateModify)
values(1,1,2,'aaqweqlkpooasddddd asdsssss saddddddddddd sadqw qqweqwe qweqw eqweqw qweqwe qweqw poqoqaaaa','2019/11/21','2019/11/21')
insert into Comments(User_Id,Product_Id,Stars,Content,DateCreate,DateModify)
values(1,1,4,'wreaadasdaaaaaaaaaaa','2019/11/26','2019/11/26')
insert into Comments(User_Id,Product_Id,Stars,Content,DateCreate,DateModify)
values(1,1,5,'qweqwaaaaaadshdfgeraaa','2019/11/01','2019/11/01')

insert into Comments(User_Id,Product_Id,Stars,Content,DateCreate,DateModify)
values(1,2,4,'wreaadasdaaaaaaaaaaa','2019/11/19','2019/11/19')
insert into Comments(User_Id,Product_Id,Stars,Content,DateCreate,DateModify)
values(1,2,5,'qweqwaaaaaadshdfgeraaa','2019/11/11','2019/11/11')
insert into Comments(User_Id,Product_Id,Stars,Content,DateCreate,DateModify)
values(1,2,1,'aaaad adaaas aaaaas aaasda a','2019/10/23','2019/10/23')
insert into Comments(User_Id,Product_Id,Stars,Content,DateCreate,DateModify)
values(1,2,3,'sdaaaaaaaaaaaaa qwe aqweqw qwe qwe qweqw eqwe qwe dwajuho oi iak djoqihe oqen qkweh oheoqwn lknadoah ornql noe ih olqie iqheo  akjsdbaiuag iqwek jkndakk iuq','2019/11/14','2019/11/14')
insert into Comments(User_Id,Product_Id,Stars,Content,DateCreate,DateModify)
values(1,2,5,'qweqwaaaaaadshdfgeraaa','2019/11/15','2019/11/15')
insert into Comments(User_Id,Product_Id,Stars,Content,DateCreate,DateModify)
values(1,2,2,'aaqweqlkpooasddddd asdsssss saddddddddddd sadqw qqweqwe qweqw eqweqw qweqwe qweqw poqoqaaaa','2019/11/21','2019/11/21')
insert into Comments(User_Id,Product_Id,Stars,Content,DateCreate,DateModify)
values(1,2,4,'wreaadasdaaaaaaaaaaa','2019/11/26','2019/11/26')
insert into Comments(User_Id,Product_Id,Stars,Content,DateCreate,DateModify)
values(1,2,5,'qweqwaaaaaadshdfgeraaa','2019/11/01','2019/11/01')
go

insert into CartStatuses(Status) VALUES('free'),('using');