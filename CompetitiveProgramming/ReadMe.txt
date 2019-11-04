



We can use wkhtmltopdf exe from the windows to convert the html into the pdf but the two column alignment is gone only single page/single column works fine without the overlaps.
Open the command prompt in the administrator mode and then change directory to the bin folder.
cd "C:\Program Files\wkhtmltopdf\bin\

after that use the following command to excute and convert the html to pdf.

wkhtmltopdf "C:\SampleCV\orange download.html" C:\SampleCV\orange.pdf