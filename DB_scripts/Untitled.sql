create database recipe_generator;

use recipe_generator;

create table recipe(
id int not null auto_increment,
title varchar(100) not null,
ingredients varchar(4000),
method varchar(10000),
imageUrl varchar(1000),
createdOn datetime DEFAULT CURRENT_TIMESTAMP,
PRIMARY KEY(id)
);
insert into recipe (title, ingredients, method, imageUrl) values
(
'Fettuccine Carbonara Pasta',
'<ul>
                <li>450g sweet potatoes, peeled and cubed                </li>
                <li>1 litre water                                        </li>
                <li>1 (1.5cm) piece fresh ginger, peeled and sliced      </li>
                <li>220g palm sugar                                      </li>
                <li>1 bulb fennel, trimmed and sliced                    </li>
                <li>2 large oranges, peeled and sliced into rounds       </li>
                <li>1 tablespoon olive oil                               </li>
                <li>1 tablespoon red wine vinegar                        </li>
                <li>1 teaspoon poppy seeds                               </li>
                <li>salt to taste                                        </li>
                <li>2 (100g) bags wild rocket - chopped                  </li>
                <li>spaghetti                                            </li>
                <li>170g packet of pancetta cubes                        </li>
                <li>1 medium onion, finely chopped                       </li>
                <li>1 dessertspoon of light olive oil (not extra virgin) </li>
                <li>2 eggs                                               </li>
                <li>2 dessertspoons of low fat yoghurt                   </li>
                <li>2 dessertspoons of Parmesan                          </li>
                <li>1 more dessertspoon of parmesan for sprinkling       </li>
                <li>freshly ground black pepper                          </li>
                <li>2 whole eggs + 1 egg yolk, beaten                    </li>
                <li>50g Parmesan cheese, plus extra to serve             </li>
                <li>ground black pepper, to taste                        </li>
                <li>350g fettuccine                                      </li>
                <li>1 tablespoon olive oil                               </li>
                <li>150g bacon, chopped                                  </li>
                <li>1 teaspoon garlic, minced                            </li>
                <li>fresh parsley, to serve                              </li>
                <li>4 unbroken egg yolks, one per serving to add on top  </li>
                <li>sea salt, to taste
            </ul>',
'<ol>
    <li>Place the sweet potato in a large pot, cover with the water and leave to soak for 30 minutes.
    <li>Remove the potatoes from the water. Bring the water to the boil and return the potatoes to the boiling water with the ginger slices. Cook the potatoes until fork-tender, 20 to 25 minutes. Stir the sugar into the water until completely dissolved to make a syrup. Remove the sweet potatoes to individual bowls and spoon the ginger syrup over the sweet potatoes to serve.
    <li>Place the fennel and orange in a large bowl. Drizzle with olive oil and vinegar; sprinkle with poppy seeds and salt. Chill and serve over a bed of rocket.
    <li>Bring a large pan of well salted water to a rolling boil. Drop in the spaghetti, stir a couple of times to stop it sticking.
    <li>While the spaghetti is cooking, fry the onion and pancetta gently in the olive oil until the onion is translucent and the pancetta is cooked through.
    <li>In a small bowl, combine the eggs, yoghurt and the parmesan.
    <li>After 10 minutes the spaghetti should be al dente. Drain the pasta well in a colander and then transfer it back to the pan it was in.
    <li>Over a low heat if you have gas, or a just switched off ring if you have electric, add the egg mixture to the pasta, stirring briskly so that the egg doesn\'t scramble.
    <li>Finally, add the pancetta and onion and a few good grindings of pepper. Serve with the additional dessertspoon of Parmesan sprinkled over the top.
    <li>In a bowl, add your 2 whole eggs, 1 egg yolk, finely grated Parmesan, and generous helpings of black pepper and mix well with a fork. Place to one side, away from direct heat.
    <li>Bring a saucepan of salted water to the boil over a high heat and add the fettuccine. Cook according to the instructions on the packet, or until al dente.
    <li>Meanwhile, in a large pan heat up your oil and fry up the chopped bacon. When almost cooked, add your garlic and cook until the bacon is nice and crispy, leaving a nice salty/garlicy/oily texture in the pan. If there is too much oil, then simply grab a sheet of kitchen paper and soak a little up. Turn off the heat.
    <li>By this point your fettuccine will be cooked so drain and pop in the pan with your bacon, toss well coating all the fettuccine. Grab your egg mixture and pour onto your fettuccine (making sure the heat is off); continue to toss, making sure all of the ingredients are being mixed so all the flavours are being soaked up. The heat from both the fettuccine and the pan will cook the eggs. If the heat is too high the eggs will scramble. Continue this for a minute or so until the fettuccine becomes a nice glossy and creamy texture, do not over cook.
    <li>Serve immediately with sprinkled parsley, extra Parmesan and an egg yolk carefully placed on top of the pasta. The egg yolk will lightly cook from the leftover heat of the fettuccine and when burst with a fork, will run down beautifully. Season with salt and enjoy!
</ol>',
'http://www.reciperoulette.tv/public/upload/f50ca8fd18c99cc30f3eb9cbdfb83a52.jpg'
);
select  * from recipe order by id desc limit 1 ;