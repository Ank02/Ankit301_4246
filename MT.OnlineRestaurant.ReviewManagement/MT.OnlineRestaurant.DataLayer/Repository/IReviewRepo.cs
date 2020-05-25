using MT.OnlineRestaurant.DataLayer.Data_Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MT.OnlineRestaurant.DataLayer.Repository
{
   public interface IReviewRepo
    {
        void GetResturantDetails(int restaurantID);
    }
}
