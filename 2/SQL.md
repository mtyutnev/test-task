В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

create table product
(
    id integer
        constraint product_pk primary key,
    name varchar(50)not null,
    category_id integer
);

create table category
(
    id integer
        constraint category_pk
            primary key
    name varchar(50) not null,
    product_id integer
);

alter table category
    add constraint category_product_id_fk
        foreign key (product_id) references product;

alter table product
    add constraint product_category_id_fk
        foreign key (category_id) references category;

SELECT p.name product_name, 
       c.name category_name
FROM product p LEFT JOIN category c on p.id = c.product_id