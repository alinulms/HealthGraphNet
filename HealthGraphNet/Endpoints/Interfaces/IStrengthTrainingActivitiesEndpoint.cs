﻿using System;
using HealthGraphNet.Models;

namespace HealthGraphNet
{
    public interface IStrengthTrainingActivitiesEndpoint
    {
        //Get Strength Training Activity Feed
        FeedModel<StrengthTrainingActivitiesFeedItemModel> GetFeedPage(int? pageIndex = null, int? pageSize = null, DateTime? noEarlierThan = null, DateTime? noLaterThan = null, DateTime? modifiedNoEarlierThan = null, DateTime? modifiedNoLaterThan = null);
        void GetFeedPageAsync(Action<FeedModel<StrengthTrainingActivitiesFeedItemModel>> success, Action<HealthGraphException> failure, int? pageIndex = null, int? pageSize = null, DateTime? noEarlierThan = null, DateTime? noLaterThan = null, DateTime? modifiedNoEarlierThan = null, DateTime? modifiedNoLaterThan = null);
        //Get Strength Training Activity (Detailed)
        StrengthTrainingActivitiesPastModel GetActivity(string uri);
        void GetActivityAsync(Action<StrengthTrainingActivitiesPastModel> success, Action<HealthGraphException> failure, string uri);
        //Update Strength Training Activity (Detailed)
        StrengthTrainingActivitiesPastModel UpdateActivity(StrengthTrainingActivitiesPastModel activityToUpdate);
        void UpdateActivityAsync(Action<StrengthTrainingActivitiesPastModel> success, Action<HealthGraphException> failure, StrengthTrainingActivitiesPastModel activityToUpdate);
        //Create Activity
        string CreateActivity(StrengthTrainingActivitiesNewModel activityToCreate);
        void CreateActivityAsync(Action<string> success, Action<HealthGraphException> failure, StrengthTrainingActivitiesNewModel activityToCreate);
        //Delete Activity
        void DeleteActivity(string uri);
        void DeleteActivityAsync(Action success, Action<HealthGraphException> failure, string uri);
    }
}