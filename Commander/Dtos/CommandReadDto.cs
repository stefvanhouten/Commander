﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Dtos
{
    public class CommandReadDto
    {
        //DTO = Data Transfer Object
        public int Id { get; set; }
        public string HowTo { get; set; }
        public string Line { get; set; }
    }
}
