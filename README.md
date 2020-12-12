## Pierre's Bakery -- Console Application

### _Place orders through the application and recieve your total cost_

### _Created by: Eric Stratton_

## Description

Navigate throught the simple console application via character entries, place orders, and see how much your order will cost

## Setup/Instillation

### Requirements:

- Internet browser
- Code editor if you wish to view/edit the code (recommended)
- .NET Core SDK

### .NET Core:

- Application is built using the deprecated .NET Core vs 2.2.
- .NET Core is a requirement for running this application, if you need to install it visit <https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.203-windows-x64-installer>
- Or if you wish to downloaded the latest editions of .Net Core, select `.NET core` in the file path at the top of the dowloaded page provided in the link above

### Download: 

- Download this repository by clicking the green 'Code' icon and selecting download zip
- Use your favorite zip.file opener to extract files to your local device

### Terminal:

- Open command terminal on local device
- Navigate to desktop in terminal using `$ cd desktop`
- Copy repository link by clicking on green 'Code' icon and clicking the clipboard to the right of the url
- Use command `$ git clone {specific_repository_URL}`
- From desktop, run command `$ cd {newly-downloaded-directory}` to navigate to the installed directory
- Run command `$ code .` to open directory in default code editor
- Run command `dotnet restore <mainDirectory>` in the console to upload necessary .NET Core files
- You'll have to do the same for the `<testDirectory>` if you want to run the tests
- Run command `$ cd Bakery` to navigate into the main directory to run console app
- Run command `$ donet run` 
- If everything has gone correctly, the console application should run in the active terminal

### Navigating in Application:

- App will stop at points where user needs to enter a charcter or integer to move forward
- Simply type the applicable character or integer into terminal line and hit enter to provide app with necessary data
- If you want to quit application, navigate back to main menu and enter `"n"` or `"N"`

## Tests

Test | Input | Output |
| :------------| :---------------| :-----------|
| PastryOrder |
| Instantiate the PastryOrder constructor | PastryOrder newPastryOrder = new PastryOrder(); | newPastryOrder |
| Add order item quantity to PastryOrder instance | 10 | newPastryOrder.Pastries = 10; |
| Calculate total cost of PastryOrder | newPastryOrder.GetCost(newPastryOrder.Pastries) | $17 |
| BreadOrder|
| Instantiate the BreadOrder constructor | BreadOrder newBreadOrder = new BreadOrder(); | newBreadOrder |
| Add order item quantity to BreadOrder instance | 10 | newBreadOrder.Loaves = 10; |
| Calculate total cost of BastryOrder | newBreadOrder.GetCost(newBreadOrder.Loaves) | $35 |

### To run your own tests: 

- Navigate to the `BakeryTests` directory
- Run command `$ dotnet restore`
- Run command `$ dotnet test` to run test suite

## Known Bugs

Excemption handlers in place to catch non numerical entries at the 'enter amount' section of the applcation throw seem to work while application is running. They notify user that they entered a non-numerical character into the terminal and reprompt the user to respond with a numerical value for quantity of bread or pastries. However, when the user is finished and closes out the application, the console throws an `Unhandled Exception error`. If user enters a numerical value into the 'enter amount' section, the `Unhandled Exception error` isn't thrown after application closes.

## Support & Contact Details

Do not hesitate to contact me at:

<strattonericj@gmail.com>

## Technologies 

- _VisualStudio Code_
- _C#_
- _.NET Core 2.2_
- _Git_
- _GitHub_

## Licensing

Copyright (c) 2020 **_Eric Stratton_**

This software is licensed under the MIT license
