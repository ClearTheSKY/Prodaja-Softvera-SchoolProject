﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Math;


namespace Prodaja_Softvera_ver3.Web.Areas.AdministratorModul.ViewModels
{
    public class PagingInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages => (int)Ceiling((decimal)TotalItems / ItemsPerPage);
    }
}
