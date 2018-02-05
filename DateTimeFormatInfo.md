##### System.Globalization.DateTimeFormatInfo
# DateTimeFormatInfo

List of the Months
``` csharp
Enumerable.Range(1, 12).ToDictionary(i => String.Format("({0}) {1}", i.ToString("00"), DateTimeFormatInfo.CurrentInfo.GetMonthName(i)), i => i)

/*
(01) January, 1 
(02) February, 2 
(03) March, 3 
(04) April, 4 
(05) May, 5 
(06) June, 6 
(07) July, 7 
(08) August, 8 
(09) September, 9 
(10) October, 10 
(11) November, 11 
(12) December, 12
*/
```
