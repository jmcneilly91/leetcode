-- https://leetcode.com/problems/nth-highest-salary/
CREATE FUNCTION getNthHighestSalary(@N INT) RETURNS INT AS
BEGIN
    RETURN (
        select max(salary) from (
            select dense_rank() over (order by salary desc) as rank, salary
            from Employee) as result
        where rank = @N
    );
END