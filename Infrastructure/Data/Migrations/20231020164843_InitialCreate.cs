using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cargo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SueldoBase = table.Column<decimal>(type: "decimal(65,30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargo", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Color",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Color", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FormaPago",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormaPago", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Insumo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ValorUnit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StockMin = table.Column<int>(type: "int", nullable: false),
                    StockMax = table.Column<int>(type: "int", nullable: false),
                    StockActual = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insumo", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Talla",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Talla", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoEstado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoEstado", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoPersona",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPersona", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoProteccion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoProteccion", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Departamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdPaisFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departamento_Pais_IdPaisFk",
                        column: x => x.IdPaisFk,
                        principalTable: "Pais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Estado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdTipoEstadoFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Estado_TipoEstado_IdTipoEstadoFk",
                        column: x => x.IdTipoEstadoFk,
                        principalTable: "TipoEstado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Municipio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdDepFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Municipio_Departamento_IdDepFk",
                        column: x => x.IdDepFk,
                        principalTable: "Departamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Prenda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdPrenda = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ValorUnitCop = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValorUnitUsd = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IdEstadoFk = table.Column<int>(type: "int", nullable: false),
                    IdTipoProteccionFk = table.Column<int>(type: "int", nullable: false),
                    IdGeneroFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prenda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prenda_Estado_IdEstadoFk",
                        column: x => x.IdEstadoFk,
                        principalTable: "Estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prenda_Genero_IdGeneroFk",
                        column: x => x.IdGeneroFk,
                        principalTable: "Genero",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prenda_TipoProteccion_IdTipoProteccionFk",
                        column: x => x.IdTipoProteccionFk,
                        principalTable: "TipoProteccion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdCliente = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdTipoPersonaFk = table.Column<int>(type: "int", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IdMunFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cliente_Municipio_IdMunFk",
                        column: x => x.IdMunFk,
                        principalTable: "Municipio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cliente_TipoPersona_IdTipoPersonaFk",
                        column: x => x.IdTipoPersonaFk,
                        principalTable: "TipoPersona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Empleado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdEmp = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdCargoFk = table.Column<int>(type: "int", nullable: false),
                    FechaIngreso = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IdMunicipioFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Empleado_Cargo_IdCargoFk",
                        column: x => x.IdCargoFk,
                        principalTable: "Cargo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empleado_Municipio_IdMunicipioFk",
                        column: x => x.IdMunicipioFk,
                        principalTable: "Municipio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nit = table.Column<int>(type: "int", nullable: false),
                    RazonSocial = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RepresentanteLegal = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IdMunFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Empresa_Municipio_IdMunFk",
                        column: x => x.IdMunFk,
                        principalTable: "Municipio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Proveedor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NitProveedor = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdTipoPersonaFk = table.Column<int>(type: "int", nullable: false),
                    IdMunicipioFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Proveedor_Municipio_IdMunicipioFk",
                        column: x => x.IdMunicipioFk,
                        principalTable: "Municipio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Proveedor_TipoPersona_IdTipoPersonaFk",
                        column: x => x.IdTipoPersonaFk,
                        principalTable: "TipoPersona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "InsumoPrenda",
                columns: table => new
                {
                    IdInsumoFk = table.Column<int>(type: "int", nullable: false),
                    IdPrendaFk = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsumoPrenda", x => new { x.IdInsumoFk, x.IdPrendaFk });
                    table.ForeignKey(
                        name: "FK_InsumoPrenda_Insumo_IdInsumoFk",
                        column: x => x.IdInsumoFk,
                        principalTable: "Insumo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InsumoPrenda_Prenda_IdPrendaFk",
                        column: x => x.IdPrendaFk,
                        principalTable: "Prenda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Inventario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CodInv = table.Column<int>(type: "int", nullable: false),
                    IdPrendaFk = table.Column<int>(type: "int", nullable: false),
                    ValorUnitCop = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValorUnitUsd = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inventario_Prenda_IdPrendaFk",
                        column: x => x.IdPrendaFk,
                        principalTable: "Prenda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Orden",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    IdEmpleadoFk = table.Column<int>(type: "int", nullable: false),
                    IdClienteFk = table.Column<int>(type: "int", nullable: false),
                    IdEstadoFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orden", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orden_Cliente_IdClienteFk",
                        column: x => x.IdClienteFk,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orden_Empleado_IdEmpleadoFk",
                        column: x => x.IdEmpleadoFk,
                        principalTable: "Empleado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orden_Estado_IdEstadoFk",
                        column: x => x.IdEstadoFk,
                        principalTable: "Estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Venta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    IdEmpleadoFk = table.Column<int>(type: "int", nullable: false),
                    IdClienteFk = table.Column<int>(type: "int", nullable: false),
                    IdFormaPagoFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Venta_Cliente_IdClienteFk",
                        column: x => x.IdClienteFk,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Venta_Empleado_IdEmpleadoFk",
                        column: x => x.IdEmpleadoFk,
                        principalTable: "Empleado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Venta_FormaPago_IdFormaPagoFk",
                        column: x => x.IdFormaPagoFk,
                        principalTable: "FormaPago",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "InsumoProveedor",
                columns: table => new
                {
                    IdInsumoFk = table.Column<int>(type: "int", nullable: false),
                    IdProveedorFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsumoProveedor", x => new { x.IdProveedorFk, x.IdInsumoFk });
                    table.ForeignKey(
                        name: "FK_InsumoProveedor_Insumo_IdInsumoFk",
                        column: x => x.IdInsumoFk,
                        principalTable: "Insumo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InsumoProveedor_Proveedor_IdProveedorFk",
                        column: x => x.IdProveedorFk,
                        principalTable: "Proveedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "InventarioTalla",
                columns: table => new
                {
                    IdInvFk = table.Column<int>(type: "int", nullable: false),
                    IdTallaFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventarioTalla", x => new { x.IdInvFk, x.IdTallaFk });
                    table.ForeignKey(
                        name: "FK_InventarioTalla_Inventario_IdInvFk",
                        column: x => x.IdInvFk,
                        principalTable: "Inventario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InventarioTalla_Talla_IdTallaFk",
                        column: x => x.IdTallaFk,
                        principalTable: "Talla",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DetalleOrden",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdOrdenFk = table.Column<int>(type: "int", nullable: false),
                    IdPrendaFk = table.Column<int>(type: "int", nullable: false),
                    CantidadProducir = table.Column<int>(type: "int", nullable: false),
                    IdColorFk = table.Column<int>(type: "int", nullable: false),
                    CantidadProducida = table.Column<int>(type: "int", nullable: false),
                    IdEstadoFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleOrden", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetalleOrden_Color_IdColorFk",
                        column: x => x.IdColorFk,
                        principalTable: "Color",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleOrden_Estado_IdEstadoFk",
                        column: x => x.IdEstadoFk,
                        principalTable: "Estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleOrden_Orden_IdOrdenFk",
                        column: x => x.IdOrdenFk,
                        principalTable: "Orden",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleOrden_Prenda_IdPrendaFk",
                        column: x => x.IdPrendaFk,
                        principalTable: "Prenda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DetalleVenta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdVentaFk = table.Column<int>(type: "int", nullable: false),
                    IdProductoFk = table.Column<int>(type: "int", nullable: false),
                    IdTallaFk = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    ValorUnit = table.Column<decimal>(type: "decimal(65,30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleVenta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetalleVenta_Inventario_IdProductoFk",
                        column: x => x.IdProductoFk,
                        principalTable: "Inventario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleVenta_Talla_IdTallaFk",
                        column: x => x.IdTallaFk,
                        principalTable: "Talla",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleVenta_Venta_IdVentaFk",
                        column: x => x.IdVentaFk,
                        principalTable: "Venta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_IdCliente",
                table: "Cliente",
                column: "IdCliente",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_IdMunFk",
                table: "Cliente",
                column: "IdMunFk");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_IdTipoPersonaFk",
                table: "Cliente",
                column: "IdTipoPersonaFk");

            migrationBuilder.CreateIndex(
                name: "IX_Departamento_IdPaisFk",
                table: "Departamento",
                column: "IdPaisFk");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleOrden_IdColorFk",
                table: "DetalleOrden",
                column: "IdColorFk");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleOrden_IdEstadoFk",
                table: "DetalleOrden",
                column: "IdEstadoFk");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleOrden_IdOrdenFk",
                table: "DetalleOrden",
                column: "IdOrdenFk");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleOrden_IdPrendaFk",
                table: "DetalleOrden",
                column: "IdPrendaFk");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleVenta_IdProductoFk",
                table: "DetalleVenta",
                column: "IdProductoFk");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleVenta_IdTallaFk",
                table: "DetalleVenta",
                column: "IdTallaFk");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleVenta_IdVentaFk",
                table: "DetalleVenta",
                column: "IdVentaFk");

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_IdCargoFk",
                table: "Empleado",
                column: "IdCargoFk");

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_IdEmp",
                table: "Empleado",
                column: "IdEmp",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_IdMunicipioFk",
                table: "Empleado",
                column: "IdMunicipioFk");

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_IdMunFk",
                table: "Empresa",
                column: "IdMunFk");

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_Nit",
                table: "Empresa",
                column: "Nit",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Estado_IdTipoEstadoFk",
                table: "Estado",
                column: "IdTipoEstadoFk");

            migrationBuilder.CreateIndex(
                name: "IX_Insumo_Nombre",
                table: "Insumo",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InsumoPrenda_IdPrendaFk",
                table: "InsumoPrenda",
                column: "IdPrendaFk");

            migrationBuilder.CreateIndex(
                name: "IX_InsumoProveedor_IdInsumoFk",
                table: "InsumoProveedor",
                column: "IdInsumoFk");

            migrationBuilder.CreateIndex(
                name: "IX_Inventario_CodInv",
                table: "Inventario",
                column: "CodInv",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Inventario_IdPrendaFk",
                table: "Inventario",
                column: "IdPrendaFk");

            migrationBuilder.CreateIndex(
                name: "IX_InventarioTalla_IdTallaFk",
                table: "InventarioTalla",
                column: "IdTallaFk");

            migrationBuilder.CreateIndex(
                name: "IX_Municipio_IdDepFk",
                table: "Municipio",
                column: "IdDepFk");

            migrationBuilder.CreateIndex(
                name: "IX_Orden_IdClienteFk",
                table: "Orden",
                column: "IdClienteFk");

            migrationBuilder.CreateIndex(
                name: "IX_Orden_IdEmpleadoFk",
                table: "Orden",
                column: "IdEmpleadoFk");

            migrationBuilder.CreateIndex(
                name: "IX_Orden_IdEstadoFk",
                table: "Orden",
                column: "IdEstadoFk");

            migrationBuilder.CreateIndex(
                name: "IX_Prenda_IdEstadoFk",
                table: "Prenda",
                column: "IdEstadoFk");

            migrationBuilder.CreateIndex(
                name: "IX_Prenda_IdGeneroFk",
                table: "Prenda",
                column: "IdGeneroFk");

            migrationBuilder.CreateIndex(
                name: "IX_Prenda_IdPrenda",
                table: "Prenda",
                column: "IdPrenda",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Prenda_IdTipoProteccionFk",
                table: "Prenda",
                column: "IdTipoProteccionFk");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedor_IdMunicipioFk",
                table: "Proveedor",
                column: "IdMunicipioFk");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedor_IdTipoPersonaFk",
                table: "Proveedor",
                column: "IdTipoPersonaFk");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedor_NitProveedor",
                table: "Proveedor",
                column: "NitProveedor",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Talla_Descripcion",
                table: "Talla",
                column: "Descripcion",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Venta_IdClienteFk",
                table: "Venta",
                column: "IdClienteFk");

            migrationBuilder.CreateIndex(
                name: "IX_Venta_IdEmpleadoFk",
                table: "Venta",
                column: "IdEmpleadoFk");

            migrationBuilder.CreateIndex(
                name: "IX_Venta_IdFormaPagoFk",
                table: "Venta",
                column: "IdFormaPagoFk");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetalleOrden");

            migrationBuilder.DropTable(
                name: "DetalleVenta");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropTable(
                name: "InsumoPrenda");

            migrationBuilder.DropTable(
                name: "InsumoProveedor");

            migrationBuilder.DropTable(
                name: "InventarioTalla");

            migrationBuilder.DropTable(
                name: "Color");

            migrationBuilder.DropTable(
                name: "Orden");

            migrationBuilder.DropTable(
                name: "Venta");

            migrationBuilder.DropTable(
                name: "Insumo");

            migrationBuilder.DropTable(
                name: "Proveedor");

            migrationBuilder.DropTable(
                name: "Inventario");

            migrationBuilder.DropTable(
                name: "Talla");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Empleado");

            migrationBuilder.DropTable(
                name: "FormaPago");

            migrationBuilder.DropTable(
                name: "Prenda");

            migrationBuilder.DropTable(
                name: "TipoPersona");

            migrationBuilder.DropTable(
                name: "Cargo");

            migrationBuilder.DropTable(
                name: "Municipio");

            migrationBuilder.DropTable(
                name: "Estado");

            migrationBuilder.DropTable(
                name: "Genero");

            migrationBuilder.DropTable(
                name: "TipoProteccion");

            migrationBuilder.DropTable(
                name: "Departamento");

            migrationBuilder.DropTable(
                name: "TipoEstado");

            migrationBuilder.DropTable(
                name: "Pais");
        }
    }
}
