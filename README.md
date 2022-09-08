# IoT

In this project i decided to use .NET Core 6. It made a lot of things easier for instance the use of swagger was
already authorized and i didnt have to add anything

## Reference
https://www.youtube.com/watch?v=SR_JEdhxWx0

https://stackoverflow.com

https://docs.microsoft.com/en-us/aspnet/core/security/authentication/?view=aspnetcore-6.0

https://www.dropbox.com/sh/p8fiokfpiqv4gud/AAC5X8SdanTnduTWYzVq4kQ7a?dl=0

## How my project works
The following methods are methods contained in the models folder and how they work
	## Zone.cs
	- GET method that retrieves all Zone entries from the database
	- GET method that will retrieve one Zone from the database based on the ID parsed through
	- Create a POST method that will create a new Zone entry on the database
	- Create a PATCH method that will update an existing Zone entry on the database
	- DELETE method that will delete an existing Zone entry on the database
	- Private method in the API that checks if a Zone exists (based on the ID parsed through) before editing or deleting an item
	- GET method that retrieves all devices within a specific zone (based on the zone ID that is parsed through)

	## Category
	- GET method that retrieves all Category entries from the database
	- GET method that will retrieve one Category from the database based on the ID parsed through
	- POST method that will create a new Category entry on the database
	- PATCH method that will update an existing Category entry on the database
	- DELETE method that will delete an existing Category entry on the database
	- private method in the API that checks if a Category exists (based on the ID parsed through) before editing or deleting an item
	- GET method that retrieves all devices within a specific category (based on the category ID that is parsed through)
	- GET method that will return the number of zones that are associated to a specific category (use the device entity to join the data)

	## Device
	- GET method that retrieves all Device entries from the database
	- GET method that will retrieve one Device from the database based on the ID parsed through
	- POST method that will create a new Device entry on the database
	- PATCH method that will update an existing Device entry on the database
	- DELETE method that will delete an existing Device entry on the database
	- private method in the API that checks if a Device exists (based on the ID parsed through) before editing or deleting an item


When connecting to my database and you get an error, please go to the firewall settings and configure them by add a client IP address

	## Database Information
		user name: cmpg
		password: Charmain@01
		Database name: IoTDevices
		Server name: cmpg323--34687602.database.windows.net
