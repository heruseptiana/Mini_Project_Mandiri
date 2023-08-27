create table AlamatNasabah
(
	ID int IDENTITY(1,1) NOT NULL,
	Kota varchar(50),
	Negara varchar(50),
	IdNasabah int
	CONSTRAINT PK_AlamatNasabah PRIMARY KEY (id)
	CONSTRAINT FK_Alamat_Nasabah_IdNasabah FOREIGN KEY(IdNasabah)
	REFERENCES Nasabah(ID)
)