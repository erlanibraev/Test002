delimiter ;.
-- Table tbl_testmessage
create table `tbl_testmessage`
(
 `ID`             VARCHAR(32)    not null comment 'ID',
 `MESSAGE`        VARCHAR(1000)  not null comment 'message',
 `SENDER`         VARCHAR(32)     comment 'sender',
 `RECIEVER`       VARCHAR(32)    not null comment 'reciever',
 `DOB`            DATETIME        comment 'date send',
 `READED`         VARCHAR(5)     not null comment 'readed|not readed',
  constraint `pk_tbl_testmessage_primary` primary key (`ID`)
)
    comment = 'testmessage'
;.

