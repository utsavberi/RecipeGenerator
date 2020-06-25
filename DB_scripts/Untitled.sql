create database recipe_generator;

use recipe_generator;

create table recipe(
id int not null auto_increment,
title varchar(100) not null,
ingredients varchar(4000),
method varchar(10000),
imageUrl varchar(1000),
PRIMARY KEY(id)
);

insert into recipe (title, ingredients, method, imageUrl) values
(
'Fettuccine Carbonara Pasta',
'450g sweet potatoes, peeled and cubed
1 litre water
1 (1.5cm) piece fresh ginger, peeled and sliced
',
'Place the sweet potato in a large pot, cover with the water and leave to soak for 30 minutes.
Remove the potatoes from the water. Bring the water to the boil and return the potatoes to the boiling water with the ginger slices. Cook the potatoes until fork-tender, 20 to 25 minutes. Stir the sugar into the water until completely dissolved to make a syrup. Remove the sweet potatoes to individual bowls and spoon the ginger syrup over the sweet potatoes to serve.',
'http://www.reciperoulette.tv/public/upload/f50ca8fd18c99cc30f3eb9cbdfb83a52.jpg'
);

