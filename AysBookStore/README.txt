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


***************************************************************************************************************************************
***************************************************************************************************************************************

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
Committing everything to git hub 

END TIME : 16:35PM 

Time: 16:37pm 

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

time: 2:43 am 

Moved further with the assignment 
Added the given code to categoryRepository file but having some syntax errors!! 
Tried to solved the errors but couldn't find any major ....error still shows 
Thought of moving forward with the assignment....**
Created a new interface in Irepository folder -ISP_Call.cs File 
Updated it with the given code but still get the same syntax error as category . cs file 
Updated readme file 
Feeling sleepy now
committing everything to github with errors unfortunately......... :(
GoodNight..cyaa <3

End time: 2:49AM 

DATE: 2022-11-13
Time: 5:30PM 
Moving further with the assignment 
Tried solving the syntax errors 
Solved some erros in the class files 
But still had some errors ...it was taking so much time so left them as it is and moved further with the assignment 
Added another interface in Irepository folder - IUnitOfWork.cs 
Added the code from the slide to the inyerface file .....goshh no red lines in it atleast!!!
Added a new class file - UnitOfWork.cs in Repository folder 
Write the code from the slides 
Againnn red lines!!!!! 
Ignoring it for now and moving forward with the further coding 
DidNot committed anything till now to git hub because it has errors 
After this updated the startup.cs file with the given line of code 
Solved all the erros displayed
Added MVC controller to the area/admin folder - CategoryController.cs 
Updated the file with the given code 
Added the category folder in Views and added a view Index in the category folder 
Updated the file with the given code 
Committing everything to git hub with no erros in the error list 

Time: 10:05 PM 
Worked a lot in past few hours on this assignment 
Solved all the errors occured and run the application 
Got the output of the page but the category page is still not found 
Committing till here on github without any errors 

Time: 11:23pm 
Added a javascript file in the js folder - category.cs 
YUpdated it as guided in the slides 
Added a methos to call java script file in index.cshtml file 
Added the upsert razor view file in the Areas>Views>category 
Updated the upsert file with the given code in the assignment files 
Added the partial views for edit and back to list buttons 
Updated the _EditAndBackToListButtons files 
Added another partial views for update and back to list buttons 
upadted the _CreateAndBackToListButton file with the given code 

Comitting everything till here on git hub taking a dinner break...

Tried solving the page not found error but didn't got the output 
Comitting everything on github ...still with the 0 errors and 0 warnings!!!
Will let solve it tomorrow with professor ....Till than GOOD NIGHT..JAI SHREE KRISHNA! 

Date: 2022-11-14
END TIME: 2:15AM 

Date : 17-11-2022 
Time: 11:56 PM 
Cleaned the application builded it again 
No errors showing on the list 
Revied the slides again 
matched the steps properly 
Found the error for showing the category page finallyy!!!!!
Did some mistake in part one....not created the Area in the last part and that was the reason for not showing the category page 
Reviewd the slides properly made amends in the application 
Delete the area folder I created in part two 
Took backup of the whole folder 
Started creating the whole new area from part 1 and followed the slides throughly 
And weehhheee!!!! Success!!!!! (*****confetti*****)  :) 
Got the desired output of the category page 
Committed everything to git hub and updated readme
Will be sleeping with a wide smile on my face and will have a peacefull beauty sleep!!<3

END TIME: 12:54 AM
*********************************************************************************************************************************************************
*********************************************************************************************************************************************************

Date: 2022-11-24 
start time: 5 pm 
Started the further steps in assignments 
Created a new class file in models - CoverType.cs 
Edited the code as per the category.cs file 
Created new class and interface files in repository folder 
CoverTypeRepository.cs 
ICoverTypeRepository.cs
Edited the code as per the previous files 
Updated the code in the unitofwork and Iunitofwork files 
Now heading towards migration>>>>>>
Dhakk dhakkk dhakk dhakkk....heheheh ;) 
Created migration using command - add-migration AddCoverTypeToDb 
Woohooo!!! 
Migration succesfull 

***********20221124233240_AddCoverTypeToDb.cs***************

Migration file created 
Updated migration and its successfull. 

On to the next protion 
Added covertype to the navbar using the previous code of category 
Added controller in the controllers folder 
Created new folder - CobverType 
Added a new MVC empty controller 
CoverTypeController.cs 
Edited the code as per the slides 
Added a new index and upsert view in the views folder  
Updated the files with the provided code 
No errors till now.....!!
Updated readme and committed everything on github 

Created product class in models folder 
Updated the file as per the slides 
Added migration using the given command 

*********20221125004657_AddProductToDb.cs************

Reviewed the tables 
Tables added to the sql server 
Updated readme and committed everything to git hub 

Created files in repository folder 
Created files in IRepository folder 
updated with the provided code 
Updated readme committed everything to github 















































































































