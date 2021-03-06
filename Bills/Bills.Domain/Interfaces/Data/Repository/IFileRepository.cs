﻿using Bills.Domain.Dtos;
using System.Threading.Tasks;

namespace Bills.Domain.Interfaces.Data.Repository
{
    /// <summary>
    /// Access files in the Blob Storage and retrieve them
    /// </summary>
    public interface IFileRepository
    {
        Task<FileDto> GetFile(string address);
    }
}
