﻿using System;

namespace HealthGraphNet.Models
{
    /// <summary>
    /// The path model used in conjunction with activity data to record geographical points.
    /// </summary>    
    public class PathModel
    {
        /// <summary>
        /// The number of seconds since the start of the activity.
        /// </summary>
        public double Timestamp { get; set; }
        
        /// <summary>
        /// The latitude, in degrees (values increase northward and decrease southward).
        /// </summary>
        public double Latitude { get; set; }
        
        /// <summary>
        /// The longitude, in degrees (values increase eastward and decrease westward).
        /// </summary>
        public double Longitude { get; set; }
        
        /// <summary>
        /// The altitude of the point, in meters.
        /// </summary>
        public double Altitude { get; set; }
        
        /// <summary>
        /// One of the following values: start, end, gps, pause, resume, manual.
        /// </summary>
        public string Type { get; set; }    
    }
}