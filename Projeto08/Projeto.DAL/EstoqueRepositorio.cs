﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.DAL;
using System.Data.SqlClient;


namespace Projeto.DAL
{
    public class EstoqueRepositorio : Conexao
    {

        public void Insert()
        {
            string query = "insert into Estoque ";
        }

    }
}