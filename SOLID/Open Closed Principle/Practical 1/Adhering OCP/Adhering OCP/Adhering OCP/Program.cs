// 1. Consider defining an abstract Shape class:
//    - Create a base class called Shape.
//    - Include an abstract method called CalculateArea.
//    - This approach allows each shape to calculate its own area.

// 2. Define concrete shape classes that inherit from the Shape class:
//    - Create classes such as Rectangle and Circle inheriting from Shape.
//    - Each shape class implements its own CalculateArea method.

// 3. Revise the AreaCalculator class to use the Shape abstraction:
//    - Change the GetArea method to accept a Shape parameter.
//    - Call the CalculateArea method of the given shape instance.
//    - This design allows the AreaCalculator to work with any shape that implements the Shape class.

// 4. By adhering to the open-closed principle, the AreaCalculator can now handle new shapes
//    without modifying its original source code.
