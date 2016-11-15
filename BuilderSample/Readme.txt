Builder Factory used :

1. When there are a lot of parameters to create an object / or object made up from complex objects but have same construction pattern
2. Parse a complex representation, create one of several targets 
3. Focuses on how the object is created


It includes decider that decides what builder objects constitue the main object
The builder objects are reusable and swappable, For example in our case the Veggie Pizza decider uses BasicCoreBuilder and FancyVeggieBuilder. EverthingDecider als uses BasicCoreBuilder

