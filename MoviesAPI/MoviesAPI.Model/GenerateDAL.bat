@echo off
"C:\Program Files (x86)\Microsoft SDKs\Windows\v7.0A\Bin\SqlMetal.exe" /server:EU-W7V-CDURAND /database:Study /user:Webapp /password:webapp /code:ProjectX.cs /context:ProjectXDataContext /namespace:MoviesAPI.Model /pluralize /functions /sprocs /views
 pause
