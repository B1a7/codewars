-- For this challenge you need to create a simple SELECT statement that will return all columns from the people table,
-- and join to the sales table so that you can return the COUNT of all sales and RANK each person by their sale_count.

-- people table schema
-- id
-- name
-- sales table schema
-- id
-- people_id
-- sale
-- price
-- You should return all people fields as well as the sale count as "sale_count" and the rank as "sale_rank".

-- NOTE: Your solution should use pure SQL. Ruby is used within the test cases to do the actual testing.

SELECT 
    p.id,
    p.name,
    COUNT(s.people_id)  sale_count,
    SUM (s.price) sale_rank
FROM people AS p
JOIN sales AS s ON s.people_id = p.id
GROUP BY s.people_id, p.id
ORDER BY sale_rank