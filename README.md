# DesignPatterns in C#

Creational

	- Builder:	Step by step object creating.
			The Builder pattern can be recognized in a class, which has a single creation method and several methods to 
			configure the resulting object. 
			Builder methods often support chaining (for example, someBuilder->setValueA(1)->setValueB(2)->create()).

	- Factory:	Wholesale object creation.
			Factory methods can be recognized by creation methods, which create objects from concrete classes, but return 
			them as objects of abstract type or interface.

	- Abstract Factory: 	Wholesale object creation without specifying their concrete classes.
				The pattern is easy to recognize by methods, which return a factory object. Then, the factory is used 
				for creating specific sub-components.

	- Protoype: 	Create an object by copying an existing object (clone).
			The prototype can be easily recognized by a clone or copy methods, etc.

	- Singleton:	For some components it only makes sense do have only one in the system.
			Singleton can be recognized by a static creation method, which returns the same cached object.


Structural

	- Adapter:	Get the interface you want from the interface you have.
			Adapter is recognizable by a constructor which takes an instance of a different abstract/interface type. When 
			the adapter receives a call to any of its methods, it translates parameters to the appropriate format and then 
			directs the call to one or several methods of the wrapped object.

	- Bridge:	A mechanism that completely decouples an interface (hierarchy) from an implementation (hierarchy). Prevents a 
			cartesian product in the hierarchy chain.
			Bridge can be recognized by a clear distinction between some controlling entity and several different platforms 
			that it relies on.

	- Composite: 	A mechanism for treating individual (scalar) objects and compositions (like IEnumerable) of those same objects in 
			a uniform matter. (Masquerade a single object as a collection (yield return this)).
			If you have an object tree, and each object of a tree is a part of the same class hierarchy, this is most likely a 
			composite. 
			If methods of these classes delegate the work to child objects of the tree and do it via the base 
			class/interface of the hierarchy, this is definitely a composite.

	- Decorator:	Facilitates the addition of behaviors to individual objects without inheriting from them.
			Decorator can be recognized by creation methods or constructor that accept objects of the same class or interface
			as a current class.

	- Facade:	Provides a simple, easy to understand user interface over a large and sophisticated body of code.
			Facade can be recognized in a class that has a simple interface, but delegates most of the work to other classes. 
			Usually, facades manage the full life cycle of objects they use.

	- Flyweight:	A space optimization technique that lets us use less memory by storing externally the data associated with similar 
			objects.
			Flyweight can be recognized by a creation method that returns cached objects instead of creating new.

	- Proxy:	A class hat functions as an interface to a particular resource. That resource may be remote, expensive to 
			construct or some other added functionality.
			Proxies (unlike decorators) are mostly used to restrict the client. Proxies delegate all of the real work to
			some other object. Each proxy method should, in the end, refer to a service object unless the proxy is a subclass 
			of a service.

Behavioral

	- Observer: 	An observer is an object that wishes to be informed about events happening in the system. The entity generating
			the events is an observable.
			The pattern can be recognized by subscription methods, that store objects in a list and by calls to the update 
			method issued to objects in that list.

	- Strategy: 	Enables the exact behavior of a system to be selected either at run-time (dynamic) or compile time (static).
			You have more ways for doing an operation; with strategy, you can choose the algorithm at run-time and you can 
			modify a single strategy without a lot of side-effects at compile-time;
			Strategy pattern can be recognized by a method that lets nested object do the actual work, as well as the setter 
			that allows replacing that object with a different one.

	- State:	A patern in which the object's behavior is determined by its state. An object transitions from one state to another.
			(something needs to trigger the transition).
			State pattern can be recognized by methods that change their behavior depending on the objects’ state, 
			controlled externally.

	- Chain of Responsibility:	A chain of components who all get a chance to process a command or a query. Optionally having 
					default processing implementation and an ability to terminate the processing chain.
					The pattern is recognizable by behavioral methods of one group of objects that indirectly call 
					the same methods in other objects, while all the objects follow the common interface.

	- Command:	An object which represents an instruction to perform a particular action. Contains all the information
			neccessery for the action to be taken.
			The Command pattern is recognizable by behavioral methods in an abstract/interface type (sender) which invokes a 
			method in an implementation of a different abstract/interface type (receiver) which has been encapsulated by the 
			command implementation during its creation. Command classes are usually limited to specific actions.

	- Interpreter:	A component that processes structured text data. Does so by turning it into separate lexical tokens (lexing)
			and then interpreting sequences of said tokens (parsing)

	- Iterator:	An object that facilitates the traversal of a data structure.
			Iterator is easy to recognize by the navigation methods (such as next, previous and others). Client code that uses 
			iterators might not have direct access to the collection being traversed.

	- Template Method:	Allows us to define the "skeleton" of the algorithm with concrete implementations defined in subclasses.
				Template Method can be recognized by behavioral methods that already have a “default” behavior defined 
				by the base class.
				Template method works like a Strategy, but through Inheritance  

	- Memento:	A token/handle representing the system state. Lets you to roll back to the state when the token was generated.
			May or may not directly expose state information.

	- Mediator: 	A component that facilitates communication between componenets without them necesserily being aware of each
			other or having direct (reference) access to each other.

	- Visitor:	A pattern where a component (visitor) is allowed to traverse the entire inheritance hierarchy. Implemented
			by propagating a single visit() method throughout the entire hierarchy.
