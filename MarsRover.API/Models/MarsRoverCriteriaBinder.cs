using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.ModelBinding;
using MarsRover;

namespace MarsRover.API.Models
{
    public class MarsRoverCiteriaBinder
    {
        public class MarsRoverCriteriaBinder : IModelBinder
        {
            public bool BindModel(HttpActionContext actionContext, ModelBindingContext bindingContext)
            {
                bindingContext.Model = new MarsRoverCriteria
                {
                    StartingX = int.Parse(GetValue("X", bindingContext, false)),
                    StartingY = int.Parse(GetValue("Y", bindingContext, false)),
                    Direction = MapDirection(GetValue("Direction", bindingContext, false)),
                    Movements = GetValue("Movements", bindingContext, false)
                };
                return true;
            }

            private Direction MapDirection(string direction)
            {
                switch (direction)
                {
                    case "N":
                        return Direction.N;
                    case "S":
                        return Direction.S;
                    case "W":
                        return Direction.W;
                    case "E":
                        return Direction.E;
                }
                return Direction.Unknown;
            }

            private static string GetValue(string key, ModelBindingContext bindingContext, bool convertToUpperCase)
            {
                var extractedValue = bindingContext.ValueProvider.GetValue(key);

                if (extractedValue != null)
                {
                    var value = extractedValue.AttemptedValue;

                    return convertToUpperCase ? value.ToUpperInvariant() : value;
                }

                return null;
            }

        }
    }
}