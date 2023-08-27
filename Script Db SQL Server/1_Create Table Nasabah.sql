create table Nasabah
(
	ID int IDENTITY(1,1) NOT NULL,
	NIK varchar(16),
	Nama varchar(100),
	NoHP varchar(15),
	Email varchar(30),
	CONSTRAINT PK_Nasabah PRIMARY KEY (id)
)

