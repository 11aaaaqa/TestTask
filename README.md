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

Создадим таблицы:
<div class="snippet-clipboard-content notranslate position-relative overflow-auto>
<pre class="notranslate">
<code>CREATE TABLE Product (
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
)
</code>
</pre>
</div>
