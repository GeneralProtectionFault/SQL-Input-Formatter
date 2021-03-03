# SQL-Input-Formatter
Format list of strings for "IN" or "INSERT" query


If you have a list of strings, and you want a quick & dirty way to put them into a query, such as:

(IN Query)
select * from [Database1]..[Table1]
WHERE [ColumnWhatever] in ('string1','string2','string3'....etc...)

OR

(INSERT Query)
INSERT INTO ##ATable VALUES
('string1'),('string2'),('string3')...etc....

Paste the list of strings into the approproate box, and click the format button.  This will automatically format the strings into the
selected format, as shown above, and copy that formatted text to the clipboard.  From here, it can be pasted into a query for
expediting in the case of an ad-hoc request that is not worth the time of setting such a thing up properly.
