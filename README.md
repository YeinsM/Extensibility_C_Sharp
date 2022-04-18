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

If you open a browser to http://localhost:9874/people, you will see data from the service.

You can leave this terminal open for all of the samples; each sample uses the same web service.

To stop the service, press "Ctrl+C" in the terminal.

Running the Web Application
To run the web application (PeopleViewer), use the following steps:

Open a terminal in the "PeopleViewer" folder.
Type "dotnet run". (This will rebuild the project if necessary.)
The web application should start and show the following info:
~~~
info: Microsoft.Hosting.Lifetime[0]
      Now listening on: http://localhost:5000
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Development
info: Microsoft.Hosting.Lifetime[0]
~~~

To run the application, open a browser to http://localhost:5000.

When you are done, you can stop the web server by going back to the terminal window and pressing "Ctrl+C".

Alternately, you can run the web application from within Visual Studio Code by using the integrated debugger. For more information, see Visual Studio Code - Debugging.
