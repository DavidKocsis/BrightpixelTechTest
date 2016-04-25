using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using MarsRover.API.Models;
using MarsRover;

namespace MarsRover.API.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        [ActionName("MoveRovers")]
        [HttpGet]
        public string MoveRovers([ModelBinder(typeof(MarsRoverCiteriaBinder.MarsRoverCriteriaBinder))]MarsRoverCriteria criteria)
        {
            var rover = new Rover(criteria.StartingX, criteria.StartingY, criteria.Direction);
            rover.ProcessOrders(criteria.Movements);
            string newPosition = string.Format("{0}, {1}, {2}", rover.Position.positionX, rover.Position.positionY, rover.Direction);
            return newPosition;
        }
    }
}
