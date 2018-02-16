# Fitness Web Service

A very very simple yet functional web service for fitness related functions.

Contains both **ASMX** and **WCF** web services.

## Methods
- **CalculateBMI()** - Calculate BMI based on height and weight
- **CalculateBMR()** - Calculate user's BMR based on height, weight, age and gender
- **CalculateAvgRunSpeed()** - Calculate average running speed for distance and time of a run
- **CalculateRunningMETS()** - Calculate mets* for a run based on distance and time
- **CalculateRunningHeartRate()** - Calculate a user's running heart rate
- **CalculatePreciseKcalBurnt()** - Calculate precise kcal burnt for exercise based on user's bmr, METS* of exercise and length of exercise
- **CalculateSimpleKcalBurnt()** - Calculate kcal burnt for exercise based on METS*, weight and length of exercise
- **BMIStatus()** - Display user's BMI health status (Underweight, Healthy, Overweight, Obese) based on BMI
- **RunningPacePerKmCalculator()** - Calculate time needed per km based on running distance and time
- **RetrieveExerciseMETSXML()** - Retrieve a DataSet containing exercises and their relevant METS*
- **RetrieveRunningEventDistancesXML()** - Retrieve a DataSet containing popular running distances and their relevant distances
- **GetMaxHeartRate()** - Calculate a user's max heart rate based on age
- **CalculateHeartRateForExerciseIntensity()** - Estimate user's heart rate based on exercise intensity percentage(eg. 70 for running), max heart rate and resting heart rate.
- **GetRestingHeartRatesXML()** - Retrieve a DataSet containing user's age range and their relevant resting heart rate range.

***METS** - Metabolic Equivalent of exercises


## Prerequisites
- Visual Studio 2017 with .NET core support 




