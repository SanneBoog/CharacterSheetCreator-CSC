CREATE TABLE [dbo].[CharacterDetails] (
    [CharacterID]      INT            NOT NULL,
    [CharacterName]    VARCHAR (255)  NOT NULL,
    [level]            INT            NOT NULL,
    [Background]       VARCHAR (255)  NOT NULL,
    [Playername]       VARCHAR (255)  NULL,
    [Race]             VARCHAR (255)  NOT NULL,
    [Alignment]        VARCHAR (255)  NOT NULL,
    [ExperiencePoints] INT            NULL,
    [Class]            NVARCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([CharacterID] ASC)
);

