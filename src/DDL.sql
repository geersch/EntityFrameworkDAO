SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Person]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Person](
	[Id] [uniqueidentifier] NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[PersonType] [int] NOT NULL CONSTRAINT [DF_Person_PersonType]  DEFAULT ((0)),
	[PreferedLanguage] [nvarchar](50) NULL,
	[Methodology] [nvarchar](50) NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Project]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Project](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Deadline] [datetime] NOT NULL,
 CONSTRAINT [PK_Project] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProjectsPerPerson]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ProjectsPerPerson](
	[PersonId] [uniqueidentifier] NOT NULL,
	[ProjectId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_ProjectsPerPerson] PRIMARY KEY CLUSTERED 
(
	[PersonId] ASC,
	[ProjectId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ProjectsPerPerson_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[ProjectsPerPerson]'))
ALTER TABLE [dbo].[ProjectsPerPerson]  WITH CHECK ADD  CONSTRAINT [FK_ProjectsPerPerson_Person] FOREIGN KEY([PersonId])
REFERENCES [dbo].[Person] ([Id])
GO
ALTER TABLE [dbo].[ProjectsPerPerson] CHECK CONSTRAINT [FK_ProjectsPerPerson_Person]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ProjectsPerPerson_Projects]') AND parent_object_id = OBJECT_ID(N'[dbo].[ProjectsPerPerson]'))
ALTER TABLE [dbo].[ProjectsPerPerson]  WITH CHECK ADD  CONSTRAINT [FK_ProjectsPerPerson_Projects] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([Id])
GO
ALTER TABLE [dbo].[ProjectsPerPerson] CHECK CONSTRAINT [FK_ProjectsPerPerson_Projects]
