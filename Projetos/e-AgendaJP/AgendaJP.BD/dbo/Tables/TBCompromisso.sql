CREATE TABLE [dbo].[TBCompromisso] (
    [ID]       INT          IDENTITY (1, 1) NOT NULL,
    [ASSUNTO]     VARCHAR (200) NOT NULL,
    [LOCAL]       VARCHAR (300) NOT NULL,
    [DATA_INICIO] DATETIME      NOT NULL,
    [DATA_FINAL]  DATETIME      NOT NULL,
    [ID_CONTATO]  INT           NULL,
    CONSTRAINT [PK_TBCompromissos] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_TBCompromisso_TBContato] FOREIGN KEY ([ID_CONTATO]) REFERENCES [dbo].[TBContato] ([ID])
);




