select p.PeakName, m.MountainRange as Mountain, p.Elevation from Peaks as p
inner join Mountains as m
on p.MountainId = m.Id
order by p.Elevation desc