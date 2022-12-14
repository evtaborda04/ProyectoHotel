USE [PROYECTOHOTEL]
GO
/****** Object:  Table [dbo].[CLIENTES]    Script Date: 25/11/2022 2:16:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLIENTES](
	[id] [nchar](10) NOT NULL,
	[nombre] [nchar](30) NULL,
	[apellido] [nchar](30) NULL,
	[genero] [nchar](15) NULL,
 CONSTRAINT [PK_CLIENTES] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 25/11/2022 2:16:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[cod_factura] [int] IDENTITY(1,1) NOT NULL,
	[fechaingreso] [date] NULL,
	[fechasalida] [date] NULL,
	[cod_reserva] [nchar](10) NULL,
	[cedula] [nchar](10) NULL,
	[nombre] [nchar](10) NULL,
	[habitacion] [nchar](10) NULL,
	[tipohabitacion] [nchar](10) NULL,
	[precio] [float] NULL,
	[cantidad_dias] [int] NULL,
	[total] [float] NULL,
 CONSTRAINT [PK_Factura] PRIMARY KEY CLUSTERED 
(
	[cod_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HABITACION]    Script Date: 25/11/2022 2:16:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HABITACION](
	[id] [nchar](10) NOT NULL,
	[tipo] [nchar](10) NULL,
	[precio] [float] NULL,
	[nropiso] [int] NULL,
 CONSTRAINT [PK_HABITACION] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reserva]    Script Date: 25/11/2022 2:16:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reserva](
	[idreserva] [nchar](10) NOT NULL,
	[cedula] [nchar](10) NULL,
	[nombre] [nchar](20) NULL,
	[cod_habitacion] [nchar](10) NULL,
	[tipo] [nchar](10) NULL,
	[precio] [float] NULL,
 CONSTRAINT [PK_Reserva] PRIMARY KEY CLUSTERED 
(
	[idreserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Reserva] FOREIGN KEY([cod_reserva])
REFERENCES [dbo].[Reserva] ([idreserva])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [FK_Factura_Reserva]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_CLIENTES] FOREIGN KEY([cedula])
REFERENCES [dbo].[CLIENTES] ([id])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_CLIENTES]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_HABITACION] FOREIGN KEY([cod_habitacion])
REFERENCES [dbo].[HABITACION] ([id])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_HABITACION]
GO
/****** Object:  StoredProcedure [dbo].[cargarcedulas]    Script Date: 25/11/2022 2:16:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[cargarcedulas] 
as
select id,nombre from CLIENTES;
GO
/****** Object:  StoredProcedure [dbo].[cargarhabitaciones]    Script Date: 25/11/2022 2:16:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[cargarhabitaciones] 
as
select id,tipo,precio from HABITACION;
GO
/****** Object:  StoredProcedure [dbo].[pa_cargar_reserva]    Script Date: 25/11/2022 2:16:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pa_cargar_reserva]
as
select idreserva, cedula,nombre,cod_habitacion,tipo,precio from Reserva;
GO
