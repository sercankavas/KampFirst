select products.ProductName as 'Ürün Adı',sum([Order Details].UnitPrice*[Order Details].Quantity) as 'Total Fiyat'
/*ÜRÜN ADINI seçmek VE ORDER DETAİLS TABLOSUNDA SATILAN ÜRÜNÜN VE FİYATININ sum kullanılarak ÜRÜN BAŞINA KAZANILANIN BULUNMASI*/
from Products inner join [Order Details] 
/*ürünler ve --satış detayı tablosunun join işlemi*/
on Products.ProductID=[Order Details].ProductID 
/*ürünler ve satış detayı tablosunundaki ürün no'sunun aynı olanlarının eşitlenmesii*/
inner join Orders on Orders.OrderID = [Order Details].OrderID 
/*son olarak satışlar tablosununda joinlenerek satışlar ve satış detayı tablolarında ortak alan olan satış no'larının eşitlmesi*/
group by ProductName
/*group by kullanarak ürün adına göre gruplanması*/
order by [Total Fiyat]
/*sum işleminde alias olarak kullanılan toplam fiyata göre ürünlerin sıralaması (isme göre sıralamak isterseniz productname olarak order by girilebilir)*/

select Products.ProductName as 'Urun Adi',sum([Order Details].UnitPrice*[Order Details].Quantity)  as 'Toplam Kazanc'
from Products inner join [Order Details]
on Products.ProductID=[Order Details].ProductID
inner join Orders