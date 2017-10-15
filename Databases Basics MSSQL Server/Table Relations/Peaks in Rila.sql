select MountainRange, PeakName, Elevation from Mountains
join Peaks on Mountains.Id = Peaks.MountainId
where Mountains.MountainRange = 'Rila'
order by Elevation desc