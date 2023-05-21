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
)

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


SELECT Product.name, Categories.name
FROM Product 
LEFT JOIN ProductsCategories ON ProductsCategories.productId = Product.id
LEFT JOIN Categories ON ProductsCategories.categoryId = Categories.id
