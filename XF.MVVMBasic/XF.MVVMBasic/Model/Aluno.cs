﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XF.MVVMBasic.Model
{
    public class Aluno
    {
        public Guid Id { get; set; }
        public string RM { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
    }

}
