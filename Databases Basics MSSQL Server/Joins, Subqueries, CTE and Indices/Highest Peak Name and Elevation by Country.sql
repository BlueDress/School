select top 5 HighestPeakElevationByCountry.CountryName, 
case
when CountryAllPeaksElevationAndMountains.HighestPeakName is null then '(no highest peak)'
else CountryAllPeaksElevationAndMountains.HighestPeakName
end as HighestPeakName,
HighestPeakElevationByCountry.HighestPeakElevation,
case
when CountryAllPeaksElevationAndMountains.Mountain is null then '(no mountain)'
else CountryAllPeaksElevationAndMountains.Mountain
end as Mountain
from
(select c.CountryName, 
case
when max(p.Elevation) is null then 0
else max(p.Elevation)
end as HighestPeakElevation 
from Countries as c
left join MountainsCountries as mc
on c.CountryCode = mc.CountryCode
left join Mountains as m
on mc.MountainId = m.Id
left join Peaks as p
on m.Id = p.MountainId
group by c.CountryName) as HighestPeakElevationByCountry
left join
(select c.CountryName,
p.PeakName as HighestPeakName,
p.Elevation as HighestPeakElevation,
m.MountainRange as Mountain
from Countries as c
left join MountainsCountries as mc
on c.CountryCode = mc.CountryCode
left join Mountains as m
on mc.MountainId = m.Id
left join Peaks as p
on m.Id = p.MountainId) as CountryAllPeaksElevationAndMountains
on HighestPeakElevationByCountry.CountryName = CountryAllPeaksElevationAndMountains.CountryName and HighestPeakElevationByCountry.HighestPeakElevation = CountryAllPeaksElevationAndMountains.HighestPeakElevation