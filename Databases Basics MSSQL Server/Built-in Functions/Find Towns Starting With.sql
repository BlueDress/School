select * from Towns
where left(Name, 1) = 'M' or left(Name, 1) = 'K' or left(Name, 1) = 'B' or left(Name, 1) = 'E'
order by Name