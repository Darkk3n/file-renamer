using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using TreasuryToolkit.Core.Contracts;
using TreasuryToolkit.Core.Models;

namespace TreasuryToolkit.Infra.Services
{
    public class JsonCompanyService : ICompanyService
    {
        private readonly List<CompanyModel> _companies;

        public JsonCompanyService()
        {
            try
            {
                string jsonContent = null;
                var assembly = Assembly.GetEntryAssembly() ?? Assembly.GetExecutingAssembly();
                string resourceName = assembly.GetManifestResourceNames()
                                              .FirstOrDefault(str => str.EndsWith("companies.json", StringComparison.OrdinalIgnoreCase));

                if (resourceName != null)
                {
                    using Stream stream = assembly.GetManifestResourceStream(resourceName);
                    using StreamReader reader = new(stream, Encoding.UTF8);
                    jsonContent = reader.ReadToEnd();
                }
                if (!string.IsNullOrEmpty(jsonContent))
                {
                    _companies = JsonSerializer.Deserialize<List<CompanyModel>>(jsonContent) ?? [];
                }
                else
                {
                    _companies = [new() { Id = "ERR", Name = "companies.json no encontrado" }];
                }
            }
            catch
            {
                _companies = [new() { Id = "ERR", Name = "Error al cargar lista de empresas" }];
            }
        }

        public IReadOnlyList<CompanyModel> GetCompanyNames() => _companies;
    }
}