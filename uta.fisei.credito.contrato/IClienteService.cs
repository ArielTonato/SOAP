using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uta.fisei.credito.dominio;
using System.ServiceModel;

namespace uta.fisei.credito.contrato
{
    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract]
        Cliente ObtenerCliente(string numeroDocumento);
        [OperationContract]
        IEnumerable<Cliente> ListarCliente();
    }
}
