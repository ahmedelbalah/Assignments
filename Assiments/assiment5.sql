use StoreDB
-- 1
SELECT 
    product_id,
    product_name,
    list_price,
    CASE 
        WHEN list_price < 300 THEN 'Economy'
        WHEN list_price BETWEEN 300 AND 999 THEN 'Standard'
        WHEN list_price BETWEEN 1000 AND 2499 THEN 'Premium'
        ELSE 'Luxury'
    END AS price_category
FROM production.products;

-- 2
SELECT 
    order_id,
    customer_id,
    order_status,
    order_date,
    CASE order_status
        WHEN 1 THEN 'Order Received'
        WHEN 2 THEN 'In Preparation'
        WHEN 3 THEN 'Order Cancelled'
        WHEN 4 THEN 'Order Delivered'
    END AS status_description,
    CASE 
        WHEN order_status = 1 AND DATEDIFF(DAY, order_date, GETDATE()) > 5 THEN 'URGENT'
        WHEN order_status = 2 AND DATEDIFF(DAY, order_date, GETDATE()) > 3 THEN 'HIGH'
        ELSE 'NORMAL'
    END AS priority_level
FROM sales.orders;

-- 3
SELECT 
    s.staff_id,
    s.first_name,
    s.last_name,
    COUNT(o.order_id) AS order_count,
    CASE 
        WHEN COUNT(o.order_id) = 0 THEN 'New Staff'
        WHEN COUNT(o.order_id) BETWEEN 1 AND 10 THEN 'Junior Staff'
        WHEN COUNT(o.order_id) BETWEEN 11 AND 25 THEN 'Senior Staff'
        ELSE 'Expert Staff'
    END AS staff_category
FROM sales.staffs s
LEFT JOIN sales.orders o ON s.staff_id = o.staff_id
GROUP BY s.staff_id, s.first_name, s.last_name;


-- 4
SELECT 
    customer_id,
    first_name,
    last_name,
    ISNULL(phone, 'Phone Not Available') AS phone,
    email,
    COALESCE(phone, email, 'No Contact Method') AS preferred_contact
FROM sales.customers;

-- 5
SELECT 
    p.product_id,
    p.product_name,
    s.quantity,
    ISNULL(p.list_price / NULLIF(s.quantity, 0), 0) AS price_per_unit,
    CASE 
        WHEN s.quantity = 0 THEN 'Out of Stock'
        WHEN s.quantity IS NULL THEN 'No Stock Info'
        ELSE 'In Stock'
    END AS stock_status
FROM production.products p
LEFT JOIN production.stocks s ON p.product_id = s.product_id
WHERE s.store_id = 1;

-- 6
SELECT 
    customer_id,
    first_name,
    last_name,
    COALESCE(street, '') + ' ' + COALESCE(city, '') + ', ' +
    COALESCE(state, '') + ' ' + COALESCE(zip_code, 'No ZIP') AS formatted_address
FROM sales.customers;

-- 7
WITH customer_spending AS (
    SELECT 
        customer_id, 
        SUM(total_amount) AS total_spent
    FROM sales.orders
    GROUP BY customer_id
)
SELECT 
    c.customer_id,
    c.first_name,
    c.last_name,
    cs.total_spent
FROM customer_spending cs
JOIN sales.customers c ON cs.customer_id = c.customer_id
WHERE cs.total_spent > 1500
ORDER BY cs.total_spent DESC;


