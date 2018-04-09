﻿// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


#pragma warning disable 1591

namespace IdentityServer4.EF6.Entities
{
    public class ClientSecret : Secret
    {
        public int? ClientId { get; set; }
        public Client Client { get; set; }
    }
}