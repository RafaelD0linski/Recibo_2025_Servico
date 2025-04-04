﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
namespace Recibo_2025_Servico.ReciboServicoUseCase;

public sealed record class DadosServicoRequest( string tipoServico, string descricaoServico, 
    double valorServico, string tipoPagamento, string cep, string cidade, string rua, string num, string estado  );
