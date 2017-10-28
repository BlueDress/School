select Content, SentOn from Messages
where SentOn > '12.05.2014' and charindex('just', Content) > 0
order by Id desc