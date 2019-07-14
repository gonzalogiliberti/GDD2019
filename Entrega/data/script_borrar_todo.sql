/*Set schema*/
DECLARE @schemaName as nvarchar(10)
DECLARE @schemaId as int

SET @schemaName = 'JavaPorter'
SET @schemaId = (select schema_id from sys.schemas where name = @schemaName)

/*Drop constraints*/
DECLARE @query AS nvarchar(400)
DECLARE foreingkeys CURSOR FOR SELECT 
    'ALTER TABLE [' +  OBJECT_SCHEMA_NAME(parent_object_id) +
    '].[' + OBJECT_NAME(parent_object_id) + 
    '] DROP CONSTRAINT [' + name + ']'
FROM sys.foreign_keys
WHERE schema_id=@schemaId

OPEN foreingkeys

FETCH NEXT FROM foreingkeys INTO @query

WHILE @@fetch_status = 0

BEGIN
    --PRINT @query
	exec (@query)
    FETCH NEXT FROM foreingkeys INTO @query
END
CLOSE foreingkeys
DEALLOCATE foreingkeys

/*Drop tables*/
DECLARE @queryDrop AS nvarchar(400)
DECLARE tables CURSOR FOR 

	select 
		'DROP TABLE [' + s.name +
		'].[' + t.name + ']'
	from sys.tables t
	inner join sys.schemas s on t.schema_id = s.schema_id
	where t.schema_id=@schemaId and t.name != 'Maestra'

OPEN tables

FETCH NEXT FROM tables INTO @queryDrop

WHILE @@fetch_status = 0

BEGIN
    --PRINT @queryDrop
	exec (@queryDrop)
    FETCH NEXT FROM tables INTO @queryDrop
END
CLOSE tables
DEALLOCATE tables

/*DROP PROCEDURES*/
DECLARE @procedureDrop AS nvarchar(400)
DECLARE proceduress CURSOR FOR select 
'DROP PROCEDURE [' + s.name +
	'].[' + o.name + ']'
from sys.objects o
inner join sys.schemas s on o.schema_id = s.schema_id
where o.schema_id=@schemaId and type = 'P'

OPEN proceduress

FETCH NEXT FROM proceduress INTO @procedureDrop
WHILE @@fetch_status = 0

BEGIN
	exec (@procedureDrop)
    FETCH NEXT FROM proceduress INTO @procedureDrop
END
CLOSE proceduress
DEALLOCATE proceduress

/*Drop Functions*/

/*
DECLARE @functionDrop AS nvarchar(MAX)
DECLARE functions CURSOR FOR select 
'DROP FUNCTION [' + s.name +
	'].[' + o.name + ']'
from sys.objects o
inner join sys.schemas s on o.schema_id = s.schema_id
where o.schema_id=@schemaId and type = 'FN'

OPEN functions

FETCH NEXT FROM functions INTO @functionDrop
WHILE @@fetch_status = 0

BEGIN
	exec (@functionDrop)
    FETCH NEXT FROM functions INTO @functionDrop
END
CLOSE functions
DEALLOCATE functions
*/


/*
declare @procName varchar(500)
declare cur cursor
    for select [name] from sys.objects where schema_id=@schemaId and type IN (N'FN', N'IF', N'TF', N'FS', N'FT',N'FX') 
open cur

fetch next from cur into @procName
      while @@fetch_status = 0
      begin
                  exec('drop function ' + @procName)
                  fetch next from cur into @procName
      end

close cur
deallocate cur
*/
DROP FUNCTION JavaPorter.fx_RecorridosYTramos

/* DROP SCHEMA*/
/* Al pedo borrar el schema */
/*
IF EXISTS (SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = 'dbo')
    DROP SCHEMA FSOCIETY
GO
*/
IF EXISTS (SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = 'JavaPorter')
    DROP SCHEMA JavaPorter
GO
