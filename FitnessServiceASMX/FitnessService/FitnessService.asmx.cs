﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.IO;

namespace FitnessService
{
    
    /// A very very simple yet functional web service to compute fitness related functions.
   
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class FitnessService : System.Web.Services.WebService
    {



        [WebMethod]
        public double CalculateBMI(double weight, double height) // weight in kg, height in cm
        { // weight in kg, height in cm
            return (weight / ((height / 100) * (height / 100)));
        }

        [WebMethod]
        public double CalculateBMR(Boolean isMale, double weight, double height, int age) //Weight in kg, height in cm
        {
            if (isMale)
            {
                return (66.5 + (13.75 * weight) + (5.003 * (height)) - (6.755 * age)); // BMR in kcal/day
            }
            else
            {
                return (655.1 + (9.563 * weight) + (1.850 * height) - (4.676 * age));
            }
        }

        [WebMethod]
        public double CalculateAvgRunSpeed(double distance, double time) //distance in km, time in hr
        {
            return (distance / time);
        }

        [WebMethod]
        public double CalculateRunningMETS(double distance, double time) //distance in km, time in hr
        {
            return distance / time;
        }

        [WebMethod]
        public double CalculateRunningHeartRate(Boolean male, int age)
        {
            double heartRate;
            if (male)
            {
                heartRate = 214 - age * 0.8;
            }
            else
            {
                heartRate = 209 - age * 0.7;
            }
            return heartRate;
        }


        [WebMethod]
        public double CalculatePreciseKcalBurnt(double bmr, double mets, double time) //time in hr
        {
            return (bmr * (mets / 24) * time);
        }




        [WebMethod]
        public double CalculateSimpleKcalBurnt(double mets, double weight, double time) //mets - metabolic equivalent, weight in kg, time in hour
        {
            return (mets * weight * time);
        }




        [WebMethod]
        public string BMIStatus(double bmi)
        {
            string BMIStatus;
            if (bmi < 18.5)
            {
                BMIStatus = "Underweight";

            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                BMIStatus = "Healthy";
            }
            else if (bmi >= 25 && bmi <= 29.9)
            {
                BMIStatus = "Overweight";
            }
            else if (bmi >= 30)
            {
                BMIStatus = "Obese";
            }
            else
            {
                BMIStatus = "Invalid";
            }
            return BMIStatus;
        }

        [WebMethod]
        public double RunningPacePerKmCalculator(double distance, double time) //distance in km, time in secs
        {
            return (time / distance); // returns seconds needed per km to achieve goal
        }

        [WebMethod]
        public DataSet RetrieveExerciseMETSXML() //Returns list of exercise names along with their METS
        {
            string filename = "ExerciseMETS.xml";
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "XML", filename);
            DataSet ds = new DataSet();
            ds.ReadXml(path);
            return ds;
        }



        [WebMethod]
        public DataSet RetrieveRunningEventDistancesXML() //Returns list of popular event distances with their distances in km.
        {
            string filename = "EventDistances.xml";
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "XML", filename);
            DataSet ds = new DataSet();
            ds.ReadXml(path);
            return ds;
        }



        [WebMethod]
        public int GetMaxHeartRate(int age)
        {
            return (220 - age);

        }

        [WebMethod]
        public double CalculateHeartRateForExerciseIntensity(int exerciseIntensityPercentage, int maxHeartRate, int restingHeartRate)
        {
            return ((maxHeartRate - restingHeartRate) * (exerciseIntensityPercentage / 100));
        }


        [WebMethod]
        public DataSet GetRestingHeartRatesXML()
        {
            string filename = "RestingHeartRates.xml";
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "XML", filename);
            DataSet ds = new DataSet();
            ds.ReadXml(path);
            return ds;
        }

    }
}
