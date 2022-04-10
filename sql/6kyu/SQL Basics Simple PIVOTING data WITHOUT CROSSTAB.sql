-- This kata is inspired by SQL Basics: Simple PIVOTING data by matt c.

-- You need to build a pivot table WITHOUT using CROSSTAB function. Having two tables products and details you need to select a pivot table of products with counts of details occurrences (possible details values are ['good', 'ok', 'bad'].

-- Results should be ordered by product's name.

-- Model schema for the kata is:

-- schema

-- your query should return table with next columns

-- name
-- good
-- ok
-- bad
-- Compare your table to the expected table to view the expected results.

SELECT 
    products.name
    SUM(IF details.detail == 'good', 1, 0) as good
    SUM(IF details.detail == 'ok', 1, 0) as ok
    SUM(IF details.detail == 'bad', 1, 0) as bad
FROM products
RIGHT JOIN details ON products.id = details.product_id
GROUP BY products.name
ORDER BY name

SELECT 
  p.name,
  SUM(CASE WHEN d.detail = 'good' THEN 1 ELSE 0 END) AS good,
  SUM(CASE WHEN d.detail = 'ok' THEN 1 ELSE 0 END) AS ok,
  SUM(CASE WHEN d.detail = 'bad' THEN 1 ELSE 0 END) AS bad
FROM products AS p
LEFT JOIN details AS d ON d.product_id = p.id
GROUP BY p.name
ORDER BY name