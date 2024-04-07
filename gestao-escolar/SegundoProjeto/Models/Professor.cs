﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoProjeto.Models
{
    internal class Professor
    {
        public string Nome {  get; set; }
        public DateTime Contrata { get; set; }
        public HashSet<Curso> Cursos { get; } = new HashSet<Curso>();

        public override bool Equals(Object obj)
        {
            if (obj is Professor)
            {
                Professor p = obj as Professor;
                return this.Nome.Equals(p.Nome);
            }
            return false;
        }
        public override int GetHashCode()
        {
            return (11 + this.Nome == null ? 0 : this.Nome.GetHashCode());
        }
    }
}
