<b>Задание:</b>

Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам.
Дополнительно к работоспособности оценим:

- Юнит-тесты

- Легкость добавления других фигур

- Вычисление площади фигуры без знания типа фигуры в compile-time

- Проверку на то, является ли треугольник прямоугольным



<b>Задание 2:</b>

В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много
продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно
выводиться.

Решение:

Сначала создадим таблицы:
<p style="border:2px solid #555; box-shadow:3px 3px 5px #999; width: 200px; text-align:center;  margin:20px; padding:20px;" >
CREATE TABLE Product (
    id INT PRIMARY KEY,
    name TEXT
)

CREATE TABLE Categories (
    id INT PRIMARY KEY,
    name TEXT
)

CREATE TABLE ProductsCategories (
    productId INT FOREIGN KEY REFERENCES Product (id),
    categoryId INT FOREIGN KEY REFERENCES Categories (id)
    PRIMARY KEY (productID, categoryId)
)</p>
Затем наполним их значениями:
INSERT INTO Product
VALUES
    (1, Apple),
    (2, Koenigsegg),
    (3, Tom)

INSERT INTO Categories
VALUES
    (1, Cars),
    (2, Books)

INSERT INTO ProductsCategories
VALUES
    (2, 1),
    (3, 2)
    
Сам SQL-запрос:
SELECT Product.name, Categories.name
FROM Product 
LEFT JOIN ProductsCategories ON ProductsCategories.productId = Product.id
LEFT JOIN Categories ON ProductsCategories.categoryId = Categories.id
