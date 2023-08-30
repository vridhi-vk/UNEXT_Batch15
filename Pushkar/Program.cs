using Assignment1;

Animal dog = new Animal("Dog", 3);
Animal cat = new Animal("Cat", 2);
Animal bird = new Animal("Bird", 3);

Circle circle = new Circle("circle",5);
Rectangle rectangle = new Rectangle("rectangle", 4);

dog.MakeSound(dog.Name);
cat.MakeSound(cat.Name);   
bird.MakeSound(bird.Name);

circle.GetInfo();
rectangle.GetInfo();