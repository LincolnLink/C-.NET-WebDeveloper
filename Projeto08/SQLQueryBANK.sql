SELECT p.IdProduto, p.Nome, p.Preco, p.Quantidade, p.DataCadastro, p.IdEstoque,
 e.IdEstoque, e.Nome, e.Descricao FROM Produto2 p INNER JOIN Estoque2 e ON p.IdEstoque = e.IdEstoque;




 alter table Estoque
 alter column NomeEstoque nvarchar(max);

 create table Estoque(
	IdEstoque		integer			identity(1,1),
	NomeEstoque		nvarchar(50)	not null,
	Descricao		nvarchar(250)	not null,
	primary key(IdEstoque))
go
create table Produto(
	IdProduto		integer			identity(1,1),
	Nome			nvarchar(50)	not null,
	Preco			decimal(18,2)	not null,
	Quantidade		integer			not null,
	DataCadastro	datetime		not null,
	IdEstoque		integer			not null,
	primary key(IdProduto),
	foreign key(IdEstoque) references Estoque(IdEstoque))
go