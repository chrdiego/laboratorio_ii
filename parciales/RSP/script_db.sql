CREATE TABLE [dbo].[Estudiantes](
	[nombre] [varchar](50) NOT NULL,
	[legajo] [int] NOT NULL,
	[nota] [float] NOT NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [UTN] SET  READ_WRITE 
GO
USE Utn;
Insert Into [dbo].[Estudiantes] (legajo, nombre, nota) values (1, 'nombre1', 3);
Insert Into [dbo].[Estudiantes] (legajo, nombre, nota) values (2, 'nombre2', 2);
Insert Into [dbo].[Estudiantes] (legajo, nombre, nota) values (3, 'nombre3', 1);
GO