using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;

namespace Recibo_2025_Servico.MensagemDeAvisoUseCase;

public class MensagemAviso
{
    public string Titulo { get; set; }
    public string Mensagem { get; set; }
    public NivelAviso Nivel { get; set; }
    public DateTime DataHora { get; private set; }

    public MensagemAviso(string titulo, string mensagem, NivelAviso nivel)
    {
        Titulo = titulo;
        Mensagem = mensagem;
        Nivel = nivel;
        DataHora = DateTime.Now;
    }

    public override string ToString()
    {
        return $"{Nivel} {Titulo}: {Mensagem}";
    }
}

public enum NivelAviso
{
    Informativo,
    Alerta,
    Critico
}
