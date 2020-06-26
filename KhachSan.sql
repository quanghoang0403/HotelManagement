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

INSERT INTO ROOMTYPE VALUES('A','150000')
INSERT INTO ROOMTYPE VALUES('B','170000')
INSERT INTO ROOMTYPE VALUES('C','200000')

CREATE TABLE AMOUNT
(
	customer_ratio FLOAT,
	max_customer INT,
	amount_surchage INT
)

INSERT INTO AMOUNT VALUES('1.25','3','3')

CREATE TABLE ROOM
(
	id_room NVARCHAR(100) PRIMARY KEY,
	room_type NVARCHAR(100) NOT NULL,
	notes NVARCHAR(100),
	statuss NVARCHAR(100),

	FOREIGN KEY (room_type) REFERENCES ROOMTYPE(room_type) ON UPDATE CASCADE 
)

INSERT INTO ROOM VALUES('1','A','','EMPTY')
INSERT INTO ROOM VALUES('2','A','','EMPTY')
INSERT INTO ROOM VALUES('3','B','','EMPTY')
INSERT INTO ROOM VALUES('4','B','','EMPTY')
INSERT INTO ROOM VALUES('5','C','','EMPTY')
INSERT INTO ROOM VALUES('6','C','','EMPTY')

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
	CONSTRAINT PK_BILL_DETAILS primary key (id_bill, id_checkin)
)

--tạo proc hiển thị roomlist
CREATE PROC USP_GetRoomList
AS SELECT * FROM ROOM
GO

--tạo proc hiển thị amountlist
CREATE PROC USP_GetAmountList
AS SELECT * FROM AMOUNT
GO

--tạo proc hiển thị billist
CREATE PROC USP_GetBillList
AS select * from dbo.BILL
go

--tạo proc hiển thị checkinlist
CREATE PROC USP_GetCheckinlist
AS SELECT * FROM CHECKIN
GO

--tạo proc hiển thị customertypelist
CREATE PROC USP_GetCustomertypeList
AS SELECT * FROM CUSTOMER_TYPE
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
 @surchage_ratio float)
as 
begin 
	insert BILL_DETAILS
		  ( id_bill,
		    id_checkin,
		    date_number, 
			surchage_ratio
		  )
	values ( @id_bill,
			@id_checkin,
			@date_number,
			@surchage_ratio
		  )
end
go

CREATE PROC USP_SignIn
   (@name NVARCHAR(100),
	@username NVARCHAR(100),
	@pass NVARCHAR(100),
	@permission NVARCHAR(100))
as 
begin 
	insert ACCOUNT
		  ( display_name,
			username,
			pass,
			permission
		  )
	values (@name,
			@username,
			@pass,
			@permission 
		   )
end
go

CREATE PROC USP_GetAccountList
AS select * from ACCOUNT
GO

CREATE PROC USP_GetByRoomType
(@room_type NVARCHAR(100))
AS select * from ROOMTYPE where room_type = @room_type
GO

CREATE PROC USP_GetByRoom
(@id_room NVARCHAR(100))
AS select * from ROOM where id_room = @id_room
GO

CREATE PROC USP_GetListType
AS SELECT * FROM CUSTOMER_TYPE
GO

CREATE PROC USP_GetByCustomerType
(@customer_type NVARCHAR(100))
AS select * from CUSTOMER_TYPE where customer_type = @customer_type
GO

CREATE PROC USP_GetStatus
(@id_room NVARCHAR(100))
AS SELECT statuss FROM ROOM WHERE id_room = @id_room
GO

CREATE PROC USP_GetRoom
AS SELECT * FROM ROOM
GO

CREATE PROC USP_GetRoomType
AS SELECT * FROM ROOMTYPE
GO

CREATE PROC USP_GetMaxIDCheckin
AS select MAX(id_checkin) from CHECKIN
GO

CREATE PROC USP_GetRatioCustomer
AS Select customer_ratio from AMOUNT
GO

CREATE PROC USP_GetAmountSurchage
AS select amount_surchage from AMOUNT
GO

CREATE PROC USP_GetMaxIDBill
AS select MAX(id_bill) from BILL
GO

CREATE PROC USP_GetStatusCheckin
(@id_checkin int)
AS select status_checkin from CHECKIN where id_checkin = @id_checkin
GO

CREATE PROC USP_GetIdRoom
(@id_checkin int)
AS select id_room from CHECKIN where id_checkin = @id_checkin
GO

CREATE PROC USP_GetNumberCustomer
(@id_checkin int)
AS select number_customer from CHECKIN where id_checkin = @id_checkin
GO

CREATE PROC USP_GetDate
(@id_checkin int)
AS select date_start from CHECKIN where id_checkin = @id_checkin
GO

CREATE PROC USP_GetListBillInfo
(@id_bill int,
 @id_checkin int)
AS SELECT C.id_room AS ID_ROOM, BD.date_number AS DATE_NUMBER, RT.price AS PRICE, C.type_ratioMAX AS TYPE_RATIO, BD.surchage_ratio AS NUMBER_RATIO, RT.price*C.type_ratioMAX*BD.surchage_ratio*BD.date_number AS TOTAL FROM BILL_DETAILS AS BD, CHECKIN AS C, ROOM AS R, ROOMTYPE AS RT WHERE BD.id_checkin = C.id_checkin and C.id_room = R.id_room and R.room_type = RT.room_type and BD.id_bill = @id_bill and BD.id_checkin = @id_checkin
GO

CREATE PROC USP_UpdateHome
   (@id_room NVARCHAR(100),
   @statuss NVARCHAR(100))
as 
begin 
	update ROOM
	SET   statuss = @statuss  
    WHERE id_room = @id_room
end
go

CREATE PROC USP_UpdateBill
   (@totalmoney float,
   @id_bill int)
as 
begin 
	update BILL
	SET   total_money = @totalmoney 
    WHERE id_bill = @id_bill
end
go

CREATE PROC USP_UpdateCheckin
   (@money float,
   @status NVARCHAR(100),
   @id_checkin int)
as 
begin 
	update CHECKIN
	SET   money_checkin = @money,
		  status_checkin = @status
    WHERE id_checkin = @id_checkin
end
go

--checkin
CREATE PROC USP_GetListCheckinInfo
(@id int)
AS select *from CHECKIN_DETAILS where id_checkin = @id
GO

CREATE PROC USP_GetAmountCustomer
(@id int)
AS select COUNT(*) from CHECKIN_DETAILS WHERE id_checkin = @id
GO

CREATE PROC USP_GetMaxRatio
(@id int)
AS select MAX(ratio) from CHECKIN_DETAILS AS CD, CUSTOMER_TYPE AS CT WHERE CD.customer_type= CT.customer_type and CD.id_checkin = @id
GO

CREATE PROC USP_UpdateRatioCheckin
   (@ratio float,
   @count int,
   @id_checkin int)
as 
begin 
	update CHECKIN
	SET   type_ratioMAX = @ratio,
		  number_customer =  @count
    WHERE id_checkin = @id_checkin
end
go

--permission
CREATE PROC USP_GetPermission
(@username nvarchar(100))
AS select permission from ACCOUNT where username = @username
GO

--revenue
CREATE PROC USP_LoadRevenue
(@month nvarchar(100),
@year nvarchar(100))
AS 
	select distinct ROOMTYPE.room_type,SUM(money_checkin) as Income
	from ROOMTYPE, CHECKIN, ROOM
	where CHECKIN.id_room = ROOM.id_room 
		and ROOM.room_type = ROOMTYPE.room_type 
		and MONTH(date_start)= @month
		and YEAR(date_start)= @year
	group by ROOMTYPE.room_type
GO

--setting 
CREATE PROC USP_ChangePassword
   (@pass nvarchar(100),
   @username nvarchar(100))
as 
begin 
	update ACCOUNT
	SET   pass = @pass
    WHERE username = @username
end
go

CREATE PROC USP_UpdateCustomertype
   (@customer_type nvarchar(100),
   @ratio nvarchar(100))
as 
begin 
	update CUSTOMER_TYPE
	SET   ratio = @ratio
    WHERE customer_type = @customer_type
end
go

CREATE PROC USP_DeleteCustomertype
   (@customer_type nvarchar(100))
as 
begin 
	DELETE FROM CUSTOMER_TYPE 
    WHERE  customer_type = @customer_type
end
go

CREATE PROC USP_DeleteAmount
as 
begin 
	DELETE FROM AMOUNT
end
go

CREATE PROC USP_InsertAmount
(@customer_ratio nvarchar(100),
 @max_customer nvarchar(100),
 @amount_surchage nvarchar(100))
as 
begin 
	insert AMOUNT
		  ( customer_ratio,
		    max_customer,
			amount_surchage
		  )
	values ( @customer_ratio,
			@max_customer,
			@amount_surchage
		  )
end
go

CREATE PROC USP_AddCustomertype
(@customer_type nvarchar(100),
 @ratio float)
as 
begin 
	insert CUSTOMER_TYPE
		  ( customer_type,
		    ratio
		  )
	values ( @customer_type,
			@ratio
		  )
end
go

--RoomManagement 
CREATE PROC USP_AddRoomType
(@roomtype nvarchar(100),
 @price nvarchar(100))
as 
begin 
	insert ROOMTYPE
		  ( room_type,
		    price
		  )
	values ( @roomtype,
			@price
		  )
end
go

CREATE PROC USP_AddRoom
(@id_room nvarchar(100),
 @class_room nvarchar(100),
 @note nvarchar(100),
 @status  nvarchar(100))
as 
begin 
	insert ROOM
		  ( id_room,
		    room_type,
			notes,
			statuss
		  )
	values ( @id_room,
			@class_room,
			@note,
			@status
		  )
end
go

CREATE PROC USP_DeleteRoomType
   (@roomtype nvarchar(100))
as 
begin 
	DELETE FROM ROOMTYPE
    WHERE room_type = @roomtype
end
go

CREATE PROC USP_DeleteRoom
   (@id_room nvarchar(100))
as 
begin 
	DELETE FROM ROOM
    WHERE id_room = @id_room
end
go

CREATE PROC USP_UpdateRoomType
   (@oldroomtype nvarchar(100),
   @newroomtype nvarchar(100),
   @newprice money)
as 
begin 
	update ROOMTYPE
	SET   room_type = @newroomtype,
		  price = @newprice
    WHERE room_type = @newroomtype
end
go

CREATE PROC USP_UpdateRoom
   (@id_room nvarchar(100),
   @class_room nvarchar(100),
   @note nvarchar(100),
   @status nvarchar(100))
as 
begin 
	update ROOM
	SET   room_type = @class_room,
		  notes = @note,
		  statuss = @status		
    WHERE id_room = @id_room
end
go


--test
SELECT C.id_room AS ID_ROOM, BD.date_number AS DATE_NUMBER, RT.price AS PRICE, C.type_ratioMAX AS TYPE_RATIO, BD.surchage_ratio AS NUMBER_RATIO, RT.price*C.type_ratioMAX*BD.surchage_ratio*BD.date_number AS TOTAL  
FROM BILL_DETAILS AS BD,CHECKIN AS C, ROOM AS R, ROOMTYPE AS RT
WHERE BD.id_checkin = C.id_checkin 
  and C.id_room = R.id_room
  and R.room_type = RT.room_type
  and BD.id_checkin = 22 
  and BD.id_bill = 8
select * from CHECKIN
select * from BILL
--SHOW THONG TIN PHONG CUA HON DON THANH TOAN
