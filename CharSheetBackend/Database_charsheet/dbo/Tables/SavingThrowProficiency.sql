CREATE TABLE [dbo].[SavingThrowProficiency] (
    [AbilityScoresId] INT NOT NULL,
    [Strength]        BIT NOT NULL,
    [Dexterity]       BIT NOT NULL,
    [Constitution]    BIT NOT NULL,
    [Intelligence]    BIT NOT NULL,
    [Wisdom]          BIT NOT NULL,
    [CharacterID]     INT NULL,
    PRIMARY KEY CLUSTERED ([AbilityScoresId] ASC),
    FOREIGN KEY ([CharacterID]) REFERENCES [dbo].[CharacterDetails] ([CharacterID])
);

