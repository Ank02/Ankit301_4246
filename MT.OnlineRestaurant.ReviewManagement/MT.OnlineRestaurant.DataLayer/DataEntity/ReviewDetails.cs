﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MT.OnlineRestaurant.DataLayer.Data_Entity
{
    class ReviewDetails
    {
        public int RestaurantId { get; set; }
        public string Restaurant_Name { get; set; }
        public string Review { get; set; }
        public double Rating { get; set; }
        
    }
}