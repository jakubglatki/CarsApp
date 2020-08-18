# CarsApp

Application that serves purpose of managing car services system- starting from keeping data of countries, where car car services are placed, and finishing with data of cars which are being serviced in particular car service. 



### Program structure

CarsApp has four main windows:

* Countries (Kraje)
* Cities (Miasta)
* Factories (Fabryki)
* Services (Serwisy)

All of these windows show a list of objects of their type- for example Countries window shows names and codes of all countries in database. 

![Countries list](https://user-images.githubusercontent.com/32642333/90507707-9fa43f80-e156-11ea-9441-66b2ef80a720.png)

Countries and cities windows allow user to add, edit and see detailed view of each of their objects.

![Edit city window](https://user-images.githubusercontent.com/32642333/90507448-31f81380-e156-11ea-9eb3-322fa7e49e22.png)

Double clicking on a country opens cities list in one country mode.

![Cities list in one country mode](https://user-images.githubusercontent.com/32642333/90508139-71732f80-e157-11ea-9eb9-6c6c4c665b19.png)


Double clicking on a factory shows additional window with all cars produced in this factory.

![Cars from chosen factory list](https://user-images.githubusercontent.com/32642333/90508052-3ffa6400-e157-11ea-8792-96797fe93091.png)

Double clicking on a car service opens additional window with details of this car service and list of all cars that are being serviced there.

![Car service detailed view](https://user-images.githubusercontent.com/32642333/90508827-a92ea700-e158-11ea-87ee-cf3482db5edc.png)

After adding a new car to the car service program asks if client got a replacement car and gives him one if it is supposed to do so.

![Choosing replacement car for user](https://user-images.githubusercontent.com/32642333/90508906-c6637580-e158-11ea-8f69-3c5b4dff13b0.png)


### Database structure

![Database structure](https://user-images.githubusercontent.com/32642333/90513935-c10a2900-e160-11ea-864b-090a5e3c1d65.png)

### Built with

* [Entity framework](https://www.entityframeworktutorial.net/) - framework used for database collection
* [Telerik](https://www.telerik.com/) - UI controls
* LGBS MVP Framework

CarsApp was made during intership in [Euvic](https://www.euvic.pl/), and the main and countries windows were made before I started my work.
