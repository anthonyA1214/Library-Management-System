CREATE TABLE [dbo].[tbl_issue] (
    [issue_id]    INT           IDENTITY (1, 1) NOT NULL,
    [member_id]   INT           NOT NULL,
    [book_id]     INT           NOT NULL,
    [issue_date]  DATE          NOT NULL,
    [due_date]    DATE          NOT NULL,
    [return_date] DATE          NULL,
    [status]      NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_tbl_issue] PRIMARY KEY CLUSTERED ([issue_id] ASC),
    CONSTRAINT [FK_tbl_issue_tbl_book] FOREIGN KEY ([member_id]) REFERENCES [dbo].[tbl_book] ([book_id]),
    CONSTRAINT [FK_tbl_issue_tbl_member] FOREIGN KEY ([book_id]) REFERENCES [dbo].[tbl_member] ([member_id])
);

