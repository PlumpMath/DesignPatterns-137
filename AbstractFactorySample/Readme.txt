
Abstract factory used to create families of related objects. It is a factory of factory 

The Abstract Factory defines a Factory Method per product. Each Factory Method encapsulates the new operator and the concrete, platform-specific, product classes.



1. Abstract Factory : IStampingEquipment
2. Concrete Factories : StampingSaloonEquipment & StampingSportsEquipment
3. Abstract Products Interface : IHood, IWheel, IDoor
5. Concrete Products Implementation : RegularDoor, CoupeDoor ...





new is EVIL EVIL EVIL 
==> It creates tight coupling : instead of depending on something, depend on what you it to do
==> Instead of class to class, use class to interface


Factory method reduces coupling to one place 