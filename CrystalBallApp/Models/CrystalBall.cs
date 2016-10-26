using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrystalBallApp.Models
{
    public class CrystalBall
    {
        public string getResponse()
        {
            string[] responses = { "You are loved", "It's best to serve soup warm", "gg my dude" };
            Random randomNum = new Random();
            int num = randomNum.Next(0, responses.Length);
            return responses[num];
        }
    }
}