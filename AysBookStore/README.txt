Date: 30-10-22 7:15pm 
Started a new assignment 
Named the project AysBookStore
Created a new git repo 
Created a readme file 
Updated readme file 
Run the application ..everything is good!!
committed to github

7:45 pm 
Reviewed all the mentioned slides 
Started debbuging 
Chnaged the code in the layout.cshtml file according to slide 
Downloaded sketchy theme from bootswatch.com 
Replaced the existing bootstrap file with new downloaded bootstrap file 
Chnaged the file name  in layout.cshtml 
Edited the code in loginPartial.cshtml and layout.cshtml files according to the given code in slides. 
Run the app ....It worked everything is alright , and new css got applied and every changes displayed!!
Commited everything to git hub 

Date; 3-11-22 
10:51 
Added the additional stylesheets to layout.cshtml from the given css.jstxt file 
Added the additional java scripts to layout.cshtml from the given js scripts file 

11:37 
Created 3 new projects 
AysBooks1.DataAccess 
AysBooks1.Models 
AysBooks1.Utility 
Installed the required nuget pacakeges 
Mdae some mistake in installing the packages 
Solved the mistake 
Copied the models folder in new AysBooks1.Models application deleted original one
Copied Data folders to DataAccess folder and delete the original one 
Edited the files according to the slides and updated the code 

Build Failed got some errors 
got this error!!!!!!
Severity	Code	Description	Project	File	Line	Suppression State
Error	NU1605	Detected package downgrade: Microsoft.EntityFrameworkCore.SqlServer from 5.0.11 to 3.1.28. Reference the package directly from the project to select a different version. 
 AysBookStore -> AysBooks1.Models -> Microsoft.EntityFrameworkCore.SqlServer (>= 5.0.11) 
 AysBookStore -> Microsoft.EntityFrameworkCore.SqlServer (>= 3.1.28)	AysBookStore	C:\Users\hp1001\Source\Repos\Anjali4006\AysBookStore\AysBookStore.csproj	1	

Committed everything to github  
Date : 2022-11-07
Solved issue of github 
Tested the app 
Got the desirable output 

time: 4:13 
Finally after so many errors and sweat and blood...hehe 
After so many errors finally managed to get desirable output......PS: I am happy :)
Committed everything to github 
Taking a break now ....Completing another work will get back to this tonight !!! Cyaa<3


Date: 2022-11-11  16:23pm 
Started part two of the assignment 
Added new migration with command - add-migration AddDefaultIdentityMigration with default project name 
Got errors as mentioned in the slides 
Changed the default project name to AysBooks1.DataAccess 
Run the same command and wwhooohoo!! MIgration successfull! (confetti in background...hihihi ;)
20221111212448_AddDefaultIdentityMigration - New migration file created in the migrations folder in Data.Access project 
Updated database with command - update-database in PM 
Successfull...without any errors 
Run the application ...everything is alright got the expected output without any errors 
END TIME : 16:35PM 
Committing everything to git hub 

time: 16:37pm 
Moving forward with the assignment 
Added a new class file to the AysBooks1.Models project 
Named the file Category.cs and modified it 
Added migration through PM and successfully migrated the new file 
Procedded with the assignment with modifying ApplicationDbContext file to update it but got the error!!! 
Added using AysBooks1.Models to the file bt got the below mentioned error ...
type or namespace name models could not be found 
type or namespace category could not be found 
Stuck here...do not know what to change
Searching on google to get help ... :(
COMMITTING EVERYTHING TO GIT HUB 

Taking a break need to cook dinner.... will get back to this after few hours 
END TIME: 17:33 PM 

Date: 2022-11-13  time: 12:16 am 
So started with the assignment further 
Started part 2.2 
Created a new folder named Repository in AysBooks1.DataAccess folder 
Added another folder IRepository in Repository folder 
Added a new interface file in the Irepository file named IRepository.cs 
Updated the Irepository.cs file with the given code in the slides 
Added a new class file in the Repository folder named Repository.cs 
Updated the file with the provided code from the files of assignment 2 
Updated readme with every step done and committed everything to git hub till here 