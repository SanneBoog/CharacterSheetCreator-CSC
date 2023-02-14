CREATE TABLE [dbo].[AbilityScores] (
    [AbilityScoresId] INT NOT NULL,
    [Strength]        INT NOT NULL,
    [Dexterity]       INT NOT NULL,
    [Constitution]    INT NOT NULL,
    [Intelligence]    INT NOT NULL,
    [Wisdom]          INT NOT NULL,
    [CharacterID]     INT NULL,
    [Charisma]        INT NULL,
    PRIMARY KEY CLUSTERED ([AbilityScoresId] ASC),
    FOREIGN KEY ([CharacterID]) REFERENCES [dbo].[CharacterDetails] ([CharacterID])
);

