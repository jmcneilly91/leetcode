-- https://leetcode.com/problems/rank-scores/submissions/1130664464/
select score, dense_rank() over (order by score desc) as rank from Scores