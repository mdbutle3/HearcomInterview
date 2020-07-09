# HearcomInterview
Work for Hear.com Interview


Instructions to run the test suite
1. Clone the Code down to Visual studio
2. Build the solutions
3. download Nunit Console msi from https://github.com/nunit/nunit-console/releases and run it
4. add a system path variable for C:\Program Files (x86)\NUnit.org\nunit-console
5. open command line
6. run the following commands linking to your dlls that your build created, and changing the LogFileName path/name to where you want it to go 
dotnet test "C:\Users\mdbut\source\repos\NewRepo\Herokuapp Automation\Herokuapp Automation\bin\Debug\netcoreapp3.1\HerokuappAutomation.dll" -l:trx;LogFileName=C:\temp\TestOutput.xml
7. Press enter


The report can be found at the path and file name that are specified on the command line.

I have checked in examples of the Reports for my 2 solutions. They are named APITestOutPut.xml and UITestOutput.xml
