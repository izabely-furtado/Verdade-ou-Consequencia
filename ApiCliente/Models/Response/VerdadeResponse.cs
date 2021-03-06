﻿using System;
using System.Collections.Generic;

namespace ApiCliente.Models.Response
{
    public class VerdadeResponse
    {
        public string descricao { get; set; }
        public int idade { get; set; }
        public PessoaResponse Pessoa { get; set; }
        public SequenciaResponse Sequencia { get; set; }
        public List<TipoResponse> Tipos { get; set; }
        public List<OpcaoResponse> Opcoes { get; set; }
        public int id { get; set; }
        
        //public int id_sequencia { get; set; }
    }
}
