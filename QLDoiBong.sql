use QLDoiBong;

--Stored Procedure Xuất ra thông tin cầu thủ
--exec SelectAllCauThu;

--Stored Procedure thêm 1 cầu thủ1 vào bảng qlCauThu
--exec ThemMoiCauThu 'CT20','Sergio Romero',2016,30,0,'GK'

--Stored Procedure update thông tin Cầu thủ
--exec updateCT 'CT14','Marcus Rashford',2016,120,45,'Att';

--Stored Procedure để select thông tin của cầu thủ
--exec selectCT 'CT5'

--Stored Procedure Tìm kiếm theo macauthu,tencauthu,loaicauthu
--exec [SelectAllCauThu] 'Eric'

--Stored Procedure Xóa cầu thủ 

create procedure xoaCT
@macauthu varchar(50)
as begin 
delete from qlCauThu where macauthu=@macauthu
end

select * from qlCauThu
exec xoaCT 'CT30'

