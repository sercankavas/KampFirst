--Select
select ContactName ,CompanyName,City from Customers

select * from Customers where City='London'

select * from Products where CategoryID=1 or CategoryID=3

select * from Products where CategoryID=1 and UnitPrice>=10

select * from Products order by CategoryID, ProductName

select * from Products order by UnitPrice desc

select * from Products where CategoryID=1 order by UnitPrice 
-- Productslardan CAtegoryid si 1 olanlari ucretlerine azdan coga dogru sirala

select count(*) from Products

select count(*) from Products where CategoryID=2

--User story: Hangi kategoriden kac farkli urunumu var
select categoryId,count(*) from Products group by CategoryID

--userstory:urun sayisi 10 dan az olan kategorileri listele
select categoryId,count(*) from Products group by CategoryID having count(*)<10

--userstory:urun sayisi 10 dan az olan kategorileri listele ama unitprice i da 20 den cok olanlar olsun dersek
select categoryId,count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10

--2 farkli listeden data cekmek icin 
select * from Products inner join Categories on Products.CategoryID=Categories.CategoryID

select Products.ProductID, Products.ProductName, Products.UnitPrice,Categories.CategoryName
from Products inner join Categories on Products.CategoryID=Categories.CategoryID
where Products.UnitPrice>10
--inner join sadec iki tabloda da eslesenleri biraraya getirir, eslesmeyen datayi getirmez
--inner join yapilirken iki tablodan ortak kolon secilir 

select * from Products p left join [Order Details] od
on p.ProductID=od.ProductID --oreder detailsde olmayip products da olanlari da getir demek

select * from Customers c left join Orders o 
on c.CustomerID=o.CustomerID
--inner yapinca 830 sonuc verdi ama left yapinca 832 tane verdi.Det betyr at 2 fark var. kim bu iki kisi diye patron sorarsa 
-- bu koda sunu da ekleriz
where o.CustomerID is null
--FISSA ve PARIS customerid li kisileri cikartir karsina . aeadaki fark sudur:o iki kisinin  customer id leri null gorunur bu listed
--cunku onlar customer da var order da yok. yani bu 2 musterimiz siparis etmemisler bizden. patron o 2 kisiye bi kampanya yapalim diyo


--ikiden fazla tabloyu join etmek icin
select * from Products p left join [Order Details] od
on p.ProductID=od.ProductID
inner join Orders o
on o.OrderID=od.OrderID