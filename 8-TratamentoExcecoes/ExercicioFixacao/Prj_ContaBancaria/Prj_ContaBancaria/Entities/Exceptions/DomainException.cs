﻿

using System;

namespace Prj_ContaBancaria.Entities.Exceptions
{
    class DomainException:ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
