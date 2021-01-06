﻿using Bills.Domain.Enums;
using System.Threading.Tasks;

namespace Bills.Domain.Interfaces.Data.Factory
{
    public interface IBillFactory
    {
        Task<Bill> Create(EBillType billType);
    }
}
