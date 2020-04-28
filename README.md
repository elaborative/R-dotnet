# R-dotnet
Simple example of using R with .net System.Diagnostics.Process

Run Rtest.aspx to interact with an R installation on the server. 

You must have R installed before you run this dotnet code.

In the vb file, you must set the correct path to the R installation on your machine and the R script you want to invoke.

The script will take your arguments, pass them to R, and return a plot image.

The demo R file randhist.R will return a histogram plot of a random set of 1000 numbers.

This R file saves the plot as a PNG into a virtual directory of my web application.

The System.Diagnotics process passes two extra arguments to the R script for demonstration purposes.

The name box will appear as part of the plot title.

The value determines the max number for the random generator to select.

Happy Coding!

