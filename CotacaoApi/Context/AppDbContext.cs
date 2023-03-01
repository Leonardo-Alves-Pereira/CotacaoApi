using CotacaoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CotacaoApi.Context;

public class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }


    public DbSet<Cotacao> Cotacoes { get; set; }
    public DbSet<CotacaoItem> CotacoesItens { get; set; }

    protected override void OnModelCreating(ModelBuilder mb)
    {
        mb.Entity<Cotacao>().HasKey(c => c.Id);

        mb.Entity<Cotacao>()
          .Property(c => new
          {
              c.CNPJComprador,
              c.CNPJFornecedor,
              c.NumeroCotacao,
              c.CEP
          }).HasMaxLength(100)
            .IsRequired();

        mb.Entity<Cotacao>()
          .Property(c => new
          {
              c.Logradouro,
              c.Complemento,
              c.Bairro,
              c.Observacao,
              c.UF
          }).HasMaxLength(100);

        mb.Entity<CotacaoItem>()
          .Property(c => c.Preco)
          .HasMaxLength(10);

        mb.Entity<CotacaoItem>()
          .Property(c => c.Marca)
          .HasMaxLength(50);

        mb.Entity<CotacaoItem>()
          .Property(c => c.Unidade)
          .HasMaxLength(4);

        mb.Entity<CotacaoItem>()
          .Property(c => new 
          { 
               c.Descricao,
               c.NumeroItem,
               c.Quantidade
          }).HasMaxLength(100)
            .IsRequired();
    }
}
