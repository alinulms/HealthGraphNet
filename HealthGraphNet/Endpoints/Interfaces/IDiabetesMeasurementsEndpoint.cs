﻿using System;
using HealthGraphNet.Models;

namespace HealthGraphNet
{
    public interface IDiabetesMeasurementsEndpoint
    {
        //Get Diabetes Measurements Feed
        FeedModel<DiabetesMeasurementsFeedItemModel> GetFeedPage(int? pageIndex = null, int? pageSize = null, DateTime? noEarlierThan = null, DateTime? noLaterThan = null, DateTime? modifiedNoEarlierThan = null, DateTime? modifiedNoLaterThan = null);
        void GetFeedPageAsync(Action<FeedModel<DiabetesMeasurementsFeedItemModel>> success, Action<HealthGraphException> failure, int? pageIndex = null, int? pageSize = null, DateTime? noEarlierThan = null, DateTime? noLaterThan = null, DateTime? modifiedNoEarlierThan = null, DateTime? modifiedNoLaterThan = null);   
        //Get Diabetes Measurement (Detailed)
        DiabetesMeasurementsPastModel GetMeasurement(string uri);
        void GetMeasurementAsync(Action<DiabetesMeasurementsPastModel> success, Action<HealthGraphException> failure, string uri);
        //Update Diabetes Measurement
        DiabetesMeasurementsPastModel UpdateMeasurement(DiabetesMeasurementsPastModel measurementToUpdate);
        void UpdateMeasurementAsync(Action<DiabetesMeasurementsPastModel> success, Action<HealthGraphException> failure, DiabetesMeasurementsPastModel measurementToUpdate);
        //Create Diabetes Measurement
        string CreateMeasurement(DiabetesMeasurementsNewModel measurementToCreate);
        void CreateMeasurementAsync(Action<string> success, Action<HealthGraphException> failure, DiabetesMeasurementsNewModel measurementToCreate);
        //Delete Diabetes Measurement
        void DeleteMeasurement(string uri);
        void DeleteMeasurementAsync(Action success, Action<HealthGraphException> failure, string uri);
    }
}