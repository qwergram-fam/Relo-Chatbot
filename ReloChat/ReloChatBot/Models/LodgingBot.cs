﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReloChatBot.Models
{
    public class LodgingBot : LuisParser
    {
        // Spot the python programmer again...
    
        // The only way to get this to work, and not inherit the RESULTS from LuisParser (parent class)
        // Is to plug in api_endpoint as one of the paramters, and set a default

        public LodgingBot(string query, string api_endpoint = "https://api.projectoxford.ai/luis/v1/application?id=8547ee95-9496-43ca-a9a2-b583da92cd7e&subscription-key=6171c439d26540d6a380208a16b31958&q=") : base(query, api_endpoint) { }
        public override string Reply
        {
            get { return this.GetReply(); }
        }

        private string GetReply()
        {

            return this.Intent;
        }
    }

    public class LodgingBotFunctionality
    {
        private string intent;
        public LodgingBotFunctionality(string intent)
        {
            this.intent = intent;
        }
    }

}
