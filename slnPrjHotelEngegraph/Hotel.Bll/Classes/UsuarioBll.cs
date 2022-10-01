using Hotel.Bll.IOC;
using Hotel.Comum.Dto;
using Hotel.Comum.Enumerados;
using Hotel.Comum.Helpers;
using Hotel.Comum.Interfaces;
using Hotel.Comum.IOC;
using Hotel.Comum.Modelos;
using Hotel.Comum.ViewModels;
using Hotel.Repositorio.ADO.Classes;
using System;

namespace Hotel.Bll.Classes
{
    public class UsuarioBll : BllBase<Usuario, IRepositorioUsuario>
    {
        readonly ConfiguracaoBll _configuracaoBll;
        public UsuarioBll()
        {
            _repositorio = Kernel.Get<IRepositorioUsuario>();
            _configuracaoBll = new ConfiguracaoBll();
        }

        public override ObjetoDeValidacao Validar(Usuario objeto)
        {
            var resultadoValidacao = new ObjetoDeValidacao();

            if (string.IsNullOrWhiteSpace(objeto.Login))
            {
                resultadoValidacao.Criticas.Add("Login do usuario não informado.");
            }

            if (string.IsNullOrWhiteSpace(objeto.Senha))
            {
                resultadoValidacao.Criticas.Add("Senha não pode estar em branco.");
            }

            if (string.IsNullOrWhiteSpace(objeto.EMail))
            {
                resultadoValidacao.Criticas.Add("Email deve ser informado.");
            }

            return resultadoValidacao;
        }

        public override Usuario Persistir(Usuario obj, EnOperacao operacao)
        {
            var usuarioAntigo = GetById(obj.Id);

            if(usuarioAntigo?.Senha != obj.Senha)
            {
                obj.DataExpiracao = DateTime.Now.AddDays(_configuracaoBll.ObterConfiguracaoPeloCodigo(1003).ToInt());
            }

            if(obj.Tentativas > _configuracaoBll.ObterConfiguracaoPeloCodigo(1002).ToInt() && obj.Ativo)
            {
                obj.Ativo = false;
            }

            return base.Persistir(obj, operacao);
        }

        public LoginViewModel Login(string login, string senha)
        {
            var usuario = _repositorio.GetUserByLogin(login);

            var resultado = new LoginViewModel()
            {
                Sucesso = true
            };

            if (usuario == null)
            {
                resultado.Sucesso = false;
                resultado.Mensagem = "Usuário não encontrado.";
            }
            else
            {
                if (usuario.Tentativas > _configuracaoBll.ObterConfiguracaoPeloCodigo(1002).ToInt())
                {
                    resultado.Sucesso = false;
                    resultado.Mensagem = "A quantidade de tentativas de login foi excedida.";
                } 
                else if (!usuario.Ativo)
                {
                    resultado.Sucesso = false;
                    resultado.Mensagem = "Usuário inativo no sistema.";
                }
                else if(DateTime.Now > usuario.DataExpiracao)
                {
                    resultado.Sucesso = false;
                    resultado.Mensagem = "A senha do usuário expirou. Entre em contato com o admnistrador do sistema.";
                }
                else if(usuario.Senha != senha)
                {
                    resultado.Sucesso = false;
                    resultado.Mensagem = "Usuário ou senha incorretos.";
                }
            }

            if(usuario != null && !resultado.Sucesso)
            {
                usuario.Tentativas++;
                Persistir(usuario, EnOperacao.Update);
            }

            return resultado;
        }
    }
}
