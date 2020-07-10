using System;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.Authorization.Users;
using Abp.AutoMapper;
using PrototipoSistemaFGV.Authorization.BaseCalcules;

namespace PrototipoSistemaFGV.BaseCalcules.Dto
{
    [AutoMapFrom(typeof(BaseCalculo))]
    public class BaseCalculoDto : EntityDto<int>
    {


        public int Numero { get; set; }
        public string Documento { get; set; }
        public DateTime Ano { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataVencimento { get; set; }
        public decimal ValorFatura { get; set; }
        public decimal ValorPago { get; set; }
        public int NumeroPedidoWeb { get; set; }
        public string CodigoConveniado { get; set; }
        public int Repasse { get; set; }
        public string CnpjConveniado { get; set; }
        public DateTime? DataVenda { get; set; }
        public DateTime DataCredito { get; set; }
        public decimal ValorBruto { get; set; }
        public decimal ValorParcela { get; set; }
        public decimal ValorLiquido { get; set; }
        public int NumeroParcela { get; set; }
        public int TotalParcela { get; set; }
        public string Bandeira { get; set; }
        public string Estabelecimento { get; set; }
        public string NsuHost { get; set; }
        public string NsuTef { get; set; }
        public decimal ValorComissao { get; set; }
    }
}
