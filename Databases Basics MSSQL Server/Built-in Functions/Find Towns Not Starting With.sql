select * from Towns
where left(Name, 1) != 'R' and left(Name, 1) != 'B' and left(Name, 1) != 'D'
order by Name