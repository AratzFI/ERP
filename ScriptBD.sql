USE [DAM2_AratzFernandez]
GO
/****** Object:  Schema [SGE]    Script Date: 11/11/2022 8:41:41 ******/
CREATE SCHEMA [SGE]
GO
/****** Object:  UserDefinedTableType [SGE].[tiposAlb]    Script Date: 11/11/2022 8:41:41 ******/
CREATE TYPE [SGE].[tiposAlb] AS TABLE(
	[CodAlb] [smallint] NULL,
	[CodPed] [tinyint] NULL,
	[FechaEntrega] [datetime] NULL,
	[Aceptado] [varchar](1) NULL,
	[Estado] [varchar](1) NULL
)
GO
/****** Object:  UserDefinedTableType [SGE].[tiposLinAlb]    Script Date: 11/11/2022 8:41:41 ******/
CREATE TYPE [SGE].[tiposLinAlb] AS TABLE(
	[CodAlb] [smallint] NULL,
	[CodProd] [tinyint] NULL,
	[Unidades] [tinyint] NULL
)
GO
/****** Object:  UserDefinedTableType [SGE].[tiposLinPed]    Script Date: 11/11/2022 8:41:41 ******/
CREATE TYPE [SGE].[tiposLinPed] AS TABLE(
	[CodPed] [tinyint] NULL,
	[NumLin] [tinyint] NULL,
	[CodProd] [tinyint] NULL,
	[Unidades] [smallint] NULL,
	[PVP] [money] NULL
)
GO
/****** Object:  UserDefinedTableType [SGE].[tiposPedidos]    Script Date: 11/11/2022 8:41:41 ******/
CREATE TYPE [SGE].[tiposPedidos] AS TABLE(
	[CodPed] [tinyint] NULL,
	[CodAlb] [smallint] NULL,
	[CodProv] [tinyint] NULL,
	[Total] [money] NULL,
	[FechaPedido] [date] NULL
)
GO
/****** Object:  Table [SGE].[albaranes]    Script Date: 11/11/2022 8:41:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [SGE].[albaranes](
	[CodAlb] [smallint] NOT NULL,
	[CodPed] [tinyint] NOT NULL,
	[FechaEntrega] [datetime] NOT NULL,
	[Aceptado] [nchar](9) NULL,
	[Estado] [nvarchar](9) NOT NULL,
 CONSTRAINT [PK_SGEalbaranes] PRIMARY KEY CLUSTERED 
(
	[CodAlb] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [SGE].[lineasAlb]    Script Date: 11/11/2022 8:41:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [SGE].[lineasAlb](
	[CodAlb] [smallint] NOT NULL,
	[CodProd] [tinyint] NOT NULL,
	[Unidades] [tinyint] NOT NULL,
 CONSTRAINT [PK_SGElineasAlb] PRIMARY KEY CLUSTERED 
(
	[CodAlb] ASC,
	[CodProd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [SGE].[linpedidos]    Script Date: 11/11/2022 8:41:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [SGE].[linpedidos](
	[CodPed] [tinyint] NOT NULL,
	[NumLin] [tinyint] NOT NULL,
	[CodProd] [tinyint] NOT NULL,
	[Unidades] [smallint] NULL,
	[PVP] [money] NULL,
 CONSTRAINT [PK_SGElinpedidos_1] PRIMARY KEY CLUSTERED 
(
	[CodPed] ASC,
	[NumLin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [SGE].[pedidos]    Script Date: 11/11/2022 8:41:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [SGE].[pedidos](
	[CodPed] [tinyint] NOT NULL,
	[CodAlb] [smallint] NOT NULL,
	[CodProv] [tinyint] NOT NULL,
	[Total] [money] NOT NULL,
	[FechaPedido] [date] NOT NULL,
 CONSTRAINT [PK_SGEpedidos] PRIMARY KEY CLUSTERED 
(
	[CodPed] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [SGE].[productos]    Script Date: 11/11/2022 8:41:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [SGE].[productos](
	[CodProd] [tinyint] NOT NULL,
	[Denominacion] [nvarchar](50) NULL,
	[PVP] [money] NULL,
	[Stock] [smallint] NULL,
 CONSTRAINT [PK_SGEproductos] PRIMARY KEY CLUSTERED 
(
	[CodProd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [SGE].[provincias]    Script Date: 11/11/2022 8:41:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [SGE].[provincias](
	[CodProv] [tinyint] NOT NULL,
	[Denominacion] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_SGEprovincias] PRIMARY KEY CLUSTERED 
(
	[CodProv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [SGE].[albaranes] ([CodAlb], [CodPed], [FechaEntrega], [Aceptado], [Estado]) VALUES (1, 1, CAST(N'2022-11-09T00:00:00.000' AS DateTime), N'aceptado ', N'cerrado')
GO
INSERT [SGE].[lineasAlb] ([CodAlb], [CodProd], [Unidades]) VALUES (1, 1, 1)
GO
INSERT [SGE].[linpedidos] ([CodPed], [NumLin], [CodProd], [Unidades], [PVP]) VALUES (1, 1, 2, 2, 29.9900)
GO
INSERT [SGE].[pedidos] ([CodPed], [CodAlb], [CodProv], [Total], [FechaPedido]) VALUES (1, 1, 2, 59.9800, CAST(N'2022-11-09' AS Date))
GO
INSERT [SGE].[productos] ([CodProd], [Denominacion], [PVP], [Stock]) VALUES (1, N'Camiseta Compresion', 39.9900, 58)
INSERT [SGE].[productos] ([CodProd], [Denominacion], [PVP], [Stock]) VALUES (2, N'Mallas Compresion', 29.9900, 38)
INSERT [SGE].[productos] ([CodProd], [Denominacion], [PVP], [Stock]) VALUES (3, N'Protector Bucal', 8.9900, 150)
INSERT [SGE].[productos] ([CodProd], [Denominacion], [PVP], [Stock]) VALUES (4, N'Botas Adidas (SG)', 119.9900, 20)
INSERT [SGE].[productos] ([CodProd], [Denominacion], [PVP], [Stock]) VALUES (5, N'Botas Adidas (FG)', 109.9900, 41)
GO
INSERT [SGE].[provincias] ([CodProv], [Denominacion]) VALUES (1, N'Guipuzcoa')
INSERT [SGE].[provincias] ([CodProv], [Denominacion]) VALUES (2, N'Madrid')
INSERT [SGE].[provincias] ([CodProv], [Denominacion]) VALUES (3, N'Álava')
INSERT [SGE].[provincias] ([CodProv], [Denominacion]) VALUES (4, N'Vizcaya')
GO
ALTER TABLE [SGE].[lineasAlb]  WITH CHECK ADD  CONSTRAINT [FK_SGElineasAlb_SGEalbaranes] FOREIGN KEY([CodAlb])
REFERENCES [SGE].[albaranes] ([CodAlb])
GO
ALTER TABLE [SGE].[lineasAlb] CHECK CONSTRAINT [FK_SGElineasAlb_SGEalbaranes]
GO
ALTER TABLE [SGE].[lineasAlb]  WITH CHECK ADD  CONSTRAINT [FK_SGElineasAlb_SGEproductos] FOREIGN KEY([CodProd])
REFERENCES [SGE].[productos] ([CodProd])
GO
ALTER TABLE [SGE].[lineasAlb] CHECK CONSTRAINT [FK_SGElineasAlb_SGEproductos]
GO
ALTER TABLE [SGE].[linpedidos]  WITH CHECK ADD  CONSTRAINT [FK_SGElinpedidos_SGEpedidos] FOREIGN KEY([CodPed])
REFERENCES [SGE].[pedidos] ([CodPed])
GO
ALTER TABLE [SGE].[linpedidos] CHECK CONSTRAINT [FK_SGElinpedidos_SGEpedidos]
GO
ALTER TABLE [SGE].[linpedidos]  WITH CHECK ADD  CONSTRAINT [FK_SGElinpedidos_SGEproductos1] FOREIGN KEY([CodProd])
REFERENCES [SGE].[productos] ([CodProd])
GO
ALTER TABLE [SGE].[linpedidos] CHECK CONSTRAINT [FK_SGElinpedidos_SGEproductos1]
GO
ALTER TABLE [SGE].[pedidos]  WITH CHECK ADD  CONSTRAINT [FK_SGEpedidos_SGEprovincias] FOREIGN KEY([CodProv])
REFERENCES [SGE].[provincias] ([CodProv])
GO
ALTER TABLE [SGE].[pedidos] CHECK CONSTRAINT [FK_SGEpedidos_SGEprovincias]
GO
ALTER TABLE [SGE].[albaranes]  WITH CHECK ADD  CONSTRAINT [CK_SGEalbaranes] CHECK  (([Aceptado]='rechazado' OR [Aceptado]='aceptado'))
GO
ALTER TABLE [SGE].[albaranes] CHECK CONSTRAINT [CK_SGEalbaranes]
GO
ALTER TABLE [SGE].[albaranes]  WITH CHECK ADD  CONSTRAINT [CK_SGEalbaranes_1] CHECK  (([Estado]='cerrado' OR [Estado]='abierto'))
GO
ALTER TABLE [SGE].[albaranes] CHECK CONSTRAINT [CK_SGEalbaranes_1]
GO
/****** Object:  StoredProcedure [SGE].[pr_AceptarAlb]    Script Date: 11/11/2022 8:41:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [SGE].[pr_AceptarAlb]
	@codAlb int,
	@p_salida int OUTPUT
AS
BEGIN
	BEGIN TRANSACTION
	BEGIN TRY
		BEGIN
				UPDATE SGE.albaranes
				SET Aceptado = 'rechazado', Estado = 'cerrado'
				WHERE CodAlb = @codAlb		
		END
		COMMIT TRANSACTION
		SET @p_salida = 1
	END TRY
	BEGIN CATCH
		SET @p_salida = @@ERROR
		ROLLBACK TRANSACTION
	END CATCH
END
GO
/****** Object:  StoredProcedure [SGE].[pr_AceptarAlb2]    Script Date: 11/11/2022 8:41:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [SGE].[pr_AceptarAlb2]
	@tabla SGE.tiposLinAlb readonly,
	@codAlb int,
	@p_salida int OUTPUT
AS
	DECLARE @v_codAlb smallint,
	@v_codProd tinyint,
	@v_unidades smallint
	DECLARE cur_lin cursor
		FOR	SELECT CodAlb, CodProd, Unidades
			FROM @tabla
BEGIN
	BEGIN TRANSACTION
	BEGIN TRY
		BEGIN
		OPEN cur_lin
			FETCH cur_lin INTO @v_codAlb, @v_codProd, @v_unidades
			WHILE @@FETCH_STATUS = 0
				BEGIN

				UPDATE SGE.productos
				SET stock += @v_unidades
				WHERE CodProd = @v_codProd

				FETCH cur_lin INTO @v_codAlb, @v_codProd, @v_unidades

				END

				UPDATE SGE.albaranes
				SET Aceptado = 'aceptado', Estado = 'cerrado'
				WHERE CodAlb = @codAlb
				
			
		END
		COMMIT TRANSACTION
		SET @p_salida = 1
	END TRY
	BEGIN CATCH
		SET @p_salida = @@ERROR
		ROLLBACK TRANSACTION
	END CATCH
END
GO
/****** Object:  StoredProcedure [SGE].[pr_CrearPed]    Script Date: 11/11/2022 8:41:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [SGE].[pr_CrearPed]
	@tabla SGE.tiposLinPed readonly,
	@codPed tinyint,
	@codProv tinyint,
	@fecha date,
	@p_salida int OUTPUT
AS
	DECLARE @v_codPed tinyint,
	@v_numLin tinyint,
	@v_codProd tinyint,
	@v_codAlb smallint,
	@v_unidades smallint,
	@v_pvp money,
	@total money
	DECLARE cur_lin cursor
		FOR	SELECT CodPed, NumLin, CodProd, Unidades, PVP
			FROM @tabla
BEGIN
	BEGIN TRANSACTION
	BEGIN TRY
		BEGIN
		SET @total = 0
		SET @v_codAlb = CONVERT(smallint, @codPed)

		INSERT INTO SGE.pedidos(CodPed, CodAlb, CodProv, Total, FechaPedido)
		VALUES(@codPed, @v_codAlb, @codProv, @total, @fecha)

		OPEN cur_lin
			FETCH cur_lin INTO @v_codPed, @v_numLin, @v_codProd, @v_unidades, @v_pvp
			WHILE @@FETCH_STATUS = 0
				BEGIN

				INSERT INTO SGE.linpedidos(CodPed, NumLin, CodProd, Unidades, PVP)
				VALUES(@v_codPed, @v_numLin, @v_codProd, @v_unidades, @v_pvp)

				SET @total += (@v_pvp*@v_unidades)

				FETCH cur_lin INTO @v_codPed, @v_numLin, @v_codProd, @v_unidades, @v_pvp

				UPDATE SGE.pedidos
				SET Total = @total
				WHERE CodPed = @codPed

				END
			
		END
		COMMIT TRANSACTION
		SET @p_salida = 1
	END TRY
	BEGIN CATCH
		SET @p_salida = @@ERROR
		ROLLBACK TRANSACTION
	END CATCH
END
GO
