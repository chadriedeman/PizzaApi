﻿using PizzaAPI.Data.Models;
using System.Collections.Generic;

namespace PizzaAPI.Services
{
    public interface IPizzasService
    {
        List<Pizza> GetPizzas();
    }
}