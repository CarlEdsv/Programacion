CREATE TABLE [dbo].[Empleados] (
    [Id]             INT             IDENTITY (1, 1) NOT NULL,
    [Nombre]         NCHAR (50)      NOT NULL,
    [DUI]            NCHAR (10)      NOT NULL,
	[Codigo]         NCHAR (10)      NOT NULL,
    [Salario]        NUMERIC (18, 2) NOT NULL,
    [AFP]            NUMERIC (18, 2) NULL,
    [ISSS]           NUMERIC (18, 2) NULL,
    [DESCUENTO]      NUMERIC (18, 2) NULL,
    [SALARIOLIQUIDO] NUMERIC (18, 2) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

