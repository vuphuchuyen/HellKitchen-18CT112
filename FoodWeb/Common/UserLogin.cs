﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodWeb
{
    [Serializable]
    public class UserLogin
    {
       
        public long UserID { set; get; }
        public string UserName { get; set; }
    }
}