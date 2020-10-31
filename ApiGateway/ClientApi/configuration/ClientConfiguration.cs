using System.Collections.Generic;
using ClientApi.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClientApi.configuration
{
    public class ClientConfiguration
    {
        public ClientConfiguration(EntityTypeBuilder<Client> entityBuilder)
        {
            entityBuilder.HasIndex(x => x.Id);
            entityBuilder.Property(x => x.Nombre).IsRequired().HasMaxLength(100);

            var client = new List<Client>();
            for (var i = 1; i <= 100; i++)
            {
                client.Add(new Client
                {
                    Id = i,
                    Nombre = $"Cliente {i}",
                    Apellidos = $"Apellido {i} del cliente {i}",
                    Documento = $"2333323{i}",
                    Direccion = $"Direccion {i}",
                    Telefono = $"4345455{i}",
                    Email = "dreyluisdel92.4@gmail.com"
                }
                );
            }
        }
    }
}