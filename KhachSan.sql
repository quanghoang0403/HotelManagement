CREATE DATABASE KhachSan
Go

USE KhachSan
GO

--ACCOUNT           - Thông tin tài khoản
--AMOUNT			- Tỉ lệ phụ thu, sl khách tối đa, sl khách tiêu chuẩn để phụ thu
--ROOM              - Danh sách phòng
--ROOMTYPE          - Danh sách loại phòng 
--CHECKIN			- Phiếu thuê phòng
--CHECKINDETAILS	- Thông tin khách hàng của mỗi phiếu thuê phòng
--BILL				- Hóa đơn
--BILLDETAILS		- Thông tin chi tiết của hóa đơn, gồm thông tin những phòng cần thanh toán

CREATE TABLE ACCOUNT
(
	id_user INT IDENTITY PRIMARY KEY,
	display_name NVARCHAR(100) NOT NULL,
	username NVARCHAR(100) NOT NULL,
	pass NVARCHAR(1000) NOT NULL,
	permission NVARCHAR(100) NOT NULL,
)


INSERT INTO ACCOUNT VALUES('QUAN LY','admin','admin','Manager')

CREATE TABLE ROOMTYPE
(
	room_type NVARCHAR(100) PRIMARY KEY,
	price MONEY
)

CREATE TABLE AMOUNT
(
	customer_ratio FLOAT,
	max_customer INT,
	amount_surchage INT
)


INSERT INTO ROOMTYPE VALUES('A','150000')
INSERT INTO ROOMTYPE VALUES('B','170000')
INSERT INTO ROOMTYPE VALUES('C','200000')

CREATE TABLE ROOM
(
	id_room NVARCHAR(100) PRIMARY KEY,
	room_type NVARCHAR(100) NOT NULL,
	notes NVARCHAR(100),
	statuss NVARCHAR(100),

	FOREIGN KEY (room_type) REFERENCES ROOMTYPE(room_type)
)

INSERT INTO ROOM VALUES('1','A','','EMPTY')
INSERT INTO ROOM VALUES('2','A','','EMPTY')
INSERT INTO ROOM VALUES('3','B','','EMPTY')
INSERT INTO ROOM VALUES('4','B','','EMPTY')
INSERT INTO ROOM VALUES('5','C','','EMPTY')
INSERT INTO ROOM VALUES('6','C','','EMPTY')
INSERT INTO ROOM VALUES('7','C','','EMPTY')

CREATE TABLE CUSTOMER_TYPE
(
	customer_type NVARCHAR(100) PRIMARY KEY,
	ratio FLOAT,
)

INSERT INTO CUSTOMER_TYPE VALUES('Noidia','1')
INSERT INTO CUSTOMER_TYPE VALUES('Nuocngoai','1.5')

CREATE TABLE CHECKIN
(
	id_checkin INT IDENTITY PRIMARY KEY,
	date_start DATE NOT NULL,
	id_room NVARCHAR(100),
	money_checkin MONEY,
	type_ratioMAX float,
	number_customer int,
	status_checkin NVARCHAR(100),
	FOREIGN KEY (id_room) REFERENCES ROOM(id_room)
)

CREATE TABLE CHECKIN_DETAILS
(
	id_checkin_details INT IDENTITY PRIMARY KEY,
	customer_name NVARCHAR(100),
	customer_type NVARCHAR(100),
	customer_cmnd NVARCHAR(100),
	customer_address NVARCHAR(100),
	id_checkin INT,

	FOREIGN KEY (customer_type)  REFERENCES CUSTOMER_TYPE(customer_type),
	FOREIGN KEY (id_checkin)  REFERENCES CHECKIN(id_checkin)
)

CREATE TABLE BILL
(
	id_bill INT IDENTITY PRIMARY KEY,
	bill_name NVARCHAR(100),
	bill_address NVARCHAR(100),
	total_money NVARCHAR(100),
)

CREATE TABLE BILL_DETAILS
(
	id_bill	INT FOREIGN KEY REFERENCES BILL(id_bill),
	id_checkin INT FOREIGN KEY REFERENCES CHECKIN(id_checkin),	
	date_number	INT,
	surchage_ratio FLOAT,
	ADD date_payment DATE,
	CONSTRAINT PK_BILL_DETAILS primary key (id_bill, id_checkin)
)

--tạo proc hiển thị roomlist
CREATE PROC USP_GetRoomList
AS SELECT * FROM ROOM
GO

--tạo proc đăng nhập tránh injection
CREATE PROC USP_LOGIN
(@username nvarchar(100),
@pass nvarchar(1000))
as
begin
	SELECT * FROM ACCOUNT WHERE username = @username and pass= @pass
end 
go

--tạo thông tin chi tiết phiếu checkin
CREATE PROC USP_InsertCheckinInfo
   (@customer_name NVARCHAR(100),
	@customer_type NVARCHAR(100),
	@customer_cmnd NVARCHAR(100),
	@customer_address NVARCHAR(100),
	@id_checkin INT)
as 
begin 
	insert CHECKIN_DETAILS
		  ( customer_name,
			customer_type,
			customer_cmnd,
			customer_address,
			id_checkin
		  )
	values (@customer_name,
			@customer_type,
			@customer_cmnd,
			@customer_address,
			@id_checkin
		   )
end
go

--tạo phiếu checkin
CREATE PROC USP_InsertCheckin
(@date date,
 @id_room nvarchar(100))
as 
begin 
	insert CHECKIN
		  ( date_start,
		    id_room,
		    money_checkin,
			type_ratioMAX,
			number_customer,
			status_checkin
		  )
	values ( @date,
			@id_room,
			0,
			1,
			0,
			'USING'
		  )
end
go

--thêm bill

CREATE PROC USP_InsertBill
(@name nvarchar(100),
 @address nvarchar(100))
as 
begin 
	insert BILL
		  ( bill_name,
		    bill_address,
		    total_money
		  )
	values ( @name,
			@address,
			0
		  )
end
go

--thêm bill_details
CREATE PROC USP_InsertBillInfo
(@id_bill int,
 @id_checkin int,
 @date_number int,
 @date_payment date,
 @surchage_ratio float)
as 
begin 
	insert BILL_DETAILS
		  ( id_bill,
		    id_checkin,
		    date_number, 
			date_payment,
			surchage_ratio
		  )
	values ( @id_bill,
			@id_checkin,
			@date_number,
			@date_payment,
			@surchage_ratio
		  )
end
go

SELECT C.id_room AS ID_ROOM, BD.date_number AS DATE_NUMBER, RT.price AS PRICE, C.type_ratioMAX AS TYPE_RATIO, BD.surchage_ratio AS NUMBER_RATIO, RT.price*C.type_ratioMAX*BD.surchage_ratio*BD.date_number AS TOTAL  
FROM BILL_DETAILS AS BD,CHECKIN AS C, ROOM AS R, ROOMTYPE AS RT
WHERE BD.id_checkin = C.id_checkin 
  and C.id_room = R.id_room
  and R.room_type = RT.room_type
  and BD.id_checkin = 22 
  and BD.id_bill = 8
--SHOW THONG TIN PHONG CUA HON DON THANH TOAN
