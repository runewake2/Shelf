# Shelf
Developed by Samuel R. Wronski as part of my "Lets Make An App" Project

Shelf is a Universal Windows App for GoodReads. It includes an easy to use implementation of the GoodReads API for use in other .NET Apps.

## Important Notes
In order to connect to the Good Reads API you will need to create a resources file containing your ApiKey and ApiSecret. The app will read from this file at launch and use its values.

The easiest way to do this is to create a Resources.resw file in your Shelf/ directory. Then add two strings "ApiKey" and "ApiSecret" and fill in your Good Reads credentials in their respective places.