﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descriçao { get; set; }
        public string Preco { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
