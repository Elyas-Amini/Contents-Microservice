﻿using EasyMicroservices.Cores.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMicroservices.ContentsMicroservice.Contracts.Requests
{
    public class IsKeyExistRequestContract : IUniqueIdentitySchema
    {
        public string Key { get; set; }
        public string UniqueIdentity { get; set; }
    }
}
