CREATE DATABASE Thu_Vien_EAUT_Latest3;
GO
--Use QLKS
--drop database Thu_Vien_EAUT_Latest3
USE Thu_Vien_EAUT_Latest3;
GO

CREATE TABLE DBO.TAI_KHOAN
(
	Ten_TK char(30) PRIMARY KEY,
	Mat_Khau char(30),
	Quyen int
)

INSERT INTO DBO.TAI_KHOAN VALUES
('admin','admin',3),
('thuthu','thuthu',2)

Select Ten_TK, Mat_Khau from TAI_KHOAN
--drop table dbo.TAI_KHOAN
CREATE TABLE DBO.TAC_GIA
(
	Ma_TG char(20) PRIMARY KEY,
	Ten_TG Nvarchar(50)
)

--SELECT * FROM DBO.TAC_GIA
DELETE FROM DBO.TAC_GIA WHERE Ma_TG = 'TG003'
--select Ma_TG from dbo.SACH WHERE MaSach = 'MS003'
INSERT INTO DBO.TAC_GIA VALUES 
('TG002',N'Đức'),
('TG001',N'Tâm')

CREATE TABLE DBO.THE_LOAI
(
	Ma_TL char(20) PRIMARY KEY,
	Ten_TL Nvarchar(50)
)
--select * from dbo.THE_LOAI
--delete from dbo.THE_LOAI WHERE Ma_TL = 'TL002'
INSERT INTO DBO.THE_LOAI VALUES 
('TL001',N'Truyện cười')

CREATE TABLE DBO.NHA_XUAT_BAN
(
	Ma_NXB char(20) PRIMARY KEY,
	Ten_NXB Nvarchar(50)
)
 --select * from dbo.NHA_XUAT_BAN
 --delete from dbo.NHA_XUAT_BAN where Ma_NXB = 'NXB005'

INSERT INTO DBO.NHA_XUAT_BAN VALUES 
('XB001',N'Kim Đồng')
select COUNT(*) from MUON_TRA where MaSach = 'MS002'
select * from MUON_TRA
CREATE TABLE DBO.SACH
(
	MaSach char(20) PRIMARY KEY,
	TenSach Nvarchar(100),
	Ma_TG char(20) foreign key references TAC_GIA(Ma_TG),
	Ten_TG Ntext,
	Ma_TL char(20) foreign key references THE_LOAI(Ma_TL),
	Ten_TL Nvarchar(50),
	Ma_NXB char(20) foreign key references NHA_XUAT_BAN(Ma_NXB),
	Ten_NXB Nvarchar(50),
	Nam_XB char(10),
	Tinh_trang_Sach Nvarchar(100),
	So_Luong char(10),
	Da_Muon char(10),
	Ton_Kho char(10)
)

select * from dbo.CHI_TIET_MUON_TRA
select * from SACH
SELECT So_Luong, Da_Muon,( CONVERT(int,So_Luong) - CONVERT(INT,Da_Muon)) FROM DBO.SACH WHERE MaSach = 'MS002'

select * from THE_LOAI
INSERT INTO DBO.SACH VALUES 
('MS001',N'300 bài code thiếu nhi','TG001',N'Tâm','TL001',N'Tuyện cười','XB001','Kim Đồng','2023-02-24',N'Rất mới','10','3','7')
INSERT INTO DBO.SACH VALUES 
('MS002',N'Truyện Conan','TG002',N'Đức','TL001',N'Tuyện cười','XB001','Kim Đồng','2023-4-1',N'Rất mới','5','3','2')
--drop table dbo.SACH
--DELETE FROM DBO.SACH WHERE MaSach = 'MS002'
--SELECT * FROM DOC_GIA WHERE Ten_TK = 'user';
CREATE TABLE DBO.DOC_GIA
(
	Ma_DG char(20) PRIMARY KEY,
	Ten_DG Nvarchar(50),
	Lop char(10),
	So_DT char(10),
	Ten_TK char(30),
)
SELECT * FROM DOC_GIA 
--drop table dbo.DOC_GIA
INSERT INTO DBO.DOC_GIA VALUES
('KH001',N'Admin','IT3','09999','admin'),
('KH002',N'Thủ Thư','IT3','09999','thuthu')


CREATE TABLE DBO.NHAN_VIEN
(
	Ma_NV char(20) PRIMARY KEY,
	Ten_NV Nvarchar(50),
	Ngay_Sinh char(10),
	So_DT int,
	Chuc_Vu Nvarchar(20),
	CMND int,
	Ten_DN char(30),
)
--drop table dbo.NHAN_VIEN
INSERT INTO DBO.NHAN_VIEN VALUES 
('NV001',N'Nhân viên Đức','24/02/2002',03213466,N'Thủ Thư',033333,'admin')
INSERT INTO DBO.NHAN_VIEN (Ma_NV,Ten_NV) VALUES 
('NV002',N'Online')

CREATE TABLE MUON_TRA
(
	Ma_MT char(20) PRIMARY KEY,
	Ma_DG char(20) foreign key references DOC_GIA(Ma_DG),
	Ten_DG Nvarchar(50),
	Lop char(20),
	So_DT char(10),
	Ma_NV char(20) foreign key references NHAN_VIEN(Ma_NV),
	Ten_NV Nvarchar(50),
	So_luong int
	
);
SELECT MUON_TRA.Ma_MT, MUON_TRA.Ten_DG, MUON_TRA.Lop, MUON_TRA.So_DT, MUON_TRA.Ten_NV, MUON_TRA.So_luong FROM DBO.MUON_TRA 
SELECT MUON_TRA.Ma_MT, MUON_TRA.Ten_DG, MUON_TRA.Lop, MUON_TRA.So_DT, MUON_TRA.Ten_NV, CHI_TIET_MUON_TRA.Soluong FROM DBO.MUON_TRA INNER JOIN DBO.CHI_TIET_MUON_TRA ON MUON_TRA.Ma_MT = CHI_TIET_MUON_TRA.MaMT
SELECT * FROM MUON_TRA
create table CHI_TIET_MUON_TRA
(
	MaSach char(20) foreign key references SACH(MaSach),
	MaMT char(20) foreign key references MUON_TRA(Ma_MT),
	Ngay_Muon char(10),
	Ngay_Tra char(10),
	Tinh_Trang_Sach Nvarchar(100),
	Da_tra Nvarchar(10),
	Soluong int
);
select * from CHI where Ma_MT = 'MT002'
delete from MUON_TRA where Ma_MT = 'MT002'
Update SACH set Da_Muon = Da_Muon - 6 , Ton_Kho =  Ton_Kho + 6 where MaSach = 'MS002'
select * from CHI_TIET_MUON_TRA 


delete from MUON_TRA where Ma_MT = 'MT003'

select count(*) from MUON_TRA

use Thu_Vien_EAUT_Latest3
INSERT INTO DBO.MUON_TRA VALUES
('MT001','KH001',N'Admin','IT3','099999','NV001', N'Nhân viên Đức',1)

--select * from dbo.MUON_TRA
select * from dbo.MUON_TRA
delete from MUON_TRA
--drop table dbo.MUON_TRA
-- Ngày trả =1 là đang mượn, ngày trả = 0 là đã trả

SELECT * FROM DOC_GIA WHERE Ma_DG LIKE '%là%' OR Ten_DG LIKE '%là%' ;
SELECT Ten_DG, Lop, So_DT  FROM DBO.DOC_GIA WHERE Ma_DG = 'KH002'

select * from SACH
select * from MUON_TRA
select * from CHI_TIET_MUON_TRA where MaMT = 'MT003'

--SELECT MaSach AS book_id, SUM(Soluong) AS borrowed_quantity FROM CHI_TIET_MUON_TRA GROUP BY MaSach;
select * from CHI_TIET_MUON_TRA where MaMT = 'MS002'
SELECT MaSach, SUM(Soluong) AS CHI_TIET_MUON_TRA
FROM chi_tiet_muon_tra
GROUP BY book_id;



SELECT SACH.*, CHI_TIET_MUON_TRA.*
FROM SACH
INNER JOIN CHI_TIET_MUON_TRA
ON SACH.MaSach = CHI_TIET_MUON_TRA.MaSach ;

delete from CHI_TIET_MUON_TRA
delete from MUON_TRA where Ma_MT = 'MT006'
Select count(*) from MUON_TRA
SELECT SUM(Soluong)FROM CHI_TIET_MUON_TRA WHERE MaMT = 'MT004';

update  CHI_TIET_MUON_TRA set Ngay_Muon = '2023-02-03', Ngay_Tra = '2023-02-06', Tinh_Trang_Sach = 'ok', Da_tra = '' where MaMT = 'MT007'

select COUNT(*) from MUON_TRA where MaSach ='MS001'

DELETE MT , DG
FROM MUON_TRA MT, DOC_GIA DG 
WHERE MT.Ma_DG = DG.Ma_DG AND DG.Ma_DG = 'KH001';

DELETE FROM MUON_TRA WHERE Ma_DG = 'KH001' AND  FROM DOC_GIA WHERE Ma_DG = 'KH001'
SELECT CHI_TIET_MUON_TRA.MaMT, SACH.TenSach, SACH.MaSach, SACH.Ten_TL, CHI_TIET_MUON_TRA.Ngay_Muon, CHI_TIET_MUON_TRA.Ngay_Tra, CHI_TIET_MUON_TRA.Tinh_Trang_Sach, DATEDIFF(day, GETDATE(), CHI_TIET_MUON_TRA.Ngay_Tra) AS SoNgayTreHan FROM CHI_TIET_MUON_TRA INNER JOIN SACH ON CHI_TIET_MUON_TRA.MaSach = SACH.MaSach INNER JOIN THE_LOAI ON SACH.Ma_TL = THE_LOAI.Ma_TL

-- store procedure
CREATE PROCEDURE checkAccount
    @username NVARCHAR(50),
    @password NVARCHAR(50)
AS
BEGIN
    SELECT COUNT(*) FROM TAI_KHOAN WHERE Ten_TK = @username AND Mat_Khau = @password
END;

CREATE PROCEDURE getUserName
	@tendn NVARCHAR(20)
AS 
BEGIN 
	SELECT * FROM TAI_KHOAN JOIN DOC_GIA ON TAI_KHOAN.Ten_TK = DOC_GIA.Ten_TK WHERE TAI_KHOAN.Ten_TK = @tendn
END


CREATE PROCEDURE createAcount 
	 @username NVARCHAR(20)
AS 
BEGIN
	SELECT COUNT(*) FROM TAI_KHOAN WHERE Ten_TK = @username
END


CREATE PROCEDURE checkPermission
	@tentk NVARCHAR(20)
AS 
BEGIN 
	SELECT Quyen FROM TAI_KHOAN WHERE Ten_TK = @tentk
END


CREATE PROCEDURE checkUserAccount
	@sodt NVARCHAR (15)
AS 
BEGIN 
	SELECT COUNT(*) FROM DBO.DOC_GIA WHERE So_DT = @sodt
END

CREATE PROCEDURE getFirstMaDG
AS
BEGIN
    SELECT TOP 1 Ma_DG FROM DOC_GIA ORDER BY Ma_DG DESC
END


CREATE PROCEDURE count_DocGia
	@madg NVARCHAR(20)
AS
BEGIN
    SELECT COUNT(*) FROM DOC_GIA WHERE Ma_DG = @madg
END


CREATE PROCEDURE addAccount
	@tentk char(30),
	@matkhau char(30),
	@quyen int
AS 
BEGIN 
	Insert into TAI_KHOAN(Ten_TK, Mat_Khau, Quyen) values (@tentk, @matkhau, @quyen)
END



CREATE PROCEDURE addReader
	@madg char(20),
	@tendg nvarchar(50),
	@lop char(10),
	@sdt char(10),
	@tendn char(30)
AS 
BEGIN 
	INSERT INTO DOC_GIA (Ma_DG , Ten_DG, Lop, So_DT , Ten_TK) VALUES (@madg, @tendg , @lop, @sdt, @tendn)
END
drop procedu
CREATE PROCEDURE autoID
	@tableName varchar(30),
	@idColumn varchar(20)
AS
BEGIN
	DECLARE @sql nvarchar(max);
	SET @sql = N'SELECT TOP 1 [' + @idColumn + N'] FROM [' + @tableName + N'] ORDER BY [' + @idColumn + N'] DESC';
	EXEC sp_executesql @sql;
END
-- Lưu ý: phải sử dụng sp_executesql để thực thi các câu lệnh SQL động trong thủ tục 
CREATE PROCEDURE count_ID
	@tableName varchar(30),
	@idColumn varchar (20),
	@madg varchar (20)
AS
BEGIN
	DECLARE @sql nvarchar(max);
	SET @sql = N'SELECT COUNT(*) FROM [' + @tableName + '] WHERE [' + @idColumn + '] = @madg';
	EXEC sp_executesql @sql, N'@madg varchar(20)', @madg;
END

CREATE PROCEDURE selectBook
AS
BEGIN 
	select * from SACH
END


CREATE PROCEDURE count_CHI_TIET_MUON_TRA
	@maSach varchar(20)
AS
BEGIN
	select COUNT(*) from CHI_TIET_MUON_TRA where MaSach = @maSach
END

CREATE PROCEDURE UpdateDaMuon
    @MaSach varchar(20),
    @DaMuon char(10)
AS
BEGIN
    UPDATE SACH
    SET Da_Muon = @DaMuon
    WHERE MaSach = @MaSach
END

CREATE PROCEDURE getAmountBook
    @ms varchar(20)
AS
BEGIN
    SELECT So_Luong, Da_Muon, (CONVERT(int, So_Luong) - CONVERT(INT, Da_Muon)) AS So_Luong_Ton FROM DBO.SACH WHERE MaSach = @ms;
END

CREATE PROCEDURE UpdateTonKho
	@maSach varchar(20),
	@tonKho int
AS
BEGIN
	UPDATE SACH
	SET Ton_Kho = @tonKho
	WHERE MaSach = @maSach
END

CREATE PROCEDURE get_SACH_TG_TL 
AS
BEGIN
    SELECT SACH.*, TAC_GIA.Ten_TG, THE_LOAI.Ten_TL 
    FROM SACH 
    INNER JOIN TAC_GIA ON SACH.Ma_TG = TAC_GIA.Ma_TG 
    INNER JOIN THE_LOAI ON SACH.Ma_TL = THE_LOAI.Ma_TL
END

CREATE PROCEDURE count_book
    @ten nvarchar(100),
    @tenTL nvarchar(100),
    @tenNXB nvarchar(100),
    @tenTg nvarchar(100)
AS
BEGIN
    SELECT COUNT(*) FROM SACH 
    WHERE TenSach = @ten AND Ten_TL = @tenTL AND Ten_NXB = @tenNXB 
    AND CAST(Ten_TG AS NVARCHAR(MAX)) = CAST(@tenTg AS NVARCHAR(MAX))
END

CREATE PROCEDURE Insert_TacGia
    @maTG varchar(10),
    @tenTG nvarchar(50)
AS
BEGIN
    INSERT INTO TAC_GIA (Ma_TG, Ten_TG)
    VALUES (@maTG, @tenTG)
END

CREATE PROCEDURE Insert_THE_LOAI
	@mtl varchar(20),
	@ttl nvarchar(50)
AS
BEGIN
	INSERT INTO THE_LOAI(Ma_TL,Ten_TL) VALUES (@mtl,@ttl)
END

CREATE PROCEDURE insert_NXB
    @maNXB varchar(20),
    @tenNXB nvarchar(50)
AS
BEGIN
    INSERT INTO NHA_XUAT_BAN(Ma_NXB, Ten_NXB)
    VALUES (@maNXB, @tenNXB)
END

CREATE PROCEDURE InsertSach
	@masach varchar(20),
	@tensach nvarchar(50),
	@maTG varchar(20),
	@ttg nvarchar(50),
	@mtl varchar(20),
	@ttl nvarchar(50),
	@mnxb varchar(20),
	@tnxb nvarchar(50),
	@namxb char (10),
	@tts nvarchar(50),
	@soLuong char (10),
	@daMuon char (10),
	@tonKho char (10)
AS
BEGIN
	Insert into SACH (MaSach, TenSach, Ma_TG, Ten_TG, Ma_TL, Ten_TL, Ma_NXB, Ten_NXB, Nam_XB, Tinh_Trang_Sach, So_Luong, Da_Muon, Ton_Kho)
	values (@masach, @tensach, @maTG, @ttg, @mtl, @ttl, @mnxb, @tnxb, @namxb, @tts, @soLuong, @daMuon, @tonKho);
END


CREATE PROCEDURE find_MaSach_by_TenSach
    @tenSach nvarchar(50)
AS
BEGIN
    SELECT MaSach FROM SACH WHERE TenSach = @tenSach
END

CREATE PROCEDURE updateSoLuongSach
	@MaSach varchar(20),
	@SoLuong int
AS
BEGIN
	UPDATE Sach SET So_Luong = So_Luong + @SoLuong WHERE MaSach = @MaSach
END

CREATE PROCEDURE update_Ton_Kho
    @MaSach varchar(20),
    @SoLuong int
AS
BEGIN
    UPDATE Sach 
    SET Ton_Kho = Ton_Kho + @SoLuong 
    WHERE MaSach = @MaSach
END


CREATE PROCEDURE get_MaTG
	@ms varchar(20)
AS
BEGIN
	SELECT Ma_TG FROM dbo.SACH WHERE MaSach = @ms
END

CREATE PROCEDURE GetMaTLFromSACH
    @ms varchar(20)
AS
BEGIN
    SELECT Ma_TL FROM dbo.SACH WHERE MaSach = @ms
END

CREATE PROCEDURE get_MaNXB
	@ms varchar(20)
AS
BEGIN
	SELECT Ma_NXB FROM dbo.SACH WHERE MaSach = @ms
END

CREATE PROCEDURE update_TenTG
	@mtg varchar(20),
	@ttg nvarchar(50)
AS
BEGIN
	UPDATE TAC_GIA
	SET Ten_TG = @ttg
	WHERE Ma_TG = @mtg
END

CREATE PROCEDURE update_Ten_TL_by_MaTL
    @mtl VARCHAR(20),
    @ttl NVARCHAR(100)
AS
BEGIN
    UPDATE THE_LOAI SET Ten_TL = @ttl WHERE Ma_TL = @mtl
END

CREATE PROCEDURE updateTenNXB
    @maNXB varchar(20),
    @tenNXB nvarchar(50)
AS
BEGIN
    UPDATE NHA_XUAT_BAN SET Ten_NXB = @tenNXB WHERE Ma_NXB = @maNXB
END

CREATE PROCEDURE UpdateSach
(
	@masach nvarchar(10),
    @tensach nvarchar(100),
    @tenTG nvarchar(50),
    @tenTL nvarchar(50),
    @tenNXB nvarchar(50),
    @namXB varchar(10),
    @tinhtrang nvarchar(50),
    @soLuong varchar(10)
)
AS
BEGIN
    UPDATE SACH 
    SET TenSach = @tensach, 
        Ten_TG = @tenTG,
        Ten_TL = @tenTL,
        Ten_NXB = @tenNXB,
        Nam_XB = @namXB,
        Tinh_Trang_Sach = @tinhtrang,
        So_Luong = @soLuong
    WHERE MaSach = @masach
END

CREATE PROCEDURE GetMaTGByMaSach
    @ms varchar(20)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT Ma_TG FROM dbo.SACH WHERE MaSach = @ms;
END

CREATE PROCEDURE GetMaTLByMaSach
    @ms char(10)
AS
BEGIN
    SELECT Ma_TL FROM dbo.SACH WHERE MaSach = @ms
END

CREATE PROCEDURE GetMaNXBByMaSach
    @ms char(10)
AS
BEGIN
    SELECT Ma_NXB 
    FROM dbo.SACH 
    WHERE MaSach = @ms
END

CREATE PROCEDURE CheckSachInCTMT
    @maSach char(10)
AS
BEGIN
    SELECT COUNT(*) FROM CHI_TIET_MUON_TRA WHERE MaSach = @maSach
END

CREATE PROCEDURE DeleteSach 
    @ms varchar(10)
AS
BEGIN
    DELETE FROM SACH WHERE MaSach = @ms
END

CREATE PROCEDURE DeleteTacGia
    @mtg  varchar(10)
AS
BEGIN
    DELETE FROM TAC_GIA WHERE Ma_TG = @mtg
END

CREATE PROCEDURE DeleteTheLoai
    @mtl  varchar(10)
AS
BEGIN
    DELETE FROM THE_LOAI WHERE Ma_TL = @mtl
END

CREATE PROCEDURE DeleteNhaXuatBan
    @mnxb varchar(10)
AS
BEGIN
    DELETE FROM NHA_XUAT_BAN WHERE Ma_NXB = @mnxb
END

CREATE PROCEDURE SearchSach
    @search nvarchar(50)
AS
BEGIN
    SELECT * FROM SACH WHERE MaSach = @search OR TenSach = @search OR MaSach LIKE '%" + @search + "%' OR TenSach LIKE '%" + @search + "%'
END

CREATE PROCEDURE GetBookAndLoanDetailByMT
(
    @mmt varchar(50)
)
AS
BEGIN
    SELECT SACH.*, CHI_TIET_MUON_TRA.*
    FROM SACH
    INNER JOIN CHI_TIET_MUON_TRA ON SACH.MaSach = CHI_TIET_MUON_TRA.MaSach
    WHERE MaMT = @mmt
END

CREATE PROCEDURE getMuonTra
AS
BEGIN
    SELECT Ma_MT, Ten_DG, Lop, So_DT, Ten_NV, So_luong FROM MUON_TRA;
END

CREATE PROCEDURE getDocGia
AS
BEGIN
    SELECT Ma_DG FROM DOC_GIA
END

CREATE PROCEDURE GetMaNV
AS
BEGIN
    SELECT Ma_NV FROM NHAN_VIEN
END

CREATE PROCEDURE SP_GetAllMaSach
AS
BEGIN
    SELECT MaSach FROM SACH
END

CREATE PROCEDURE getLatestMaMT
AS
BEGIN
	DECLARE @sql nvarchar(max);
    SELECT TOP 1 Ma_MT FROM MUON_TRA ORDER BY Ma_DG DESC
	EXEC sp_executesql @sql
END
CREATE PROCEDURE CountMuonTraByIdMT
    @idmt char(10)
AS
BEGIN
	DECLARE @sql nvarchar(max);
    SELECT COUNT(*) FROM MUON_TRA WHERE Ma_MT = @idmt
	EXEC sp_executesql @sql
END

CREATE PROCEDURE GetDocGiaInfoById
    @madg char(10)
AS
BEGIN
    SELECT Ten_DG, Lop, So_DT FROM DBO.DOC_GIA WHERE Ma_DG = @madg
END

CREATE PROCEDURE GetTenNVById
    @manv char(10)
AS
BEGIN
    SELECT Ten_NV FROM DBO.NHAN_VIEN WHERE Ma_NV = @manv
END

CREATE PROCEDURE SumSoluongByIdMT
    @mamt char(10)
AS
BEGIN
    SELECT SUM(Soluong) FROM CHI_TIET_MUON_TRA WHERE MaMT = @mamt
END

CREATE PROCEDURE UpdateMuonTra
	@mamt NVARCHAR(50),
    @madg NVARCHAR(50),
    @tendg NVARCHAR(50),
    @lop NVARCHAR(50),
    @sdt NVARCHAR(50),
    @manv NVARCHAR(50),
    @tennv NVARCHAR(50),
    @soluong NVARCHAR(50)
   
AS
BEGIN
    UPDATE MUON_TRA SET Ma_DG = @madg, Ten_DG = @tendg, Lop = @lop, So_DT = @sdt, Ma_NV = @manv, Ten_NV = @tennv, So_luong = @soluong WHERE Ma_MT = @mamt
END

CREATE PROCEDURE CountMuonTra
AS
BEGIN
    SELECT COUNT(*) FROM MUON_TRA
END

CREATE PROCEDURE GetLastMaMT
AS
BEGIN
    SELECT TOP 1 Ma_MT FROM MUON_TRA ORDER BY Ma_DG DESC
END

Go
CREATE PROCEDURE CountMuonTraByIdMTBegin
    @idmt char(10)
AS
BEGIN
	DECLARE @sql NVARCHAR(MAX)
    SELECT COUNT(*) FROM MUON_TRA WHERE Ma_MT = @idmt
	EXEC sp_executesql @sql, N'@idmt char(10)', @idmt
END
GO
CREATE PROCEDURE GetChiTietMuonTraByMaMT
    @mamt char(20)
AS
BEGIN
    SELECT * FROM CHI_TIET_MUON_TRA WHERE MaMT = @mamt
END
GO
CREATE PROCEDURE UpdateSachAfterMuon
	@ms char(20),
	@muon int
AS
BEGIN
	UPDATE SACH SET Da_Muon = Da_Muon - @muon, Ton_Kho = Ton_Kho + @muon WHERE MaSach = @ms
END
GO
CREATE PROCEDURE DeleteChiTietMuonTraByMaMT
    @ma CHAR(10)
AS
BEGIN
    DELETE FROM CHI_TIET_MUON_TRA WHERE MaMT = @ma
END

CREATE PROCEDURE DeleteMuonTra
    @ma CHAR(10)
AS
BEGIN
    DELETE FROM MUON_TRA WHERE Ma_MT = @ma
END

CREATE PROCEDURE InsertMuonTra
    @maMT CHAR(10)
AS
BEGIN
    INSERT INTO MUON_TRA (Ma_MT) VALUES (@maMT)
END

CREATE PROCEDURE InsertChiTietMuonTra
	@ms char (20),
	@mmt char (20),
	@nm char (20),
	@nt char (20),
	@tts NVARCHAR(50),
	@dt  NVARCHAR(50)
AS
BEGIN
INSERT INTO CHI_TIET_MUON_TRA (MaSach, MaMT, Ngay_Muon, Ngay_Tra, Tinh_Trang_Sach, Da_tra)
VALUES (@ms, @mmt, @nm, @nt, @tts, @dt)
END

CREATE PROCEDURE UPDATE_SoLuong_ChiTietMuonTra
    @MaSach char (20),
    @MaMT char (20),
    @SoLuong INT
AS
BEGIN
    UPDATE CHI_TIET_MUON_TRA
    SET SoLuong = @SoLuong
    WHERE MaSach = @MaSach AND MaMT = @MaMT
END

CREATE PROCEDURE UpdateSoLuongTonKho
    @MaSach char(20),
    @SoLuong INT
AS
BEGIN
    UPDATE SACH SET Ton_Kho = Ton_Kho - @SoLuong WHERE MaSach = @MaSach
END

CREATE PROCEDURE Update_DaMuon
    @MaSach char (20),
    @sluong INT
AS
BEGIN
    UPDATE SACH SET Da_Muon = Da_Muon + @sluong WHERE MaSach = @MaSach
END

CREATE PROCEDURE SelectAllSach
AS
BEGIN
	SELECT MaSach, TenSach, Ten_TG, Ten_NXB, Nam_XB, Ten_TL, Ton_Kho
	FROM SACH
END

CREATE PROCEDURE SearchSachByMaOrTen
	@ma NVARCHAR(50)
AS
BEGIN
	SELECT * FROM SACH WHERE MaSach = @ma OR TenSach = @ma
END

CREATE PROCEDURE GetDocGiaByTenTK
	@tentk NVARCHAR(50)
AS
BEGIN
	SELECT Ma_DG, Ten_DG, Lop, So_DT
	FROM DOC_GIA
	WHERE Ten_TK = @tentk
END

CREATE PROCEDURE GetBookInfo
    @masach char(20)
AS
BEGIN
    SELECT TenSach, Ten_TL FROM SACH WHERE MaSach = @masach
END

CREATE PROCEDURE GetLatest_MaMT
    @MaMT char(20)
AS
BEGIN
	DECLARE @sql NVARCHAR(MAX)
    SELECT TOP 1 @MaMT = Ma_MT FROM MUON_TRA ORDER BY Ma_DG DESC
	EXEC sp_executesql @sql
END

CREATE PROCEDURE GetDocGiaByID
	@madg char (20)
AS
BEGIN
	SELECT Ten_DG, Lop, So_DT FROM DBO.DOC_GIA WHERE Ma_DG = @madg
END

CREATE PROCEDURE GetBookInfor
    @mas NVARCHAR(50)
AS
BEGIN
    SELECT TenSach, Ten_TL, Tinh_Trang_Sach 
    FROM DBO.SACH 
    WHERE MaSach = @mas
END
select * from SACH
CREATE PROCEDURE Insert_MuonTra
    @idmt VARCHAR(10),
    @madg VARCHAR(10),
    @tendg NVARCHAR(50),
    @lop NVARCHAR(50),
    @sdt NVARCHAR(50),
    @manv VARCHAR(10),
    @tennv NVARCHAR(50),
	@soluong int 
AS
BEGIN
    INSERT INTO MUON_TRA (Ma_MT, Ma_DG, Ten_DG, Lop, So_DT, Ma_NV, Ten_NV,So_luong)
    VALUES (@idmt, @madg, @tendg, @lop, @sdt, @manv, @tennv,@soluong)
END


CREATE PROCEDURE Insert_ChiTietMuonTra
	@ms VARCHAR(10),
	@mmt VARCHAR(10),
	@ngaymuon VARCHAR(10),
	@ngaytra VARCHAR(10),
	@tts NVARCHAR(50),
	@datra NVARCHAR(50),
	@sl INT
AS
BEGIN
	INSERT INTO CHI_TIET_MUON_TRA (MaSach, MaMT, Ngay_Muon, Ngay_Tra, Tinh_Trang_Sach, Da_tra, Soluong)
	VALUES (@ms, @mmt, @ngaymuon, @ngaytra, @tts, @datra, @sl)
END


CREATE PROCEDURE GetDocGiaByTenTK1
    @tentk NVARCHAR(50)
AS
BEGIN
    SELECT Ma_DG, Ten_DG, Lop, So_DT 
    FROM DOC_GIA 
    WHERE Ten_TK = @tentk
END

CREATE PROCEDURE Update_DaMuon_Sach
	@MaSach VARCHAR(10)
AS
BEGIN
	UPDATE Sach SET Da_Muon = Da_Muon + 1 WHERE MaSach = @MaSach
END

CREATE PROCEDURE Select_DocGia
AS
BEGIN
	SELECT * FROM DBO.DOC_GIA
END

CREATE PROCEDURE GetMaxMaDG
AS
BEGIN
    SELECT TOP 1 Ma_DG FROM DOC_GIA ORDER BY Ma_DG DESC
END


CREATE PROCEDURE Check_DocGia_Exist
    @madg VARCHAR(10)
AS
BEGIN

    SELECT COUNT(*) FROM DOC_GIA WHERE Ma_DG = @madg
END

CREATE PROCEDURE Insert_DocGia
    @madg VARCHAR(10),
    @tendg NVARCHAR(50),
    @lop NVARCHAR(50),
    @sdt NVARCHAR(50)
AS
BEGIN
    INSERT INTO DOC_GIA (Ma_DG, Ten_DG, Lop, So_DT)
    VALUES (@madg, @tendg, @lop, @sdt)
END

CREATE PROCEDURE Update_DocGia
    @ma VARCHAR(10),
    @ten NVARCHAR(50),
    @lop NVARCHAR(50),
    @sdt NVARCHAR(50)
AS
BEGIN
    UPDATE DOC_GIA SET Ten_DG = @ten, Lop = @lop, So_DT = @sdt WHERE Ma_DG = @ma
END

CREATE PROCEDURE Delete_TaiKhoan
    @ma char(20)
AS
BEGIN
    DELETE TK FROM TAI_KHOAN TK JOIN DOC_GIA DG ON TK.Ten_TK = DG.Ten_TK WHERE DG.Ma_DG = @ma
END

CREATE PROCEDURE Delete_ChiTietMuonTra_By_MaDG
	@ma char(20)
AS
BEGIN
	DELETE MT FROM CHI_TIET_MUON_TRA MT JOIN MUON_TRA CTMT ON CTMT.Ma_MT = MT.MaMT WHERE CTMT.Ma_DG = @ma
END
drop procedure Delete_ChiTietMuonTra_By_MaDG
CREATE PROCEDURE Delete_MuonTra_By_MaDG
	@ma char(20)
AS
BEGIN
	DELETE FROM MUON_TRA WHERE Ma_DG = @ma
END

CREATE PROCEDURE Delete_DocGia
    @ma Char(20)
AS
BEGIN
    DELETE FROM DOC_GIA WHERE Ma_DG = @ma;
END

CREATE PROCEDURE Search_DOC_GIA
	@ma NVARCHAR(50)
AS
BEGIN
	SELECT * FROM DOC_GIA WHERE Ma_DG = @ma OR Ten_DG = @ma OR Ma_DG LIKE '%' + @ma + '%' OR Ten_DG LIKE '%' + @ma + '%'
END


CREATE PROCEDURE Get_Sach_ChiTietMuonTra
AS
BEGIN
	SELECT SACH.*, CHI_TIET_MUON_TRA.*
	FROM SACH
	INNER JOIN CHI_TIET_MUON_TRA ON SACH.MaSach = CHI_TIET_MUON_TRA.MaSach
END

CREATE PROCEDURE GetMuonTraDetails
AS
BEGIN
    SELECT MUON_TRA.Ma_MT, SACH.TenSach, CHI_TIET_MUON_TRA.MaSach, SACH.Ten_TL ,CHI_TIET_MUON_TRA.Ngay_Muon, CHI_TIET_MUON_TRA.Ngay_Tra, CHI_TIET_MUON_TRA.Tinh_Trang_Sach , DATEDIFF(day, GETDATE(), CHI_TIET_MUON_TRA.Ngay_Tra) AS SoNgayTreHan FROM MUON_TRA JOIN CHI_TIET_MUON_TRA ON MUON_TRA.Ma_MT = CHI_TIET_MUON_TRA.MaMT JOIN SACH ON CHI_TIET_MUON_TRA.MaSach = SACH.MaSach;
END
drop procedure GetMuonTraDetails

CREATE PROCEDURE usp_LayThongTinSachDaTra
    @datra NVarChar(10)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT SACH.*, CHI_TIET_MUON_TRA.*
    FROM SACH
    INNER JOIN CHI_TIET_MUON_TRA ON SACH.MaSach = CHI_TIET_MUON_TRA.MaSach
    WHERE Da_tra = @datra
END
drop PROCEDURE usp_LayThongTinSachDaTra
CREATE PROCEDURE GetAllTaiKhoan
AS
BEGIN
	SELECT * FROM TAI_KHOAN
END