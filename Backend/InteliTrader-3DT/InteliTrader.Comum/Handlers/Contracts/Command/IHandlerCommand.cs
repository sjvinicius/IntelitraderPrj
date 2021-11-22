using InteliTrader.Comum.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteliTrader.Comum.Handlers.Contracts
{// <T> ->   Cria uma interface associada à um objeto genérico
 // where -> Garante que este objeto genérico herde da interface Icommand
    public interface IHandlerCommand<T> where T : ICommand
   {
        ICommandResult Handler(T command);
   }
}
