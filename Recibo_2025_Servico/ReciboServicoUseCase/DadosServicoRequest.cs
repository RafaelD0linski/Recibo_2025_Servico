using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recibo_2025_Servico.ReciboServicoUseCase;

public sealed record class DadosServicoRequest( DateTimePicker dataServiço, string tipoServico, string descricaoServico, double valorServico, string tipoPagamento );
