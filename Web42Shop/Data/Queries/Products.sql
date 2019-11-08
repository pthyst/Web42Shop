use Web42Shop
go
/*thêm dữ liệu tạm cho bảng roles*/
insert into Roles(Name) values(N'Nhân viên nhập hàng')

go
/*thêm dữ liệu tạm cho bảng Admins*/
insert into  Admins(Role_Id,Username,Password,Email,DateCreate,DateModify)
values(1,'nhanvien','123','nhanvien@gmail.com','2019/10/17','2019/10/17')

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
values(1,N'Panasonic','2019/10/17','2019/10/17')
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
insert into Slug(Url, DateCreate, DateModify) values('url','2019/10/17','2019/10/17')
insert into Slug(Url, DateCreate, DateModify) values('url1','2019/10/17','2019/10/17')
insert into Slug(Url, DateCreate, DateModify) values('url2','2019/10/17','2019/10/17')
insert into Slug(Url, DateCreate, DateModify) values('url3','2019/10/17','2019/10/17')
insert into Slug(Url, DateCreate, DateModify) values('url4','2019/10/17','2019/10/17')
insert into Slug(Url, DateCreate, DateModify) values('url5','2019/10/17','2019/10/17')
insert into Slug(Url, DateCreate, DateModify) values('url6','2019/10/17','2019/10/17')
insert into Slug(Url, DateCreate, DateModify) values('url7','2019/10/17','2019/10/17')
insert into Slug(Url, DateCreate, DateModify) values('url8','2019/10/17','2019/10/17')
insert into Slug(Url, DateCreate, DateModify) values('url9','2019/10/17','2019/10/17')
insert into Slug(Url, DateCreate, DateModify) values('url10','2019/10/17','2019/10/17')
insert into Slug(Url, DateCreate, DateModify) values('url11','2019/10/17','2019/10/17')
insert into Slug(Url, DateCreate, DateModify) values('url12','2019/10/17','2019/10/17')




go
/**/
insert into 
Product(ProductBrand_Id,ProductType_Id,Slug_Id,Admin_Id, Name, Description, Price, Saleoff, Thumbnail, Instore,Stars,BuyPoints,Views,Orders,DateCreate,DateModify)
values
(1,3,1,1,N'Điện thoại Samsung Galaxy S10+ (512GB)',N'- Chính hãng, Mới 100%, Nguyên seal <br>
- Màn hình: Dynamic AMOLED 6.4"<br>
- Camera sau: 16MP, 2x 12MP<br>
- Camera trước: 8MP, 10MPbr<>
- CPU: Exynos 9820<br>
- Bộ nhớ: 512GB<br>
- RAM: 8GB<br>
- Hệ điều hành: Android 9.0<br>
',28990000,0,'DienThoai/dtsamsung1.png',0,5,0,0,0,'2019/10/18','2019/10/18'),
(1,3,14,1,N'Điện thoại Samsung Galaxy Note 10+',N'- Chính hãng, Mới 100%, Nguyên seal<>br
- Màn hình: 6.8" Dynamic AMOLED<br>
- Camera sau: 16MP, 2x 12MP, TOF 3D<br>
- Camera trước: 10MP<br>
- CPU: Exynos 9825<br>
- Bộ nhớ: 256GB<br>
- RAM: 12GB<br>
- Hệ điều hành: Android 9.0',26990000,0,'DienThoai/dtsamsung2.png',0,5,0,0,0,'2019/10/18','2019/10/18'),
(1,3,15,1,N'Điện thoại Samsung Galaxy Note 9',N'- Chính hãng, Mới 100%, Nguyên seal<br>
- Màn hình: Super AMOLED , 6.4"<br>
- Camera sau: 2x 12MP<br>
- Camera trước: 8MP<br>
- CPU: Exynos 9810<br>
- Bộ nhớ: 128GB<br>
- RAM: 6GB<br>
- Hệ điều hành: Android 8.1',22990000,0,'DienThoai/dtsamsung3.png',0,5,0,0,0,'2019/10/18','2019/10/18'),
(1,3,16,1,N'Samsung Galaxy s10',N'- Chính hãng, Mới 100%, Nguyên seal<br>
- Màn hình: 6.8" Dynamic AMOLED<br>
- Camera sau: 16MP, 2x 12MP, TOF 3D<br>
- Camera trước: 10MP<br>
- CPU: Exynos 9825<br>
- Bộ nhớ: 256GB<br>
- RAM: 12GB<br>
- Hệ điều hành: Android 9.0',24990000,0,'DienThoai/dtsamsung4.png',0,5,0,0,0,'2019/10/18','2019/10/18'),
(1,3,17,1,N'Điện thoại Samsung Galaxy A80',N'- Chính hãng, Mới 100%, Nguyên seal<br>
- Màn hình: Super AMOLED , 6.7"<br>
- Camera sau: 48MP, 8MP, TOF 3D<br>
- Camera trước: 8MP, 48MP, TOF 3D<br>
- CPU: Snapdragon 730<br>
- Bộ nhớ: 128GB<br>
- RAM: 8GB<br>
- Hệ điều hành: Android 9.0',14990000,0,'DienThoai/samsung5.png',0,5,0,0,0,'2019/10/18','2019/10/18'),
(1,3,18,1,N'Điện thoại Samsung Galaxy A70',N'- Chính hãng, Mới 100%, Nguyên seal<br>
- Màn hình: Super AMOLED 6.7"<br>
- Camera sau: 5MP, 8MP, 32MP<br>
- Camera trước: 32MP<br>
- CPU: Snapdragon 675<br>
- Bộ nhớ: 128GB<br>
- RAM: 6GB<br>
- Hệ điều hành: Android 9.0<br>
',83900000,0,'DienThoai/dtsamsung6.png',0,5,0,0,0,'2019/10/18','2019/10/18'),
(9,3,19,1,N'Điện thoại iPhone Xs Max 256GB',N'- Chính hãng, Mới 100%, Nguyên seal<br>
- Màn hình: 6.5" OLED<br>
- Camera sau: 2x 12MP<br>
- Camera trước: 7MP<br>
- CPU: Apple A12 Bionic<br>
- Bộ nhớ: 256GB<br>
- RAM: 4GB<br>
- Hệ điều hành: iOS 12',35990000,0,'DienThoai/dtapple1.png',0,5,0,0,0,'2019/10/18','2019/10/18'),
(9,3,20,1,N'Điện thoại iPhone 11 Pro Max 64GB',N'- Chính hãng, Mới 100%, Nguyên seal<br>
- Màn hình: 6.5"<br>
- Camera sau: 3x 12MP<br>
- Camera trước: 12MP<br>
- CPU: A13 Bionic<br>
- Bộ nhớ: 64GB<br>
- RAM: 6GB<br>
- Hệ điều hành: iOS 13',33990000,0,'DienThoai/apple2.png',0,5,0,0,0,'2019/10/18','2019/10/18'),
(9,3,21,1,N'Điện thoại iPhone Xs 256GB',N'- Chính hãng, Mới 100%, Nguyên seal<br>
- Màn hình: 5.8" OLED<br>
- Camera sau: 2x 12MP<br>
- Camera trước: 7MP<br>
- CPU: Apple A12 Bionic<br>
- Bộ nhớ: 256GB<br>
- RAM: 4GB<br>
- Hệ điều hành: iOS 12',31990000,0,'DienThoai/apple3.png',0,5,0,0,0,'2019/10/18','2019/10/18'),
(9,3,22,1,N'Điện thoại iPhone Xs Max 64GB',N'- Chính hãng, Mới 100%, Nguyên seal<br>
- Màn hình: 6.5" OLED<br>
- Camera sau: 2x 12MP<br>
- Camera trước: 7MP<br>
- CPU: Apple A12 Bionic<br>
- Bộ nhớ: 64GB<br>
- RAM: 4GB<br>
- Hệ điều hành: iOS 12',29990000,0,'DienThoai/dtapple4.png',0,5,0,0,0,'2019/10/18','2019/10/18'),
(1,3,23,1,N'Điện thoại iPhone Xs 256GB',N'- Chính hãng, Mới 100%, Nguyên seal<br>
- Màn hình: 5.8" OLED<br>
- Camera sau: 2x 12MP<br>
- Camera trước: 7MP<br>
- CPU: Apple A12 Bionic<br>
- Bộ nhớ: 256GB<br>
- RAM: 4GB<br>
- Hệ điều hành: iOS 12',31990000,0,'DienThoai/dtaple5.png',0,5,0,0,0,'2019/10/18','2019/10/18'),
(1,3,24,1,N'Điện thoại iPhone Xs 64GB',N'- Chính hãng, Mới 100%, Nguyên seal<br>
- Màn hình: 5.8" OLED<br>
- Camera sau: 2x 12MP<br>
- Camera trước: 7MP<br>
- CPU: Apple A10 Bionic<br>
- Bộ nhớ: 64GB<br>
- RAM: 4GB<br>
- Hệ điều hành: iOS 12',25490000,0,'DienThoai/dtappl6.png',0,5,0,0,0,'2019/10/18','2019/10/18')

-- Sương
insert Roles values (N'Người Dùng')
--user
insert Users values
(2,'Suong@gmail.com','0968467519',N'Sương',N'Ngọc Như',N'Nguyễn',N'Nữ','1997-12-13','','','','','90','',''),
(2,'Suong1@gmail.com','0968467518',N'Sương',N'Ngọc Như',N'Nguyễn',N'Nữ','1997-12-13','','','','','90','',''),
(2,'Suong2@gmail.com','0968467517',N'Sương',N'Ngọc Như',N'Nguyễn',N'Nữ','1997-12-13','','','','','90','',''),
(2,'Suong3@gmail.com','0968467516',N'Sương',N'Ngọc Như',N'Nguyễn',N'Nữ','1997-12-13','','','','','90','',''),
(2,'Suong4@gmail.com','0968467515',N'Sương',N'Ngọc Như',N'Nguyễn',N'Nữ','1997-12-13','','','','','90','','')