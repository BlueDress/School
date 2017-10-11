select PeakName, RiverName, lower(PeakName + substring(RiverName, 2, len(RiverName) - 1)) as Mix		
from Peaks, Rivers
where right(PeakName, 1) = left(RiverName, 1)
order by Mix
