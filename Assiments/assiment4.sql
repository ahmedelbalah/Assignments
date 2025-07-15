use StoreDB
---1
select count(product_id) as num_of_product
from production.products

--2
select avg(list_price) as Average , min(list_price) as miniprice , max(list_price) as maxprice
from production.products

--3
select category_id, count(*) as ProductCount
from production.products
group by  category_id
order by category_id

--4
select store_id , count(*) as  num_of_order_stores
from sales.orders
group by store_id
order by store_id

--5
select top 10 upper(first_name) as FistName , lower(last_name) as LastName
from sales.customers


--6
select top 10 product_name,len(product_name) as length_of_PN
from production.products


--7
select top 15 '('+(left(phone,3) )+')'+right(phone,len(phone)-3) as PhoneNumber
from sales.customers

--8
select year(getdate()) as currentyear , month(getdate()) as currentmonth

--9
select top 10 product_name ,category_name
from production.products p inner join production.categories c
on c.category_id = p.category_id


--10
select top 10 first_name +' '+last_name as CustomerName , order_date
from sales.customers c  inner join sales.orders o
on c.customer_id = o.customer_id

--11
select p.* , b.brand_name
from production.products p left outer join production.brands b
on b.brand_id = p.brand_id

--12
select product_name , list_price as price
from production.products
where list_price > (
select avg(list_price)
from production.products )

--13
select customer_id , first_name +' '+last_name as CustomerName
from sales.customers
where customer_id in(
select customer_id
from sales.orders
where order_status > 1
)







--17
select product_name , list_price
from production.products
where list_price between 50 and 200
order by list_price asc

--18 
select x.state, count(*) as customer_count
from sales.customers x
group by x.state
order by customer_count desc

--19
select category_name , product_name , list_price
from production.products p inner join production.categories c
on c.category_id = p.category_id


