SELECT 
    Products.Name,
    ISNULL(Categories.Name, '[No category]')
FROM Products
    LEFT JOIN Categories
    ON Products.Category = Categories.ID
