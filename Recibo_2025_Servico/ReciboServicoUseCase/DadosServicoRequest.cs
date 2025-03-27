using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recibo_2025_Servico.ReciboServicoUseCase;

public sealed record class DadosServicoRequest( DateTime dataDoServico, string tipoServico, string descricaoServico, 
    double valorServico, string tipoPagamento, string cep, string cidade, string rua, string num, string estado  );
