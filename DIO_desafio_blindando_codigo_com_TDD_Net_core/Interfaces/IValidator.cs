using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO_Desafio_blindando_codigo_com_TDD_Net_core.Interfaces
{
    public interface IValidator
    {
        string Validate();

        void SetItemForValidation(Object Item);
        
    }
}