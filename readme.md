# Fitness Web Service

A very very simple yet functional web service for fitness related functions.

Contains both **ASMX** and **WCF** web services.

## Methods
- **CalculateBMI()** - Calculate BMI based on height(cm) and weigh(kg)
- **CalculateBMR()** - Calculate user's BMR based on height(cm), weight(kg), age and gender
- **CalculateAvgRunSpeed()** - Calculate average running speed for distance(km) and time(hr) of a run
- **CalculateRunningMETS()** - Calculate mets* for a run based on distance and time (hr)
- **CalculateRunningHeartRate()** - Calculate a user's running heart rate (bpm)
- **CalculatePreciseKcalBurnt()** - Calculate precise kcal burnt for exercise based on user's bmr, mets* of exercise and length of exercise(hr)
- **CalculateSimpleKcalBurnt()** - Calculate kcal burnt for exercise based on mets*, weight(kg) and length of exercise(hr) 
- **BMIStatus()** - Display user's BMI health status (Underweight, Healthy, Overweight, Obese) based on BMI
- **RunningPacePerKmCalculator()** - Calculate time (secs) needed per km based on running distance(km) and time(secs)
- **RetrieveExerciseMETSXML()** - Retrieve a DataSet containing exercises and their relevant METs
- **RetrieveRunningEventDistancesXML()** - Retrieve a DataSet containing popular running distances and their relevant distances(km)
- **GetMaxHeartRate()** - Calculate a user's max heart rate based on age
- **CalculateHeartRateForExerciseIntensity()** - Estimate user's heart rate based on exercise intensity percentage(eg. 70 for running), max heart rate and resting heart rate.
- **GetRestingHeartRatesXML()** - Retrieve a DataSet containing user's age range and their relevant resting heart rate range.

***mets** - Metabolic Equivalent of exercises


## Prerequisites
- Visual Studio 2017 with .NET core support 




