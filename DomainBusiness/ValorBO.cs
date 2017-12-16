using wpEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wpService;
using wpRepository;

namespace DomainBusiness
{
    public static class ValorBO
    {
        /// <summary>
        /// Metodo de salvar Valor (Async)
        /// </summary>
        /// <param name="Valor"> Objeto Produtp</param>
        /// <param name="token"> Token valido</param>
        /// <returns>Verdadeiro: Salvou o Valor / Falso: Houve falha</returns>
        public static async Task<bool> SaveAsync(Valor Valor, string token)
        {
            if (await SeguracaServ.validaTokenAsync(token))
            {
                if (Valor.idCliente != 0)
                    try { return ValorRep.Save(Valor); } catch { return false; }
                else
                    return false;
            }
            else
                return false;
        }

        /// <summary>
        /// Metodo de retornar todos os Valors por cliente
        /// </summary>
        /// <param name="idCliente">ID do cliente solicitante</param>
        /// <param name="token">Token Valido</param>
        /// <returns></returns>
        public static async Task<List<Valor>> GetAllAsync(int idCliente, string token)
        {
            if (await SeguracaServ.validaTokenAsync(token))
                return ValorRep.GetAll().Where(x => x.idCliente == idCliente).ToList();
            else
                return new List<Valor>();
        }

        /// <summary>
        /// Metodo de deletar Valor
        /// </summary>
        /// <param name="Valor">Valor que iraser deletado</param>
        /// <param name="token">Token valido</param>
        /// <returns>Verdadeiro: Removeu o Valor / Falso: Houve falha</returns>
        public static async Task<bool> RemoveAsync(Object Valor, string token)
        {
            dynamic objEn = Valor;
            string a = objEn.ID.ToString();
            if (await SeguracaServ.validaTokenAsync(token))
            {
                Valor obj = ValorRep.GetAll().Where(x => x.ID == Convert.ToInt32(a)).FirstOrDefault();
                return ValorRep.Remove(obj);
            }
            else
                return false;
        }
    }
}
