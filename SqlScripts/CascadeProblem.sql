


ALTER TABLE [Orders]     
ADD CONSTRAINT FK_UserId FOREIGN KEY (UserId)     
    REFERENCES [ApplicationUsers] (Id)     
    ON DELETE NO ACTION   
    ON UPDATE NO ACTION    
;    
GO    