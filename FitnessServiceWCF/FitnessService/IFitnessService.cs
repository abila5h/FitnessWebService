using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace FitnessService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IFitnessService
    {
       
        [OperationContract]
        double CalculateBMI(double weight, double height);

        [OperationContract]
        double CalculateBMR(Boolean isMale, double weight, double height, int age);

        [OperationContract]
        double CalculateAvgRunSpeed(double distance, double time);

        [OperationContract]
        double CalculateRunningMETS(double distance, double time);

        [OperationContract]
        double CalculateRunningHeartRate(Boolean isMale, int age);

        [OperationContract]
        double CalculatePreciseKcalBurnt(double bmr, double mets, double time);

        [OperationContract]
        double CalculateSimpleKcalBurnt(double mets, double weight, double time);

        [OperationContract]
        string BMIStatus(double bmi);

        [OperationContract]
        double RunningPacePerKmCalculator(double distance, double time);

        [OperationContract]
        DataSet RetrieveExerciseMETSXML();

        [OperationContract]
        DataSet RetrieveRunningEventDistancesXML();

        [OperationContract]
        int GetMaxHeartRate(int age);

        [OperationContract]
        double CalculateHeartRateForExerciseIntensity(int exerciseIntensityPercentage, int maxHeartRate, int restingHeartRate);

        [OperationContract]
        DataSet GetRestingHeartRatesXML();

    }

}
