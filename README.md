# "C# Interfaces" Extensibility
This repository contains sample code for the "C# Interfaces".

# Running the Sample
The code sample can be followed using Visual Studio (Windows) or Visual Studio Code (Windows, Linux, macOS).

.NET 5.0 - development tool options

Visual Studio 2022 (Community Edition)
Visual Studio 2019 (Community Edition)
Visual Studio Code

When using Visual Studio, open the solution file (.sln) that is included in each sample folder. The solution is set up to automatically start the web application as well as the required web service, so no special action should be required.

Running the Web Service and Application
To run a project, click F5 or use "Start debugging" from the toolbar or Debug menu.

Your default browser will automatically open to http://localhost:5000 (the location of the web application). When you are done, close the browser window.

Note: If you get the following error:

~~~
'No connection could be made because the target machine actively refused it. [::ffff:127.0.0.1]:9874 (localhost:9874)'
     Then the web service is not running. Check the Troubleshooting Guide for help.
~~~

When using Visual Studio Code, you will need to start the web service project separately from the web application.

Starting the Service
For the projects that have a "People.Service" folder, use the following steps to start the service:

1. Open a terminal in the "People.Service" folder.
2. Type "dotnet run". (This will rebuild the project if necessary.)
3. The service should start and show the following info:
~~~
info: Microsoft.Hosting.Lifetime[0]
      Now listening on: http://localhost:9874
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Development
~~~
