﻿CREATE PROCEDURE DSOpeProc
AS
BEGIN
    SET NOCOUNT ON;

    SELECT  ID,
            CONVERT(BIT, CASE WHEN [default] IS NOT NULL THEN 1 ELSE 0 END) AS Selected
    FROM    DSOpe;
END;