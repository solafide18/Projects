select * from Products
select * from Categories
select * from Customers
select * from Orders
select * from [Order Details]
select * from RunningNumber

select 0%3,1%3,2%3,3%3

select '<th>'+COLUMN_NAME+'</th>' from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = 'Products'
select '<td>@item.'+COLUMN_NAME+'</td>' from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = 'Products'
select '''<td><input id="'+COLUMN_NAME+'" type="text"></td>''+' from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = 'Products'
select COLUMN_NAME+':$("#'+COLUMN_NAME+'").val(),' from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = 'Products'