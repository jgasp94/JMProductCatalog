using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JMProductCatalog.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Products(Id, Name,Description,Price,Stock,Image,CategoryId) " +
            "VALUES(NEWID(), 'Caderno espiral','Caderno espiral 100 fôlhas',7.45,50,'caderno1.jpg','06b5594a-7503-4bd8-b210-47d41b364634')");

            mb.Sql("INSERT INTO Products(Id, Name,Description,Price,Stock,Image,CategoryId) " +
            "VALUES(NEWID(), 'Estojo escolar','Estojo escolar cinza',5.65,70,'estojo1.jpg','06b5594a-7503-4bd8-b210-47d41b364634')");

            mb.Sql("INSERT INTO Products(Id, Name,Description,Price,Stock,Image,CategoryId) " +
            "VALUES(NEWID(), 'Borracha escolar','Borracha branca pequena',3.25,80,'borracha1.jpg','06b5594a-7503-4bd8-b210-47d41b364634')");

            mb.Sql("INSERT INTO Products(Id,Name,Description,Price,Stock,Image,CategoryId) " +
            "VALUES(NEWID(), 'God of War - Ragnarok','Exclusivo para PS4 e PS5',299.39,20,'god-of-war-ragnarok.jpg','47f617e9-3135-4cc1-9d0e-4e1d9476536a')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM Products");
        }
    }
}
