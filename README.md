# Factory Manager

#### **1/8/20**

## By _Harrison Strand_
---
## <u>**About the Project** </u>
### 🚩 **Description**
This application is for a Factory Manager that allows administrators to track Engineers and their license to work on specific machines with the use of a database.

### 🐛 Known Bugs
There are no known bugs at this time.

## <u>**Getting Started**</u>
### 🔧 **Setup/Installation**
#### **Project Editor Setup**
1. Copy this download link: https://github.com/HarrisonStrand/factory-manager.solution.git
2. Open bash and go to the directory where you would like to store your cloned project.
3. Clone the repo.
```
git clone https://github.com/HarrisonStrand/factory-manager.solution.git
```
4. Navigate to the cloned project folder and open VS code.
```
$ cd Desktop
$ cd [known directory]
$ code .
```
5. Navigate to the testing project folder in your VS terminal initalizes dotnet.
```
dotnet restore
```
6. If you wish to see if everything is compiling correctly go to the Office directory and run the following:
```
dotnet build
```
7. To see if the program is functioning properly you can use:
```
dotnet watch run
```
This will show you if everything is compiling correctly; otherwise you be will prompt with error messages.

#### **Dont forget that in order to push any changes you need to add your own GitHub repo. to your project.**
```
git remote add origin [personal Github repo. link]
```

#### **Import Database with Entity Framework Core**
1. Navigate to factory-manager/Factory directory using your terminal.
2. Run the command ```dotnet ef database update``` to generate the databse through Entity Framework Core.
3. (Optional) To update the database with any changes to the code, run the command ```dotnet ef migrations add [MigrationsName]``` which will use Entity Framework Core's code-first principle to generate a database update. After, run the previous command 'dotnet ef database update' to update the database.

#### **AppSettings**
1. Create a new file in the factory-manager/Factory directory named appsettings.json
2. Add in the following code snippet to the new appsettings.json file:
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=firstName_lastName;uid=root;pwd=YourPassword;"
  }
}
```

#### **Import Database with MySQL Workbench**
1. Open MySQL Workbench and enter your password.
2. Go to the nav bar at the top, click on Server > Data Import.
3. Use the option 'Import from Self-Contained File'.
4. Set the 'Default Target Schema' or create a new schema.
5. Select all Schema Objects you wish to import.
6. At the bottom, ensure the option 'Dump Structure and Data' is selected.
7. Click 'Start Import'

#### **SQL MANUAL IMPORT**
```
CREATE DATABASE  IF NOT EXISTS `harrison_strand`
USE `harrison_strand`;
-- MySQL dump 10.13  Distrib 8.0.15, for macos10.14 (x86_64)
--
-- Host: localhost    Database: harrison_strand
-- ------------------------------------------------------
-- Server version	8.0.15

--
-- Table structure for table `__EFMigrationsHistory`
--

DROP TABLE IF EXISTS `__EFMigrationsHistory`;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `__EFMigrationsHistory` (
  `MigrationId` varchar(95) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Table structure for table `EngineerMachine`
--

DROP TABLE IF EXISTS `EngineerMachine`;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `EngineerMachine` (
  `EngineerMachineId` int(11) NOT NULL AUTO_INCREMENT,
  `EngineerId` int(11) NOT NULL,
  `MachineId` int(11) NOT NULL,
  PRIMARY KEY (`EngineerMachineId`),
  KEY `IX_EngineerMachine_EngineerId` (`EngineerId`),
  KEY `IX_EngineerMachine_MachineId` (`MachineId`),
  CONSTRAINT `FK_EngineerMachine_Engineers_EngineerId` FOREIGN KEY (`EngineerId`) REFERENCES `engineers` (`EngineerId`) ON DELETE CASCADE,
  CONSTRAINT `FK_EngineerMachine_Machines_MachineId` FOREIGN KEY (`MachineId`) REFERENCES `machines` (`MachineId`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Table structure for table `Engineers`
--

DROP TABLE IF EXISTS `Engineers`;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `Engineers` (
  `EngineerId` int(11) NOT NULL AUTO_INCREMENT,
  `EngineerName` longtext,
  `HireDate` longtext,
  PRIMARY KEY (`EngineerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Table structure for table `Machines`
--

DROP TABLE IF EXISTS `Machines`;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `Machines` (
  `MachineId` int(11) NOT NULL AUTO_INCREMENT,
  `MachineName` longtext,
  `InstallDate` longtext,
  PRIMARY KEY (`MachineId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
```

## **Technologies Used**
* Visual Studio Code 1.52.1
* C# V:7.3
* .NET Core V: 2.2.0
* ASP.NET Core MVC
* ASP.NET Core Razor Pages
* MySQL WorkBench V: 8.0
* Entity Framework Core V: 2.2.6
* dotnet script, REPL

------------------------------
## 👥 Contributors

| Author | Email |
|--------|:-----:|
| [Harrison Strand](https://www.linkedin.com/in/harrisonstrand/) | [harrisonstrand@gmail.com](mailto:harrisonstrand@gmail.com) |
------------------------------

## 📝 Legal
```
MIT License

Copyright (c) 2021 Harrison Strand

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
```
<center><a href="#">Return to Top</a></center>