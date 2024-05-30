/*
	Вопрос №3:
В базе данных MS SQL Server есть продукты и категории. 
Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. 
Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». 
Если у продукта нет категорий, то его имя все равно должно выводиться.
*/
/*
Решение:
Таблицы Продуктов и Категорий у нас уже в базе существуют.
Поэтому перед составлением запроса создадим промежуточную таблицу, в которой будут внешние ключи на таблицы Продуктов и Категорий:
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

-- SQL запрос для выбора всех пар "Имя продукта - Имя категории"
SELECT 
	p.ProductName as "Имя продукта", 
	c.CategoryName as "Имя категории" 
FROM 
	dbo.Products as p
	left join dbo.ProductsCategories as pc on p.ID = pc.ID_Products
	left join dbo.Category as c on c.ID = pc.ID_Categories
