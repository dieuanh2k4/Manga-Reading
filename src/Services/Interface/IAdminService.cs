using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.src.Dtos.Admin;
using backend.src.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend.src.Services.Interface
{
    public interface IAdminService
    {
        Task<List<Admin>> GetInfoAdmin();
        Task<Admin> GetInfoAdminById(int id);
        Task<Admin> CreateAdmin(CreateAdminDto adminDto);
        Task<Admin> UpdateAdmin(UpdateAdminDto adminDto, int id);
        Task<Admin> DeleteAdmin(int id);
        Task<List<Readers>> GetInfoReader();
        Task<Readers> GetInfoReaderById(int id);
        Task<Readers> CreateReader(CreateReaderDto readerDto, string? userName, string? password);
        Task<Readers> UpdateReader(UpdateReaderDto readerDto, int id);
        Task<Readers> DeleteReader(int id);
    }
}