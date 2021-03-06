﻿using Bills.Domain.Dtos;
using Bills.Domain.Entities;
using Bills.Domain.Interfaces.Data.Repository;
using System.Threading.Tasks;

namespace Bills.Infrastructure.Data.Repositories
{
    /// <summary>
    /// Access files in the Blob Storage and retrieve them
    /// </summary>
    public class FileRepository : IFileRepository
    {
        public Task<FileDto> GetFile(string address)
        {
            throw new System.NotImplementedException();
        }
    }
}
