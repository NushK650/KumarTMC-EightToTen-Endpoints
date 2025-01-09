using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KumarTMC_EightToTen_Endpoints.Services;
using Microsoft.AspNetCore.Mvc;

namespace KumarTMC_EightToTen_Endpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantPickerController : ControllerBase
    {
                private readonly RestaurantPickerService _restaurantPickerService;

        public RestaurantPickerController (RestaurantPickerService restaurantPickerService)
        {
            _restaurantPickerService = restaurantPickerService;
        }

        
        

        [HttpGet]
        [Route("RestaurantPicker/{input}")]
public string RestaurantPicker(string input)
        {
            return _restaurantPickerService.RestaurantPicker(input);
        }

    }
}