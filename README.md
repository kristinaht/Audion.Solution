# Quesis API Application

#### _API for interacting with an MVC_

#### By: **Alyssa Colistro, Kristina Hengster Tintor, Fatma Dogan, Jieun Kang**, April 2020

## Description

_This custom API allows users to GET, POST, PUT, and DELETE text responses to random questions. This MVC works together with the API to allow users to access questoins and answer them, as well as view the responses of others, to connect people and promote communication_

## Endpoint Documentation:

http://localhost:5000/audion/ <br>
http://localhost:5004/

| Endpoint | Http Action | Return data |
| ------------- |:-------------:| -------------------:|



## Specification user stories:
* A user is able to have a random text resonse returned to them to read to (GET) from all the files in the database.
* A user is able to see the daily question (GET) returned from the database.
* A user is able to create (POST) a new text response to the daily question and add it to the database.
* A user can edit (PUT) their login information.
* A user is able to replace (PUT) an existing text response that they created in the database. 
* A user is able to delete (DELETE) an existing text response that they created in the database.
* A user is able to view (GET) details for a specific response based on user input.
* A user must create an account and sign in to add a response to a question.
* A user can delete (DELETE) a post in the database.
* STRETCH GOAL A user is able to filter their search by various query parameters

## Setup/Installation Requirements

### Install .NET Core

#### on macOS:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download a .NET Core SDK from Microsoft Corp._
* _Open the file (this will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.)_

#### on Windows:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp._
* _Open the .exe file and follow the steps provided by the installer for your OS._

#### Install dotnet script
_Enter the command ``dotnet tool install -g dotnet-script`` in Terminal (macOS) or PowerShell (Windows)._

### Install MySQL

#### on macOS:
_Download the MySQL Community Server DMG File [here](https://dev.mysql.com/downloads/file/?id=484914). Follow along with the installer until you reach the configuration page. Once you've reached Configuration, set the following options (or user default if not specified):_
* use legacy password encryption
* set password (and change the password field in appsettings.json file of this repository to match your password)
* click finish
* open Terminal and enter the command ``echo 'export PATH="/usr/local/mysql/bin:$PATH"' >> ~/.bash_profile`` if using Git Bash.
* Verify MySQL installation by opening Terminal and entering the command ``mysql -uroot -p{your password here, omitted brackets}``. If you gain access to the MySQL command line, installation is complete. An error (e.g., -bash: mysql: command not found) indicates something went wrong.

#### on Windows:
_Download the MySQL Web Installer [here](https://dev.mysql.com/downloads/file/?id=484919) and follow along with the installer. Click "Yes" if prompted to update, and accept license terms._
* Choose Custom setup type
* When prompted to Select Products and Features, choose the following: MySQL Server (Will be under MySQL Servers) and MySQL Workbench (Will be under Applications)
* Select Next, then Execute. Wait for download and installation (can take a few minutes)
* Advance through Configuration as follows:
  - High Availability set to Standalone.
  - Defaults are OK under Type and Networking.
  - Authentication Method set to Use Legacy Authentication Method.
  - Set password to epicodus. You can use your own if you want but epicodus will be assumed in the lessons.
  - Unselect Configure MySQL Server as a Windows Service.
* Complete installation process

_Add the MySQL environment variable to the System PATH. Instructions for Windows 10:_
* Open the Control Panel and visit _System > Advanced System Settings > Environment Variables..._
* Select _PATH..._, click _Edit..._, then _Add_.
* Add the exact location of your MySQL installation and click _OK_. (This location is likely C:\Program Files\MySQL\MySQL Server 8.0\bin, but may differ depending on your specific installation.)
* Verify installation by opening Windows PowerShell and entering the command ``mysql -uroot -p{your password here, omitted brackets}``. It's working correctly if you gain access to the MySQL command line. Exit MySQL by entering the command ``exit``.

### Clone this repository

_Enter the following commands in Terminal (macOS) or PowerShell (Windows):_
* ``cd desktop``
* ``git clone`` followed by the URL to this repository
* ``cd Audion.Solution`` 

_Confirm that you have navigated to the Audion.Solution directory (e.g., by entering the command_ ``pwd`` _in Terminal)._


## Run this API application in another Terminal or PowerShell window
_Run the AudionAPI file by entering the following command in Terminal (macOS) or PowerShell (Windows) at the root of the AudionApi directory:_
  * ``cd AudionApi ``
  * ``dotnet run`` or ``dotnet watch run``

## Run this MVC application in another Terminal or PowerShell window

_Run this MVC application by entering the following command in Terminal (macOS) or PowerShell (Windows) at the root of the AudionClient directory:_
* ``cd AudionClient ``
* ``dotnet run`` or ``dotnet watch run``

_To view/edit the source code of this application, open the contents of the LocalBusinessAPI2.Solution directory in a text editor or IDE of your choice (e.g., to open all contents of the directory in Visual Studio Code on macOS, enter the command_ ``code .`` _in Terminal at the root of the Audion.Solution directory)._

## Technologies Used

* Git
* C#/.NET
* Visual Studio Code 1.43.1
* dotnet script 0.50.1
* MySQL 8.0.15
* ASP.NET Core MVC 2.2
* Entity Framework Core 2.2
* RestSharp version 106.6.10
* Newtonsoft.Json version 12.0.2
* [Audion API version 1.0](https://github.com/kristinaht/Audion.Solution.git)

## License

Licensed under the MIT license.

&copy; 2020 - Alyssa Colistro, Kristina Hengster Tintor, Fatma Dogan, Jieun Kang