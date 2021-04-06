insert into Categories(CategoryName,UpperCategory,CreatedBy,CreatedDate,ModifiedBy,ModifiedDate,Active)
values
('PERALATAN TULIS',null,'ADMIN',GETDATE(),null,null,1),
('ALAT RUMAH TANGGA',null,'ADMIN',GETDATE(),null,null,1),
('HOBBY',null,'ADMIN',GETDATE(),null,null,1),
('PERHIASAN',null,'ADMIN',GETDATE(),null,null,1)

select * from Categories