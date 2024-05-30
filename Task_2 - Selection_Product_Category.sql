/*
	������ �3:
� ���� ������ MS SQL Server ���� �������� � ���������. 
������ �������� ����� ��������������� ����� ���������, � ����� ��������� ����� ���� ����� ���������. 
�������� SQL ������ ��� ������ ���� ��� ���� �������� � ��� ���������. 
���� � �������� ��� ���������, �� ��� ��� ��� ����� ������ ����������.
*/
/*
�������:
������� ��������� � ��������� � ��� ��� � ���� ����������.
������� ����� ������������ ������� �������� ������������� �������, � ������� ����� ������� ����� �� ������� ��������� � ���������:
*/

CREATE TABLE dbo.ProductsCategories (
	ID_Products INT null,
	ID_Categories INT null,
	CONSTRAINT FK_ProductsCategories_Products 
		FOREIGN KEY(ID_Products)
		REFERENCES dbo.Products(ID),
	CONSTRAINT FK_ProductsCategories_Categories 
		FOREIGN KEY(ID_Categories)
		REFERENCES dbo.Categories(ID)
);

-- SQL ������ ��� ������ ���� ��� "��� �������� - ��� ���������"
SELECT 
	p.ProductName as "��� ��������", 
	c.CategoryName as "��� ���������" 
FROM 
	dbo.Products as p
	left join dbo.ProductsCategories as pc on p.ID = pc.ID_Products
	left join dbo.Category as c on c.ID = pc.ID_Categories
