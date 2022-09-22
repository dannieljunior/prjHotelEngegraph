using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class ProdutoServico
    {
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public bool IsServico { get; set; }
        public bool  IsProduto { get; set; }
        public bool IsProdutoIndustrializado { get; set; }
    }

    public class CalculoImpostoGO: ICalculoImposto
    {
        public double CalculaIcms(ProdutoServico produto)
        {
            if (produto.IsProduto)
            {
                return produto.Valor * 0.10;
            }
            else
            {
                return 0;
            }
        }

        public double CalculaIss(ProdutoServico produto)
        {
            if (produto.IsServico)
            {
                return produto.Valor * 0.01;
            }
            else
            {
                return 0;
            }
        }

        public double CalculaIPI(ProdutoServico produto)
        {
            if (produto.IsProdutoIndustrializado)
            {
                return produto.Valor * 0.06;
            }
            else
            {
                return 0;
            }
            
        }
    }

    public class CalculoImpostoMG: ICalculoImposto
    {
        public double CalculaIcms(ProdutoServico produto)
        {
            if (produto.IsProduto)
            {
                return produto.Valor * 0.11;
            }
            else
            {
                return 0;
            }
        }

        public double CalculaIss(ProdutoServico produto)
        {
            if (produto.IsServico)
            {
                return produto.Valor * 0.04;
            }
            else
            {
                return 0;
            }
        }

        public double CalculaIPI(ProdutoServico produto)
        {
            if (produto.IsProdutoIndustrializado)
            {
                return produto.Valor * 0.08;
            }
            else
            {
                return 0;
            }
        }
    }

    public class CalculoImpostoDF: ICalculoImposto
    {
        public double CalculaIcms(ProdutoServico produto)
        {
            if (produto.IsProduto)
            {
                return produto.Valor * 0.17;
            }
            else
            {
                return 0;
            }
        }

        public double CalculaIss(ProdutoServico produto)
        {
            if (produto.IsServico)
            {
                return produto.Valor * 0.09;
            }
            else
            {
                return 0;
            }
        }

        public double CalculaIPI(ProdutoServico produto)
        {
            if (produto.IsProdutoIndustrializado)
            {
                return produto.Valor * 0.05;
            }
            else
            {
                return 0;
            }
        }
    }
}
