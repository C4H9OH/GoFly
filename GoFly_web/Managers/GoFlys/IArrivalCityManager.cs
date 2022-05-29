﻿using GoFly_web.Storage.Entity;

namespace GoFly_web.Managers.GoFlys
{
    public interface IArrivalCityManager
    {
        Task<IList<ArrivalCity>> GetAll();

        Task CreateCity(string name, string currency, string language, string description,
            string imageLink, string country);

        Task DeleteCity(int id);

    }
}
