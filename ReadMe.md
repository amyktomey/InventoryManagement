C# Iventory Management System

This repository contains all the files for the C# Software Development final project.

According to the plan, this program will assist with managing inventory before, during and after sales events and trade shows.
<br>
Sometimes things don't go according to plan.  Neil and I spent a good amount of time on this 11/30/2023. The errors, we could not get them to go away.
 <br>
 There are no errors on the error list. There are warnings like this when I attempt a migration (one for each model in the library):
 <br>
Warning	CS0436	The type 'Product' in 'C:\Users\m0mon\CapstoneC#2023\InventoryLibrary\Models\Product.cs' conflicts with the imported type 'Product' in 'InventoryLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Using the type defined in 'C:\Users\m0mon\CapstoneC#2023\InventoryLibrary\Models\Product.cs'.	InventoryBrowser.Maui (net7.0), InventoryBrowser.Maui (net7.0-windows10.0.19041.0)	C:\Users\m0mon\CapstoneC#2023\InventoryLibrary\Data\ProductContext.cs	7	Active
<br>
There is ONE red error:  CSC : error CS5001: program does not contain a static "Main" method suitasble for an entry point.
<br>Now, the project will build quite nicely... but click on Products anf ther is an error "An unhandled error has occurred. Reload" F12 reveals the following:
<br>An invalid request URI was provided. Either the request URI must be an absolute URI or BaseAddress must be set. 
<br>So, no migrations... and I don't know why.
<br>As a result, I cannot prove that any of my features work... 
<br>
Required:<br>
 Visual Appeal:
	<br>[X]	Design your project to be visually appealing; follow industry trends.
	<br>[X]	Aim to create projects that employers find attractive and engaging.
	<br>[X]	Select a color palette and font stack to enhance design consistency.
	<br>
Database Interaction:
	<br>[X]Develop at least one class (excluding the default class in a new project),
create an object of that class, populate it with data from a database, and incorporate the data in
your application. A minimum of 1 table (entity) should be utilized. Note that classes should be
created even when using object relational mappers like Entity Framework.
<br>
Functions/Methods: 
<br>[ X ] Create and utilize a minimum of 3 functions or methods, with at least one
returning a value integral to your application.
<br>
Features:  ** Use THREE of these**
<br>
[x]Create a dictionary or list, populate it with several values, retrieve at least one value, and use it in your program
<br>
[X]Make a generic class and use it
<br>
[ ]Query your database using a raw SQL query, not EF (in progress)
<br>
<br>
I had planned to be able to change the quantities and print out a list of items out of stock


