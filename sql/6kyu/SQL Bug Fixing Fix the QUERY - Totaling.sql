-- Oh no! Timmys been moved into the database divison of his software company but as we know Timmy loves making mistakes. Help Timmy keep his job by fixing his query...

-- Timmy works for a statistical analysis company and has been given a task of totaling the number of sales on a given day grouped by each department name and then each day.

-- Resultant table:
-- day (type: date) {group by} [order by asc]
-- department (type: text) {group by} [In a real world situation it is bad practice to name a column after a table]
-- sale_count (type: int)
-- Tables and relationship below:



SELECT 
  s.transaction_date::date as day,
  d.name::text as department,
  COUNT(s.id)::int AS sale_count
  FROM department AS d
    JOIN sale AS s
    on d.id = s.department_id
  group by day, department 
  order by day 