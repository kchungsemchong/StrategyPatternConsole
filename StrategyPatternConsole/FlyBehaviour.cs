using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternConsole
{
    public class FlyBehaviour : IMovementBehaviour
    {
	   public void Move()
	   {
		  Console.WriteLine("I can fly!");
	   }
    }
}
