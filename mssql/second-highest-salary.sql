-- https://leetcode.com/problems/second-highest-salary/
select MAX(salary) as SecondHighestSalary
from Employee
where salary < (
    select MAX(salary)
    from Employee
)